# Working with Pipelines

## BizTalk Server Recipe: Calling multiple Disassemblers in a Receive pipeline
You receive a zip file, containing several files to extract. The extracted files should be disassembled too. (Possibly because they are in flat file format, or you want to call the XmlDisassembler to set the message type.)

Although the disassemble stage in the receive pipeline can contain multiple components, only the first component (matching the message) will be executed.


# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

