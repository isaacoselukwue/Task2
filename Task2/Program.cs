using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {



            try
            {


                Task3 secondExercise = new Task3();
                Task4 thirdExercise = new Task4();
                Task5 fourthExercise = new Task5();
                Console.WriteLine("Hello!!!");
                Console.WriteLine("Welcome to my trial lessons");
                Console.WriteLine("For a function that returns the largest element in a list, enter [1]");
                Console.WriteLine("For a function that reverses a list of strings, enter [2]");
                Console.WriteLine("For a function that checks whether an element occurs in a list, enter [3]: ");
                Console.WriteLine("For a function returns the elements in odd positions in a list, enter [4]");
                Console.WriteLine("For a function returns the sum of elements in a list using a for loop, enter [5]");
                Console.WriteLine("For a function checks if a string is a palindrome, enter [6]");
                Console.WriteLine("For a function returns the sum of elements in a list using a while loop, enter [7]");
                Console.WriteLine("For a function returns the sum of elements in a list using a do while loop, enter [8]");
                Console.WriteLine("For a class that generates a random no between 1 and 10, enter [9] ");
                Console.WriteLine("For a class that converts digits(int) to word format(string), enter [10]");
                Console.WriteLine("For a Class that stores and retrieves names from a file, enter [11]");
                //string input = Console.ReadLine();
                bool run = true;
                while (run)
                {
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("This function returns the maximum value integer in the list: ");
                        maxvalue();

                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("This function reverses a list strings: ");
                        reversedString();
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("This function checks whether an element occurs in a list: ");
                        inplace();
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("This function returns the elements in odd positions in a list");
                        oddPosition();
                    }
                    else if (input == "5")
                    {
                        Console.WriteLine("This function reurns the sum of elements in a list. Uses a for loop");
                        calculateSum();
                    }
                    else if (input == "6")
                    {
                        Console.WriteLine("This function checks if a string is a palindrome");
                        isPalindrome();
                    }
                    else if (input == "7")
                    {
                        Console.WriteLine("This function reurns the sum of elements in a list. Uses a while loop");
                        CalculateSumWhileLoop();
                    }
                    else if (input == "8")
                    {
                        Console.WriteLine("This function reurns the sum of elements in a list. Uses a do while loop");
                        CalculateSumDoWhileLoop();
                    }
                    else if (input == "9")
                    {
                        Console.WriteLine("This function generates a random no between 1 and 10 ");
                        secondExercise.randomFuntion();
                    }
                    else if (input == "10")
                    {
                        Console.WriteLine("This Class converts digits(int) to word format(string)");
                        thirdExercise.wordConversion();
                    }
                    else if (input == "11")
                    {
                        Console.WriteLine("This Class stores and retrieves names from a file");
                        fourthExercise.textInput();
                    }
                    else
                    {
                        Console.WriteLine("Input unaccounted for");
                        //run = false;
                    }
                    break;
                }
            }
            catch (Exception e)
            {
                Console.Beep();
                Console.WriteLine("!!!Fatal Error!!! " + e.Message);

            }

            Console.ReadLine();
        }

        public static void maxvalue()
        {
            //a function that returns the largest element in a list.
            List<int> numSet = new List<int>();
            Console.Write("Enter No of Elements: ");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i< sizeOfList; i++)
            {
                Console.Write("Please enter a number: ");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //for list.size 
            int max = 0;
            foreach (int element in numSet)
            {
                if (max < element)
                {
                    max = element;
                }
            }
            Console.WriteLine($"The Largest Element in List is: {max}");

            //var max = numSet.Max();
            //Console.WriteLine($"The Largest Element in List is: {max}");
        }
        public static void reversedString()
        {
            List<string> stringSet = new List<string>();
            Console.Write("Enter No of Elements: ");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.Write("Please enter a text - ");
                stringSet.Add(Console.ReadLine());
            }
            int n = stringSet.Count;
            for (int i = 0; i < n/2; i++)
            {
                string newList = stringSet[i];
                stringSet[i] = stringSet[n - i - 1];
                stringSet[n - i - 1] = newList;
            }
            foreach (string item in stringSet)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(String.Join(stringSet));
            //numberStr = numberStr.Substring(1);
            //stringSet.Reverse();
            //foreach (string e in stringSet)
            //{
            //    Console.WriteLine(e);
            //}
        }
        public static void inplace() {
            //checks whether an element occurs in a list.
            List<string> stringSet = new List<string> { "Isaac", "Lucho", "Navaret" };
            Console.WriteLine("Enter A String: ");
            string doesExist = Console.ReadLine();

            //if (stringSet.Contains(doesExist) == true)
            //{
            //    Console.WriteLine($"The string {doesExist} is in the List: ");
            //}
            //else
            //{
            //    Console.WriteLine($"The String {doesExist} is not in the list");
            //}
            
            foreach (string item in stringSet)
            {
                if (item == doesExist)
                {
                    Console.WriteLine($"The string {doesExist} is in the List: ");
                    break;
                }
                else
                {
                    Console.WriteLine($"The String {doesExist} is not in the list");
                }
            }
        }
        public static void oddPosition()
        {
            //calculates the odd numbers in a list
            List<string> stringSet = new List<string>();
            //Console.Write("Enter No of Elements: ");
            //int sizeOfList = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < sizeOfList; i++)
            //{
            //    Console.Write("Please enter a text: ");
            //    stringSet.Add(Console.ReadLine());
            //}
            while (true)
            {
                if (stringSet.Contains("stop"))
                {
                    stringSet.Remove("stop");
                    break;
                }
                else
                {
                    Console.Write("Please enter a text(Enter -stop- when done): ");
                    stringSet.Add(Console.ReadLine());
                }
            }
            List<string> evens = new List<string>();
            int n = stringSet.Count;
            for (int i = 0; i < n; i+=2)
            {
                Console.WriteLine(stringSet[i]);               
            }
            
            //var odds = stringSet.Where((p, index) => index % 2 == 0);
            //Console.WriteLine("The numbers in odd position in the list are: ");
            //foreach (string item in evens)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine(" The bla is",odds);
        }
        public static void calculateSum()
        {
            //sum of elements in a list
            List<int> numSet = new List<int>();
            Console.Write("Enter No of Elements: ");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.Write("Please enter a number: ");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //int totalSum = numSet.Sum();
            int sum = 0;
            foreach (int element in numSet)
            {
                sum += element;
            }
            Console.WriteLine($"The sum of the numbers in the List is: {sum}");
            //Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
        }
        public static void isPalindrome()
        {
            //Method to check if there is a palindrome
            Console.WriteLine("Enter the string to check if its a palindrome");
            string num = Console.ReadLine();
            char[] test = num.ToCharArray();
            Array.Reverse(test);
            if (test.Equals(num))
            {
                Console.WriteLine("Its a palindrome");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        private static void CalculateSumWhileLoop()
        {
            //sum of elements in a list using while loop
            List<int> numSet = new List<int>();
            Console.Write("Enter No of Elements: ");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            int elements = 0;
            while (elements < sizeOfList)
            {
                Console.Write("Please enter a number: ");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
                elements++;
            }
            //int totalSum = numSet.Sum();
            //Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
            int sum = 0;
            foreach (int element in numSet)
            {
                sum += element;
            }
            Console.WriteLine($"The sum of the numbers in the List is: {sum}");
        }
        private static void CalculateSumDoWhileLoop()
        {
            //sum of elements in a list using a do while loop
            List<int> numSet = new List<int>();
            Console.Write("Enter No of Elements: ");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            int elements = 0;
            do
            {
                Console.Write("Please enter a number: ");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
                elements++;
            } while (elements < sizeOfList);
            //int totalSum = numSet.Sum();
            //Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
            int sum = 0;
            foreach (int element in numSet)
            {
                sum += element;
            }
            Console.WriteLine($"The sum of the numbers in the List is: {sum}");
        }
    }
}
