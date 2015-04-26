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
           int nbRows = 6;
           int nbCols = 7;
           IToken jetonVide = new Token();
           IToken jetonJ1 = new Token('x','X',ConsoleColor.Yellow);
           IToken jetonJ2 = new Token('+', 'O', ConsoleColor.Red);
           List<IToken> table = new List<IToken>();
           table.Add(jetonVide);
           table.Add(jetonJ1);
           table.Add(jetonJ2);
           
           IArrayFormatter formatter = new ArrayFormat();
           IArrayStock stockage = new ArrayStock(nbRows, nbCols, jetonVide);
           IPlayer player1 = new Player(jetonJ1);
           IPlayer player2 = new Player(jetonJ2);
           IPlayer[] p = new IPlayer[2];
           p[0] = player1;
           p[1] = player2;
           IOutput output = new ColorOutput(table);
           IInput input = new KeyboardInput();
           Power4 m = new Power4(p, formatter, stockage, output, input);
           m.run();
        }
    }
}
