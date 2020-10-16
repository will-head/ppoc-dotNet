Feature: FeedTranslator
	In order to listen to podcasts in any player
	As a podcast user
	I want to be able to translate feeds into other player formats

@mytag
Scenario: http to feed
	Given I have a feed http://example.com/feed
	When I press feed
	Then the result should be feed://example.com/feed
