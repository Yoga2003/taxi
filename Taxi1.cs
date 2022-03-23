using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriveName = "Yoga";
            taxi.OnDuty = true;
            taxi.Numpassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassengger();

            Console.ReadKey();
        }
    }
}
