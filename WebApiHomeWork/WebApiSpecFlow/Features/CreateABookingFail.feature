Feature: CreateABookingFail

Creating a new booking
Background: Background: There is a test site as client at: https://restful-booker.herokuapp.com/booking

@tag1
Scenario: Try to create a new booking with a missing data
	Given an object to add as booking, but a data is missing
	When sending the incomplete datas
	Then it should return a null
