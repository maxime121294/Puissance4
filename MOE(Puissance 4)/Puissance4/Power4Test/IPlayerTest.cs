using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IPlayerTest, destinée à contenir tous
    ///les tests unitaires IPlayerTest
    ///</summary>
    [TestClass()]
    public class IPlayerTest
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


        internal virtual IPlayer CreateIPlayer()
        {
            IToken t = new Token('+', 'O', ConsoleColor.Yellow);
            IPlayer target = new Player(t,1);
            return target;
        }

        /// <summary>
        ///Test pour name
        ///</summary>
        [TestMethod()]
        public void nameTest()
        {
            IToken t = new Token('+', 'O', ConsoleColor.Yellow);
            int n = 1;
            Player target = new Player(t, n);
            string expected = "Testeur";
            string actual;
            target.name = expected;
            actual = target.name;
            Assert.AreEqual(expected, actual);

            expected = "Testeur N°2";
            Assert.AreNotEqual(expected, actual);

            expected = "Testeur";
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour nbToken
        ///</summary>
        [TestMethod()]
        public void nbTokenTest()
        {
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);
            IPlayer target = new Player(plein, 10);

            int expected = 10; 
            int actual;
            target.nbToken = expected;
            actual = target.nbToken;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour tokenStyle
        ///</summary>
        [TestMethod()]
        public void tokenStyleTest()
        {
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);
            IPlayer target = new Player(plein, 10);

            IToken expected = new Token('+', 'O', ConsoleColor.Yellow);
            IToken actual;
            target.tokenStyle = expected;
            actual = target.tokenStyle;
            Assert.AreEqual(expected, actual);

            expected = new Token('+', 'O', ConsoleColor.Black);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
