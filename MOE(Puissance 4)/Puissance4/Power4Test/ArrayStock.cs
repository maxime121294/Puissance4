using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power4;

namespace Power4Test
{
    [TestClass]
    public class ArrayStock
    {
        [TestMethod]
        public void addToken()
        {
            IToken jeton = new Token();
            IArrayStock tableau = new ArrayStock(10, 10, jeton);
            IPlayer player = new Player(jeton, 10);

            int solution = tableau.addToken(player, 15);

            Assert.AreEqual(-1, solution);
        }
    }
}
