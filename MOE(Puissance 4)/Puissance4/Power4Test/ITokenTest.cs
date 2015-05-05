using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour ITokenTest, destinée à contenir tous
    ///les tests unitaires ITokenTest
    ///</summary>
    [TestClass()]
    public class ITokenTest
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


        internal virtual IToken CreateIToken()
        {
            // TODO: instanciez une classe concrète appropriée.
            IToken target = null;
            return target;
        }

        /// <summary>
        ///Test pour Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black);
            IToken t = new Token(); 
            bool expected = false;
            bool actual;
            actual = target.Equals(t);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour color
        ///</summary>
        [TestMethod()]
        public void colorTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black); 
            ConsoleColor expected = ConsoleColor.Black; 
            ConsoleColor actual;
            target.color = expected;
            actual = target.color;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour icon
        ///</summary>
        [TestMethod()]
        public void iconTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black);
            char expected = 'O';
            char actual;
            target.icon = expected;
            actual = target.icon;
            Assert.AreEqual(expected, actual);

            expected = '0';
            target.icon = expected;
            actual = target.icon;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///Test pour value
        ///</summary>
        [TestMethod()]
        public void valueTest()
        {
            IToken target = CreateIToken(); // TODO: initialisez à une valeur appropriée
            char expected = '\0'; // TODO: initialisez à une valeur appropriée
            char actual;
            target.value = expected;
            actual = target.value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
