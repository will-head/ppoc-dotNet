using Ppoc;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Ppoc.Specs.Steps
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

        [When(@"it is translated to http")]
        public void WhenItIsTranslatedToHttp()
        {
            _result = _feed_translator.Http();
        }

        [When(@"it is translated to https")]
        public void WhenItIsTranslatedToHttps()
        {
            _result = _feed_translator.Https();
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

        [When(@"it is translated to podcast")]
        public void WhenItIsTranslatedToPodcast()
        {
            _result = _feed_translator.Podcast();
        }
        
        [When(@"it is translated to downcast")]
        public void WhenItIsTranslatedToDowncast()
        {
            _result = _feed_translator.Downcast();
        }

        [When(@"it is translated to pcast")]
        public void WhenItIsTranslatedToPcast()
        {
            _result = _feed_translator.Pcast();
        }

        [Then(@"it should be feed ""(.*)""")]
        public void ThenItShouldBeFeed(string expectedResult)
        {
            _result.Should().Be(expectedResult);
        }

    }
}
