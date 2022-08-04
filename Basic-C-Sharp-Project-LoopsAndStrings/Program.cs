using System;

namespace Basic_C_Sharp_Project_LoopsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number 0-9! (You have 3 chances!!!)");
            int number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            bool win = number == 1;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("Your gess was correct, the winning number is: " + 1);
                        win = true;
                        break;
                    default:
                        Console.WriteLine("\n");

                        Console.WriteLine("Try again");
                        counter++;
                        if (counter == 3)
                        {
                            Console.WriteLine("\n");

                            Console.WriteLine("You run our of the guesses, good luck next time!");
                        }
                        break;
                }
            }
            while (counter < 3 && !win);
            {
                Console.WriteLine(3 - counter + " chances!!!)");


                if (counter > 0)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");




            }


        }
    }
}
