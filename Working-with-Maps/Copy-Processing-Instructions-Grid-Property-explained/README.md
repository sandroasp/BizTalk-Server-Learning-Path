# BizTalk Mapper: TreatElementsAsRecords attribute of the mapsource element

# Introduction
The official documentation states that you should use the Copy Processing Instructions (PIs) property to specify whether any processing instructions found in the input instance message should be copied to the output instance message during transformation. This property allows two values:
* False: Specifies that processing instructions should not be copied from the input instance message to the output instance message. (Default Value)
* True: Specifies that processing instructions should be copied from the input instance message to the output instance message.

A processing instruction is an item in an XML file that is used to provide instructions to an application that processes the XML file. Within an XML file, processing instructions are delimited by "<?" and "?>".

> **Note**: The Copy Processing Instructions property copies instructions only from one message to another, single message. Processing instructions cannot be copied from or to all of the parts in multi-part mappings (one-to-many or many-to-one).

This property is extremely useful when we are dealing with InfoPath or similar technologies with BizTalk, This type of messages have always a XML processing header and BizTalk Mapper will not copy them to the output messages by default, so we have to set this property manually to accomplish that.
 
# Read more about it
You can read more about this topic here: [BizTalk Mapping Patterns and Best Practices book [Free] released](https://blog.sandro-pereira.com/2014/09/28/biztalk-mapping-patterns-and-best-practices-book-free-released/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

