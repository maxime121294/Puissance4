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
            IToken full = new Token('+', 'O', ConsoleColor.Yellow);
 
            Check.nbCols = 4;
            Check.nbRows = 4;
            Check.empty = empty;
            IArrayStock grilleJeu = new ArrayStock(Check.nbCols, Check.nbRows, empty);
            
            IIterator[] iterator = new IIterator[4];
            iterator[0] = new Iterator(0, 1, grilleJeu);
            iterator[1] = new Iterator(1, 0, grilleJeu);
            iterator[2] = new Iterator(1, 1, grilleJeu);
            iterator[3] = new Iterator(1, -1, grilleJeu);
            Check.iterators = iterator;

            IPlayer player = new Player(full, 10);

            int jeton = grilleJeu.addToken(player, 3);
            jeton = grilleJeu.addToken(player, 3);
            jeton = grilleJeu.addToken(player, 3);
            jeton = grilleJeu.addToken(player, 3);

            Coordonnees coor = new Coordonnees(3, jeton);
            bool expected = true; 
            bool actual;
            actual = Check.checkEnd(coor, grilleJeu);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour checkNumberColonneValide
        ///</summary>
        [TestMethod()]
        public void checkNumberColonneValideTest()
        {
            Check.nbCols = 4;
            int numcolonne = 3; 
            bool expected = true; 
            bool actual;
            actual = Check.checkNumberColonneValide(numcolonne);
            Assert.AreEqual(expected, actual);

            numcolonne = 5;
            expected = false;
            actual = Check.checkNumberColonneValide(numcolonne);
            Assert.AreEqual(expected, actual);
        }
    }
}
