using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "amir afjal";
            //int age = 22;
            //Console.WriteLine(name+" is "+age );

            GetAppInfo();//run the GetAppInfo to run the info

            GreetUsers();//ask for users name and greet 

            while (true)
            {

                //init correct number
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess the number between 0 to 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change the text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user its not a number
                        Console.WriteLine("Please an actual number..");

                        //reset text color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //cast to int and put it into guess
                    guess = Int32.Parse(input);

                    //match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        //change the text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user its wrong number
                        Console.WriteLine("Wrong Number , Please try again ..");

                        //reset text color
                        Console.ResetColor();
                    }
                }

                //output success message
                //change the text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //tell user its the right number
                Console.WriteLine("You are Correct !!!");

                //reset text color
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

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

        //get and display app info
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "amir afjal";

            //change the text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }
        //ask users name and greet 
        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} , let's play a game ... ", inputName);
        }
    }
}
