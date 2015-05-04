﻿using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour PlayerTest, destinée à contenir tous
    ///les tests unitaires PlayerTest
    ///</summary>
    [TestClass()]
    public class PlayerTest
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
        ///Test pour Constructeur Player
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest()
        {
            IToken t = null; // TODO: initialisez à une valeur appropriée
            int n = 0; // TODO: initialisez à une valeur appropriée
            Player target = new Player(t, n);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour name
        ///</summary>
        [TestMethod()]
        public void nameTest()
        {
            IToken t = null; // TODO: initialisez à une valeur appropriée
            int n = 0; // TODO: initialisez à une valeur appropriée
            Player target = new Player(t, n); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            target.name = expected;
            actual = target.name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour nbToken
        ///</summary>
        [TestMethod()]
        public void nbTokenTest()
        {
            IToken t = null; // TODO: initialisez à une valeur appropriée
            int n = 0; // TODO: initialisez à une valeur appropriée
            Player target = new Player(t, n); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            target.nbToken = expected;
            actual = target.nbToken;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour tokenStyle
        ///</summary>
        [TestMethod()]
        public void tokenStyleTest()
        {
            IToken t = null; // TODO: initialisez à une valeur appropriée
            int n = 0; // TODO: initialisez à une valeur appropriée
            Player target = new Player(t, n); // TODO: initialisez à une valeur appropriée
            IToken expected = null; // TODO: initialisez à une valeur appropriée
            IToken actual;
            target.tokenStyle = expected;
            actual = target.tokenStyle;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
