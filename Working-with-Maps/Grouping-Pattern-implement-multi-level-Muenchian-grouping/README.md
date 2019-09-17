# BizTalk Mapper Patterns: Grouping Pattern 

# How to implement multi-level Muenchian grouping in BizTalk Maps
The Muenchian Method is a method developed by Steve Muench for performing grouping and sorting functionalities in a more efficient way using keys.  Keys work by assigning a key value to a node and giving you easy access to that node through the key value.  If there are lots of nodes that have the same key value, then all those nodes are retrieved when you use that key value.  Effectively this means that if you want to group a set of nodes according to a particular property of the node, then you can use keys to group them together.

There is an astonishing post by Chris Romp about [Muenchian Grouping and Sorting in BizTalk Maps](https://blogs.msdn.microsoft.com/chrisromp/2008/07/31/muenchian-grouping-and-sorting-in-biztalk-maps/), but it has one limitation, by creating and configures Custom XSL Path we lose all mapping features.

And I already explained how can we use Muenchian Grouping without losing Map features [here](https://github.com/sandroasp/BizTalk-Server-Learning-Path/tree/master/Working-with-Maps/Muenchian-Grouping-and-Sorting-without-losing-Map-functionalities).

![Grouping Pattern](media/screenshot.png)

# Building the Sample
Inspired by a question in BizTalk Server Forums: [XSLT Mapping Question (Summing Values)](https://social.msdn.microsoft.com/Forums/en-US/9a78f5a4-c90d-4abe-a54b-e1dfdcb8f2ed/xslt-mapping-question-summing-values?forum=biztalkgeneral)

How can we can we performe multi-level Muenchian grouping in BizTalk Maps and perform mathematical operations on this group?

I decided to solved this problem and publish this sample to help the user.

Description

Problem: sum all records and create a unique record for records having same account type and city! 

Source: 

    
    <InputRecord> 
	 <Record> 
	  <AccountType>TypeA</AccountType> 
	  <City>Dallas</City> 
	  <Sign>+</Sign> 
	  <Price>100</Price> 
	 </Record> 
	 <Record> 
	  <AccountType>TypeA</AccountType> 
	  <City>Dallas</City> 
	  <Sign>-</Sign> 
	  <Price>200</Price> 
	 </Record> 
	 <Record> 
	  <AccountType>TypeB</AccountType> 
	  <City>Chicago</City> 
	  <Sign>+</Sign> 
	  <Price>600</Price> 
	 </Record> 
	 <Record> 
	  <AccountType>TypeB</AccountType> 
	  <City>Chicago</City> 
	  <Sign>-</Sign> 
	  <Price>500</Price> 
	 </Record> 
	 <Record> 
	  <AccountType>TypeC</AccountType> 
	  <City>Chicago</City> 
	  <Sign>-</Sign> 
	  <Price>500</Price> 
	 </Record> 
	</InputRecord>
    

Expected Result: 

    
    <OutputNode> 
	  <Record> 
	  <AccountType>TypeA</AccountType>  
	  <City>Dallas</City>  
	  <Sign>-</Sign>  
	  <Price>100</Price>  
	  </Record> 
	  <Record> 
	  <AccountType>TypeB</AccountType>  
	  <City>Chicago</City>  
	  <Sign>+</Sign>  
	  <Price>100</Price>  
	  </Record> 
	  <Record> 
	  <AccountType>TypeC</AccountType>  
	  <City>Chicago</City>  
	  <Sign>-</Sign>  
	  <Price>500</Price>  
	  </Record> 
	</OutputNode>
    

# Read more about it
You can read more about this topic here: [BizTalk Training – Mapping – How to implement multi-level Muenchian grouping in BizTalk Maps](https://blog.sandro-pereira.com/2012/05/15/biztalk-training-mapping-how-to-implement-multi-level-muenchian-grouping-in-biztalk-maps/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

