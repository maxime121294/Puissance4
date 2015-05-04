using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class Program
    {
        static void Main(string[] args)
        {
           Check.nbRows = 6;
           Check.nbCols = 7;
           IToken jetonVide = new Token();
           IToken jetonVainqueur = new Token('=', 'O', ConsoleColor.Green);
           IToken jetonJ1 = new Token('+','O',ConsoleColor.Yellow);
           IToken jetonJ2 = new Token('-', 'O', ConsoleColor.Red);
           List<IToken> table = new List<IToken>();
           table.Add(jetonVide);
           table.Add(jetonJ1);
           table.Add(jetonJ2);
           
           IArrayFormatter formatter = new ArrayFormat();
           IArrayStock stockage = new ArrayStock(Check.nbRows, Check.nbCols, jetonVide);
           IIterator[] iterator = new IIterator[4];
           iterator[0] = new Iterator(0, 1, stockage);
           iterator[1] = new Iterator(1, 0, stockage);
           iterator[2] = new Iterator(1, 1, stockage);
           iterator[3] = new Iterator(1, -1, stockage);
           Check.iterators = iterator;
           Check.empty = jetonVide;
           IPlayer[] p = new IPlayer[2];
           p[0] = new Player(jetonJ1, Check.nbRows * Check.nbCols / 2);
           p[1] = new Player(jetonJ2, Check.nbRows * Check.nbCols / 2);
           IOutput output = new ColorOutput(table);
           IInput input = new KeyboardInput();
           Power4 m = new Power4(p, formatter, stockage, output, input);
           m.run();
        }
    }
}
