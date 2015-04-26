using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    interface IOutput
    {
        void write(string p);

        void writeLine(string p);

        void writeGrid(string grid);

        void resetColor();

        void setForegroundColor(ConsoleColor c);
    }
}
