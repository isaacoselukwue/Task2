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
            Console.Write("Enter a number btw 1 and 1000: ");
            int guessed = Convert.ToInt32(Console.ReadLine());
            Random myRandom = new Random();
            int num = myRandom.Next(1, 1000);
            while (guessed != num)
            {
                if (num > guessed)
                {
                    Console.WriteLine("too high");
                }
                else
                    Console.WriteLine("too low");
                Console.Write("Enter a number btw 1 and 1000: ");
                //break;
            }
            return random;
        }
    }
}
