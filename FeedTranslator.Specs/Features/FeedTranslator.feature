Feature: FeedTranslator
	In order to listen to podcasts in any player
	As a podcast user
	I want to be able to translate feeds into other player formats

Scenario: http to feed, no trailing slash
	Given I have an http: feed "http://example.com/feed"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed"

Scenario: http to feed, trailing slash
  Given I have an http: feed "http://example.com/feed/"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed/"

Scenario: https to feed
  Given I have an http: feed "https://example.com/feed/"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed/"

Scenario: http to feed, with parameter in feed
  Given I have an http: feed "http://example.com/feed?rss"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed?rss"

Scenario: http to feed, with parameter equals in feed
  Given I have an http: feed "http://example.com/feed?format=rss"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed?format=rss"

Scenario: http to feed, with extension in feed
  Given I have an http: feed "http://example.com/feed.rss"
  When it is translated
  Then it should be a feed: feed "feed://example.com/feed.rss"
