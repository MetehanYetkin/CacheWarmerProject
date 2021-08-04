using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Core.Utilities.WepRequest
{
    public class WepRequestt
    {
        public static void CallUrl(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Console.WriteLine("Success request");
            // string urlText = reader.ReadToEnd();
            // Console.WriteLine(urlText);
        }
    }
}
