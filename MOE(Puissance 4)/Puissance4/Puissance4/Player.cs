using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Player : IPlayer
    {
        public string name { get; set; }
        public int nbToken { get; set; }
        public IToken tokenStyle { get; set;}
       
        public Player() {
            nbToken = 21;
        }
    }
}
