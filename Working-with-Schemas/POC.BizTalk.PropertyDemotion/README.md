# How to implement Property Demotion in BizTalk Server

# Introduction
Property Promotion is a pretty known subject for people that work in BizTalk Server. Everybody with minimum knowledge knows what property promotion is. However, Property Demotion is not that well known because it is kind of an unknown feature and is not used often. To be honest, in more than 16 years working in BizTalk Server, I never needed to use it, but not using it and not knowing that it exist is two different things, and personally, I like to know all these little features.

Recapping, Property Promotion, let's ignore for now distinguished fields, is the process of getting values from different places like runtime, adapter, or content of the messages itself and adding them to the context of the message.
 * These values are accessed through all phases of the BizTalk message processing, either in orchestrations or custom code, routing (receive and send ports), and pipelines.

Property Demotion, it is the opposite of Property Promotion. Property Demotion is the process of taking message context data and putting it into the content of the message. This is, typically done in the Send Pipeline.

This topic/sample provides step-by-step instructions for Property Demotion.

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

