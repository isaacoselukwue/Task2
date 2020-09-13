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
    }
}
