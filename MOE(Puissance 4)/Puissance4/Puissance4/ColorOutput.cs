using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class ColorOutput : IOutput
    {
        public void write(string p)
        {
            Console.Write(p);
        }

        public void writeLine(string p)
        {
            Console.WriteLine(p);
        }
    }
}
