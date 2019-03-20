Feature: GetMarketsList

@mytag
Scenario Outline: Get list of markets
	When I visit the path "apiservices/reference/v1.0/countries/en-US"
	Then Status code is 200
	And I get a list of <number> countries

	Examples:
	| number |
	| 234    |
