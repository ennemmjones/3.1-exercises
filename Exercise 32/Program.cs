using System;

namespace Exercise_32
{
    class Program
    {
        static void Main(string[] args)

        {
            bool exitCondition = true;
            while (exitCondition)
            {
                int[] intArray = { 2, 8, 0, 24, 51 };
                bool indexExists = false;
                int index = 0;

                Console.WriteLine("Enter a number");
                bool checkNumber = int.TryParse(Console.ReadLine(), out int valueOf); // check if user input is int
                
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (valueOf == intArray[i])
                    {
                        indexExists = true; // if valueOf is in intArray then it's index exists
                        index = i;  // set index of valueOf
                        break;  // exit for loop 
                    }
                   
                }
                if (indexExists && checkNumber) // true if user input is an int and in intArray
                {
                    Console.WriteLine($"The value {valueOf} can be found at index {index}");
                }
                
                else 
                {
                    Console.WriteLine("The value cannot be found in the array");
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
