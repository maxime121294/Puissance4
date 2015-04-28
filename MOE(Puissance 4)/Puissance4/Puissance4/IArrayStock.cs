﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    interface IArrayStock
    {
        int nbrows { get; set; }
        int nbcols { get; set; }

        IToken getValue(int row, int col);

        int addToken(IPlayer p, int numcol);

    }
}
