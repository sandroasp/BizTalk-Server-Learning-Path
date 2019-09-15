# Working with Maps

## Mapping Patterns

### Muenchian Grouping and Sorting in BizTalk Maps without losing Map functionalities
Project explaining how to use Muenchian Method to handle grouping and sorting in BizTalk Maps without losing Map functionalities. The Muenchian Method is a method developed by Steve Muench for performing grouping and sorting functionalities in a more efficient way using keys.

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

## Advance Properties

### BizTalk Mapper: Omit XML Declaration (Grid Property) explained
The official documentation states that you should use the Omit XML Declaration property to specify whether the transformation output should include an XML declaration.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: TreatElementsAsRecords attribute of the mapsource element
This is probably one of the most undocumented attributes, and the most difficult to explain and understand, present in the BizTalk Mapper. The official documentation states that when you use a Looping functoid, a Conditional functoid, or a Value Mapping functoid, an <xsl:for-each> statement is generated in the compiled map. If the child field of the destination schema has unbounded maximum occurrences, the <xsl:for-each> statement is put at the child field. If the child field does not have unbounded maximum occurrences, the <xsl:for-each> statement is put at the parent field of the child field.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: Copy Processing Instructions (PIs) (Grid Property) explained
The official documentation states that you should use the Copy Processing Instructions (PIs) property to specify whether any processing instructions found in the input instance message should be copied to the output instance message during transformation.

In this sample we will address and explain this property and when you should use it.

### BizTalk Mapper: Method (Grid Property) explained
The official documentation states that you should use the Method property to specify the overall method for producing the output of the transformation.

In this sample we will address and explain this property and when you should use it.

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

