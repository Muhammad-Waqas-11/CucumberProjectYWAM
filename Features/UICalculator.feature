Feature: UICalculator

  A short summary of the feature

  @basic
  Scenario: Add two numbers
    Given I press "5" on the calculator
    And I press "+" on the calculator
    And I press "3" on the calculator
    When I press "=" on the calculator
    Then the result should be "8" on the display

  @basic
  Scenario: Subtract two numbers
    Given I press "9" on the calculator
    And I press "-" on the calculator
    And I press "4" on the calculator
    When I press "=" on the calculator
    Then the result should be "5" on the display

  @basic
  Scenario: Multiply two numbers
    Given I press "6" on the calculator
    And I press "*" on the calculator
    And I press "7" on the calculator
    When I press "=" on the calculator
    Then the result should be "42" on the display

  @basic
  Scenario: Divide two numbers
    Given I press "8" on the calculator
    And I press "/" on the calculator
    And I press "2" on the calculator
    When I press "=" on the calculator
    Then the result should be "4" on the display

  @basic
  Scenario: Clear the display
    Given I press "5" on the calculator
    When I press "C" on the calculator
    Then the result should be "0" on the display
