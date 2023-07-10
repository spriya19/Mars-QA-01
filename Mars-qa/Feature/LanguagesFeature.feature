Feature: LanguagesFeature
As I login my Mars-QA application
I Would like to create my profile language details
So I can Add my language created successfully.


Scenario:01 - Adding a language to User Profile 
	Given  I successfullly logged into the Mar_qa Project
	When Create a language into user profile '<Language>' and '<LanguageLevel>'
	Then The new record created '<Language>' and '<LanguageLevel>' Successfully Created

Examples:
| Language | LanguageLevel    |
| Tamil    | Native/Bilingual |
| English  | Basic            |
| 123@#$   | Basic            |
| Hindi    | Conversational   |

Scenario Outline:02 -  Edit Existing language and level with valid details
          Given   I successfullly logged into the Mar_qa Project
		  When    I update '<Language>'and'<Level>' an Existing language and levels record
		   Then   The record should be updated '<Language>'and '<Level>'

Examples: 
| Language | Level          |
| French   | Conversational |
| Arabic   | Basic          |
| Hh@#(74) | Fluent         |
| Korean   | Conversational |
| Tamil    | Fluent         |

Scenario Outline:03 - Delete an Existing language and level with valid details
Given             I successfullly logged into the Mar_qa Project 
When              I delete '<Language>' and '<Level>' an Existing language and levels Record
Then              The record should be deleted '<language>' and '<Level>'

Examples: 
| Language | Level           |
| Tamil    | Fluent          |





 