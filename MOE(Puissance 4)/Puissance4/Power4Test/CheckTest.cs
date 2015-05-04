using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour CheckTest, destinée à contenir tous
    ///les tests unitaires CheckTest
    ///</summary>
    [TestClass()]
    public class CheckTest
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
        ///Test pour Constructeur Check
        ///</summary>
        [TestMethod()]
        public void CheckConstructorTest()
        {
            Check target = new Check();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour checkEnd
        ///</summary>
        [TestMethod()]
        public void checkEndTest()
        {
            IToken empty = new Token();
            IToken plein = new Token('+', 'O', ConsoleColor.Yellow);

            IPlayer player = new Player(plein, 10);


            int impactRow = 1; // TODO: initialisez à une valeur appropriée
            int impactCol = 2; // TODO: initialisez à une valeur appropriée
            IArrayStock grilleJeu = new ArrayStock(4,4, empty); // TODO: initialisez à une valeur appropriée

            bool expected = false; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = Check.checkEnd(impactRow, impactCol, grilleJeu);

            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour checkNumberColonneValide
        ///</summary>
        [TestMethod()]
        public void checkNumberColonneValideTest()
        {
            int numcolonne = 0; // TODO: initialisez à une valeur appropriée
            bool expected = false; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = Check.checkNumberColonneValide(numcolonne);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
