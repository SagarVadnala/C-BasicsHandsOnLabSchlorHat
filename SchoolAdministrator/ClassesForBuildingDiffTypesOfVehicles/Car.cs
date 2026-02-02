using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.ClassesForBuildingDiffTypesOfVehicles
{
    public class Car
    {
        public static void BildCar()
        {
            Console.WriteLine("What Brand Car Do You Want");
            string? Brand = Console.ReadLine();
            Console.WriteLine("What Color Bike Do you Want");
            string? Colour = Console.ReadLine();
            Console.WriteLine("What Engine Do You Want In Your car");
            string? Engine = Console.ReadLine();
            Console.WriteLine("What Brand Tires Do you Want In Your car");
            string? Tyre = Console.ReadLine();

            Console.WriteLine($"Below are the all specifications which you have selected: /n Brand:{Brand}. /n Colour: {Colour} /n Engine: {Engine} /n Tyre; {Tyre}");
        }
    }
}
