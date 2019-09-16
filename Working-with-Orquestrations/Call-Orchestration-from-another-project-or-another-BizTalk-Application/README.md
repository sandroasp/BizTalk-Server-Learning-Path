# BizTalk Server: How to call Orchestration from another project or from another BizTalk Application

# Introduction
Project explaining how to call Orchestration from another project or from another BizTalk Application.

Imagine that we have 2 distinct  Visual Studio BizTalk Project:
* Project1 with the following resources
  * Orch1
  * Schema1
* And Project2 with the following resources
  * Orch2

Both projects can be deployed to the same BizTalk Application or they can be deployed to different BizTalk Applications (the two situations can be applied), and Orch1 from the Project1 want to call a common orchestration that exists in Project2: Orch.

# Building the Sample
As mentioned above, the aim is to be able to create a "common" orchestration that we can invoke, from different projects, using the call or start orchestration shapes.

So how can I accomplish this?

To accomplish this goal, we need to do:
* In Project2, go to the properties of Orch2, and then you need to define the Orchestration property **Type Modifier** to **Public**;
* In Project1, you have to Add the reference of Project2
* In Project1, add call Orchestration shape, in property **Called Orchestration**, choose **Select from referenced assembly**,
  * Choose Project1 reference and Orch2

The key is, in the Orchestration that you want to call from another’s Orchestrations, defined the property **Type Modifier** to **Public**

# Read more about it
You can read more about this topic here: [BizTalk Orchestration – Call Orchestration from another project or from another BizTalk Application](https://blog.sandro-pereira.com/2009/07/24/biztalk-orchestration-call-orchestration-from-another-project-or-from-another-biztalk-application/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

