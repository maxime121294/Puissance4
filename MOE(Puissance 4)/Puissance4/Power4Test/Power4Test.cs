using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///This is a test class for Power4Test and is intended
    ///to contain all Power4Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Power4Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Power4 Constructor
        ///</summary>
        [TestMethod()]
        public void Power4ConstructorTest()
        {
            System.Collections.Generic.List<IToken> table = new System.Collections.Generic.List<IToken>();
            IToken empty = new Token();
            IPlayer[] p = new IPlayer[2]; 

            IArrayFormatter format = new ArrayFormat();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IOutput output = new ColorOutput(table); 
            IInput input = new KeyboardInput();
            Power4.Power4 target = new Power4.Power4(p, format, stock, output, input);
        }

        /// <summary>
        ///A test for endOutput
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ConsoleApplication1.exe")]
        public void endOutputTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Power4_Accessor target = new Power4_Accessor(param0); // TODO: Initialize to an appropriate value
            int currentPlayer = 0; // TODO: Initialize to an appropriate value
            string grid = string.Empty; // TODO: Initialize to an appropriate value
            string gridExpected = string.Empty; // TODO: Initialize to an appropriate value
            bool finParti = false; // TODO: Initialize to an appropriate value
            bool finPartiExpected = false; // TODO: Initialize to an appropriate value
            target.endOutput(currentPlayer, ref grid, ref finParti);
            Assert.AreEqual(gridExpected, grid);
            Assert.AreEqual(finPartiExpected, finParti);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for otherPlayer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ConsoleApplication1.exe")]
        public void otherPlayerTest()
        {
            PrivateObject param0 = null;
            Power4_Accessor target = new Power4_Accessor(param0); 
            int player = 1; 
            int expected = 1; 
            int actual;
            actual = target.otherPlayer(player);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for run
        ///</summary>
        [TestMethod()]
        public void runTest()
        {
            System.Collections.Generic.List<IToken> table = new System.Collections.Generic.List<IToken>();
            IToken empty = new Token();
            IPlayer[] p = new IPlayer[2];

            IArrayFormatter format = new ArrayFormat();
            IArrayStock stock = new ArrayStock(10, 10, empty);
            IOutput output = new ColorOutput(table);
            IInput input = new KeyboardInput();
            Power4.Power4 target = new Power4.Power4(p, format, stock, output, input);
            target.run();
        }

        /// <summary>
        ///A test for title
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ConsoleApplication1.exe")]
        public void titleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Power4_Accessor target = new Power4_Accessor(param0); // TODO: Initialize to an appropriate value
            target.title();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
