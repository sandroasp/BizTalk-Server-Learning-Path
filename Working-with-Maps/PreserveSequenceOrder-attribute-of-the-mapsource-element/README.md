# BizTalk Mapper: PreserveSequenceOrder attribute of the mapsource element

# Introduction
Sequence groups in XSD schemas do not provide a looping context because they are not represented in the message instance. Without looping possibilities on the sequence group, the Mapper compiler does not generate the appropriate XSLT to maintain the segment order. As a result, relative context that is present in the input instance is lost, which makes the output instances useless for further processing that depends on the relative context.

You can use the **PreserveSequenceOrder** flag to maintain record order when mapping a repeating sequence to another repeating sequence. By default, the value of the flag is set to **No** to preserve the functionality of existing maps created in earlier BizTalk Server versions where the flag is not present. In the newly created maps, the flag will be present with its value set to **No**. To maintain segment order, you must explicitly set the value to **Yes** in the .btm file

Let’s take a look to a small example where we have an unbounded choice element where we can have Football Players or Hockey Players information and we need to translate to another this to a unique node “Player” in the destination schema.

![PreserveSequenceOrder attribute](media/BizTalk-Mapper-PreserveSequenceOrder-attribute.png)
 
# Read more about it
You can read more about this topic here: [BizTalk Mapping Patterns and Best Practices book [Free] released](https://blog.sandro-pereira.com/2014/09/28/biztalk-mapping-patterns-and-best-practices-book-free-released/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

