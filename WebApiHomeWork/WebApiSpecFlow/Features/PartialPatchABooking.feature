Feature: PartialPathABooking

Try to patch a few datas of a booking
Background: There is a test site as client at: https://restful-booker.herokuapp.com/auth


@partialpatch
Scenario: Try to patch a few datas of a booking
	Given a booking on id 5
	And  a firstname to change for ChangedFirstName
	And a lastname to change for ChangedLastName
	When sending the request for the patch
	Then the mentioned datas should be changed
