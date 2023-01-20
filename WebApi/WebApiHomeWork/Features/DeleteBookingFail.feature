Feature: DeleteBookingFail

Miss the auth, so cant delete the record

@tag1
Scenario: Delete a booking fails
	Given a booking Id we want to delete but we miss the auth
	Then we send the request, we should get back an error message
