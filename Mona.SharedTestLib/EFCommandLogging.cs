using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mona.SharedTestLib
{
    public static class EFCommandLogging
    {
        //To display newline and linefeed in the immediate window use the syntax
        //?LogBuilder.Tostring(),nq
        public static StringBuilder LogBuilder { get; set; } = new StringBuilder();

        public static void Log(string message)
        {
            LogBuilder.Append(message);
            
        }

        

    }
}
