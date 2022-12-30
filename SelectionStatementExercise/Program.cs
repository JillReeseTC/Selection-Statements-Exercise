using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            var r = new Random();
            int favNumber = r.Next(1, 10);
            Console.WriteLine(favNumber);
            Console.WriteLine("Guess my favorite number! Enter an integer 1 to 1000:");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess);
            int guess2 = -5;
            //Trying to do a loop without a while statement. I'll do three guesses.

            guess2 = SetTries(favNumber, guess, guess2);
            guess = guess2;
            guess2 = SetTries(favNumber, guess, guess2);
            guess = guess2;
            guess2 = SetTries(favNumber, guess, guess2);
            Console.WriteLine($"Game Over! My favorite number is {favNumber}.");

            //Exercise 2
            Console.WriteLine("\n\nExercise 2 \n\n");
            Console.WriteLine("Tell me your favorite Subject:");
            string favSubject = Console.ReadLine();
                
            switch(favSubject.ToLower())
            {
                case "math":
                case "mathematics":
                case "maths":
                    Console.WriteLine("Math is so cool!");
                    break;
                case "english":
                case "language":
                case "grammar":
                    Console.WriteLine("English lets you talk to the world!");
                    break;
                case "psychology":
                case "psych":
                    Console.WriteLine("You're psyching me out!");
                    break;
                case "chemistry":
                case "chem":
                case "science":
                    Console.WriteLine("Figure out the world!");
                    break;
                case "computer science":
                case "comp sci":
                case "programming":
                case "coding":
                    Console.WriteLine("Now you're talking my language!");
                    break;
                default:
                    Console.WriteLine($"I'm glad that you love {favSubject} that much!");
                    break;
            }


        }

        public static int SetTries(int favNumber, int guess, int guess2)
        {
            if (guess2 == -5)
            {
                guess2 = GuessAgain(favNumber, guess, guess2);
            }
            else if (guess2 != 0)
            {
                guess2 = GuessAgain(favNumber, guess, guess2);
            }
            else
            {
                Console.WriteLine("EVERYONE LOVES A WINNER!!!");
            }
            return guess2;
        }
        public static int GuessAgain(int favNumber, int guess, int guess2)
        {
            if (guess == favNumber)
            {
                Console.WriteLine($"You guessed it! My number was {favNumber}.");
                guess2 = 0;
            }
            else if (guess < favNumber)
            {
                Console.WriteLine($"Your guess is too low. Try again! Enter number:");
                guess2 = int.Parse(Console.ReadLine());
            }
            else if (guess > favNumber)
            {
                Console.WriteLine($"Your guess is too high. Try again! Enter number:");
                guess2 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Oh! You lose!");
            }

            return guess2;
        }
    }
}
