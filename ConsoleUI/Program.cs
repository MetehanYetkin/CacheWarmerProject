using Core.Utilities.Parser;
using Core.Utilities.Writer;
using Core.Utilities.WepRequest;
using System;
using Core.Utilities.RequestsAtSpecifiedTimes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Scheduler scheduler = new Scheduler();
           scheduler.InitializeJobsForHour();


            test();
        }
        private static void test()
        {
            XmlParser xmlParser = new XmlParser(new StreamWrite(),new WepRequestt());
            xmlParser.XmlParserr();

        }
    }
}
