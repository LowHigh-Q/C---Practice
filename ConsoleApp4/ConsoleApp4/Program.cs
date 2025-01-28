using System;

public class Program
{
    public static void Main(string[] args)
    {
        int laastind = 0;
        int[] aarr = new int[4];
        Console.WriteLine("Enter 4 numbers probably with zeros also:");
        for (int i = 0; i < aarr.Length; i++)
        {
            aarr[i] = Convert.ToInt32(Console.ReadLine());
        }
        //1 0 2 5
        //0 1 2 3 -> i
        //0 1 1 2 -> laastind++( after post increment)
        for (int i = 0;i < aarr.Length; i++)
        {
            if (aarr[i] != 0)
            {
                int temp = aarr[laastind]; // 1 - 0 - 
                aarr[laastind] = aarr[i]; // 1 - 2
                aarr[i] = temp; // 1 - 0
                laastind++; // 0 -> 1 ->2 

            }
        }
        for (int i= 0;i < aarr.Length;i++)
        {
            Console.WriteLine(aarr[i]);
        }
    }
}