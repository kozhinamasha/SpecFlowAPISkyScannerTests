Feature: GetQuotes

@mytag
Scenario: Retrieve the cheapest quotes from prices
	When I visit the path "apiservices/browsequotes/v1.0/US/USD/en-US/SFO-sky/JFK-sky/2019-04-01?inboundpartialdate=2019-01-01"
	Then Status code is 200
	And The data 174.0 about quotes is correct