# BizTalk Server 2010: Using the Unit Testing Feature with Schemas and Maps

# Introduction
esting is an important aspect of (BizTalk) application life cycle. Before a developer deploys his solution he needs to be confident that it will perform, and do the task(s) it is intended to do. It is a developer responsibility that he creates a robust application. Therefore he needs to unit test his BizTalk application artifacts before he deploys them for further testing.

A BizTalk developer has a couple of options when it comes to unit testing BizTalk artifacts. Testing of each can be done using a framework like BizUnit, or some of the other available tools offered through CodePlex, or Visual Studio. With BizTalk Server 2009 the unit test feature was introduced, which offered built-in developer support for testing schemas, maps and pipelines in Visual Studio. The test capabilities offered by Visual Studio in for BizTalk artifacts are the following:
* Validating an XML document instance.
* Testing a map.
* Unit test a schema, map and/or a pipeline.

This sample is a sample BizTalk solution to explain how we can use these unit test feature within Visual Studio to test Schemas and Maps.

# Testing Schemas Sample
To unit test a schema you can leverage the unit test framework in Visual Studio you need to use the following sample code:

    
    /// <summary> 
	///A test for PersonOrigin Constructor 
	///</summary> 
	[TestMethod()] 
	public void PersonOriginConstructorTest() 
	{ 
		PersonOrigin target = new PersonOrigin(); 


		//=== The SamplePOInput.xml file from <Samples Path>\Orchestrations\HelloWorld ===// 
		string strSourcePO_XML = "C:\\Development\\UnitTestingFeatureWithMaps\\Files\\PersonOrigin.xml"; 
		 
		//=== Validate the SamplePOInput message against the schema ===// 
		Assert.IsTrue(target.ValidateInstance(strSourcePO_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML)); 
	}
    

# Testing Maps Sample
To unit test a map you can leverage the unit test framework in Visual Studio you need to use the following sample code:

    
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
    

# Read more about it
You can read more about this topic here: [Why is so hard to make a simple If-Then-Else Functoid? … well, not anymore!
](https://blog.sandro-pereira.com/2016/02/10/why-is-so-hard-to-make-a-simple-if-then-else-functoid-well-not-anymore/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

