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

        [Given(@"I have a feed ""(.*)""")]
        public void GivenIHaveAFeed(string input)
        {
            _feed_translator = new FeedTranslator(input);
        }

        [When(@"it is translated to feed")]
        public void WhenItIsTranslatedToFeed()
        {
            _result = _feed_translator.Feed();
        }

        [When(@"it is translated to itpc")]
        public void WhenItIsTranslatedToItpc()
        {
            _result = _feed_translator.Itpc();
        }
        
        [Then(@"it should be feed ""(.*)""")]
        public void ThenItShouldBeFeed(string expectedResult)
        {
            _result.Should().Be(expectedResult);
        }

    }
}
