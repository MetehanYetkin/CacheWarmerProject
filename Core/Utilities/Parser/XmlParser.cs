using Core.Utilities.WepRequest;
using Core.Utilities.Writer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Core.Utilities.Parser
{
    public class XmlParser
    {
        IStreamWrite _streamWrite;
        IWepRequest _wepRequest;
        public XmlParser(IStreamWrite streamWrite, IWepRequest wepRequest)
        {
            _streamWrite = streamWrite;
            _wepRequest = wepRequest;

        }

        public void XmlParserr() 
        {
           
            String URLStringg = "https://bimarket.co.uk/sitemap_index.xml";

            XmlTextReader readerr = new XmlTextReader(URLStringg);
            List<string> xmlUrl = new List<string>();

            while (readerr.Read())
            {
                switch (readerr.NodeType)
                {
                    
                    
                    case XmlNodeType.Text:
                        if (readerr.Value.Contains("http"))
                        {
                            Console.WriteLine(readerr.Value);
                            xmlUrl.Add(readerr.Value);
                        }
                        break;



                }
            }

            List<string> locUrl = new List<string>();
          
            foreach (var x in xmlUrl)
            {
                string URLString = x;
                XmlTextReader reader = new XmlTextReader(URLString);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {


                        case XmlNodeType.Text:
                            if (reader.Value.Contains("http"))
                            {
                                if (reader.Value.EndsWith("/"))
                                {
                                  Console.WriteLine(reader.Value);
                                  locUrl.Add(reader.Value);
                                  _wepRequest.CallUrl(reader.Value);
                                }
                                

                            }

                            break;


                    }
                }

            }

            _streamWrite.StreamWriteWriteLine(locUrl);
        }
    }
}
