using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task3
    {
        //random no game
        public string MyProperty(string random) {
            Console.Write("Guess a number between 1 and 10: ");
            int guessed = 0;
            Random myRandom = new Random();
            int num = myRandom.Next(1, 10);
            while (guessed != num)
            {
                Console.WriteLine("Guess the number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (num < input)
                {
                    Console.WriteLine("too high");
                }
                else if (num > input)
                {
                    Console.WriteLine("too low");
                }
                else
                {
                    Console.WriteLine("correct");
                    break;
                }
            }
            return random;
        }
    }
    class Task4
    {
        public string wordnos(string num) {
            int number = 0;
            Console.WriteLine("Enter a number");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine($"Num is: {numberToWord(number)}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Enter an integer: ");
                throw;
            }
            return num;
        }
        public string numberToWord(int number) {
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
                // convert the number to a string
                String numberStr = "" + number;
                // remove minus before the number 
                numberStr = numberStr.Substring(1);
                // add minus before the number and convert the rest of number 
                return "minus " + numberToWord(Convert.ToInt32(numberStr));
            }
            // check if number is divisible by 1 million
            if ((number / 1000000) > 0)
            {
                words += numberToWord(number / 1000000) + " million ";
                number %= 1000000;
            }
            // check if number is divisible by 1 thousand
            if ((number / 1000) > 0)
            {
                words += numberToWord(number / 1000) + " thousand ";
                number %= 1000;
            }
            // check if number is divisible by 1 hundred
            if ((number / 100) > 0)
            {
                words += numberToWord(number / 100) + " hundred and ";
                number %= 100;
            }

            if (number > 0)
            {
                // check if number is within teens
                if (number < 20)
                {
                    // fetch the appropriate value from unit array
                    words += unitList[number];
                }
                else
                {
                    // fetch the appropriate value from tens array
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
