using FeedTranslator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FeedTranslator.Specs.Steps
{
    [Binding]
    public class FeedTranslatorSteps
    {
        private FeedTranslator _feed_translator;
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
        
        [Then(@"it should be translated into a feed: feed ""(.*)""")]
        public void ThenItShouldBeTranslatedIntoAFeedFeed(string p0)
        {
            _scenarioContext.Pending();
        }

    }
}
