using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX test
            //Console.WriteLine("Hello World!!!");

            ///////////////////////////////////////////////////////

            // EX 4
            //Console.Write("Enter you Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello {0}, I hope you are feeling well.", name);

            ///////////////////////////////////////////////////////

            // Ex 1.2
            Console.WriteLine();

            Console.Write("Enter your age (I promise not to tell anyone): ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("if your birthday is after {0}", DateTime.Now);
            Console.WriteLine("you will be {0} later this year.", age + 1);
            Console.WriteLine("you will be {0} later until year.", age);

            ///////////////////////////////////////////////////////


        }
    }
}
