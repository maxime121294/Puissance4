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
            if (nbTokenJ1 + nbTokenJ2 < 8)
            {
                // pas assezde jeton pour avoir un gagnant
            }
            //verif grille
            if (nbTokenJ1 == 0 && nbTokenJ2 == 0)
            {
                // fin de partie mais si pas de gagnant a la fin
                // de la verif 
            }

            return result;
        }
    }
}
