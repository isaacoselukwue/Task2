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
        public int GetHighestValue(List<MyTypes> list)
        {
            return list.Count > 0 ? list.Max(t => t.Age) : 0; //could also return -1
        }
        public void maxvalue()
        {
            List<int> primeNumbers = new List<int>();

            string elements = Console.ReadLine();
        }
    }
}
