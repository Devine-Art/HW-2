//Written by Arthur Devine
//On 2/5/2025

using System.ComponentModel.Design;

namespace The_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask user1 for variable and assign it
            Console.WriteLine("Pilot, Enter your # between 1-100");
            int Pilotnum = int.Parse(Console.ReadLine());

            //determine if valid
            while (Pilotnum <= 0 || Pilotnum >= 100)
            {
                //ask user1 for new variable and assign it
                Console.WriteLine("Pilot, Enter your # between 1-100");
                int Pilotnumre = int.Parse(Console.ReadLine());

                //determine if new variable is valid
                if (Pilotnumre >= 0 || Pilotnumre <= 100)
                {
                    Pilotnum = Pilotnumre;
                }
            }

            //clear console for user two
            Console.Clear();
            while (1 == 1)
            {
                //ask user2 for guess
                Console.WriteLine("Hunter, Enter your # between 1-100");
                int Hunternum = int.Parse(Console.ReadLine());

                //check if correct
                if (Pilotnum == Hunternum)
                {
                    Console.WriteLine("You got the #!");
                    break;
                }
                //check if lower
                if (Pilotnum > Hunternum)
                {
                    Console.WriteLine("Your # is too low");
                }
                //check if higher
                if (Pilotnum < Hunternum)
                {
                    Console.WriteLine("Your # is too high");
                }
            }
        }
    }
}