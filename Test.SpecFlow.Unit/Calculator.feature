Feature: Calculator
	In order to avoid silly mistakes
	Calculate the sum of tho numbers
	Calculate the reduct of tho numbers
	Calculate the multiplication of tho numbers
	Calculate the division of tho numbers

@mytag
Scenario: Add two numbers
	Given I have entered <input1> into the calculator
	And I have also entered <input2> into the calculator
	When I press Suma 
	Then the result should be <output> on the screen

		Examples: 
			| input1 | input2 | output |
			| 2      | 2      | 4      |



@mytag
Scenario: Reduct two numbers
	Given I have entered <input1> into the calculator
	And I have also entered <input2> into the calculator
	When I press Resta 
	Then the result should be <output> on the screen

		Examples: 
			| input1 | input2 | button | output |
			| 2      | 2      | Resta  | 0      |



@mytag
Scenario: Add two numbers
	Given I have entered <input1> into the calculator
	And I have also entered <input2> into the calculator
	When I press Multiplicacion 
	Then the result should be <output> on the screen

		Examples: 
			| input1 | input2 | output |
			| 2      | 2      | 4      |



@mytag
Scenario: Add two numbers
	Given I have entered <input1> into the calculator
	And I have also entered <input2> into the calculator
	When I press Division
	Then the result should be <output> on the screen

		Examples: 
			| input1 | input2 | output |
			| 2      | 2      | 4      |


