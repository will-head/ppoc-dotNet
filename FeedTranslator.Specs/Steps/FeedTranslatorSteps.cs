using FeedTranslator;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FeedTranslator.Specs.Steps
{
    [Binding]
    public class FeedTranslatorSteps
    {
        private readonly FeedTranslator _feed_translator = new FeedTranslator();

    }
}
