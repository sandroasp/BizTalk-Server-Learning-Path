# Flat Files Schemas: Dealing with Files Delimited by Symbols

# Introduction
Syntax Transformations occurs in the receive or send pipelines and aim to transform a document into another representation, e.g. CSV to XML. Here the document maintains the same data (semantics) but changes the syntax that is represented. I.e. we translate the document, but typically we don't modify the structure. Normally, this type of transformation is bidirectional, since we still have the same semantic content, we can apply the same transformation logic and obtain the document in its original format. Common examples of these transformations are also conversions between HL7 and XML, or EDI and XML.

In this sample I will walk you through the required steps at design time:
* using the Flat File Schema Wizard to generate the Flat File Schema;
* and the pipeline editor to create a custom pipeline;

To enable the runtime to support the processing of the Flat File delimited by symbols.

# Building the Sample
This are simple walkthroughs explaining the basic principles to create a flat file schema from a file delimited by symbols. 

## Sample 1

    
	Sandro;Pereira;1978;Crestuma;4415 
	Vânia;Braziela;1981;Vila Nova de Gaia;4400 
	José;Silva;1972;Crestuma;4415 
	Rui;Barbosa;1975;Lever;4415
    

## Sample 2

    
	Praceta do Marão;Crestuma;4415 Crestuma;Portugal 
	Rua Passos Manuel, 223 - 4º Andar;Porto;4000-385 Porto;Portugal
    

# How did I solve (or I overcame) this challenger? Read more about it
You can read more about this topic here: [BizTalk Server: Teach me something new about Flat Files (or not) – Files Delimited by Symbols](https://blog.sandro-pereira.com/2015/10/14/biztalk-server-teach-me-something-new-about-flat-files-or-not-files-delimited-by-symbols/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

