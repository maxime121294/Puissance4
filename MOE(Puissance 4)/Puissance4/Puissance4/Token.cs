using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Token : IToken
    {
        private char _value;
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

        public Token() {
            _value = '.';
        }

        public Token(char valeur)
        {
            _value = valeur;
        }
        
    }
}
