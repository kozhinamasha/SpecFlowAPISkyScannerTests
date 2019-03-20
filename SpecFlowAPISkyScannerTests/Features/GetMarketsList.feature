Feature: GetMarketsList

@mytag
Scenario Outline: Get list of markets
	When I visit the path "apiservices/reference/v1.0/countries/en-US"
	Then Status code is 200
	And I get a list of <number> countries
	And I see country name and code

	Examples:
	| number |
	| 234    |
