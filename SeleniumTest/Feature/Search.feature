Feature: Search

Scenario: Verify search results for slected query
	Given I am on Home page
	When I go to "Careers" drop down
	And I clcik "Your Career" item
	And I scroll to Search field
	And I eneter "QA" in Search field
	And I select "Poland" location
	And I click Search button
	Then "2 results" of serach are shown