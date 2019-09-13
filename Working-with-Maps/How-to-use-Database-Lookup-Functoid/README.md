# Muenchian Grouping and Sorting in BizTalk Maps without losing Map functionalities

# Introduction
We can use the Database Lookup functoid to extract information from a database and store it as a Microsoft® ActiveX® Data Objects (ADO) recordset. This functoid requires four input parameters in the following order:
* Parameter 1: A value for which to search in the specified database, table, and column.
* Parameter 2: The full connection string for the database with a provider, machine name, database and authentication (an ActiveX Data Objects .NET (ADO.NET) connection string)
* Parameter 3: The name of the table in the database in which to search.
* Parameter 4: The name of the column in the table in which to search.

The functoid is actually quite simple to use, however, the main problem that developers face when they use it refers to the second parameter: the connection string. And why?

# What is the correct value for the connection string?
I always find hard to remember the correct value for the connection string to be used inside this functoid.

The Easiest way to make sure we are using the correct connection string value and for not having to remember this by head is to create a simple Universal Data Link (.udl) File… set OLE DB provider connection parameters and test the connection to check if everything is correct.

See Resources folder inside the zip file.

## using the connection string statically inside the Database Lookup Functoid will lead you to problems

Hard-coding the SQL connection strings might lead to maintenance overhead and serviceability issues.

**Important** considerations:
* You shouldn’t Hard-coding this value directly in the functoid otherwise it will be a nightmare when you deploy this to a different environment.
* You can and you should store this parameter in a different storage location (SSO, Registry or others) and get this value using a scripting Functoid or custom functoid which can then be linked to the Database Lookup Functoid, like the:
  * **BTSNTSvc Config Get Functoid**: This functoid allows you to get configuration parameters from BTSNTsvc.exe.config. If there is no section specified, the functoid reads from the AppSettings.
  * **Windows Registry Config Get Functoid**: This functoid allows you to get configuration parameters from Windows Registry.
  * **SSO Config Get Functoid**: This functoid allows you to get configuration parameters from SSO Database.
  * **Rule Engine Config Get Functoid**: This functoid allows you to obtain a definition value from a Vocabulary in the Business Rules Engine.

All of these custom functoids are available in the BizTalk Mapper Extensions UtilityPack

# Read more about it
You can read more about this topic here: [BizTalk Server tips and tricks for developers: How to easily set the connection string in the database lookup functoid](https://blog.sandro-pereira.com/2015/05/06/biztalk-server-tips-and-tricks-for-developers-how-to-easily-set-the-connection-string-in-the-database-lookup-functoid/)

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)

