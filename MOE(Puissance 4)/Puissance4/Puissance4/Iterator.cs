using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class Iterator : IIterator
    {
        public int x { get; set; }
        public int y { get; set; }
        public IArrayStock s { get; set; }

        public Iterator(int a, int b, IArrayStock stock)
        {
            x = a;
            y = b;
            s = stock;
        }

        public IToken next(int col, int row)
        {
            return s.getValue(row + y, col + x);
        }

        public IToken previous(int col, int row)
        {
            return s.getValue(row - y, col - x);
        }
    }
}
