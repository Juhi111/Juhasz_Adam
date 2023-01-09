Feature: Creating a new booking

Creating a new booking
Background: Background: There is a test site as client at: https://restful-booker.herokuapp.com/booking

@CreateBooking
Scenario: Creating a full new booking
	Given an object as the new booking
	When sending the object in the request
	Then should get back the sended object as a booking
