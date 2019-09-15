# Working with Maps

## Mapping Patterns

### BizTalk Mapper Patterns: Canonical Data Model Pattern
When several applications need to work together through Messaging and each application has its own internal data format, most of the times semantically equivalent, we sometimes want or need to minimize all these dependencies and implement an additional mechanism of indirection between the data formats for each individual application.

In an Enterprise application integration (EAI) scenario it is quite common for an enterprise to receive messages from different systems that may have the same meaning but follow different formats but were developed independently based on incompatible or different data models, yet they must share information efficiently and accurately in order to effectively support the business. Different systems can have different terms for the same concept, leading to miscommunication and errors of interpretation (i.e. a bundle product can be named also as a pack product or a compose product). Canonical Data Modeling is a technique for developing and maintaining a logical model of the data required to support the needs of the business for a subject area and it is intended to reduce costs and standardize on agreed data definitions associated with integrating business systems.

The Canonical Data Model (CMD) will ensure loose coupling between applications, and if a new application is added to the integration solution, the only transformation between the Canonical Data Model need to be created, independent of the number of applications that already participate.

### BizTalk Mapper Patterns: Looping Pattern
When exchanging messages in an Enterprise application integration (EAI) or Business-to-Business (B2B) some scenarios need to deal with more complicated types of data manipulation can only reasonably be done using recurring records or elements (type of arrays in XML documents). These two types are extremely useful when manipulating large number of data. And a combination of this of Arrays and Loop operations can save you incredible amounts of time when performing certain types of repetitive transformations.

## Working with Functoids

### BizTalk Mapper: Built-in Functoids, Scripting Functoid and Custom Functoids
One question that we always try to answer or explain is when to use the Built-in Functoids (or basic/standard Functoids), Scripting Functoids or when to developer Custom Functoids. Well there isn’t a correct answer to this question and we only can suggest some best practices for you to use.

You need to remember and learn that there’s never only a single way and there are no right or wrong way method to solve a mapping problem, we can find more effective ways (performances) than others or easiest ways to solve the problem, yet the output generated will be the same. Quite often, deciding which way is the best approach to use or have the right balance between the easier and effective way can be difficult and often the approach used depend on the expertise and personal choice of the developers or company guidelines

### How to create a Global Inline C# Function
The Scripting functoid enables you to use Inline Custom Script (C# .NET, JScript .NET, Visual Basic .NET, Extensible Stylesheet Language Transformations (XSLT) or XSLT Call Template) or call code from an external assembly at run time to perform operation otherwise not available

### How To Reuse Scripting Functoids with Inline C#
Inline scripts are convenient for custom code that you are unlikely to use elsewhere in your application or other maps. In addition to being convenient for one-time scripts, inline scripts are also useful for declaring global variables for use among a number of scripts and to use

### How to create a custom If-Then-Else Functoid
Sometimes I ask myself: Why is so hard to make a simple If-Then-Else Functoid, or even so painful to do an If-Then-Else operation, using BizTalk mapper?I don't mean to say that it is complicated, quite the opposite, is quite easy to make If…Then…Else statements using the Mapper.

### How to use Database Lookup Functoid
We can use the Database Lookup functoid to extract information from a database and store it as a Microsoft® ActiveX® Data Objects (ADO) recordset. This functoid requires four input parameters in the following order:
* Parameter 1: A value for which to search in the specified database, table, and column.
* Parameter 2: The full connection string for the database with a provider, machine name, database and authentication (an ActiveX Data Objects .NET (ADO.NET) connection string)
* Parameter 3: The name of the table in the database in which to search.
* Parameter 4: The name of the column in the table in which to search.

The functoid is actually quite simple to use, however, the main problem that developers face when they use it refers to the second parameter: the connection string.

in this sample we will address this issue and how can you handle.

## Mapping Exercices

### BizTalk Mapper: Working With Nillable Values (xsi:nil="true")
Basically, there are two properties inside the schema element decides whether an element can be absent from the document: Min Occurs and Nillable.

In this sample scenario, we will have 2 mandatory elements that can be nillable that we need to map to the destination schema. In this scenario, all the destination elements are also mandatory and we need to fill them with a valid value or specify the nillable property as true: so if the element exists we need to map the correct source value otherwise we need to set the destination element as nillable.

### Muenchian Grouping and Sorting in BizTalk Maps without losing Map functionalities
Project explaining how to use Muenchian Method to handle grouping and sorting in BizTalk Maps without losing Map functionalities. The Muenchian Method is a method developed by Steve Muench for performing grouping and sorting functionalities in a more efficient way using keys.

## Advance Properties

### BizTalk Mapper: Omit XML Declaration (Grid Property) explained
The official documentation states that you should use the Omit XML Declaration property to specify whether the transformation output should include an XML declaration.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: Copy Processing Instructions (PIs) (Grid Property) explained
The official documentation states that you should use the Copy Processing Instructions (PIs) property to specify whether any processing instructions found in the input instance message should be copied to the output instance message during transformation.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: Method (Grid Property) explained
The official documentation states that you should use the Method property to specify the overall method for producing the output of the transformation.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: When to use the Ignore Namespaces for Links property
The official documentation states that you should use the “Ignore Namespaces for Links” property to indicate whether the links stored in the map contain any references to the namespaces used in the schemas.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: TreatElementsAsRecords attribute of the mapsource element
This is probably one of the most undocumented attributes, and the most difficult to explain and understand, present in the BizTalk Mapper. The official documentation states that when you use a Looping functoid, a Conditional functoid, or a Value Mapping functoid, an <xsl:for-each> statement is generated in the compiled map. If the child field of the destination schema has unbounded maximum occurrences, the <xsl:for-each> statement is put at the child field. If the child field does not have unbounded maximum occurrences, the <xsl:for-each> statement is put at the parent field of the child field.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: PreserveSequenceOrder attribute of the mapsource element
Sequence groups in XSD schemas do not provide a looping context because they are not represented in the message instance. Without looping possibilities on the sequence group, the Mapper compiler does not generate the appropriate XSLT to maintain the segment order. As a result, relative context that is present in the input instance is lost, which makes the output instances useless for further processing that depends on the relative context.

You can use the PreserveSequenceOrder flag to maintain record order when mapping a repeating sequence to another repeating sequence. By default, the value of the flag is set to No to preserve the functionality of existing maps created in earlier BizTalk Server versions where the flag is not present. In the newly created maps, the flag will be present with its value set to No. To maintain segment order, you must explicitly set the value to Yes in the .btm file

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: GenerateDefaultFixedNodes attribute of the mapsource element
When the Mapper is using a schema that has a very large instance footprint with deep complex structures and/or recursive nodes, testing the map, validating the map, or compiling the map could take a long time or, in the worst case, result in an "out of memory" error. This could happen with small, complex schemas as well as with large schemas.

The problem with complex schemas is due to the fact that the Mapper has to recursively load the entire schema tree looking for nodes that either have links connected to them or have the Value property set on them. You can alleviate this problem by setting the GenerateDefaultFixedNodes flag of the mapsource element in the .btm files to “No”.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: OptimizeValueMapping attribute of the mapsource element
This attribute will decide whether or not the BizTalk Mapper automatically optimize the Value Mapping Functoid Code Generation.

In this sample we will address and explain this property and when you should use it.

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

