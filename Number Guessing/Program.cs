using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int range = 5;
            bool keepPlaying = true;


            do
            {
                Random randomNumberGenerator = new Random();
                int realAnswer = randomNumberGenerator.Next(range); // Returns non-negative value, LESS than specificed number

                int guessNumber = readIntFromConsole($"Guess a number from 0-{range - 1}: ");
                int attempts = 1;


                while (guessNumber != realAnswer)
                {
                    attempts++;

                    if (guessNumber < realAnswer)
                    {
                        guessNumber = readIntFromConsole("You guessed incorrectly! Try a higher number: ");
                    }
                    else if (guessNumber > realAnswer)
                    {
                        guessNumber = readIntFromConsole("You guessed incorrectly! Try a lower number: ");
                    }

                }



                Console.WriteLine($"You guessed correctly! You took {attempts} attempt(s).");

                bool checkRepeat = true;

                while (checkRepeat)
                {

                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Y / N ");

                    string playOption = Console.ReadLine();


                    if (playOption.ToLower() == "n")
                    {
                        Console.WriteLine("Press any key to exit the game.");
                        keepPlaying = false;
                        checkRepeat = false;
                    }
                    else if (playOption.ToLower() == "y")
                    {
                        checkRepeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input");
                    }

                }

                Console.WriteLine();    // For spacing

            } while (keepPlaying);         
 


            Console.ReadLine();
        }

        public static int readIntFromConsole(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
