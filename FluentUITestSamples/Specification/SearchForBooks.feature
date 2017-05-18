Feature: Search for books
	In order to find quickly books of favorite authors
	As a cusmtomer
	I want to be able to see books list for a certain author

@amazon
Scenario: Search for books by author
	Given I navigated to Amazon home page

	When I search for author "Emilian Balanescu"

	Then the first result on the screen shoul be "Beginning PHP and PostgreSQL E-Commerce: From Novice to Professional (Beginning, from Novice to Professional)"
