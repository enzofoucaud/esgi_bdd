Feature: API
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowAPI/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Init participants
	Given the maxParticipants is 5
	When the participants are init
	Then the int result should be 5

Scenario: Init votes
	Given the maxVotes is 10
	When the votes are init
	Then the int result should be 10

Scenario: Votes are closed
	Given the maxVotes is 10
	When the votes are init
	When the votes are closed
	Then the int result should be 10
