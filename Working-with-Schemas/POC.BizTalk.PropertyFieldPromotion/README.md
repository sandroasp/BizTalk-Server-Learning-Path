# How to promoted properties from the body of the messages

# Introduction
Most BizTalk Server developers have some idea about what Property Promotion is.  In a simple way, we can say that Property Promotion is the process of taking message or system data and putting it into the message context.  The tricky part is to know when and how properties get promoted.

There are two crucial things you need to know:
 * The properties are always promoted using a property schema.
  * It can be using the out-of-the-box property schemas or custom properties schemas that we can create on your BizTalk Server Visual Studio solutions.
 * The promotions typically happen inside the pipelines. Nevertheless, they can happen in the adapter layer.  
  * If you use pass-through pipelines, your properties will not be promoted.

For the data payload, BizTalk Server provides two types of property promotions: Distinguished Fields and Property Fields. You can promote a property as a Property Field in much the same way as promoting a property as a Distinguished Field. However, in a simplified manner, distinguished fields can only be used within an orchestration, whereas Property Fields fields can be accessed through all phases of the BizTalk message processing, either in orchestrations or from custom code, routing, and pipelines. A Property Fields requires the existence of a Property Schema.

This topic/sample provides step-by-step instructions for promoting properties as Property Fields.

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

