using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power4;

namespace Power4Test
{
    [TestClass]
    public class ArrayStockTest
    {

        /// <summary>
        ///Test pour addToken
        ///</summary>
        [TestMethod()]
        public void addTokenTest()
        {
            IToken empty = new Token();
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);

            ArrayStock tableau = new ArrayStock(10, 10, empty);
            IPlayer player = new Player(plein, 10);

            /* Si le jeton est en dehors du tableau */
            int solution = tableau.addToken(player, 15);
            Assert.AreEqual(-1, solution);

            /* Si Le tableau est rempli */
            ArrayStock tableauPlein = new ArrayStock(10, 10, plein);
            int TokenPlein = tableauPlein.addToken(player, 9);
            Assert.AreNotEqual(-1, TokenPlein);
            Assert.AreEqual(-3, TokenPlein);
        }
    }
}
