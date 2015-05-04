using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    public class Power4
    {
        private IArrayFormatter format;
        private IArrayStock stock;
        private IOutput output;
        private IInput input;
        private IPlayer[] players;

        public Power4(IPlayer[] p, IArrayFormatter format, IArrayStock stock, IOutput output, IInput input)
        {
            this.players = p;
            this.format = format;
            this.stock = stock;
            this.output = output;
            this.input = input;
        }

        internal void run()
        {
            title();
            for (int i = 0; i < players.Length; i++)
            {
                output.writeLine("Saisir le nom du joueur "+(i+1)+" :");
                players[i].name = input.readLine();
            }
            int currentPlayer = 1;
            Coordonnees impactCell;
            string grid = format.formatAsAGrid(stock);
            bool finParti = false;
            int numcol;
            int errorCode = 0;
            int impactLine = -1;
            while (!finParti)
            {
                currentPlayer = otherPlayer(currentPlayer);
                output.Clean();
                output.writeGrid(grid);
                while (true)
                {
                    output.writeLine(players[currentPlayer].name+", entrez le numero de colonne où jouer : ");
                    try
                    {
                        numcol = Convert.ToInt16(input.readLine()) - 1;
                    }
                    catch (FormatException)
                    {
                        errorCode = -999;
                        numcol = -1;
                    }
                    impactLine = stock.addToken(players[currentPlayer], numcol);
                    if (impactLine > -1)
                        break;
                    else if(errorCode > -999)
                        errorCode = impactLine;
                    //Affichage des cas d'erreurs.
                    switch(errorCode)
                    {
                        case -3:
                            output.writeLine("Colonne pleine.");
                            break;
                        case -1:
                            output.writeLine("Numéro de colonne hors du tableau.");
                            break;
                        default :
                            output.writeLine("Valeur incorrecte.");
                            break;
                    }
                }
                grid = format.formatAsAGrid(stock);
                impactCell = new Coordonnees(numcol, impactLine);
                finParti = Check.checkEnd(impactCell, stock);
            }
            output.Clean();
            grid = format.formatAsAGrid(stock);
            output.writeGrid(grid);
            output.writeLine("Victoire du joueur "+players[currentPlayer].name+ "!");
            input.readLine();
        }
        private int otherPlayer(int player)
        {
            return (player + 1) % players.Length;
        }

        private void title()
        {
            output.writeLine(":::::::::   ::::::::  :::       ::: :::::::::: :::::::::      :::     ");
            output.writeLine(":+:    :+: :+:    :+: :+:       :+: :+:        :+:    :+:    :+:      ");
            output.writeLine("+:+    +:+ +:+    +:+ +:+       +:+ +:+        +:+    +:+   +:+ +:+   ");
            output.writeLine("+#++:++#+  +#+    +:+ +#+  +:+  +#+ +#++:++#   +#++:++#:   +#+  +:+   ");
            output.writeLine("+#+        +#+    +#+ +#+ +#+#+ +#+ +#+        +#+    +#+ +#+#+#+#+#+ ");
            output.writeLine("#+#        #+#    #+#  #+#+# #+#+#  #+#        #+#    #+#       #+#   ");
            output.writeLine("###         ########    ###   ###   ########## ###    ###       ###   \n");
        }

    }
}
