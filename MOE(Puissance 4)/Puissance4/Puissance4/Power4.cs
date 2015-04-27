using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Power4
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
            int currentPlayer = 0;
            string grid = format.formatAsAGrid(stock);
            bool finParti = false;
            int numcol;
            bool test;
            while (!finParti)
            {
                output.Clean();
                output.writeGrid(grid);
                while (true)
                {
                    output.writeLine(players[currentPlayer].name+", entrez le numero de colonne où jouer : ");
                    try
                    {
                        numcol = Convert.ToInt16(input.readLine()) - 1;
                    }
                    catch (FormatException e)
                    {
                        numcol = -1;
                    }
                    test = stock.addToken(players[currentPlayer], numcol);
                    if (test)
                        break;
                    output.writeLine("Valeur incorrecte.");
                }
                grid = format.formatAsAGrid(stock);
                finParti = Check.checkEnd(players[currentPlayer].nbToken, players[otherPlayer(currentPlayer)].nbToken, stock);
                currentPlayer = otherPlayer(currentPlayer);
            }
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
