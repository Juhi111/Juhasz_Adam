Feature: AddANewRecordAndCancel

I add a new record but cancel the action before saving it

@tag1
Scenario: Cancel the action
	Given I navigate to application	
	When I login as admin user
	When i navigate to AdminPage
	When i navigate to PayGrades
	When I add a new record but instead of saving, cancel it
	Then it shouldnt be on the PayGrade page
