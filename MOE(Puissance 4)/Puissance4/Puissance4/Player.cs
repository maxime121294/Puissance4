using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class Player : IPlayer
    {
        public string name { get; set; }
        public int nbToken { get; set; }
        public IToken tokenStyle { get; set;}
       
        public Player(IToken t, int n) {
            nbToken = n;
            tokenStyle = t;
        }

        public void reset(int n)
        {
            nbToken = n;
        }
    }
}
