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
            Console.ReadLine();
        }
        //public int GetHighestValue(List<MyTypes> list)
        //{
        //    return list.Count > 0 ? list.Max(t => t.Age) : 0; //could also return -1
        //}
        public void maxvalue()
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
    }
}
