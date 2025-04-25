Feature: Login

Login to the page

@tag1
Scenario: Try to login	
	When sending the request
    Then the statusCode should be Ok
