Feature: LanguageFeature
As I login my Mars-QA application
I Would like to create my profile language details
So I can Add my language created successfully.


Scenario:01 - Adding a language to User Profile 
	Given User has successfullly logged into the Mar_qa Project
	When Create a language into user profile
	Then Language have been Successfully Created



Scenario Outline:02 - Edit Existing language and level with valid details
           Given  User has successfullly logged into the Mar_qa Project
		   And     I update '<Language>'and'<Level>' an Existing language and levels record
		   Then   The record should be updated '<Language>'and '<Level>'

Examples: 
| Language | Level          |
| French   | Conversational |
| Arabic   | Basic          |
| Haa@##   | Fluent         |
| Korean   | Conversational |
| Tamil    | Fluent         |


Scenario Outline:03  - Delete an Existing language and level 
           Given  User has successfullly logged into the Mar_qa Project  
		   And    I Delete '<Language>' and '<Level>'an Existing language and levels recod
		   Then   The recors should be Deleted '<Language>' and '<Level>'


Examples: 
| Language | Level         |
|  Korean  | Conversational|





