Feature: SpecFlowFeature
	To test the page Challenging DOM

@QATest
Scenario: Check the launch of Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The "Challenging DOM" is visible

@QATest
Scenario Outline: Check the Buttons on the Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The Buttons <<Name>> are visible 
	Examples: 
	| Name |
	| blue |
	| red |
	| green |

@QATest
Scenario Outline: Check the AllButtons on the Page
	Given I have Cooldata with <data>, <name>

	Examples: 
	| data     | name  |
	| Cooldata | blue  |
	| Cooldata | red   |
	| Cooldata | green |

@QATest
Scenario Outline: Check the Button blue on the Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The Button "Button1" Is Visible

	

@QATest
Scenario: Check the table on Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The table with rows is visible

@QATest
Scenario Outline: Click the Buttons on the Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The Buttons <<Name>> are visible 

	Examples: 
	| Name |
	| blue |
	| red |
	| green |


@QATest
Scenario: Check the options table rows on Page
	Given I launch the website "https://the-internet.herokuapp.com/challenging_dom"
	And The Page is Launched correctly
	Then The table with rows is visible