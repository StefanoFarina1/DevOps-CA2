Scenario: Validate Days Range for Sustainability Calculation
    Given the user has entered the number of days as 8
    When the user selects any transport mode
    Then an error message should be displayed indicating an invalid number of days
