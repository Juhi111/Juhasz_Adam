Feature: GetBookingById

Try to get a booking by an id
Background: Background: There is a test site as client at: https://restful-booker.herokuapp.com/booking

@GetBooking
Scenario: Get booking details by an Id
	Given an Id	1
	When sending the get request by id 
	Then should get back an existing booking 


