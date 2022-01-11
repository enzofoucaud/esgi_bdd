Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Multiple two numbers
	Given the first number is 2
	And the second number is 10
	When the two numbers are multiplied
	Then the result should be 20

Scenario: Divide two random numbers
	Given the first number is 50
	And the second number is 25
	When the two numbers are divided
	Then the result should be 2

Scenario: Divide with 0 in dividend
	Given the first number is 0
	And the second number is 3
	When the two numbers are divided
	Then the result should be 0

Scenario: Divide with 0 in divisor
	Given the first number is 3
	And the second number is 0
	When the two numbers are divided
	Then the result should be error