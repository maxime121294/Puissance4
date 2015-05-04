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
            IIterator target = CreateIIterator(); // TODO: initialisez à une valeur appropriée
            int y = 0; // TODO: initialisez à une valeur appropriée
            int x = 0; // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.next(y, x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour previous
        ///</summary>
        [TestMethod()]
        public void previousTest()
        {
            IIterator target = CreateIIterator(); // TODO: initialisez à une valeur appropriée
            int y = 0; // TODO: initialisez à une valeur appropriée
            int x = 0; // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.previous(y, x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour x
        ///</summary>
        [TestMethod()]
        public void xTest()
        {
            IIterator target = CreateIIterator(); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.x = expected;
            actual = target.x;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour y
        ///</summary>
        [TestMethod()]
        public void yTest()
        {
            IIterator target = CreateIIterator(); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.y = expected;
            actual = target.y;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
