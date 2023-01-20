Feature: UpdateBooking

Full update a booking

@tag1
Scenario: Update all of the datas of a booking
	Given booking by an Id to update
	When sending the new datas
	Then should get back the new booking
