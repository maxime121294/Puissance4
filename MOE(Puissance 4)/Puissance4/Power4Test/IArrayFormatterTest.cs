using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IArrayFormatterTest, destinée à contenir tous
    ///les tests unitaires IArrayFormatterTest
    ///</summary>
    [TestClass()]
    public class IArrayFormatterTest
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


        internal virtual IArrayFormatter CreateIArrayFormatter()
        {
            IArrayFormatter target = new ArrayFormat();
            return target;
        }

        /// <summary>
        ///Test pour formatAsAGrid
        ///</summary>
        [TestMethod()]
        public void formatAsAGridTest()
        {
            IArrayFormatter target = new ArrayFormat(); 
            IToken empty = new Token();
            IArrayStock tab = new ArrayStock(10,10,empty);

            string expected = "";
            string actual;
            actual = target.formatAsAGrid(tab);
            
            Assert.AreNotEqual(expected, actual);
        }
    }
}
