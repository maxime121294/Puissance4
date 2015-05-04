using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class ColorOutput : IOutput
    {
        public List<IToken> table;

        public ColorOutput(List<IToken> list)
        {
            table = list;
        }

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

        public void setForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void writeGrid(string grid)
        {
            foreach (Object c in grid)
            {
                char i = (char) c;
                int index = table.FindIndex( delegate(IToken bk)
                                {
                                    return bk.value == (char)c;
                                }
            );
                if (index>-1)
                {
                    setForegroundColor(table.ElementAt(index).color);
                    i = table.ElementAt(index).icon;
                }
                write(i);
                resetColor();
            }
        }

        public void Clean()
        {
            Console.Clear();
        }
    }
}
