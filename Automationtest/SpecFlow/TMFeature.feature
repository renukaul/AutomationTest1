Feature: TMFeature

Here we will login the Time and material TurnUp page.
Where we have to create ,edit and delete the records of the Turnup page.

@tag1
Scenario: Create T & Material page with valid data
	Given I logged it sucessfully 
	And I  nevigate  to  T & M page
	When create T & M page
	Then we will sucessfully create the T & M record 

Scenario Outline: Edit T & Material page with valid data
	Given I logged it sucessfully 
	And I  nevigate  to  T & M page
	When Update '<Description>','<TypeCode>','<price>' on an existing  T & M record
	Then The record shoub have the  updated '<Description>' ,'<TypeCode>','<price>'

	Examples: 
	| Description         | TypeCode | price |
	| AutomationTesting11 | T		 | 123   |
	| UnitTest 54         | T        | 76    |
	| RegressionTest 76   | T        | 45    |

	