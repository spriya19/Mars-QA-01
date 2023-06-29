Feature: SkillsFeature

As I login my Mars-QA application
I Would like to create my profile Skills details
So I can Add my skills created successfully.




Skills Added to profie
Scenario:  Adding skills to  the User Profile
	Given User has successfully logged into the Mar_qa application
	When Create skills in the user profile
	Then Skills have been Successfully Created


Scenario Outline: Edit an Existing Skill and Level with valid details
        Given     User has successfully logged into the Mar_qa application
		When      I update '<Skill>' and '<Level>' anExisting skills and levels
		Then      The record should be updated '<Skill>' and '<Level>'

Examples: 
| Skill |     Level    |
| API   | Intermediate |

Scenario Outline: Delete an Existing Skill and Level with valid Details
       Given      User has successfully logged into the Mar_qa application
	   When       I delete '<Skill>' and '<Level>' an Existing skills and levels
	   Then       The record should be deleted '<Skill>' and '<Level>'

Examples: 
| Skill | Level        |
| API   | Intermediate |


