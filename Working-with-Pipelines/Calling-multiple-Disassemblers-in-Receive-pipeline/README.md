# BizTalk Server Recipe: Calling multiple Disassemblers in a Receive pipeline

## Situation
You receive a zip file, containing several files to extract. The extracted files should be disassembled too. (Possibly because they are in flat file format, or you want to call the XmlDisassembler to set the message type).

## Problem
Although the disassemble stage in the receive pipeline can contain multiple components, only the first component (matching the message) will be executed.

## Solution
Create a new disassembler component, which will handle calling the sequential disassembler components.

## Sample
This demonstration exercise in with the first stage will be is an FF dasm, followed by an Xml dasm. This sample maybe will not very useful in real case scenarios, but it shows the principle and it avoids 3rd party components.  * Credits: Peter Vervoorn from Virtual Green.

## Author Credits
[Peter Vervoorn](https://www.linkedin.com/in/petervervoorn/) from Virtual Green. Peter is a very experienced integration specialist. He has been working in ICT since 1995 and was a co-founder of Axon Olympus (now part of the Codit Group). Until his sabbatical in 2014 he headed the team of consultants at Axon Olympus as Technical Director. During his sabbatical in Thailand, he lost over 50 kilos and currently, he divides his time between Thailand and The Netherlands. He is a specialist with (Microsoft) Integration Tools and Technologies like BizTalk Server, Windows 10 IoT,  Node-RED and is also involved in developing industrial automation prototypes.

THIS SAMPLE CODE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND.

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

