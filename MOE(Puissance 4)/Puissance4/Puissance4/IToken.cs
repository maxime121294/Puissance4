using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    interface IToken
    {
        char value {get;set;}
        ConsoleColor color { get; set; }
    }
}
