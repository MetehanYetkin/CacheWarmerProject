using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Writer
{
   public interface IStreamWrite
    {
        void StreamWriteWriteLine(List<string> xmlText);
    }
}
