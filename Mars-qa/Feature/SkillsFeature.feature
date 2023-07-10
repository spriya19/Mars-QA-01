Feature: SkillsFeature

As I login my Mars-QA application
I Would like to create my profile Skills details
So I can Add my skills created successfully.
 short summary of the feature


Scenario:01 - Adding a language to User Profile 
	Given  User successfullly logged into the Mar_qa Project
	When Create a Skills into user profile '<skill>' and '<skilllLevel>'
	Then The new skill created '<skill>' and '<skilllLevel>' Successfully Created

Examples: 
| skill          | skilllLevel  |
| Manual Testing | Expert       |
| C#             | Intermediate |
| Java           | Beginner     |
| Python         | Beginner     |
| API            | Intermediate |
| Selenium       | Expert       |
| SQL            | Beginner     |
| 123!@#         | Intermediate |

Scenario Outline:02 - Edit an Existing Skill and Level with valid details
        Given    User successfullly logged into the Mar_qa Project
		When      I update '<Skill>' and '<Level>' an Existing skills and levels
		Then      The record should be updated '<Skill>' and '<Level>'

Examples: 
| Skill         | Level        |
| qwerty        | Beginner     |
| !@$#$%        | Intermediate |
| C++           | Beginner     |
| Postman       | Expert       |
| Specflow      | Intermediate |
| ASD@#$!!!(87) | Beginner     |
| Automation    | Expert       |

Scenario Outline:03 - Delete an Existing Skill and Level with valid Details
       Given      User successfullly logged into the Mar_qa Project
	   When       I delete '<Skill>' and '<Level>' an Existing skill and level
	   Then       The Existing record should be deleted '<Skill>' and '<Level>'

Examples: 
| Skill      | Level  |
| Automation | Expert |



	