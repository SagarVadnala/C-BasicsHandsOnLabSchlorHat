using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.ClassesForBuildingDiffTypesOfVehicles
{
    public class Truck
    {
        public static void BildTruck()
        {
            Console.WriteLine("What Brand Truck Do You Want");
            string? Brand = Console.ReadLine();
            Console.WriteLine("What Color Truck Do you Want");
            string? Colour = Console.ReadLine();
            Console.WriteLine("What Engine Do You Want In Your Truck");
            string? Engine = Console.ReadLine();
            Console.WriteLine("What Brand Tires Do you Want In Your Truck");
            string? Tyre = Console.ReadLine();

         Console.WriteLine($"Below are the all specifications which you have selected: \n Brand:{Brand}. \n Colour: {Colour} \n Engine: {Engine} \n Tyre; {Tyre}");

        }
    }
}
