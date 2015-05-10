using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///This is a test class for TokenTest and is intended
    ///to contain all TokenTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TokenTest
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
        ///A test for Token Constructor
        ///</summary>
        [TestMethod()]
        public void TokenConstructorTest()
        {
            char valeur = '+'; 
            char icone = 'O'; 
            ConsoleColor couleur = ConsoleColor.Black;
            Token target = new Token(valeur, icone, couleur);
        }

        /// <summary>
        ///A test for Token Constructor
        ///</summary>
        [TestMethod()]
        public void TokenConstructorTest1()
        {
            Token target = new Token();
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black);
            IToken t = new Token();
            bool expected = false;
            bool actual;
            actual = target.Equals(t);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for color
        ///</summary>
        [TestMethod()]
        public void colorTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black);
            
            ConsoleColor expected = ConsoleColor.Black;
            ConsoleColor actual;
            actual = target.color;
            Assert.AreEqual(expected, actual);

            expected = ConsoleColor.Blue;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for icon
        ///</summary>
        [TestMethod()]
        public void iconTest()
        {
            IToken target = new Token('+', 'O', ConsoleColor.Black);
            char expected = 'O';
            char actual;
            target.icon = expected;
            actual = target.icon;
            Assert.AreEqual(expected, actual);

            expected = '0';
            target.icon = expected;
            actual = target.icon;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for value
        ///</summary>
        [TestMethod()]
        public void valueTest()
        {
            Token target = new Token('+', 'O', ConsoleColor.Black);
            
            char expected = '+';
            char actual;
            target.value = expected;
            actual = target.value;
            Assert.AreEqual(expected, actual);
        }
    }
}
