using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public interface IToken
    {
        char value { get; set; }
        char icon { get; set; }
        ConsoleColor color { get; set; }

        bool Equals(IToken t);
    }
}
