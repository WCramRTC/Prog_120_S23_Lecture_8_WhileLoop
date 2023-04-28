    namespace Prog_120_S23_Lecture_8_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TO go up, your start must be less than the end, and you have to Increment ++
            // To go DOWN, your start must be GREATER THAN the end, and you must DECREMENT --

            //while(start > end)
            //  {
            //      // Compound Operator : Combines the assignment and the math operator
            //      // += , -=, *=, /*, %=
            //      //count = count + 1;  
            //      // Incrementer
            //      start--; // By doing plus plus, it adds 1

            //      Console.WriteLine(start);
            //  }

            //Console.WriteLine("Please select a choice");
            //Console.WriteLine("1 - Choice 1");
            //Console.WriteLine("2 - Choice 2");
            //Console.WriteLine("3 - Choice 3");
            //Console.WriteLine("e - Exit");
            //Console.Write("Enter your choice: ");
            //string userChoice = Console.ReadLine();

            //while(userChoice != "e")
            //{
            //    if (userChoice == "1")
            //    {
            //        Console.WriteLine("You selected choice 1");
            //    }
            //    else if(userChoice == "2")
            //    {
            //        Console.WriteLine("You selected choice 2");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You selected choice 3");
            //    }

            //    Console.Clear();
            //    Console.WriteLine("Please select a choice");
            //    Console.WriteLine("1 - Choice 1");
            //    Console.WriteLine("2 - Choice 2");
            //    Console.WriteLine("3 - Choice 3");
            //    Console.WriteLine("e - Exit");



            //    Console.Write("Enter your choice: ");
            //    userChoice = Console.ReadLine();
            //}

            // we use the Do while

            // do {} while(condition)
            // will run once, and then check the condition
            string userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Please select a choice");
                Console.WriteLine("1 - Choice 1");
                Console.WriteLine("2 - Choice 2");
                Console.WriteLine("3 - Choice 3");
                Console.WriteLine("e - Exit");
                Console.Write("Enter your choice: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("You selected choice 1");
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("You selected choice 2");
                }
                else
                {
                    Console.WriteLine("You selected choice 3");
                }


            } while (userChoice != "e");




        } // Main

        public static void Login()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            string userId = "Will";

            // This will run as long as the user types the incorrect name
            while (userName != userId)
            {
                Console.WriteLine("You have entered an invalid name. Please try again\n");

                Console.Write("Please enter another name: ");
                userName = Console.ReadLine();
            }

            Console.WriteLine("Thank you for logging in.");
        }

        public static void AutomaticallyChangingLoop()
        {
            //Console.Write("Please enter a starting number: ");
            //// Start at 100 and go to 0
            //int start = 100;
            //int end = 10;

            //if(start < end) // checking if the ending number is greater than th
            //{
            //    while(start < end)
            //    {
            //        start++;
            //        Console.WriteLine(start);
            //    }
            //}
            //else
            //{
            //    while(start > end)
            //    {
            //        start--;
            //        Console.WriteLine(start);
            //    }
            //}
        }

        public static void Display0To10()
        {
            // Loops
            // In programming a loop is a BLOCK of code, that runs over and over again, under a certain CONDITION

            // while loop
            // do while

            // if statement (true / false) : If true, runs once
            // while statment (true / false ) : if true, continues to run

            // WHile true, run this loop
            // We can use our compairson operators : > < >= <= == !=

            // This will run from 0 to 9 then stop

            int count = 0;
            Console.WriteLine("Before Loop");
            // Problem You'll Face: Inifinite loops happen when your condition nevers changes from true
            while (count <= 10)
            {
                Console.WriteLine($"Before incrementing: {count}");
                // We are adding one, to the current value of count
                count = count + 1;


                //Console.ReadKey();
                // The end of our loop, it loops back to the top of the while loop
            } // End of our While Loop

            Console.WriteLine("After Loop");

        }

    } // class

} // namespace

// Fundamentals are
// Input
// Output
// Loops
// Conditions
// Variables
// Operations