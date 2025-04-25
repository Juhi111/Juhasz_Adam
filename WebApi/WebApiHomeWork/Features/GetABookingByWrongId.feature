Feature: GetABookingByWrongId

Should get a null or empty result

@tag1
Scenario: Try to get a booking by a non existing Id
	When sending the wrong ID
	Then should get a null or an emptyresult 
