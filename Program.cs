using System;
using System.Text.RegularExpressions;

namespace Task2_Sorting
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            RunSortingApplication(new QuickSortDescending());
        }

        static void RunSortingApplication(ISorter sorter)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Enter the Array: ");
                string strNumbers = Console.ReadLine();

                int[] intNumbers = ConvertInputToIntArray(strNumbers);

                if (intNumbers != null)
                {
                    
                    sorter.Sort(intNumbers);

                    Console.WriteLine("Sorted Array in Descending Order:");
                    PrintIntArray(intNumbers);

                }
                running = AskToContinue();
            }

            DisplayExitMessage();
        }

        static int[] ConvertInputToIntArray(string input)
        {
            input = input.Replace(" ", "");
            string[] strNumbers = input.Split(',');
            int[] intNumbers = new int[strNumbers.Length];

            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (!int.TryParse(strNumbers[i], out int number))
                {
                    DisplayErrorMessage("Input should only contain numbers.");
                    return null;
                }
                intNumbers[i] = number;
            }

            return intNumbers;
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }

        static bool AskToContinue()
        {
            Console.WriteLine("\nContinue sorting? Y (Yes)/ N (exit) ");
            string response = Console.ReadLine();
            return string.Equals(response, "Y", StringComparison.OrdinalIgnoreCase);
        }

        static void DisplayExitMessage()
        {
            Console.Write("Exiting application.");
        }

        static void DisplayErrorMessage(string message)
        {
            Console.WriteLine("Error: " + message);
        }

    }
}


