using System;
using System.Data;

namespace Canada
{
    class Naanu
    {
        static void Main(string[] args)
        {
            int x = 4;
            int[] arr = new int[x];
            Console.WriteLine("Enter " + x + " numbers of elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Evennumbs = 0;
            int OddNumbs = 0;
            foreach (int j in arr)
            {
                if (j % 2 == 0) { Evennumbs++; }
                else { OddNumbs++; }
            }

            int[][] jarr = new int[2][];
            jarr[0] = new int[Evennumbs];
            jarr[1] = new int[OddNumbs];

            int evenindex = 0;
            int oddindex = 0;

            foreach (int q in arr)
            {
                if (q % 2 == 0) { jarr[0][evenindex++] = q; }
                else { jarr[1][oddindex++] = q; }
            }
            foreach (int d in jarr[0])
            {
                Console.WriteLine("Even Number: " + d);
            }
            foreach (int d in jarr[1])
            {
                Console.WriteLine("Odd number: " + d);
            }

        }
    }
}