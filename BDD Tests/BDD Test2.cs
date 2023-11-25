Scenario: Calculate Total Carbon Footprint for Diesel
    Given the user has entered a distance of 40 kilometers
    And the user has selected the distance measurement as Kilometers
    And the user travels to work for 4 days in a week
    When the user selects the transport mode as Diesel
    Then the total carbon footprint should be 2.88
