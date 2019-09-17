# BizTalk Server: Basics principles of Maps

# Introduction
This project aims to address the Basics principles of Maps.

The map editor, BizTalk Mapper Designer, enables us to perform transformations of complex messages in a visual and extremely simple way, expressed in graphics associations of links that define the relationships between the various elements of messages.

When we perform a transformation in the message there are 5 basic functionalities that typically arise:
* Simple mapping of a given value (direct copy)
* Concatenation of values
* Conditional selection
* Custom scripts
* Add new values (data)
* Simple mapping of a given value (direct copy)

This is the most basic operation of all, where we intend to move a value from the source to the destination schema, without perform any kind of operation on the values ​​(direct copy or simple drag-and-drop).

For this we need only to drag-and-drop the element in the source schema to the element in the destination schema. This operation is exemplified in the next image with the mapping of the element "Address"

## Concatenation of values
Concatenate two or more values from the source to a particular element in the destination schema, is another of the daily operations in mapping, for this we need to:
* Open the Toolbox window and drag the String Concatenate functoid onto the grid;
* Drag-and-drop a link of the desired elements from the source to the String Concatenate functoid, for example the elements: “FirstName” and “LastName”;
* Drag-and-drop a link from the String Concatenate functoid to the element “FullName” in the destination schema;

## Conditional selection
Often we don't want to simply move values ​​from source to destination schema and sometimes we need to generate data output according with certain conditions. We can make these conditions in many different ways using functoids or through custom scripts, here's an example: test whether the value in the source is a valid string, if so map it to the destination schema, for this we need to:
* Open the Toolbox window and drag the Logical String functoid onto the grid, this functoid validates whether the input parameter is a valid string, similar to the C# function String.IsNullOrEmpty.
  * Returns “False” if the string is empty or null;
  * Returns “True” if the value specified by the input parameter is a valid string;
* Drag-and-drop a link of the desired element from the source to the Logical String functoid, in this case the element “ZipCode”
* Drag the Value Mapping functoid from the Toolbox window onto the grid. This functoid returns the value of its second parameter if its first parameter is true, i.e., enables you, based in a Boolean value, to control whether an entire structure or another single value in an input instance message gets copied to an output instance message. The functoid receives two parameters:
  * The first will be a Boolean (True/False);
  * The second is the value to be mapped;
  * If the value of the first parameter is true, then the value of the second parameter is mapped to the destination schema; otherwise it will not be mapped.
* Drag a link from the Logical String functoid to the Value Mapping functoid;
* Drag a link from the element “ZipCode” from the source schema to the Value Mapping functoid;
* Drag a link from the Value Mapping functoid to the element “ZipCode” in the destination schema;

## Custom scripts
Custom scripts are commonly used in more complex transformations or to facilitate some mapping conditions. Basically there are two main scenarios where we can or should use this functoid:
* When none of the existing functoids allows doing what we want, the example that we will see is convert a date of birth in age.
* Or when the use of existing functoids becomes extremely complex to solve a problem of mapping.

In this example, we want to convert a date of birth in age, for this we need to:
* Open the Toolbox window and drag the Scripting functoid onto the grid,
* Drag a link from the element “DateOfBirth” from the source schema to the Scripting functoid;
* Drag a link from the Scripting functoid to the element “Age” in the destination schema;

## Add new values (data)
An example, more basic and simple, is to add a stamp date in the final message, describing the date and time it was processed. For this we need to:
* Open the Toolbox window and drag the Date and Time functoid onto the grid;
* Drag a link from the Date and Time functoid to the element “ProcessingDatetime” in the destination schema;

# Read more about it
You can read more about this topic here: [BizTalk Server: Basics principles of Maps – Introduction (Part 1)](https://blog.sandro-pereira.com/2012/03/29/biztalk-server-basics-principles-of-maps-introduction-part-1/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

