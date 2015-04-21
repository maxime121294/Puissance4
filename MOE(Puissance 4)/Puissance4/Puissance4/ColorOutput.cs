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

        public void write(char p)
        {
            Console.Write(p);
        }

        public void writeLine(string p)
        {
            Console.WriteLine(p);
        }

        public void resetColor()
        {
            Console.ResetColor();
        }

        public void green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void writeGrid(string grid)
        {
            foreach (char c in grid)
            {
                if (c == 'x')
                    green();
                else if (c == '+')
                    red();
                else
                    resetColor();
                write(c);
                resetColor();
            }
        }
    }
}
