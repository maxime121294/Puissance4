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
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);
            
            ArrayStock tableau = new ArrayStock(10, 10, empty);
            IPlayer player = new Player(plein, 10);

            int solution = tableau.addToken(player, 15);
            Assert.AreEqual(-1, solution);

            ArrayStock tableauPlein = new ArrayStock(10, 10, plein);
            int TokenPlein = tableauPlein.addToken(player, 9);
            Assert.AreNotEqual(-1, TokenPlein);
            Assert.AreEqual(-3, TokenPlein);
        }

        /// <summary>
        ///Test pour Constructeur ArrayStock
        ///</summary>
        [TestMethod()]
        public void ArrayStockConstructorTest()
        {
            int nbr = 0; // TODO: initialisez à une valeur appropriée
            int nbc = 0; // TODO: initialisez à une valeur appropriée
            IToken empty = null; // TODO: initialisez à une valeur appropriée
            ArrayStock target = new ArrayStock(nbr, nbc, empty);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour addToken
        ///</summary>
        [TestMethod()]
        public void addTokenTest()
        {
            int nbr = 0; // TODO: initialisez à une valeur appropriée
            int nbc = 0; // TODO: initialisez à une valeur appropriée
            IToken empty = null; // TODO: initialisez à une valeur appropriée
            ArrayStock target = new ArrayStock(nbr, nbc, empty); // TODO: initialisez à une valeur appropriée
            IPlayer p = null; // TODO: initialisez à une valeur appropriée
            int numcol = 0; // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.addToken(p, numcol);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour getValue
        ///</summary>
        [TestMethod()]
        public void getValueTest()
        {
            int nbr = 0; // TODO: initialisez à une valeur appropriée
            int nbc = 0; // TODO: initialisez à une valeur appropriée
            IToken empty = null; // TODO: initialisez à une valeur appropriée
            ArrayStock target = new ArrayStock(nbr, nbc, empty); // TODO: initialisez à une valeur appropriée
            int row = 0; // TODO: initialisez à une valeur appropriée
            int col = 0; // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.getValue(row, col);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour nbcols
        ///</summary>
        [TestMethod()]
        public void nbcolsTest()
        {
            int nbr = 0; // TODO: initialisez à une valeur appropriée
            int nbc = 0; // TODO: initialisez à une valeur appropriée
            IToken empty = null; // TODO: initialisez à une valeur appropriée
            ArrayStock target = new ArrayStock(nbr, nbc, empty); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.nbcols = expected;
            actual = target.nbcols;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour nbrows
        ///</summary>
        [TestMethod()]
        public void nbrowsTest()
        {
            int nbr = 0; // TODO: initialisez à une valeur appropriée
            int nbc = 0; // TODO: initialisez à une valeur appropriée
            IToken empty = null; // TODO: initialisez à une valeur appropriée
            ArrayStock target = new ArrayStock(nbr, nbc, empty); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.nbrows = expected;
            actual = target.nbrows;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
