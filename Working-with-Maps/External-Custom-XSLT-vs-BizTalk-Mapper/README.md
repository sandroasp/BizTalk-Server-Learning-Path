# BizTalk Mapper: External Custom XSLT file vs BizTalk Mapper (Best Practices)

# Introduction
If you follow my blog or already saw one of my presentations in BizTalk innovation Days events about BizTalk Mapper Patterns and Best Practices, you already notice that I avoid using Custom XSLT files for solving a mapping problem.

You may argument that XSLT automatically generated code by the BizTalk mapper compiler cannot perform as well as the personal Custom-XSLT code! And yes, I agree with you… in most of the cases… but it also depends on the approach that you are implementing to solve the problem.

The real secret is to find the best of both worlds: BizTalk Mapper and custom XSLT together.

I only recommend using custom XSLT files:
* If you are dealing with huge message and High Performance is one of the primary requirements (and even then this maybe can be avoided)
* Or if you already have a custom XSLT file provided by another team, or from another system that you can re-use in your map. In this case, don’t try to reinvent the wheel!
But again, this is my personal opinion. You may argument that XSLT automatically generated code by the BizTalk mapper compiler cannot perform as well as the personal Custom-XSLT code! And yes, I agree with you… in most of the cases.

I can spend many hours discussing this topic, and this will also be addressed in my upcoming eBook in more detail, however, I let you with two statements:
* In most scenarios you wouldn’t really notice too much difference between using the BizTalk Mapper and a custom XSLT file;
* I can prove to you that BizTalk Mapper can have the same performance that a custom XSLT file! (of course, that can always be exceptions)

However, if you are using an external XSLT file at least you should follow some of this best practices:
* Add XSLT files to the solution
* Give it a proper name
* Add standard XML comments
* Rename the page grid
 
# Read more about it
You can read more about this topic here: [BizTalk Mapper: Best Practices when using Custom XSLT files](https://blog.sandro-pereira.com/2014/01/20/biztalk-mapper-best-practices-when-using-custom-xslt-files/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

