using System;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Print1kToNegative1k();

            Print3To999By3();

            CheckEqualOdd(22, -55);

            CheckPostitiveNegative(22, -55);

            CanYouVote();

            IsThatNumber10();

            Multiply();
        }

        public static void Print1kToNegative1k()
        {
            Console.WriteLine("Prints 1000 to -1000 to the console");
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Print3To999By3()
        {
            Console.WriteLine("");
            Console.WriteLine("Prints 3 to 999, by increments of 3, to the console");
            int number3 = 3;

            do
            {
                Console.WriteLine(number3);
                number3 += 3;
            } while (number3 < 1000);
        }

        public static void CheckEqualOdd(int myFirstNumber, int mySecondNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("Checks wether the number is even or odd");

            if (myFirstNumber % 2 == 0)
            {
                Console.WriteLine("The first number is even");
            }
            else
            {
                Console.WriteLine("the first number is odd");
            }

            if (mySecondNumber % 2 == 0)
            {
                Console.WriteLine("The second number is even");
            }
            else
            {
                Console.WriteLine("the second number is odd");
            }
        
        }

        public static void CheckPostitiveNegative (int myFirstNumber, int mySecondNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("Checks wether the number is positive or negative");

            if (myFirstNumber > 0)
            {
                Console.WriteLine("The first number is positive");
            }
            else
            {
                Console.WriteLine("the first number is negative");
            }

            if (mySecondNumber > 0)
            {
                Console.WriteLine("The second number is positive");
            }
            else
            {
                Console.WriteLine("the second number is negative");
            }

        }

        public static void CanYouVote()
        {
            Console.WriteLine("");
            Console.WriteLine("Can you vote?  Please enter your age to find out:");

            string ageAnswer;
            int age;
            bool checkAnswer;
            do
            {
                ageAnswer = Console.ReadLine();
                checkAnswer = int.TryParse(ageAnswer, out age);

                if (checkAnswer == false)
                {
                    Console.WriteLine("Please enter your age numerically");


                }
                else if (age >= 18)
                {
                    Console.WriteLine("Yay, you can vote in America!");
                }
                else
                {
                    Console.WriteLine("Nope sorry not old enough");
                }
            } while (checkAnswer == false);
            
           
        }

        public static void IsThatNumber10()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter a number:");

            string userAnswer;
            int number;
            bool checkAnswer;
            bool checkNumber;

            do
            {
                userAnswer = Console.ReadLine();
                checkAnswer = int.TryParse(userAnswer, out number);
                checkNumber = (number >= -10 && number <= 10);

                if (checkAnswer == false)
                {
                    Console.WriteLine("Please enter a number");


                }
                else if (checkNumber == false)
                {
                    Console.WriteLine("Sorry wrong number");
                    
                }
                else
                {
                    Console.WriteLine("Thank you");
                }
            } while (checkAnswer == false || checkNumber == false);
        }

        public static void Multiply()
        {
            Console.WriteLine("");
          
            Console.WriteLine("Please enter a number:");

            string userAnswer;
            int number;
            bool checkAnswer;

            do
            {
                userAnswer = Console.ReadLine();
                checkAnswer = int.TryParse(userAnswer, out number);
               

                if (checkAnswer == false)
                {
                    Console.WriteLine("Please enter a number for multiplication ");


                }
                
                else
                {
                    Console.WriteLine("Multiply 1 - 12");
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine(number * i);
                    }
                }
            } while (checkAnswer == false);

        }
    }
}
