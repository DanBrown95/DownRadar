using DownRadar.Models.Interfaces.SMS;

namespace DownRadar.Models.SMS
{
    public class SMS : ISMS
    {
        #region Constructors

        public SMS(string to, string message)
        {
            To = to;
            Message = message;
        }

        #endregion

    }
}
