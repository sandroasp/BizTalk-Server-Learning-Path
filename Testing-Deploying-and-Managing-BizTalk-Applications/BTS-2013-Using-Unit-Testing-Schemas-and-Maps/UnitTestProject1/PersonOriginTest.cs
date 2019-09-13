using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingFeatureWithMaps.Schemas;

namespace UnitTestProject1
{
    /// <summary>
    ///This is a test class for PersonOriginTest and is intended
    ///to contain all PersonOriginTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonOriginTest
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
        ///A test for PersonOrigin Constructor
        ///</summary>
        [TestMethod()]
        public void PersonOriginConstructorTest()
        {
            PersonOrigin target = new PersonOrigin();

            //=== Schema input file for validation ===//
            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin.xml";

            //=== Validate the XML Input message against the schema ===//
            Assert.IsTrue(target.ValidateInstance(strSourcePO_XML, 
                Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }

        // <summary>
        ///A test for PersonOrigin Constructor
        ///</summary>
        [TestMethod()]
        public void PersonOriginWithoutPhoneCallsConstructorTest()
        {
            PersonOrigin target = new PersonOrigin();

            //=== Schema input file for validation ===//
            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin2.xml";

            //=== Validate the XML Input message against the schema ===//
            Assert.IsTrue(target.ValidateInstance(strSourcePO_XML, 
                Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }

        // <summary>
        ///A test for PersonOrigin Constructor
        ///</summary>
        [TestMethod()]
        public void PersonOriginWithoutZipConstructorTest()
        {
            PersonOrigin target = new PersonOrigin();

            //=== Schema input file for validation ===//
            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOriginWithoutZip.xml";

            //=== Validate the XML Input message against the schema ===//
            Assert.IsTrue(target.ValidateInstance(strSourcePO_XML, 
                Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }
    }
}
