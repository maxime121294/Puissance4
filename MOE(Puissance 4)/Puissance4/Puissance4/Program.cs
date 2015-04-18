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
           IToken jetonJ1 = new Token('x', ConsoleColor.Yellow);
           IToken jetonJ2 = new Token('+', ConsoleColor.Yellow); ;
           IArrayFormatter formatter = new ArrayFormat();
           IArrayStock stockage = new ArrayStock(nbRows, nbCols, jetonVide);
           IPlayer player1 = new Player();
           player1.tokenStyle = jetonJ1;
           IPlayer player2 = new Player();
           player2.tokenStyle = jetonJ2;
           IOutput output = new ColorOutput();
           IInput input = new KeyboardInput();
           Power4 p = new Power4(player1, player2, formatter, stockage, output, input);
           p.run();
        }
    }
}
