using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 holder = new Class1();
            string temp;
            int numInt;
            double numDub;

            Console.WriteLine("Enter an integer");
            temp = Console.ReadLine();
            numInt = Convert.ToInt32(temp);
            numInt = Class1.Math1(numInt);
            Console.WriteLine(numInt);

            Console.WriteLine("Enter a decimal");
            temp = Console.ReadLine();
            numDub = Convert.ToDouble(temp);
            numInt = Class1.Math2(numDub);
            Console.WriteLine(numInt);

            Console.WriteLine("Enter a string!");
            temp = Console.ReadLine();
            numInt = Class1.Math3(temp);
            Console.WriteLine(numInt);

            Console.ReadLine();


        }
    }
}
