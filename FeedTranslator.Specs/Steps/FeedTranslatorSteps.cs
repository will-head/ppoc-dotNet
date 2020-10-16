using FeedTranslator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FeedTranslator.Specs.Steps
{
    [Binding]
    public class FeedTranslatorSteps
    {
        private FeedTranslator _feed_translator;
        private string _result;
        private readonly ScenarioContext _scenarioContext;

        public FeedTranslatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have an http: feed ""(.*)""")]
        public void GivenIHaveAnHttpFeed(string p0)
        {
            _feed_translator = new FeedTranslator(p0);
        }
        
        [When(@"it is translated")]
        public void WhenItIsTranslated()
        {
            _result = _feed_translator.Feed();
        }
        
        [Then(@"it should be a feed: feed ""(.*)""")]
        public void ThenItShouldBeAFeedFeed(string expectedResult)
        {
            _result.Should().Be(expectedResult);
        }

    }
}
