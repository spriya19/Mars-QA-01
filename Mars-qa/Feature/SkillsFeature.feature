Feature: SkillsFeature

As I login my Mars-QA application
I Would like to create my profile Skills details
So I can Add my skills created successfully.




Skills Added to profie
Scenario:01 -  Adding skills to  the User Profile
	Given User has successfully logged into the Mar_qa application
	When Create skills in the user profile
	Then Skills have been Successfully Created


Scenario Outline:02 - Edit an Existing Skill and Level with valid details
        Given     User has successfully logged into the Mar_qa application
		When      I update '<Skill>' and '<Level>' anExisting skills and levels
		Then      The record should be updated '<Skill>' and '<Level>'

Examples: 
| Skill    | Level        |
| C#       | Intermediate |
| Selenium | Expert       |
| Aa2234   | Beginner     |
| 12!@#$   | Intermediate |
| @@**!!   | Beginner     |


Scenario Outline:03 - Delete an Existing Skill and Level with valid Details
       Given      User has successfully logged into the Mar_qa application
	   When       I delete '<Skill>' and '<Level>' an Existing skills and levels
	   Then       The record should be deleted '<Skill>' and '<Level>'

Examples: 
| Skill | Level        |
| @@**!! | Beginner     |



