using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Power4Test
{
    
    
    /// <summary>
    ///Classe de test pour ColorOutputTest, destinée à contenir tous
    ///les tests unitaires ColorOutputTest
    ///</summary>
    [TestClass()]
    public class ColorOutputTest
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
        ///Test pour Constructeur ColorOutput
        ///</summary>
        [TestMethod()]
        public void ColorOutputConstructorTest()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Clean
        ///</summary>
        [TestMethod()]
        public void CleanTest()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
            target.Clean();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour resetColor
        ///</summary>
        [TestMethod()]
        public void resetColorTest()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
            target.resetColor();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour setForegroundColor
        ///</summary>
        [TestMethod()]
        public void setForegroundColorTest()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
            ConsoleColor color = new ConsoleColor(); // TODO: initialisez à une valeur appropriée
            target.setForegroundColor(color);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour write
        ///</summary>
        [TestMethod()]
        public void writeTest()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
            char p = '\0'; // TODO: initialisez à une valeur appropriée
            target.write(p);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour write
        ///</summary>
        [TestMethod()]
        public void writeTest1()
        {
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
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
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
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
            List<IToken> list = null; // TODO: initialisez à une valeur appropriée
            ColorOutput target = new ColorOutput(list); // TODO: initialisez à une valeur appropriée
            string p = string.Empty; // TODO: initialisez à une valeur appropriée
            target.writeLine(p);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
