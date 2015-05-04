using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour Power4Test, destinée à contenir tous
    ///les tests unitaires Power4Test
    ///</summary>
    [TestClass()]
    public class Power4Test
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
        ///Test pour Constructeur Power4
        ///</summary>
        [TestMethod()]
        public void Power4ConstructorTest()
        {
            IPlayer[] p = null; // TODO: initialisez à une valeur appropriée
            IArrayFormatter format = null; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            IOutput output = null; // TODO: initialisez à une valeur appropriée
            IInput input = null; // TODO: initialisez à une valeur appropriée
            Power4 target = new Power4(p, format, stock, output, input);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour otherPlayer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ConsoleApplication1.exe")]
        public void otherPlayerTest()
        {
            PrivateObject param0 = null; // TODO: initialisez à une valeur appropriée
            Power4_Accessor target = new Power4_Accessor(param0); // TODO: initialisez à une valeur appropriée
            int player = 0; // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.otherPlayer(player);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour run
        ///</summary>
        [TestMethod()]
        public void runTest()
        {
            IPlayer[] p = null; // TODO: initialisez à une valeur appropriée
            IArrayFormatter format = null; // TODO: initialisez à une valeur appropriée
            IArrayStock stock = null; // TODO: initialisez à une valeur appropriée
            IOutput output = null; // TODO: initialisez à une valeur appropriée
            IInput input = null; // TODO: initialisez à une valeur appropriée
            Power4 target = new Power4(p, format, stock, output, input); // TODO: initialisez à une valeur appropriée
            target.run();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour title
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ConsoleApplication1.exe")]
        public void titleTest()
        {
            PrivateObject param0 = null; // TODO: initialisez à une valeur appropriée
            Power4_Accessor target = new Power4_Accessor(param0); // TODO: initialisez à une valeur appropriée
            target.title();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
