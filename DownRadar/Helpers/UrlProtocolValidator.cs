using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DownRadar.Helpers
{
    public static class UrlProtocolValidator
    {
        public static string FormatUrl(string url)
        {
            var result = "";
            if (url.Length > 7)
            {
                if (url.Substring(0, 8).ToLower() == "https://" || url.Substring(0, 7) == "http://")
                {
                    result = url;
                }
                else
                {
                    result = url.Insert(0, "http://");
                }
            }
            else
            {
                result = url.Insert(0, "http://");
            }
            return result;
        }
    }
}
