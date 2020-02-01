using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DownRadar.Models.Interfaces.SMS
{
    public class ISMS
    {
        /// <summary>
        /// Recipient of the message
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Message to send
        /// </summary>
        public string Message { get; set; }
    }
}
