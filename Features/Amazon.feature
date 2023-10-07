Feature: Amazon Webpage Functional Test

@mytag
Scenario: First laptop price should be more than $100.00
	Given Browser has Amazon webpage navigated
	And The currency preference is set to US Dollar
	When Query for laptop using search bar
	Then First laptop item should be priced more than $100.00