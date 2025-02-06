//Written by Arthur Devine
//On 2/5/2025

using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace The_Replicator_of_DTo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] orig_array = new int[5];
            int[] new_array = new int[5];
            
            //ask for 5 numbers to fill array
            Console.WriteLine("Enter #1");
            orig_array[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #2");
            orig_array[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #3");
            orig_array[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #4");
            orig_array[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter #5");
            orig_array[4] = int.Parse(Console.ReadLine());

            for (int index = 0; index < orig_array.Length; index++)
            {
                new_array[index] = orig_array[index];
            }

            Console.WriteLine();

            for (int index = 0; index < new_array.Length; index++)
            {
                Console.WriteLine(new_array[index]);
            }
        }
    }
}
