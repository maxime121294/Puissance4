using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Check
    {
        public static int nbRows;
        public static int nbCols;
        public static IIterator[] iterators;
        public static IToken empty;

        public static bool checkEnd(int impactRow, int impactCol, IArrayStock grilleJeu)
        {
            foreach(IIterator it in iterators)
            {
                Console.WriteLine("[" + it.x + "," + it.y + "]");
                // On initialise et on change le vecteur.
                IToken previousToken = null;
                IToken currentToken = grilleJeu.getValue(impactRow, impactCol);
                int chainSize1 = -1;
                int chainSize2 = -1;
                int x = 0;
                int y = 0;
                if ((impactRow < grilleJeu.nbrows && impactCol < grilleJeu.nbcols))
                {
                    y = impactRow;
                    x = impactCol;
                    Console.WriteLine("Suivants");
                    do
                    {
                        previousToken = currentToken;
                        Console.WriteLine("Nous sommes en [" + x + "," + y + "]");
                        Console.WriteLine("Le jeton est " + previousToken.value);
                        // On vérifie les jetons qui suivent.
                        chainSize1++;
                        if (x + it.x >= nbRows || y + it.y >= nbCols || x + it.x < 0 || y + it.y < 0)
                            break;
                        currentToken = it.next(y, x);
                        if (currentToken == null || currentToken.Equals(empty))
                            break;
                        x += it.x;
                        y += it.y;
                        Console.WriteLine("Nous allons en [" + x + "," + y + "]");
                        Console.WriteLine("Le jeton est " + currentToken.value);
                    }
                    while (previousToken.Equals(currentToken));
                    y = impactRow;
                    x = impactCol;
                    currentToken = grilleJeu.getValue(impactRow, impactCol);
                    Console.WriteLine("Précédents");
                    do
                    {
                        previousToken = currentToken;
                        Console.WriteLine("Nous sommes en [" + x + "," + y + "]");
                        Console.WriteLine("Le jeton est " + previousToken.value);
                        // On vérifie les jetons qui précédent.
                        chainSize2++;
                        if (x - it.x >= nbRows || y - it.y >= nbCols || x - it.x < 0 || y - it.y < 0)
                            break;
                        currentToken = it.previous(y, x);
                        if (currentToken == null || currentToken.Equals(empty))
                            break;
                        x -= it.x;
                        y -= it.y;
                    }
                    while (previousToken.Equals(currentToken));
                    Console.ReadKey();
                    // On fait la somme des deux, si c'est supérieur ou égal à 4, le joueur a gagné.
                    if (chainSize1 + chainSize2 >= 4)
                        return true;
                }
            }
            return false;
        }

        public static bool checkNumberColonneValide(int numcolonne)
        {
            if (numcolonne > 0 && numcolonne < nbCols)
                return true;
            else
                return false;
        }
    }
}
