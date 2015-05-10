using Power4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power4Test
{
    
    
    /// <summary>
    ///This is a test class for KeyboardInputTest and is intended
    ///to contain all KeyboardInputTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KeyboardInputTest
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
        ///A test for KeyboardInput Constructor
        ///</summary>
        [TestMethod()]
        public void KeyboardInputConstructorTest()
        {
            KeyboardInput target = new KeyboardInput();
        }

        /// <summary>
        ///A test for read
        ///</summary>
        [TestMethod()]
        public void readTest()
        {
            KeyboardInput target = new KeyboardInput();
            char expected = '\0';
            char actual;
            actual = target.read();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for readLine
        ///</summary>
        [TestMethod()]
        public void readLineTest()
        {
            IInput target = new KeyboardInput();
            string expected = "";
            string actual;
            actual = target.readLine();
            Assert.AreNotEqual(expected, actual);
        }
    }
}
