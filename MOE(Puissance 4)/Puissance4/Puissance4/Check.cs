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
                // On initialise et on change le vecteur.
                IToken previousToken = grilleJeu.getValue(impactRow, impactCol);
                IToken currentToken = null;
                int chainSize1 = 0;
                int chainSize2 = 0;
                int x = 0;
                int y = 0;
                if ((impactRow < grilleJeu.nbrows && impactCol < grilleJeu.nbcols))
                {
                    y = impactRow;
                    x = impactCol;
                    while (true)
                    {
                        // On vérifie les jetons qui suivent.
                        if ((x + it.x) >= nbCols || (y + it.y) >= nbRows || (x + it.x) < 0 || (y + it.y) < 0)
                        {
                            break;
                        }
                        currentToken = it.next(x, y);
                        if (currentToken == null || currentToken.Equals(empty))
                        {
                            break;
                        }
                        x += it.x;
                        y += it.y;
                        if (previousToken.Equals(currentToken))
                        {
                            chainSize1++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    y = impactRow;
                    x = impactCol;
                    previousToken = grilleJeu.getValue(impactRow, impactCol);
                    while(true)
                    {
                        // On vérifie les jetons qui précédent.
                        if ((x - it.x) >= nbCols || (y - it.y) >= nbRows || (x - it.x) < 0 || (y - it.y) < 0)
                        {
                            break;
                        }
                        currentToken = it.previous(x, y);
                        if (currentToken == null || currentToken.Equals(empty))
                        {
                            break;
                        }
                        x -= it.x;
                        y -= it.y;
                        if (previousToken.Equals(currentToken))
                        {
                            chainSize2++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // On fait la somme des deux, si c'est supérieur ou égal à 4, le joueur a gagné.
                    if (chainSize1 + chainSize2 >= 3)
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
