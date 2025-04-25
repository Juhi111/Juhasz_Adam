Feature: UpdateBookingWithoutAuthorization

Try to update a booking but with a wrong authorization

@tag1
Scenario: Auth fail
	Given booking by an Id to update but the auth is wrong
	When sending the new datas
	Then should get back an error code
