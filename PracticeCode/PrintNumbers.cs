using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class PrintNumbers
    {
        public void printnumber()
        {
            print(1, 101);
        }

        static void print(int start, int end)
        {
            if (start < end)
            {
                Console.Write(" " + start);
                print(start + 1, end);
            }
        }
    }

    public class Hello
    {
        //Console.WriteLine("Hello world");
    }
}
