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
        [TestMethod]
        public void addToken()
        {
            IToken empty = new Token();
            IToken jeton = new Token('+', 'O', ConsoleColor.Yellow);
            
            ArrayStock tableau = new ArrayStock(10, 10, empty);
            IPlayer player = new Player(jeton, 10);

            int solution = tableau.addToken(player, 15);

            Assert.AreEqual(-1, solution);
        }
    }
}
