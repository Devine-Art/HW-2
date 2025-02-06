//Written by Arthur Devine
//On 2/5/2025

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace The_Magic_Cannon
{
    public class Program
    {
        static void Main(string[] args)
        {
            //variable to keep track of shots
            int shot = 0;

            //Loop to fire 100 shots
            while (shot <= 100)
            {
                //add one to shot count
                shot++;

                //check if double shot
                if (shot % 3 == 0 && shot % 5 == 0)
                {
                    //change color of text for double shot
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Beep();
                    Console.WriteLine("ELECTRIC & FIRE SHOT!");
                }

                //check if fire shot
                else if (shot % 3 == 0)
                {
                    //change color of text for double shot
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire Shot");
                }

                //check if electric shot
                else if (shot % 5 == 0)
                {
                    //change color of text for double shot
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric Shot");
                }

                //check if normal shot
                else if (shot % 3 != 0 && shot % 5 != 0)
                {
                    Console.ResetColor();
                    Console.WriteLine("Normal Shot");
                }
                Console.WriteLine(shot);
                Console.WriteLine("Press to fire next shot");
                Console.ReadLine();


            }
        }
    }
}