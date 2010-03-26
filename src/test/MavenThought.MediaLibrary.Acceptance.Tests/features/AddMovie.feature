Feature: Addition
	In order to make my library grow
	As a registered user
	I want to add movies to the library

	Scenario: Add a movie
		Given I'm on the home page
		When I follow Add Media 
		And I enter Young Frankestein in the title
		And I click Submit
		Then I should see Young Frankestein in the listing
		And the case for Young Frankestein should not be empty
		
	Scenario: Add a movie with no case
		Given I'm on the home page
		When I follow Add Media
		And I enter Back To The Future in the title
		And I click Submit
		Then I should see Back To The Future in the listing	
		And the case for Back To The Future should be empty	