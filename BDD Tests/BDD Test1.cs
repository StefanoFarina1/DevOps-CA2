Feature: Calculator Sustainability and Carbon Footprint Calculation

  Scenario: Calculate Sustainability Weighting for Cycling
    Given the user has entered a distance of 15 miles
    And the user has selected the distance measurement as Miles
    And the user travels to work for 3 days in a week
    When the user selects the transport mode as Cycling
    Then the sustainability weighting should be 36
