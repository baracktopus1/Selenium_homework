Feature: Var2
	Simple calculator for adding two numbers

@mytag
Scenario: Login and change job
	Given User navigates to the login page
	When User inputs username and password
	And Clicks on login button
	Then User is navigated to the homepagee

	Given User is in the Job titles page
	When User clicks Add button
	And Inputs <job_title> <description> and <note>
	And Clicks save button
	Then User notices new data on the page

	When User clicks on <job_title>
	And User enters edit mode
	And User edits <description>
	And User saves changes
	Then User notices edited data on the page

	When User ticks <job_title>
	And clicks Delete button
	And clicks ok button
	Then User notices his field deleted on Job title page