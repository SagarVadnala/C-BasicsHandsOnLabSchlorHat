using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.ClassesForBuildingDiffTypesOfVehicles
{
    public class Bike
    {
        public static void BildBike()
        {
            Console.WriteLine("What Brand Bike Do You Want");
            string? Brand = Console.ReadLine();
            Console.WriteLine("What Color Bike Do you Want");
            string? Colour = Console.ReadLine();
            Console.WriteLine("What Engine Do You Want In Your Bike");
            string? Engine = Console.ReadLine();
            Console.WriteLine("What Brand Tires Do you Want In Your Bike");
            string? Tyre = Console.ReadLine();

            Console.WriteLine($"Below are the all specifications which you have selected:\n Brand:{Brand}\n Colour: {Colour}\n Engine: {Engine}\n Tyre; {Tyre}");
        }
    }
}
