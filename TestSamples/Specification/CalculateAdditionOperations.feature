Feature: Calculator addition operations
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have a calculator

@addition
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have pressed the plus key
	And I have entered 70 into the calculator

	When I press the equal key

	Then the result on the screen should be 120

Scenario Outline: Valid inputs when adding two numbers
	Given I have entered <First value> into the calculator
	And I have pressed the plus key
	And I have entered <Second value> into the calculator

	When I press the equal key

	Then the result on the screen should be <Output>

	Examples:
		| First value | Second value | Output | Reason                                        |
		| one         | two          | 3      | string inputs until three are valid           |
		| four        | 1            | ERR    | string inputs over three will result in error |
