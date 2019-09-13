# Flat Files Schemas: Dealing with Positional Flat Files

# Introduction
Syntax Transformations occurs in the receive or send pipelines and aim to transform a document into another representation, e.g. CSV to XML. Here the document maintains the same data (semantics), but changes the syntax that is represented. I.e. we translate the document, but typically we don't modify the structure. Normally, this type of transformation is bidirectional, since we still have the same semantic content, we can apply the same transformation logic and obtain the document in its original format. Common examples of these transformations are also conversions between HL7 and XML, or EDI and XML.

In this sample I will walk you through the required steps at design time:
* using the Flat File Schema Wizard to generate the Flat File Schema;
* and the pipeline editor to create a custom pipeline;

To enable the runtime to support the processing Positional Flat Files.

# Building the Sample
This are simple walkthroughs explaining the basic principles to create a flat file schema from a file delimited by positions. 

## Sample 1

    
	0120200300 01 PT        Sandro      Pereira         Rua Central, 133      Crestuma    Vila Nova de Gaia  4415 Crestuma
	0120200300 01 PT        José        Silva           Crestuna              Crestuma    Vila Nova de Gaia  4415 Crestuma
	0120200300 01 PT        Rui         Barbosa         Porto                 Porto       Porto              4400 Crestuma
	0120200300 01 PT        Miguel      Silva                                 Porto       Porto              4415 Crestuma
    
Explanation:
    
    0120|20|03|0|0 |01 |PT        |Sandro      |Pereira         |Rua Central, 133      |Crestuma    |Vila Nova de Gaia  |4415 Crestuma
    

Basically is devide as:
GroupId|PrimaryKey|SecondaryKey|ControlFlag|PartyNo|Remark|Country|Name|Surname|Street|City|District|ZipCode

| Field Description | Length |
| GroupId | 4 |
| PrimaryKey | 2 |
| SecondaryKey | 2 |
| ControlFlag | 1 |
| PartyNo | 1 |
| Remark | 3 |
| Country | 10 |
| Name | 12 |
| Surname | 16 |
| Street | 22 |
| City | 12 |
| District | 19 |
| ZipCode | … |


# How did I solve (or I overcame) this challenger? Read more about it
You can read more about this topic here: [BizTalk Server: Teach me something new about Flat Files (or not) – Positional Files](https://blog.sandro-pereira.com/2015/11/03/biztalk-server-teach-me-something-new-about-flat-files-or-not-positional-files/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

