Feature: Order
	To be able to order item on Codas Website

@mytag
Scenario:Ordering from Codas's Website 
	Given I navigate to"https://www.codas.com/"
	When I click on the news tab
	Then I can confirm the  March article 
	When I click on read more and take a screenshoot
	When I click on the Home link
	And I click on CODAS -IQO
	Then I click on IQO Demo
	When i enter postcode "M54TP"
	And I click on Get Quote
	Then I select day for delivery and take a screenshot
