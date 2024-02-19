using System.Collections.Generic;
using System.Threading.Channels;
using System.Xml.Linq;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject? Math, English, Science, Art, or History?");
            string userFavSubject = Console.ReadLine().ToLower().Trim();

            switch (userFavSubject)
            {
                case "math":
                    Console.WriteLine($"Ah, I see you like {userFavSubject}.");
                    Console.WriteLine("Sometimes, math to me just seems like a random set of numbers and letters and other alphanumerics that changes hourly forever.");
                    break;
                case "english":
                    Console.WriteLine($"{userFavSubject} can be fun. To me, studying english feels like a thousand vowels fading down a sinkhole to a sussurus.");
                    break;
                case "science":
                    Console.WriteLine($"Yes, {userFavSubject} is a good one.\nThe difference between screwing around and science is writing it down.");
                    break;
                case "art":
                    Console.WriteLine($"I like {userFavSubject}. I used to draw\r\nHard to admit that I used to draw\r\nPortraiture and the human form\r\nDoodle of a two-headed unicorn");
                    break;
                case "history":
                    Console.WriteLine($"{userFavSubject} - an important subject to study and understand. In school, I found most of it boring to learn.\nBut now learning the history of different subhjects that interest me is much more entertaining.");
                    break;
                default:
                    Console.WriteLine($"Sorry, {userFavSubject} is not a choice in this program, please restart and choose from one of the 5 options.");
                    break;

            }
        }
    }
}