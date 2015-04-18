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
        private CheckEnd end;
        private IOutput output;
        private IInput input;

        public Power4(IPlayer p1, IPlayer p2, IArrayFormatter format, IArrayStock stock, CheckEnd end, IOutput output, IInput input)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.format = format;
            this.stock = stock;
            this.end = end;
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
            output.writeLine("Appuyer sur une touche pour lancer le jeu.\n");
            input.readKey();
            string grid = format.formatAsAGrid(stock);
            output.write(grid);
            output.writeLine(p1.name+", entrez le numero de colonne où jouer : ");
            input.readKey();
        }
    }
}
