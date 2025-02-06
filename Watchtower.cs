//Written by Arthur Devine
//On 2/5/2025

namespace Watchtower
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask user for variable and assign them
            Console.WriteLine("Enter X value");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y value");
            double Y = double.Parse(Console.ReadLine());

            //statements to determine output

            if (X < 0)
            {
                // Sets of Y for X less than 0
                if (Y > 0)
                {
                    Console.WriteLine("Enemy approaching from NW!");
                }
                if (Y == 0)
                {
                    Console.WriteLine("Enemy approaching from W!");
                }
                if (Y < 0)
                {
                    Console.WriteLine("Enemy approaching from SW!");
                }
            }

            if (X == 0)
            {
                // Sets of Y for X equal 0
                if (Y > 0)
                {
                    Console.WriteLine("Enemy approaching from N!");
                }
                if (Y == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Beep();
                    Console.WriteLine("ENEMY IS HERE!!!");
                    Console.ResetColor();
                }
                if (Y < 0)
                {
                    Console.WriteLine("Enemy approaching from S!");
                }
            }

            if (X > 0)
            {
                // Sets of Y for X greater than 0
                if (Y > 0)
                {
                    Console.WriteLine("Enemy approaching from NE!");
                }
                if (Y == 0)
                {
                    Console.WriteLine("Enemy approaching from E!");
                }
                if (Y < 0)
                {
                    Console.WriteLine("Enemy approaching from SE!");
                }
            }
        }
    }
}
