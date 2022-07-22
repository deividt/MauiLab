@MainPage
Feature: MainPage
	Main Page tests

Scenario: Validate Count Button Text
	Given the app shows the main page
	Then the count button text should be "Click me"