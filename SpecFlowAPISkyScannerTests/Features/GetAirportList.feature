Feature: GetAirportsLists

@mytag
Scenario Outline: Get list of aiports for the country
	When I visit the path "apiservices/autosuggest/v1.0/UK/GBP/en-GB/?query=<city>"
	Then Status code is 200
	And The number of the airports is <number>
	#And All airports for the right country <country>

	Examples:
	| city      | country | number |
	| Stockholm | Sweden  | 5      |
	| London    |     t   | 10     |

Scenario: Retrieve the cheapest quotes from prices
	When I visit the path "apiservices/browsequotes/v1.0/US/USD/en-US/SFO-sky/JFK-sky/2019-04-01?inboundpartialdate=2019-01-01"
	Then Status code is 200
	And The data about quotes is correct

Scenario Outline: Get list of markets
	When I visit the path "apiservices/reference/v1.0/countries/en-US"
	Then Status code is 200
	And I get a list of <number> countries

	Examples:
	| number |
	| 234    |


