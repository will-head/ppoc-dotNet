Feature: FeedTranslator
	In order to listen to podcasts in any player
	As a podcast user
	I want to be able to translate feeds into other player formats

Scenario: http to feed for "http://example.com/feed"
	Given I have an http: feed "http://example.com/feed"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed"
