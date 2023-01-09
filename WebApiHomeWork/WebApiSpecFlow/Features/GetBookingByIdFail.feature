Feature: GetBookingByIdFail

Try to get a booking by a wrong id
Background: Background: There is a test site as client at: https://restful-booker.herokuapp.com/booking

@GetBooking
Scenario: Get booking details by a wrong Id
	Given a non existing Id	999999999999999999999999
	When sending the get request by this wrong id 
	Then shouldnt get back an empty object 
