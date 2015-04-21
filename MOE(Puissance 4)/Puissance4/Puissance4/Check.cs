using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Check
    {
        public static bool checkEnd(int nbTokenJ1, int nbTokenJ2, IArrayStock grilleJeu)
        {
            bool result = false;
            // si assez de jetons jouez pour avoir un gagnant 
            if (!(nbTokenJ1 + nbTokenJ2 < 8))
            {
                //verif colonne
                for (int i = 0; i < grilleJeu.nbcols; i++)
                {

                }
                //verif lignes
                for (int i = 0; i < grilleJeu.nbrows; i++)
                {

                }
                //verif diagonal
                if (nbTokenJ1 == 0 && nbTokenJ2 == 0)
                {
                    result = true;
                }
            }
            
            return result;
        }

        public static bool checkNumberColonneValide(int numcolonne)
        {
            if (numcolonne > 0 && numcolonne < 8)
                return true;
            else
                return false;
        }
    }
}
