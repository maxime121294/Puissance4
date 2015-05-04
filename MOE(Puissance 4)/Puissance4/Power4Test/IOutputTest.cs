using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour IOutputTest, destinée à contenir tous
    ///les tests unitaires IOutputTest
    ///</summary>
    [TestClass()]
    public class IOutputTest
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


        internal virtual IOutput CreateIOutput()
        {
            // TODO: instanciez une classe concrète appropriée.
            IOutput target = null;
            return target;
        }

        /// <summary>
        ///Test pour Clean
        ///</summary>
        [TestMethod()]
        public void CleanTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            target.Clean();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour resetColor
        ///</summary>
        [TestMethod()]
        public void resetColorTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            target.resetColor();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour setForegroundColor
        ///</summary>
        [TestMethod()]
        public void setForegroundColorTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            ConsoleColor c = new ConsoleColor(); // TODO: initialisez à une valeur appropriée
            target.setForegroundColor(c);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour write
        ///</summary>
        [TestMethod()]
        public void writeTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            string p = string.Empty; // TODO: initialisez à une valeur appropriée
            target.write(p);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour writeGrid
        ///</summary>
        [TestMethod()]
        public void writeGridTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            string grid = string.Empty; // TODO: initialisez à une valeur appropriée
            target.writeGrid(grid);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour writeLine
        ///</summary>
        [TestMethod()]
        public void writeLineTest()
        {
            IOutput target = CreateIOutput(); // TODO: initialisez à une valeur appropriée
            string p = string.Empty; // TODO: initialisez à une valeur appropriée
            target.writeLine(p);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
