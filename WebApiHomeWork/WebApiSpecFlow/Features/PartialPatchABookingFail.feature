Feature: PartialPatchABookingFail

Try to patch a booking with wrong ID
Background: There is a test site as client at: https://restful-booker.herokuapp.com/auth

@PartialPatchABookingFail
Scenario: Try to patch a booking with wrong ID
	Given a wrong id 9999999999999999999999
	And  a firstName to change
	And a lastName to change
	When sending the patch request
	Then should return an error message