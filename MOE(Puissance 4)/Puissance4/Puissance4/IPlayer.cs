﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    interface IPlayer
    {
        string name { get; set; }
        int nbToken { get; set; }
        IToken tokenStyle { get; set; }
    }
}