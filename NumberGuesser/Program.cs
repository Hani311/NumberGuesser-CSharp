using System;

// from youtube https://www.youtube.com/watch?v=GcFJjpMFJvI&t=1666s&ab_channel=TraversyMedia
namespace NumberGuesser
{
    class program
    {
        static void Main(String[] args)
        {
            GetAppInfo();

            GreetUser();


            while (true)
            {

                //set correct number

                // create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


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


                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {

                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }


                }

                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You guessed it!");

                Console.WriteLine("Play again? [Y or N]");

                String answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;

                }
                
                
              }
            
        }

        static void GetAppInfo()
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

        }

        static void GreetUser()
        {
            Console.WriteLine("What is you name?");

            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a agame...", inputName);

        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, String message)
        {
            // change text color
            Console.ForegroundColor = color;

            //tell user its wrong number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }

    }
}