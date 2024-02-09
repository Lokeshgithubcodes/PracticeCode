using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class RepeatedElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        Console.WriteLine("Repeated First Elements is " + arr[j]);
                        break;
                    }
                }
            }
        }
        public void secondlargest()
        {
            Console.WriteLine("Enter number of Elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            Console.WriteLine("Second Largest Element in the array is " + arr[arr.Length - 2]);

        }
    }
}
