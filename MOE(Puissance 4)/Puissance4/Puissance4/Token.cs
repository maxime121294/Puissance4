using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class Token : IToken
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
        private char _icon;
        public char icon
        {
            get
            {
                return _icon;
            }

            set
            {
                _icon = icon;
            }
        }
        private ConsoleColor _color;
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

        public Token()
        {
            _value = '.';
            _icon = '.';
            _color = ConsoleColor.White;
        }

        public Token(char valeur, char icone, ConsoleColor couleur)
        {
            _value = valeur;
            _icon = icone;
            _color = couleur;
        }

        public bool Equals(IToken t)
        {
            return t.value == _value;
        }
    }
}
