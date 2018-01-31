Feature: Search

Scenario: Verify search results by keyword and location
	Given I am on Home page
	When I go to "Careers" drop down
	And I clcik "Your Career" item
	And I scroll to Search field
	And I eneter "QA" in Search field
	And I click locations drop down
	And I scroll to "Malaysia" location
	And I select "Poland" location
	And I click Search button
	Then "2 results" of search are shown

Scenario: Verify search results by location
	Given I am on Home page
	When I go to "Careers" drop down
	And I clcik "Your Career" item
	And I scroll to Search field
	And I click locations drop down
	And I scroll to "Germany" location
	And I select "Japan" location
	And I click Search button
	Then at least 1 result is shown

Scenario: Verify qualification for job offer
	Given I am on Home page
	When I go to "Careers" drop down
	And I clcik "Your Career" item
	And I scroll to Search field
	And I eneter "Business Analyst" in Search field
	And I click locations drop down
	And I scroll to "Sweden" location
	And I select "United States" location
	And I click Search button
	And I select "Senior Analyst, Advanced Analytics" offer
	Then "Senior Analyst, Advanced Analytics" offer is shown
	And I can see "Experience in structured problem-solving assignments." qualification
