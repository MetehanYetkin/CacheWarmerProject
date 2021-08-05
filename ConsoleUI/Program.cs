using Core.Utilities.Parser;
using Core.Utilities.Writer;
using Core.Utilities.WepRequest;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        private static void test()
        {
            XmlParser xmlParser = new XmlParser(new StreamWrite(),new WepRequestt());
            xmlParser.XmlParserr();

        }
    }
}
