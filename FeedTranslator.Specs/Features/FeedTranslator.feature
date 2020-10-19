Feature: FeedTranslator
	In order to listen to podcasts in any player
	As a podcast user
	I want to be able to translate feeds into other player formats

Scenario: http to feed, no trailing slash
	Given I have a feed "http://example.com/feed"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed"

Scenario: http to feed, trailing slash
  Given I have a feed "http://example.com/feed/"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed/"

Scenario: http to feed, with parameter in feed
  Given I have a feed "http://example.com/feed?rss"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed?rss"

Scenario: http to feed, with parameter equals in feed
  Given I have a feed "http://example.com/feed?format=rss"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed?format=rss"

Scenario: http to feed, with extension in feed
  Given I have a feed "http://example.com/feed.rss"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed.rss"

Scenario: http to feed, with username in feed
  Given I have a feed "http://user@example.com/feed"
  When it is translated to feed
  Then it should be feed "feed://user@example.com/feed"

Scenario: http to feed, with username and password in feed
  Given I have a feed "http://user:password@example.com/feed"
  When it is translated to feed
  Then it should be feed "feed://user:password@example.com/feed"

Scenario: https to feed
  Given I have a feed "https://example.com/feed/"
  When it is translated to feed
  Then it should be feed "feed://example.com/feed/"

Scenario: http to itcp
  Given I have a feed "http://example.com/feed"
  When it is translated to itpc
  Then it should be feed "itpc://example.com/feed"

Scenario: http to podcast
  Given I have a feed "http://example.com/feed"
  When it is translated to podcast
  Then it should be feed "podcast://example.com/feed"

Scenario: http to downcast
  Given I have a feed "http://example.com/feed"
  When it is translated to downcast
  Then it should be feed "downcast://example.com/feed"