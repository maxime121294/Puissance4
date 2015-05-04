using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour TokenTest, destinée à contenir tous
    ///les tests unitaires TokenTest
    ///</summary>
    [TestClass()]
    public class TokenTest
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
        ///Test pour Constructeur Token
        ///</summary>
        [TestMethod()]
        public void TokenConstructorTest()
        {
            char valeur = '\0'; // TODO: initialisez à une valeur appropriée
            char icone = '\0'; // TODO: initialisez à une valeur appropriée
            ConsoleColor couleur = new ConsoleColor(); // TODO: initialisez à une valeur appropriée
            Token target = new Token(valeur, icone, couleur);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Token
        ///</summary>
        [TestMethod()]
        public void TokenConstructorTest1()
        {
            Token target = new Token();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            Token target = new Token(); // TODO: initialisez à une valeur appropriée
            IToken t = null; // TODO: initialisez à une valeur appropriée
            bool expected = false; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.Equals(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour color
        ///</summary>
        [TestMethod()]
        public void colorTest()
        {
            Token target = new Token(); // TODO: initialisez à une valeur appropriée
            ConsoleColor expected = new ConsoleColor(); // TODO: initialisez à une valeur appropriée
            ConsoleColor actual;
            target.color = expected;
            actual = target.color;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour icon
        ///</summary>
        [TestMethod()]
        public void iconTest()
        {
            Token target = new Token(); // TODO: initialisez à une valeur appropriée
            char expected = '\0'; // TODO: initialisez à une valeur appropriée
            char actual;
            target.icon = expected;
            actual = target.icon;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour value
        ///</summary>
        [TestMethod()]
        public void valueTest()
        {
            Token target = new Token(); // TODO: initialisez à une valeur appropriée
            char expected = '\0'; // TODO: initialisez à une valeur appropriée
            char actual;
            target.value = expected;
            actual = target.value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
