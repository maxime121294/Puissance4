using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Program
    {
        static void Main(string[] args)
        {
           IPlayer player1 = new Player();
           IPlayer player2 = new Player();
           IArrayFormatter formatter = new ArrayFormat();
           IArrayStock stockage = new ArrayStock();
           CheckEnd checkend = new CheckEnd();
           IOutput output = new ColorOutput();
           IInput input = new KeyboardInput();
           Power4 p = new Power4(player1, player2, formatter, stockage, checkend, output, input);
           p.run();
        }
    }
}
