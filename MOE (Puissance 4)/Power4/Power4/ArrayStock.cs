using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class ArrayStock : IArrayStock
    {
        public IToken[][] array;
        public int nbrow;
        public int nbcol;

        public ArrayStock(int nbr, int nbc, IToken empty)
        {
            nbrow = nbr;
            nbcol = nbc;
            array = new Token[nbcol][];
            for (int i = 0; i < nbcol; i++ )
            {
                array[i] = new Token[nbrow];
            }
            for (int i = 0; i < nbcol; i++)
            {
                for (int j = 0; j < nbrow; j++)
                {
                    array[i][j] = empty;
                }
            }

        }
    }
}
