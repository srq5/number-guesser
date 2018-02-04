using System;

namespace number_guesser
{
   
    class Program
    {
        //This is the entry point method
        static void Main(string[] args)
        {

            AppInfo();
            
            GreetUser();

            while (true)
            {

                //Sets the correct number as a random number between 1 and 10.
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Initalizes user guess variable.
                int numberGuess = 0;

                //Asks users to guess.
                Console.WriteLine("Guess a number between 1 and 10");

                //While the guess is incorrect...
                while (numberGuess != correctNumber)
                {

                    string numInput = Console.ReadLine();

                    //Ensure the input is a number.
                    if (!int.TryParse(numInput, out numberGuess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");

                        continue;
                    }


                    //Parse int and pass to numberGuess
                    numberGuess = Int32.Parse(numInput);

                    //Match guess to correct number
                    if (numberGuess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect. Please guess again.");
                    }

                }

                //When the user guesses correct number...
                PrintColorMessage(ConsoleColor.Green, "Correct!");

                //See if the user would like to play again.
                Console.WriteLine("Would you like to play again? [Y or N]");
                string playAgainAnswer = Console.ReadLine().ToUpper();


                if (playAgainAnswer == "Y")
                {
                    continue;

                } else if (playAgainAnswer == "N")
                {

                    return;

                } else
                {
                    return;
                }
            }
        }

        //Function definitions
        static void AppInfo ()
        {

            //Set variables for information about the application.
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Steven Sammon";
            
            //Changes text color and writes information to the console.
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} | Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

        }

        static void GreetUser ()
        {
            Console.WriteLine("What is your name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Hello {0}. Let's play a game.", nameInput);
        }

        //This function will take two parameters: the console color and the message.
        static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
