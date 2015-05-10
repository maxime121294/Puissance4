using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IteratorTest, destinée à contenir tous
    ///les tests unitaires IteratorTest
    ///</summary>
    [TestClass()]
    public class IteratorTest
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


        /// <summary>
        ///Test pour Constructeur Iterator
        ///</summary>
        [TestMethod()]
        public void IteratorConstructorTest()
        {
            int a = 10;
            int b = 10;
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            Iterator target = new Iterator(a, b, stock);
        }

        /// <summary>
        ///Test pour next
        ///</summary>
        [TestMethod()]
        public void nextTest()
        {
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IIterator target = new Iterator(10, 10, stock);
            int y = 5;
            int x = 5;

            IToken expected = new Token('+', 'O', ConsoleColor.Yellow);
            IToken actual;
            expected = stock.getValue(15, 15);
            actual = target.next(y, x);
            Assert.AreEqual(expected, actual);

            expected = stock.getValue(14, 14);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour previous
        ///</summary>
        [TestMethod()]
        public void previousTest()
        {
            int a = 5; 
            int b = 5; 
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            Iterator target = new Iterator(a, b, stock); 
            int col = 1; 
            int row = 1; 
            IToken expected = stock.getValue(4, 4);
            IToken actual;
            actual = target.previous(col, row);
            Assert.AreEqual(expected, actual);

            expected = stock.getValue(6, 6);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour x
        ///</summary>
        [TestMethod()]
        public void xTest()
        {
            int a = 5;
            int b = 4;
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            Iterator target = new Iterator(a, b, stock);

            int expected = 5;
            int actual;
            actual = target.x;
            Assert.AreEqual(expected, actual);

            expected = 4;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour y
        ///</summary>
        [TestMethod()]
        public void yTest()
        {
            int a = 4; 
            int b = 5; 
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            Iterator target = new Iterator(a, b, stock); 
           
            int expected = 5; 
            int actual;
            actual = target.y;
            Assert.AreEqual(expected, actual);

            expected = 4;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
