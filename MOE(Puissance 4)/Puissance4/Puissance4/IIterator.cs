using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    interface IIterator
    {
        int x { get; set; }
        int y { get; set; }

        IToken next(int y, int x);
        IToken previous(int y, int x);
    }
}
