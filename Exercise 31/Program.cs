using System;

namespace Exercise_31
{
    class Program
    {
        static void Main(string[] args)

        {
            bool exitCondition = true;
            while (exitCondition)
            {
                int[] intArray = { 2, 8, 0, 24, 51 };

                Console.WriteLine("Enter an index of the array");
                
                bool checkNumber = int.TryParse(Console.ReadLine(), out int indexOf); // check if user input is int
                
                if (indexOf <= intArray.Length - 1 && checkNumber)  // run if user input is valid
                {
                    Console.WriteLine($"The value at index {indexOf} is {intArray[indexOf]}");
                }
                
                else
                {
                    Console.WriteLine("That is not a valid index");
                }
                
                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit


                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false; // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }
        }

        
    }
}



