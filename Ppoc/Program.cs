using System;
using Ppoc;

namespace ConsoleApplication
{
    public class Program
    {
        private static FeedTranslator feedTranslator;

        public static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a feed: ");
            string input = Console.ReadLine();
            feedTranslator = new FeedTranslator(input);
            Console.WriteLine($"\nYour translated feed is:\n{feedTranslator.Itpc()}");
        }
    }
}
