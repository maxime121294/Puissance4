using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IArrayStockTest, destinée à contenir tous
    ///les tests unitaires IArrayStockTest
    ///</summary>
    [TestClass()]
    public class IArrayStockTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IArrayStock CreateIArrayStock()
        {
            // TODO: instanciez une classe concrète appropriée.
            IArrayStock target = null;
            return target;
        }

        /// <summary>
        ///Test pour addToken
        ///</summary>
        [TestMethod()]
        public void addTokenTest()
        {
            IToken empty = new Token();
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);

            IArrayStock target = new ArrayStock(10, 10, empty);
            IPlayer p = new Player(plein, 10);
            int numcol = 15;
            int expected = -1;
            int actual;
            actual = target.addToken(p, numcol);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour getValue
        ///</summary>
        [TestMethod()]
        public void getValueTest()
        {
            IToken empty = new Token();
            IArrayStock target = new ArrayStock(10, 10, empty);
            IToken[,] expected = new Token[8, 8];

            int row = 8;
            int col = 8; 
            IToken actual;
            actual = target.getValue(row, col);
            Assert.IsNotNull(actual);

            row = 12;
            col = 12;
            actual = target.getValue(row, col);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///Test pour nbcols
        ///</summary>
        [TestMethod()]
        public void nbcolsTest()
        {
            IToken empty = new Token();
            IArrayStock target = new ArrayStock(10, 10, empty); 

            int expected = 10;
            int actual;
            target.nbcols = expected;
            actual = target.nbcols;
            Assert.AreEqual(expected, actual);

            expected = -1;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour nbrows
        ///</summary>
        [TestMethod()]
        public void nbrowsTest()
        {
            IToken empty = new Token();
            IArrayStock target = new ArrayStock(10, 8, empty);
            int expected = 10; // TODO: initialisez à une valeur appropriée
            int actual;
            target.nbrows = expected;
            actual = target.nbrows;
            Assert.AreEqual(expected, actual);

            expected = -1;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
