using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///This is a test class for PlayerTest and is intended
    ///to contain all PlayerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlayerTest
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
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest()
        {
            IToken t = new Token('+', 'O', ConsoleColor.Yellow);
            int n = 1; 
            Player target = new Player(t, n);
        }

        /// <summary>
        ///A test for reset
        ///</summary>
        [TestMethod()]
        public void resetTest()
        {
            IToken t = new Token('+', 'O', ConsoleColor.Yellow); 
            int n = 10; 
            Player target = new Player(t, n); 
            int n1 = 9; 
            target.reset(n1);
            int actual = n1;
            int expected = target.nbToken;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for name
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
        ///A test for nbToken
        ///</summary>
        [TestMethod()]
        public void nbTokenTest()
        {
            IToken t = new Token('+', 'O', ConsoleColor.Yellow); 
            int n = 1; 
            Player target = new Player(t, n); 
            int expected = 10; 
            int actual;
            target.nbToken = expected;
            actual = target.nbToken;
            Assert.AreEqual(expected, actual);

            expected = 5;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for tokenStyle
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
