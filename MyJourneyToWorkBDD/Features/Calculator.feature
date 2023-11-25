Feature: Calculator
    In order to promote environmental awareness
    As a user
    I want to know the sustainability impact of my travel choices

Scenario: Calculate total carbon footprint for diesel mode
    Given I have chosen 'diesel' as my transport mode
    And I set the distance to '20' miles
    And I travel '4' days a week
    When I calculate the sustainability weighting
    Then the result should be '144'

Scenario: Calculate total carbon footprint for electric bike mode
    Given I have chosen 'electricbike' as my transport mode
    And I set the distance to '5' miles
    And I travel '7' days a week
    When I calculate the sustainability weighting
    Then the result should be '0.35'

Scenario: Calculate total carbon footprint for hybrid mode
    Given I have chosen 'hybrid' as my transport mode
    And I set the distance to '30' miles
    And I travel '2' days a week
    When I calculate the sustainability weighting
    Then the result should be '10.8'

