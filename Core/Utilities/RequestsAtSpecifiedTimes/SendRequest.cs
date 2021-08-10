using Core.Utilities.Parser;
using Core.Utilities.WepRequest;
using Core.Utilities.Writer;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Core.Utilities.RequestsAtSpecifiedTimes
{
    public class SendRequest : IJob
    {
       
        public Task Execute(IJobExecutionContext context)
        {

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

            XmlParser xmlParser = new XmlParser(new StreamWrite(), new WepRequestt());
            xmlParser.XmlParserr();
            return Task.CompletedTask;
        }
    }
}
