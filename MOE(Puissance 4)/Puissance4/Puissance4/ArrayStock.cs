using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class ArrayStock : IArrayStock
    {
        public IToken[,] array;
        private int _nbrows;
        private int _nbcols;
        public int nbrows
        {
            get
            {
                return _nbrows;
            }

            set
            {
                _nbrows = value;
            }
        }
        public int nbcols
        {
            get
            {
                return _nbcols;
            }
            set
            {
                _nbcols = value;
            }
        }

        /** Stock les tokens (grille de jeu)
         */
        public ArrayStock(int nbr, int nbc, IToken empty)
        {
            
            _nbrows = nbr;
            _nbcols = nbc;
            array = new Token[_nbrows,_nbcols];
            
            for (int i = 0; i < _nbrows; i++)
                for (int j = 0; j < _nbcols; j++)
                    array[i,j] = empty;

        }

        public IToken getValue (int row, int col){
            if (row >= nbrows || col >= nbcols)
                return null;
            return array[row,col];
        }

        public bool addToken(IPlayer p, int numcol)
        {
            bool insertionOK = false;
            //Si le numero saisi est hors tableau.
            if (numcol >= nbcols || numcol < 0)
                return insertionOK;
            for(int i = 0; i < nbrows && !insertionOK; i++)
                if (array[i, numcol].value == '.')
                {
                    array[i, numcol] = p.tokenStyle;
                    insertionOK = true;
                    p.nbToken = p.nbToken - 1;
                }

            return insertionOK;
        }

    }
}
