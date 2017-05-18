Feature: Calculator arithmetic expressions
	In order to avoid silly mistakes 
	As a math idiot 
	I want to be able to perform arithmetic on the calculator

Background:
	Given I have a calculator

@subtraction
Scenario Outline: Calculating expressions
	Given I have entered the following expression in the calculator
		| Field        | Value          |
		| First value  | <First value>  |
		| Operation    | <Operation>    |
		| Second value | <Second value> |

	When I press the equal key

	Then the result on the screen should be <Output>

	Examples:
		| First value | Operation | Second value | Output |
		| one         | plus      | one          | 2      |
