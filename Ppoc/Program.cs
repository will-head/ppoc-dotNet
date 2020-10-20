using System;
using Ppoc;
using StringExtensions;

namespace ConsoleApplication
{
    public class Program
    {
        private static FeedTranslator feedTranslator;

        public static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a feed: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nEnter a feed format: ");
            string outputFeedType = Console.ReadLine().ToTitleCase();

            feedTranslator = new FeedTranslator(input);
            string outputFeed = (string)feedTranslator.GetType().GetMethod(outputFeedType).Invoke(feedTranslator, null);

            Console.WriteLine($"\nYour translated feed is:\n{outputFeed}");
        }
    }
}
