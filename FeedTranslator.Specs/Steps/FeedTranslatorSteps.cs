﻿using FeedTranslator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FeedTranslator.Specs.Steps
{
    [Binding]
    public class FeedTranslatorSteps
    {
        private readonly FeedTranslator _feed_translator = new FeedTranslator();
        private readonly ScenarioContext _scenarioContext;

        public FeedTranslatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"I have an http: feed ""(.*)""")]
        public void GivenIHaveAnHttpFeed(string p0)
        {
            _scenarioContext.Pending();
        }
        
        [When(@"it is translated")]
        public void WhenItIsTranslated()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"it should be a feed: feed ""(.*)""")]
        public void ThenItShouldBeAFeedFeed(string p0)
        {
            _scenarioContext.Pending();
        }

    }
}