Feature: Adding a new record

Adding a new record at  https://opensource-demo.orangehrmlive.com/

@tag1
Scenario: Adding a new record
	Given I navigate to application	
	When I login as admin user
	When i navigate to AdminPage
	When i navigate to PayGrades
	When i add a new record and save it
	Then its should be in the Currencies block
	
