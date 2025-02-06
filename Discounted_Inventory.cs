﻿//Written by Arthur Devine
//On 2/5/2025

using System.Reflection.PortableExecutable;
using System;

namespace Discounted_Inventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List products
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 – Rope");
            Console.WriteLine("2 – Torches");
            Console.WriteLine("3 – Climbing Equipment");
            Console.WriteLine("4 – Clean Water");
            Console.WriteLine("5 – Machete");
            Console.WriteLine("6 – Canoe");
            Console.WriteLine("7 – Food Supplies");

            //Assign variable to ask which product they want
            Console.WriteLine("Enter desired product #");
            int choice = int.Parse(Console.ReadLine());

            //Assign variable to ask name for potential discount
            Console.WriteLine("Enter your name");
            string name = (Console.ReadLine());

            if (name == "Arthur_Devine")
            {
                //initialize switch statement for discount
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Rope is 5 gold");
                        break;

                    case 2:
                        Console.WriteLine("Torches are 8 gold");
                        break;

                    case 3:
                        Console.WriteLine(" Climbing Equipment is 12 gold");
                        break;

                    case 4:
                        Console.WriteLine("Clean Water is 1 gold");
                        break;

                    case 5:
                        Console.WriteLine("Machete is 10 gold");
                        break;

                    case 6:
                        Console.WriteLine("Canoe is 100 gold");
                        break;

                    case 7:
                        Console.WriteLine("Food Supplies are 1 gold");
                        break;

                    default:
                        Console.WriteLine("Item does not exist");
                        break;
                }

                //Initialize switch statement for not discount
                if (name != "Arthur_Devine")
                {
                    //initialize switch statement for discount
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Rope is 10 gold");
                            break;

                        case 2:
                            Console.WriteLine("Torches are 16 gold");
                            break;

                        case 3:
                            Console.WriteLine(" Climbing Equipment is 24 gold");
                            break;

                        case 4:
                            Console.WriteLine("Clean Water is 2 gold");
                            break;

                        case 5:
                            Console.WriteLine("Machete is 20 gold");
                            break;

                        case 6:
                            Console.WriteLine("Canoe is 200 gold");
                            break;

                        case 7:
                            Console.WriteLine("Food Supplies are 2 gold");
                            break;

                        default:
                            Console.WriteLine("Item does not exist");
                            break;
                    }

                }
            }
        }
    }
}
