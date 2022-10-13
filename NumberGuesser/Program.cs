using System;

// from youtube https://www.youtube.com/watch?v=GcFJjpMFJvI&t=1666s&ab_channel=TraversyMedia
namespace NumberGuesser
{
    class program
    {
        static void Main(String[] args)
        {

            // set app vars

            String appName = "Number guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Brad Traversy";


            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        
        
            //reset text color
            Console.ResetColor();

            Console.WriteLine("What is you name?");
            
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a agame...", inputName);

            //set correct number
            int correctNumber = 7;

            //init guess var

            int guess = 0;

            //ask user for number

            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct

            while (guess != correctNumber)
            {
                //get user input
                String input = Console.ReadLine();

                //make sure its a number
                if (!int.TryParse(input, out guess))
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //tell user its not a number
                    Console.WriteLine("Please use an actual number");

                    //reset text color
                    Console.ResetColor();

                    //keep going
                    continue;
                }

                //cast to int and put in guess
                guess = Int32.Parse(input);

                //match guess to correct number
                if (guess != correctNumber)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //tell user its wrong number
                    Console.WriteLine("Wrong number, please try again");

                    //reset text color
                    Console.ResetColor();
                }
            }

            //asdads




        }
    }
}