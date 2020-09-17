using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Guess a number between 1 and 10: ");
            //int guessed = 0;
            //Random myRandom = new Random();
            //int num = myRandom.Next(1, 10);
            //while (guessed != num)
            //{
            //    Console.WriteLine("Guess the number: ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (num < input)
            //    {
            //        Console.WriteLine("too high");
            //    }
            //    else if (num > input)
            //    {
            //        Console.WriteLine("too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("correct");
            //        break;
            //    }
            //}

            //int number = 0;
            //Console.WriteLine("Enter a number");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
            //    if (number == 0)
            //    {
            //        Console.WriteLine("Zero");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Num is: {numberToWord(number)}");
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Enter an integer: ");
            //    throw;
            //}
            string input = Console.ReadLine();
            bool run = true;
            while (run)
            {
                if (input == "1")
                {
                    maxvalue();
                }
            }

            Console.ReadLine();
        }
        //public int GetHighestValue(List<MyTypes> list)
        //{
        //    return list.Count > 0 ? list.Max(t => t.Age) : 0; //could also return -1
        //}
        public static void maxvalue()
        {
            //a function that returns the largest element in a list.
            List<int> numSet = new List<int>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i< sizeOfList; i++)
            {
                Console.WriteLine("Please enter a number");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var max = numSet.Max();
            Console.WriteLine($"The Largest Element in List is: {max}");
        }
        public string reversedString(string Set)
        {
            List<string> stringSet = new List<string>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.WriteLine("Please enter a text");
                stringSet.Add(Console.ReadLine());
            }
            stringSet.Reverse();
            Console.WriteLine();
            foreach (string dinosaur in stringSet)
            {
                Console.WriteLine(dinosaur);
            }

            Console.ReadLine();
            return Set;
        }
        public string inplace(string sentence) {
            //checks whether an element occurs in a list.
            List<string> stringSet = new List<string> { "Isaac", "Lucho", "Navaret" };
            Console.WriteLine("Enter A String: ");
            string doesExist = Console.ReadLine();

            if (stringSet.Contains(doesExist) == true)
            {
                Console.WriteLine($"The string {doesExist} is in the List: ");
            }
            else
            {
                Console.WriteLine($"The String {doesExist} is not in the list");
            }
            return sentence;
        }
        public string oddPosition(string oddNum)
        {
            //calculates the odd numbers in a list
            List<string> stringSet = new List<string>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.WriteLine("Please enter a text");
                stringSet.Add(Console.ReadLine());
            }
            var odds = stringSet.Where((p, index) => index % 2 == 0);
            Console.WriteLine("The numbers in odd position in the list are: ");
            foreach (string item in odds)
            {
                Console.WriteLine($"{item} ");
            }
            //Console.WriteLine(" The bla is",odds);
            return oddNum;
        }
        public int calculateSum(int numSum)
        {
            //sum of elements in a list
            List<int> numSet = new List<int>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.WriteLine("Please enter a number");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int totalSum = numSet.Sum();
            Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
            return numSum;
        }
        public string isPalindrome(string input)
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

            return input;
        }
        public int calculateSumWhileLoop(int numSum)
        {
            //sum of elements in a list using while loop
            List<int> numSet = new List<int>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            int elements = 0;
            while (elements < sizeOfList)
            {
                Console.WriteLine("Please enter a number");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
                elements++;
            }
            int totalSum = numSet.Sum();
            Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
            return numSum;
        }
        public int calculateSumDoWhileLoop(int numSum)
        {
            //sum of elements in a list using while loop
            List<int> numSet = new List<int>();
            Console.WriteLine("Enter No of Elements");
            int sizeOfList = Convert.ToInt32(Console.ReadLine());
            int elements = 0;
            do
            {
                Console.WriteLine("Please enter a number");
                numSet.Add(Convert.ToInt32(Console.ReadLine()));
                elements++;
            } while (elements < sizeOfList);
            int totalSum = numSet.Sum();
            Console.WriteLine($"The sum of the numbers in the List is: {totalSum}");
            return numSum;
        }
        public static string numberToWord(int number)
        {
            string words = "";
            List<string> unitList = new List<string> { "zero", "one", "two", "three", "four", "five", "six",
                      "seven", "eight", "nine", "ten", "eleven", "twelve",
                      "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                      "eighteen", "nineteen"};
            List<string> tensList = new List<string> { "zero", "ten", "twenty", "thirty", "forty", "fifty",
                      "sixty", "seventy", "eighty", "ninety" };

            if (number == 0)
            {
                return "zero";
            }

            if (number < 0)
            {
                String numberStr = "" + number; 
                numberStr = numberStr.Substring(1);
                return "minus " + numberToWord(Convert.ToInt32(numberStr));
            }
            if ((number / 1000000) > 0)
            {
                words += numberToWord(number / 1000000) + " million ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += numberToWord(number / 1000) + " thousand ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += numberToWord(number / 100) + " hundred and ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                {
                    words += unitList[number];
                }
                else
                {
                    words += tensList[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + unitList[number % 10];
                    }
                }
            }
            return words;
        }
    }
}
