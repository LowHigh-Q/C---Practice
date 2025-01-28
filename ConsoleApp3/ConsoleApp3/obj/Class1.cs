using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.obj
{
    public class Class1
    {
        static void zerotohero(string[] args)
        {
            Console.WriteLine("Enter the size the array: ");
            int n = Convert.ToInt32(Console.Read());
            int[] arr = new int[n];
            int lastIndex = 0;
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[lastIndex];
                    arr[lastIndex] = arr[i];
                    arr[i] = temp;
                    lastIndex++;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
       //int temp = arr[lastNonZeroFoundAt];
        //arr[lastNonZeroFoundAt] = arr[i];
        //        arr[i] = temp;