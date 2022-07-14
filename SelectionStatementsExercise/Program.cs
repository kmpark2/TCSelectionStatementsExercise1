using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number between 1 and 1000.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high.");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }

            Console.WriteLine("What is your favorite school subject?");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "Math":
                case "math":
                case "Mathematics":
                case "mathematics":
                    Console.WriteLine("Imaginary numbers are not real.");
                    break;
                case "Science":
                case "science":
                case "Geology":
                case "geology":
                    Console.WriteLine("The Earth is flat and resting on four giant elephants that stand on a humongous tortoise.");
                    break;
                case "History":
                case "history":
                    Console.WriteLine("Genghis Khan did nothing wrong.");
                    break;
                case "Gym":
                case "gym":
                    Console.WriteLine("Do you even lift, bro?");
                    break;
                case "English":
                case "english":
                    Console.WriteLine("Donde Esta La Biblioteca?");
                    break;
                default:
                    Console.WriteLine("That sounds like it's the most boring thing in the world.");
                    break;
            }
        }
    }
}
