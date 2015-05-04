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
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour next
        ///</summary>
        [TestMethod()]
        public void nextTest()
        {
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock); // TODO: initialisez à une valeur appropriée
            int col = 0; // TODO: initialisez à une valeur appropriée
            int row = 0; // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.next(col, row);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour previous
        ///</summary>
        [TestMethod()]
        public void previousTest()
        {
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock); // TODO: initialisez à une valeur appropriée
            int col = 0; // TODO: initialisez à une valeur appropriée
            int row = 0; // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            actual = target.previous(col, row);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour s
        ///</summary>
        [TestMethod()]
        public void sTest()
        {
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock); // TODO: initialisez à une valeur appropriée
            IArrayStock expected = null; // TODO: initialisez à une valeur appropriée
            IArrayStock actual;
            target.s = expected;
            actual = target.s;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour x
        ///</summary>
        [TestMethod()]
        public void xTest()
        {
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock); // TODO: initialisez à une valeur appropriée
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
            int a = 0; // TODO: initialisez à une valeur appropriée
            int b = 0; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            Iterator target = new Iterator(a, b, stock); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.y = expected;
            actual = target.y;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
