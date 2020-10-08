using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task3
    {
        //random no game
        public void randomFuntion() {
            Console.Write("Guess a number between 1 and 10: ");
            int guessed = 0;
            Random myRandom = new Random();
            int num = myRandom.Next(1, 10);
            while (guessed != num)
            {
                Console.Write("Guess the number: ");
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
        }
    }
    class Task4
    {
        public void wordConversion()
        {
            int number = 0;
            Console.WriteLine("Enter a number");

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
        private string numberToWord(int number) {
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
    class Task5
    {
        //storing student name to txt
        public void textInput()
        {
            Console.WriteLine("Enter 1 to wrte to file and 2 to read from file");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ReadLine();
                    break;
                case "2":
                    PrintOut();
                    break;
                default:
                    break;
            }
        }
        public string GetLine(string fileName, string searchingKey)
        {
            {
                //for (int i = 1; i < line; i++)
                //    ssr.ReadLine();
                string line = null;
                using (StreamReader ssr = new StreamReader(@"C:\\Users\\princ\\Downloads\\student.txt"))
                {
                    while ((line = ssr.ReadLine()) != null)
                    {
                        if (line.Contains(searchingKey))
                        {
                            return line;
                        }
                        else if (line.Contains(searchingKey) == true)
                        {
                            Console.WriteLine("impossible");
                            break;
                            //return "Sorry student profile not found";
                            
                        }
 
                    }
                    return "";
                    //foreach (int item in ssr.ReadToEnd())
                    //{
                    //    if (item.CompareTo(Convert.ToInt32(line)) == 0)
                    //    {
                    //        return ssr.ReadLine();
                    //    }
                    //    else
                    //    {
                    //        return "error";
                    //    }
                    //}
                    //return "done";
                }
            }
        }
                   
        
        private void ReadLine() {
            StreamWriter sw = new StreamWriter("C:\\Users\\princ\\Downloads\\student.txt", true);
            Console.WriteLine("Number of Students you want to register: ");
            int studentNo = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("StudentID\tStudentName");
            while (studentNo != 0)
            {
                Console.WriteLine("Enter Students Number: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter students Name: ");
                string number = Console.ReadLine();
                var lines = number + "\t" + name;
                //System.IO.File.WriteAllText(@"C:\Users\princ\Downloads\student.txt", lines);
                sw.WriteLine(lines);
                studentNo--;
            }
            //Console.WriteLine("Enter Students Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter students Number: ");
            //string number = Console.ReadLine();
            //var lines = name + " " + number;
            //System.IO.File.WriteAllText(@"C:\Users\princ\Downloads\student.txt", lines);
            //sw.WriteLine(lines);
            sw.Close();

        }
        private void PrintOut()
        {
            Console.Write("Enter the mat no: ");
            string matricno = Console.ReadLine();
            string line1 = GetLine(@"C:\\Users\\princ\\Downloads\\student.txt", matricno);
            Console.WriteLine(line1);//line by line
                                     //string text = File.ReadAllText(@"C:\\Users\\princ\\Downloads\\student.txt");

            //// Display the file contents to the console. Variable text is a string.
            //Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
    class HelperMethod
    {
        public int MaxSize(List<int> stringSet) {
            int max = 0;
            foreach (int element in stringSet)
            {
                if (max < element)
                {
                    max = element;
                }
            }
            
            return max;
        }
        public int Sum(List<int> stringSet)
        {
            int sum = 0;
            foreach (int element in stringSet)
            {
                sum += element;
            }
            return sum;
        }
    }

    public class StudentDetails
    {
        public string Name { get; set; }
        public int MatNo { get; set; }
        public StudentDetails(string name, int matNo)
        {
            Name = name;
            MatNo = matNo;
        }
        // Other properties, methods, events...
    }

    class UniversityList
    {
        private void NewMain()
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\princ\\Downloads\\student.txt", true);
            Console.WriteLine("Number of Students you want to register: ");
            int studentNo = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("StudentID\tStudentName");
            while (studentNo != 0)
            {

                Console.WriteLine("Enter Students Number: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter students Name: ");
                string number = Console.ReadLine();
                StudentDetails person1 = new StudentDetails(name, Convert.ToInt32(number));
                //var lines = number + "\t" + name;
                //System.IO.File.WriteAllText(@"C:\Users\princ\Downloads\student.txt", lines);
                sw.WriteLine(person1);
                studentNo--;
            }
            
        }
    }

}
