Feature: UICalculator

  A short summary of the feature

  @ADD
  Scenario: Add two numbers
    Given I press "5" on the calculator
    And I press "+" on the calculator
    And I press "3" on the calculator
    When I press "=" on the calculator
    Then the result should be "8" on the display

  @Subtract
  Scenario: Subtract two numbers
    Given I press "9" on the calculator
    And I press "-" on the calculator
    And I press "4" on the calculator
    When I press "=" on the calculator
    Then the result should be "5" on the display

  @Multiply
  Scenario: Multiply two numbers
    Given I press "6" on the calculator
    And I press "*" on the calculator
    And I press "7" on the calculator
    When I press "=" on the calculator
    Then the result should be "42" on the display

  @Divide
  Scenario: Divide two numbers
    Given I press "8" on the calculator
    And I press "/" on the calculator
    And I press "2" on the calculator
    When I press "=" on the calculator
    Then the result should be "4" on the display
  
  @Clear
  Scenario: Clear the display
    Given I press "5" on the calculator
    When I press "C" on the calculator
    Then the result should be "" on the display
  
  @Parameterized
  Scenario Outline: Perform various calculations
    Given I press "<first_number>" on the calculator
    And I press "<operator>" on the calculator
    And I press "<second_number>" on the calculator
    When I press "=" on the calculator
    Then the result should be "<result>" on the display

  Examples:
    | first_number | operator | second_number | result |
    | 5            | +        | 3             | 8      |
    | 9            | -        | 4             | 5      |
    | 6            | *        | 7             | 42     |
    | 8            | /        | 2             | 4      |
    | 10           | -        | 2             | 8      |