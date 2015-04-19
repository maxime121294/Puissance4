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

        public void writeGrid(string grid)
        {
            foreach (char c in grid)
            {
                if (c == 'x')
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (c == '+')
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ResetColor();
                Console.Write(c);
                Console.ResetColor();
            }
        }
    }
}
