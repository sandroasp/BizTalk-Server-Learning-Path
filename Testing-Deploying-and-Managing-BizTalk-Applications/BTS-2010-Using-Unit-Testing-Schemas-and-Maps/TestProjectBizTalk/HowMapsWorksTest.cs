using UnitTestingFeatureWithMaps.Maps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace TestProjectBizTalk
{
    /// <summary>
    ///This is a test class for HowMapsWorksTest and is intended
    ///to contain all HowMapsWorksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HowMapsWorksTest
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


        [TestMethod()]
        public void HowMapsWorksMapTest()
        {
            HowMapsWorks map = new HowMapsWorks();

            //=== Use the HelloWorld sample directory path for the message files ===//

            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin.xml";
            string strDestInvoice_XML = testContextInstance.TestDir + "\\OUT\\PersonTarget2.xml";


            //=== Test the map by using the TestMap method of the TestableMapBase class ===//

            map.ValidateOutput = true;
            map.TestMap(strSourcePO_XML,
                           Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                           strDestInvoice_XML,
                           Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);


            //=== Output file should be created as a result of testing the map ===//

            Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }

        [TestMethod()]
        public void HowMapsWorksWithoutPhoneCallsMapTest()
        {
            HowMapsWorks map = new HowMapsWorks();

            //=== Use the HelloWorld sample directory path for the message files ===//

            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin2.xml";
            string strDestInvoice_XML = testContextInstance.TestDir + "\\OUT\\PersonTargetWithoutTotals.xml";


            //=== Test the map by using the TestMap method of the TestableMapBase class ===//

            map.ValidateOutput = true;
            map.TestMap(strSourcePO_XML,
                           Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                           strDestInvoice_XML,
                           Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);


            //=== Output file should be created as a result of testing the map ===//

            Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }

        [TestMethod()]
        public void HowMapsWorksWithoutZipMapTest()
        {
            HowMapsWorks map = new HowMapsWorks();

            //=== Use the HelloWorld sample directory path for the message files ===//

            string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin.xml";
            string strDestInvoice_XML = testContextInstance.TestDir + "\\OUT\\PersonTargetWithoutZip.xml";


            //=== Test the map by using the TestMap method of the TestableMapBase class ===//

            map.ValidateOutput = true;
            map.TestMap(strSourcePO_XML,
                           Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                           strDestInvoice_XML,
                           Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);


            //=== Output file should be created as a result of testing the map ===//

            Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }
    }
}
