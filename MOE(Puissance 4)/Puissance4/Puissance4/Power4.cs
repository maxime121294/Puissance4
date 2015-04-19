using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Power4
    {
        private IPlayer p1;
        private IPlayer p2;
        private IArrayFormatter format;
        private IArrayStock stock;
        private IOutput output;
        private IInput input;

        public Power4(IPlayer p1, IPlayer p2, IArrayFormatter format, IArrayStock stock, IOutput output, IInput input)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.format = format;
            this.stock = stock;
            this.output = output;
            this.input = input;
        }

        internal void run()
        {
            output.writeLine(":::::::::   ::::::::  :::       ::: :::::::::: :::::::::      :::     ");
            output.writeLine(":+:    :+: :+:    :+: :+:       :+: :+:        :+:    :+:    :+:      ");
            output.writeLine("+:+    +:+ +:+    +:+ +:+       +:+ +:+        +:+    +:+   +:+ +:+   ");
            output.writeLine("+#++:++#+  +#+    +:+ +#+  +:+  +#+ +#++:++#   +#++:++#:   +#+  +:+   ");
            output.writeLine("+#+        +#+    +#+ +#+ +#+#+ +#+ +#+        +#+    +#+ +#+#+#+#+#+ ");
            output.writeLine("#+#        #+#    #+#  #+#+# #+#+#  #+#        #+#    #+#       #+#   ");
            output.writeLine("###         ########    ###   ###   ########## ###    ###       ###   ");
            output.writeLine("\n\nSaisir le nom du joueur 1 :");
            p1.name = input.readLine();
           
            output.writeLine("Saisir le nom du joueur 2 :");
            p2.name = input.readLine();
            output.writeLine(p1.name + " VS " + p2.name + "!!!");

            string grid = format.formatAsAGrid(stock);
            bool finParti = false;
            int numcol;
            while (!finParti){
                output.writeGrid(grid);
                output.writeLine(p1.name+", entrez le numero de colonne où jouer : ");
                numcol = Convert.ToInt16(input.readLine()) - 1;
                stock.addToken(p1, numcol);
                grid = format.formatAsAGrid(stock);
                finParti = Check.checkEnd(p1.nbToken, p2.nbToken, stock);
                output.writeGrid(grid);
                output.writeLine(p2.name + ", entrez le numero de colonne où jouer : ");
                numcol = Convert.ToInt16(input.readLine()) - 1;
                stock.addToken(p2, numcol);
                grid = format.formatAsAGrid(stock);
                finParti = Check.checkEnd(p1.nbToken, p2.nbToken, stock);
            }
            
        }
    }
}
