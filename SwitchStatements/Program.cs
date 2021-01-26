using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite school subject?");

            var subject = Console.ReadLine(); // Evaluate to a string 

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is tough subject!");
                    break;
                case "english":
                    Console.WriteLine("Math is an interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
      }
}
