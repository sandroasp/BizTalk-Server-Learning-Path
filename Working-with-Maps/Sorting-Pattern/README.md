# BizTalk Mapper Patterns: Sorting Pattern

# Introduction
The Sorting Pattern is used to sort the contents of a message body to get them into a certain order, assuming that the message body contains a list of items that can be sorted. Most of the times are bounded with the Grouping Pattern.

XSLT 1.0 lets you sort elements, however, it will force you to jump through several hoops to do anything extra with the groups that result from the sort and for accomplish this we need to use custom XSLT inside the BizTalk Mapper.

Sorting is a way of manage the randomly data in sequence and basically we can have two types of sorting:
* **Ascending Sort**:  is find the smallest number or first letter of the dictionary in the array and placed on first position and the highest number or last letter of the dictionary and placed on the last position;
* And **Descending Sort**: it’s the opposite, it will find the highest number or last letter of the dictionary in the array and placed on first position and smallest number or first letter of the dictionary placed on the last position

# Building the Sample

## SortElementsDemo
In this simple sample scenario we will have a message that can contain several persons and some of there personal information and for each one, a list of countries that we already visited.

    
    <ns0:Persons xmlns:ns0="http://BizTalkMapperSortingPattern.Persons"> 
	  <Person> 
		<Name>Sandro Pereira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>Italy</Country> 
		  <Country>Spain</Country> 
		  <Country>France</Country> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Norway</Country> 
		  <Country>Jamaica</Country> 
		  <Country>Mexico</Country> 
		  <Country>Cuba</Country> 
		  <Country>Switzerland</Country> 
		  <Country>Irland</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person> 
		<Name>Márcia Teixeira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>Spain</Country> 
		  <Country>USA</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person> 
		<Name>José António Silva</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>Irland</Country> 
		  <Country>Spain</Country> 
		  <Country>France</Country> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Italy</Country> 
		  <Country>Cabo Verde</Country> 
		</ListCountriesVisited> 
	  </Person> 
	</ns0:Persons>
    
And we want to order all the people in an ascending way (A...Z) but the list of the countries for each person should be order in a descending way (Z...A).
    
	<ns0:Persons xmlns:ns0="http://BizTalkMapperSortingPattern.Persons"> 
	  <Person> 
		<Name>José António Silva</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Spain</Country> 
		  <Country>Italy</Country> 
		  <Country>Irland</Country> 
		  <Country>France</Country> 
		  <Country>Cabo Verde</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person> 
		<Name>Márcia Teixeira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>Spain</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person> 
		<Name>Sandro Pereira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Switzerland</Country> 
		  <Country>Spain</Country> 
		  <Country>Norway</Country> 
		  <Country>Mexico</Country> 
		  <Country>Jamaica</Country> 
		  <Country>Italy</Country> 
		  <Country>Irland</Country> 
		  <Country>France</Country> 
		  <Country>Cuba</Country> 
		</ListCountriesVisited> 
	  </Person> 
	</ns0:Persons>
    
## SortElementsDemoByNumber
This sample is the same of the above with a small change, each Person has an "Id" and we want to order all the people in an ascending way by this "Id"

    
	<ns0:Persons xmlns:ns0="http://BizTalkMapperSortingPattern.PersonsWithId"> 
	  <Person Id="8"> 
		<Name>Márcia Teixeira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>Spain</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person Id="10"> 
		<Name>Sandro Pereira</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Switzerland</Country> 
		  <Country>Spain</Country> 
		  <Country>Norway</Country> 
		  <Country>Mexico</Country> 
		  <Country>Jamaica</Country> 
		  <Country>Italy</Country> 
		  <Country>Irland</Country> 
		  <Country>France</Country> 
		  <Country>Cuba</Country> 
		</ListCountriesVisited> 
	  </Person> 
	  <Person Id="12"> 
		<Name>José António Silva</Name> 
		<Nacionality>Portuguese</Nacionality> 
		<ListCountriesVisited> 
		  <Country>USA</Country> 
		  <Country>UK</Country> 
		  <Country>Spain</Country> 
		  <Country>Italy</Country> 
		  <Country>Irland</Country> 
		  <Country>France</Country> 
		  <Country>Cabo Verde</Country> 
		</ListCountriesVisited> 
	  </Person> 
	</ns0:Persons>
    
## DistinctListSample
In this simple sample scenario we will have a message with a list of extenal employees and we want to get a list of all distinct companies and order them.

We will also learn how to implement Sort operation with grouping operations in this case using the preceding-sibling axis.

## SortUsingMuenchianMethod
This sample is explain here: Muenchian Grouping and Sorting in BizTalk Maps without losing Map functionalities.

We will also learn how to implement Sort operation with grouping operations in this case using the Muenchian Method.

## SortByMultipleFields
In this simple sample we will learn how to implement sort operations using multiple fields.
 
# Read more about it
You can read more about this topic here: [BizTalk Mapping Patterns and Best Practices book [Free] released](https://blog.sandro-pereira.com/2014/09/28/biztalk-mapping-patterns-and-best-practices-book-free-released/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

