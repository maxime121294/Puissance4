using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Token : IToken
    {
        private char _value;
        private ConsoleColor _color;
        public char value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }
        public ConsoleColor color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = color;
            }
        }

        public Token() {
            _value = '.';
            _color = ConsoleColor.White;
        }

        public Token(char valeur, ConsoleColor c)
        {
            _value = valeur;
            _color = c;
        }
        
    }
}
