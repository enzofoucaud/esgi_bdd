Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add numbers
	Given the numbers are 50,50,100
	When the numbers are added
	Then the result should be 200

Scenario: Substracted numbers
	Given the numbers are 200,50,50
	When the numbers are substracted
	Then the result should be 100

Scenario: Multiple numbers
	Given the numbers are 2,2,2,2,2
	When the numbers are multiplied
	Then the result should be 32

Scenario: Divide random numbers
	Given the numbers are 4,2,2
	When the numbers are divided
	Then the result should be 1

Scenario: Divide with 0 in dividend
	Given the numbers are 0,2,10
	When the numbers are divided
	Then the result should be 0

Scenario: Divide with 0 in divisor
	Given the numbers are 50,2,0
	When the numbers are divided
	Then the result should be Désolé.. Nous ne pouvons pas diviser par zéro.