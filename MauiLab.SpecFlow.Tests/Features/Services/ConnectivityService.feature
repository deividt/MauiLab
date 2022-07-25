@ConnectivityService
Feature: ConnectivityService
	Connectivity Service Tests

Scenario: Testing network access
	Given the phone is connected to <ConnectionType>
	Then the connection result should be <ConnectionResult>

	Examples:
	  | ConnectionType      | ConnectionResult |
	  | Internet            | True             |
	  | None                | False            |
	  | Unknown             | False            |
	  | Local               | False            |
	  | ConstrainedInternet | False            |