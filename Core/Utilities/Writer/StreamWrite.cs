using Core.Utilities.WepRequest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Core.Utilities.Writer
{
    public class StreamWrite 
    {
        public static void StreamWriteWriteLine(List<string> xmlText)
        {
            var path = @"C:\Users\Lenovo\Desktop\ParseRec.txt";
            File.AppendAllLines(path, xmlText);
            

        }
    }
}
