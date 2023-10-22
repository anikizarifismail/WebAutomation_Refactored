Feature: Amazon Webpage Functional Test

@mytag
Scenario: First laptop price should be more than $100.00
	Given Browser has Amazon webpage navigated
	And The currency preference is set to US Dollar
	When Query for laptop using search bar
	Then First laptop item should be priced more than $100.00

Scenario Outline: First item price should be more than certain price
	Given Browser has Amazon webpage navigated
	When Query for '<item>' using search bar
	Then First listed item should be priced more than '<price>'
Examples:
| item | price |
| shoe | 40.00 |
| handbag | 30.00 |
