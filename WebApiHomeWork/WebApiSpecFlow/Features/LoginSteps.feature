Feature: LoginSteps

Try to login 

Background: There is a test site as client at: https://restful-booker.herokuapp.com/auth

@rightLogin
Scenario: Login with right username and password
Given a username admin
And a password password123
When sending the request
Then the statusCode should be Ok


	
