Feature: Negative

As I login my Mars-QA application
I Would like to create my profile language details
So I can Add my skills created successfully.



Scenario:01 - Adding a language to User Profile 
	Given   successfullly logged into the Mar_qa Project
	When  Create new  language into user profile '<Language>' and '<LanguageLevel>'
	Then  The record created '<Language>' and '<LanguageLevel>' Successfully Created

Examples:
| Language | LanguageLevel |
| English  |               |
|          |               |

Scenario Outline:02 -  Edit Existing language and level with invalid details
          Given   successfullly logged into the Mar_qa Project
		  When     updated '<Language>'and'<Level>' an Existing language and levels record
		   Then   The Existing record should be updated '<Language>'and '<Level>'

Examples: 
| Language | Level       |
|          | Converstion |
| Tamil    | Basic       |
|          |             |


Scenario:03 - Adding a skill to User Profile 
	Given    successfullly logged into the Mar_qa Project
	When     Create a Invalid Skills into user profile '<skill>' and '<skilllLevel>'
	Then     The Invalid skill created '<skill>' and '<skilllLevel>' Successfully Created

Examples: 
| skill   | skilllLevel |
| adbcdjs |             |
|         | Beginner    |
|         |             |

Scenario Outline:04 - Edit an Existing Skill and Level with invalid details
        Given         User successfullly logged into the Mar_qa Project
		When          I updated invalid '<Skill>' and '<Level>' an Existing skills and levels
		Then          The invalid  record should be updated '<Skill>' and '<Level>'

Examples: 
| Skill | Level    |
|       |          |








        