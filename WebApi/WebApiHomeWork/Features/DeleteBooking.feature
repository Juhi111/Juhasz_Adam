Feature: DeleteBooking

Delete a booking by Id

@tag1
Scenario: Try to get and delete a booking
	Given a booking by an Id we want to delete
	Then after sended the request, should get the message "created"
