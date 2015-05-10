using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IIteratorTest, destinée à contenir tous
    ///les tests unitaires IIteratorTest
    ///</summary>
    [TestClass()]
    public class IIteratorTest
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


        internal virtual IIterator CreateIIterator()
        {
            // TODO: instanciez une classe concrète appropriée.
            IIterator target = null;
            return target;
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

            expected = stock.getValue(14, 15);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour previous
        ///</summary>
        [TestMethod()]
        public void previousTest()
        {
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IIterator target = new Iterator(10, 10, stock);

            int y = 5;
            int x = 5;
           
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.previous(y, x);
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour x
        ///</summary>
        [TestMethod()]
        public void xTest()
        {
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IIterator target = new Iterator(5, 6, stock);

            int expected = 5; 
            int actual;
            target.x = expected;
            actual = target.x;
            
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour y
        ///</summary>
        [TestMethod()]
        public void yTest()
        {
            IToken empty = new Token();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IIterator target = new Iterator(6, 5, stock);

            int expected = 5; 
            int actual;
            target.y = expected;
            actual = target.y;
            
            Assert.AreEqual(expected, actual);
        }
    }
}
