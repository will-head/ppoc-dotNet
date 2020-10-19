using System;
using Ppoc;

namespace ConsoleApplication
{
    public class Program
    {
        private static FeedTranslator feedTranslator;

        public static void Main(string[] args)
        {
            string input = "http://example.com/feed";
            feedTranslator = new FeedTranslator(input);
            Console.WriteLine(feedTranslator.Feed());
        }
    }
}
