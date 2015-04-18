using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class KeyboardInput : IInput
    {
        public char read()
        {
            return Convert.ToChar(Console.Read());
        }

        public String readLine()
        {
            return Console.ReadLine();
        }
    }
}
