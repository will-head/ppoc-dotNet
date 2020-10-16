using System;

namespace FeedTranslator
{
    public class FeedTranslator
    {
        public FeedTranslator(string request)
        {
            Console.WriteLine(request);
        }

        public string Feed()
        {
            return "feed://example.com/feed";
        }
    }
}
