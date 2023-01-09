Feature: DeleteABooking

Try to delete an existing booking

@bookingDelete
Scenario: Delete an existing booking by an Id
	Given an id 8
	When sending the request for deleting the booking
	Then should get a message like created
