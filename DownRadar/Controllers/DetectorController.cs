using System;
using System.Net;
using DownRadar.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DownRadar.Controllers
{
    public class DetectorController : Controller
    {
        [HttpGet]
        public JsonResult PingUrl(string url)
        {
            var result = "";
            HttpStatusCode statusCode = default(HttpStatusCode);

            var formattedUrl = UrlProtocolValidator.FormatUrl(url);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(formattedUrl);
                request.Method = "HEAD";

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        statusCode = response.StatusCode;
                        response.Close();
                    }
                }
                result = "Status: " + statusCode;
            }
            catch (WebException ex)
            {
                if (ex.Status.ToString() == "NameResolutionFailure")
                {
                    result = "Status: Down";
                }
            }
            catch (Exception ex)
            {
                result = "Error: please check the url and try again";
            }

            return Json(new { url = formattedUrl, result });
        }
    }
}