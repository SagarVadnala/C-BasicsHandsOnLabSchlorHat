using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.ClassesForBuildingDiffTypesOfVehicles
{
    public class SwitchClass
    {
        public void switchCases()
        {
            Console.WriteLine("Select the Vechile you want to buy:");

            String? vehicle ="";

            while (true) //Is to make user select the correct option until they do so.
            {

                Console.WriteLine("Below is the stock ehich is available : Car,Bike,Truck");
                vehicle = Console.ReadLine();
                switch (vehicle)
                {
                    case "Car":
                        Console.WriteLine("You have selected Car.");
                        Car.BildCar();
                        break;
                    case "Bike":
                        Console.WriteLine("You have selected Bike.");
                        Bike.BildBike();
                        break;
                    case "Truck":
                        Console.WriteLine("You have selected Truck.");
                        Truck.BildTruck();
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please choose Car, Bike, or Truck.");

                        continue;
                }
                break;
            }
        }
          
    }
}
