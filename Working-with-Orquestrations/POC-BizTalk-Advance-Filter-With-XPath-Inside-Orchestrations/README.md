# POC: BizTalk - Advance Filter With XPath Inside Orchestrations

# Introduction
Often you will want to count or fielter specific nodes present on the messages to add some business logic inside your Orchestrations. Working with XPath inside Orchestrations is a powerful and straightforward feature available since BizTalk Server 2004, and it doesn’t require any additional effort like the alternative (C# Code). Xpath is also a lovely way to retrieve values from BizTalk Server messages, especially when you can not use Distinguished Fields and Property Fields, such as looping records, or don’t want to use property promotions.

This project explaining how to use XPath count() function inside Orchestrations to count number of nodes with advance filters.

# Building the Sample

**Count/Filter all nodes, base on a single filter condition: Type == 'P'.**
 
varCountSF = System.Convert.ToInt32(xpath(msgInput,"count(//*[local-name()='XMLSample']/*[local-name()='Object']/*[local-name()='Type'][text()='P'])"));

**Count/Filter all nodes, base on a single filter condition with Logical operators: Type == 'P' OR Type == 'A'.**

varCountOr = System.Convert.ToInt32(xpath(msgInput,"count(//*[local-name()='XMLSample']/*[local-name()='Object']/*[local-name()='Type'][text()='P' or text()='A'])"));

**Count/Filter all nodes, base on a multiple filter conditions: Type == 'P' and Name == 'Sandro'.**

varCountMF = System.Convert.ToInt32(xpath(msgInput,"count(//*[local-name()='XMLSample']/*[local-name()='Object'][*[local-name()='Type'][text()='P']][*[local-name()='Name'][text()='Sandro']])"));

**Count/Filter all nodes, with unique (distinct) values: Distinct Name**

varCountDistinct = System.Convert.ToInt32(xpath(msgInput,"count(//*[local-name()='XMLSample']/*[local-name()='Object'][not(*[local-name()='Name']/text()=preceding-sibling::*[local-name()='Object']/*[local-name()='Name']/text())]/*[local-name()='Name'])"));

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

