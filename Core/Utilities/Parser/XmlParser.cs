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
        public void XmlParserr() 
        {
            //StreamWrite streamWrite = new StreamWrite();
           // WepRequestt wepRequestt = new WepRequestt();
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
                            // WepRequestt wepRequestt = new WepRequestt();
                        }
                        break;



                }
            }

            List<string> locUrl = new List<string>();
          
            foreach (var x in xmlUrl)
            {
                String URLString = x;
                XmlTextReader reader = new XmlTextReader(URLString);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {


                        case XmlNodeType.Text:
                            if (reader.Value.Contains("http"))
                            {
                                Console.WriteLine(reader.Value);
                                locUrl.Add(reader.Value);
                                //WepRequestt wepRequestt = new WepRequestt();
                            }//Display the text in each element.
                          
                            break;


                    }
                }

            }
           

            StreamWrite.StreamWriteWriteLine(locUrl);
        }
    }
}
