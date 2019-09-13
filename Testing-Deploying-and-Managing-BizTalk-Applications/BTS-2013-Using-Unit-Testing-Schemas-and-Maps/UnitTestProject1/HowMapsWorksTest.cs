using UnitTestingFeatureWithMaps.Maps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject1
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
            #region Expected Way
            /*********************************************************************************
             * There is a bug with Map Unit Test inside Microsoft.BizTalk.TestTools.dll 
             * Microsoft had missed on to upgrade TestableMapBase class. They still using the 
             * BTSXslTransform instead of using XslCompiledTransform witch will cause the 
             * TestMap() function to failed.
             * 
             * The following code was the expected code for BizTalk Map unit testing 
             *********************************************************************************/

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
            #endregion

            //HowMapsWorks map = new HowMapsWorks();

            ////=== Map input file instance to be mapped  ===//
            //string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin.xml";
            ////=== Path for the Map output file instance with the result of the transformation  ===//
            //string strDestInvoice_XML = testContextInstance.TestDir + "\\Out\\PersonTarget2.xml";

            ////WORKAROUND SOLUTION to test maps
            //SandroPereira.BizTalk.MapTestTools.TestableMapBase mapper = new SandroPereira.BizTalk.MapTestTools.TestableMapBase();

            //mapper.Mapper = map;
            //mapper.Mapper.ValidateOutput = true;

            ////=== Test the map by using the TestMap method of a custom TestableMapBase class ===//
            ////=== that uses the XslCompiledTransform. This class is basically an improved    ===//
            ////=== clone of the class present in the Microsoft.BizTalk.TestTools DLL          ===//
            //mapper.TestMap(strSourcePO_XML,
            //    Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
            //    strDestInvoice_XML,
            //    Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            ////=== Output file should be created as a result of testing the map ===//
            //Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }

        [TestMethod()]
        public void HowMapsWorksWithoutPhoneCallsMapTest()
        {
            #region Expected Way
            /*********************************************************************************
             * There is a bug with Map Unit Test inside Microsoft.BizTalk.TestTools.dll 
             * Microsoft had missed on to upgrade TestableMapBase class. They still using the 
             * BTSXslTransform instead of using XslCompiledTransform witch will cause the 
             * TestMap() function to failed.
             * 
             * The following code was the expected code for BizTalk Map unit testing 
             *********************************************************************************/

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
            #endregion

            //HowMapsWorks map = new HowMapsWorks();

            ////=== Map input file instance to be mapped  ===//
            //string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOrigin2.xml";
            ////=== Path for the Map output file instance with the result of the transformation  ===//
            //string strDestInvoice_XML = testContextInstance.TestDir + "\\Out\\PersonTarget2.xml";

            ////WORKAROUND SOLUTION to test maps
            //SandroPereira.BizTalk.MapTestTools.TestableMapBase mapper = new SandroPereira.BizTalk.MapTestTools.TestableMapBase();

            //mapper.Mapper = map;
            //mapper.Mapper.ValidateOutput = true;

            ////=== Test the map by using the TestMap method of a custom TestableMapBase class ===//
            ////=== that uses the XslCompiledTransform. This class is basically an improved    ===//
            ////=== clone of the class present in the Microsoft.BizTalk.TestTools DLL          ===//
            //mapper.TestMap(strSourcePO_XML,
            //    Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
            //    strDestInvoice_XML,
            //    Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            ////=== Output file should be created as a result of testing the map ===//
            //Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }

        [TestMethod()]
        public void HowMapsWorksWithoutZipMapTest()
        {
            #region Expected Way
            /*********************************************************************************
             * There is a bug with Map Unit Test inside Microsoft.BizTalk.TestTools.dll 
             * Microsoft had missed on to upgrade TestableMapBase class. They still using the 
             * BTSXslTransform instead of using XslCompiledTransform witch will cause the 
             * TestMap() function to failed.
             * 
             * The following code was the expected code for BizTalk Map unit testing 
             *********************************************************************************/

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
            #endregion

            //HowMapsWorks map = new HowMapsWorks();

            ////=== Map input file instance to be mapped  ===//
            //string strSourcePO_XML = testContextInstance.TestDir + "..\\..\\..\\Files\\PersonOriginWithoutZip.xml";
            ////=== Path for the Map output file instance with the result of the transformation  ===//
            //string strDestInvoice_XML = testContextInstance.TestDir + "\\Out\\PersonTargetWithoutZip.xml";

            ////WORKAROUND SOLUTION to test maps
            //SandroPereira.BizTalk.MapTestTools.TestableMapBase mapper = new SandroPereira.BizTalk.MapTestTools.TestableMapBase();

            //mapper.Mapper = map;
            //mapper.Mapper.ValidateOutput = true;

            ////=== Test the map by using the TestMap method of a custom TestableMapBase class ===//
            ////=== that uses the XslCompiledTransform. This class is basically an improved    ===//
            ////=== clone of the class present in the Microsoft.BizTalk.TestTools DLL          ===//
            //mapper.TestMap(strSourcePO_XML,
            //    Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
            //    strDestInvoice_XML,
            //    Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            ////=== Output file should be created as a result of testing the map ===//
            //Assert.IsTrue(File.Exists(strDestInvoice_XML));
        }
    }
}