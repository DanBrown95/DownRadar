using DownRadar.Configurations;
using DownRadar.Helpers;
using DownRadar.Models.Interfaces.SMS;
using DownRadar.Models.SMS;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DownRadar.Controllers
{
    public class SMSController : Controller
    {

        private readonly SMSSettings _smsSettings;

        public SMSController(SMSSettings smsSettings)
        {
            _smsSettings = smsSettings;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="url"></param>
        /// <param name="hours"></param>
        /// <returns>The formatted url subscribed to. Result of the subscription process</returns>
        [HttpPost]
        public JsonResult Subscribe(string phone, string url, int hours)
        {
            var formattedUrl = UrlProtocolValidator.FormatUrl(url);
            var message = "You have been subscribed to " + formattedUrl + ". \n\n-DownRadar";
            var sms = new SMS(phone, message);
            var result = Send(sms);

            return Json(new { url = formattedUrl, result });
        }

        /// <summary>
        /// Send SMS
        /// </summary>
        /// <param name="anonymous">Whether the text should include the sender phone number or send as Down Radar</param>
        /// <param name="sms">ISMS object to send</param>
        /// <returns>Status of the attempt</returns>
        private string Send(bool anonymous, ISMS sms)
        {
            var status = SendSms(anonymous, sms);
            return status.ToString();
        }

        /// <summary>
        /// Send SMS
        /// </summary>
        /// <param name="sms">ISMS object to send</param>
        /// <returns>Status of the sms attemp</returns>
        private string Send(ISMS sms)
        {
            return Send(false, sms);
        }

        /// <summary>
        /// Send an sms using Twilio services
        /// </summary>
        /// <param name="anonymous">Show the twilio phone number to the recipient or send as an alphanumeric senderID </param>
        /// <param name="sms">ISMS object</param>
        /// <returns>Status of the sms send attempt</returns>
        private MessageResource.StatusEnum SendSms(bool anonymous, ISMS sms)
        {
            string accountSid = _smsSettings.accountSid;
            string authToken = _smsSettings.authToken;

            TwilioClient.Init(accountSid, authToken);
            var from = anonymous ? _smsSettings.anonymousName : new Twilio.Types.PhoneNumber(_smsSettings.from);

            var response = MessageResource.Create(
                body: sms.Message,
                from: from,
                to: new Twilio.Types.PhoneNumber(sms.To)
            );
            return response.Status;
        }
    }
}