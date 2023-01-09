Feature: WrongLoginSTeps
Try to login 

Background: There is a test site as client at: https://restful-booker.herokuapp.com/auth

@wrongLogin
Scenario: Login with wrong username and password
Given a wrong username admi
And a wrong password  passwor
When sending the request with bad datas
Then the result should be "bad credentials"
