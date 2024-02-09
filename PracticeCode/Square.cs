using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class Square
    {
        public void square()
        {
            Console.WriteLine("Enter First Number");
            Double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            Double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Sum Of Square Of given two numbers are");
            Console.WriteLine(a * a + b * b);
            Console.WriteLine("Differnece of Square of given two numbers are");
            Console.WriteLine(a * a - b * b);

            Console.WriteLine("Enter a String");
            string d = Console.ReadLine();
            string repeatedString = string.Concat(Enumerable.Repeat(d + " ", 10));

            Console.WriteLine(repeatedString);

        }
    }
}
