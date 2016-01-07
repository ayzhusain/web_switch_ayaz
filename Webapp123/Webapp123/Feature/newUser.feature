Feature: newUser
	To register a new user
    user clicks on the page register new user


Scenario: New User
	Given You are on the reguser page
	When fill in your user name
    And fill in your password
    And fill in email
    And click on register
	Then registered should appare

Scenario: Login
    Given You are on the login page
    When fill in your user name
    And fill in your password
    And click on Login
    Then Welcome user should appare
