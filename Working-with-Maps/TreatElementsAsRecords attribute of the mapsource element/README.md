# BizTalk Mapper: TreatElementsAsRecords attribute of the mapsource element

# Introduction
This is probably one of the most undocumented attributes, and the most difficult to explain and understand, present in the BizTalk Mapper. The official documentation states that when you use a Looping functoid, a Conditional functoid, or a Value Mapping functoid, an <xsl:for-each> statement is generated in the compiled map. If the child field of the destination schema has unbounded maximum occurrences, the <xsl:for-each> statement is put at the child field. If the child field does not have unbounded maximum occurrences, the <xsl:for-each> statement is put at the parent field of the child field.

However, because the location of the <xsl:for-each> statement affects the map result, you may want the <xsl:for-each> statement to be put at the child field of the destination schema, regardless of whether the maximum occurrence of the child field is set to 1.

You can control the placement of the <xsl:for-each> statement by modifying the value of the TreatElementsAsRecords attribute in the map (.btm) file.

When this attribute is set to **Yes**, the <xsl:for-each> statement is put at the child field of the destination schema, regardless of whether the maximum occurrence of the child field is set to **1**.

![TreatElementsAsRecords attribute](media/BizTalk-Mapper-TreatElementsAsRecords-attribute.png)

With the TreatElementsAsRecords attribute set to **No** will generate a valid output as we can see:

    
	<Parent> 
	  <Child>RChild_1</Child> 
	</Parent> 
	<Parent> 
	  <Child>RChild_2</Child> 
	</Parent> 
	<Parent> 
	  <Child>RChild_3</Child> 
	</Parent> 
	

However if we set the TreatElementsAsRecords attribute as **Yes** it will generate multiple child elements, which will translate to an invalid message:

    
    <Parent> 
	  <Child>RChild_1</Child> 
	  <Child>RChild_2</Child> 
	  <Child>RChild_3</Child> 
	</Parent>  
    
 
# Read more about it
You can read more about this topic here: [BizTalk Mapping Patterns and Best Practices book [Free] released](https://blog.sandro-pereira.com/2014/09/28/biztalk-mapping-patterns-and-best-practices-book-free-released/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

