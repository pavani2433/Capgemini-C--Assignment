using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    using System;

    namespace CSharpAssignment
    {
        class Vehicle
        {
            public virtual void Start()
            {
                Console.WriteLine("The vehicle is starting...");
            }
        }

        class Car : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("The car starts with a key ignition.");
            }
        }

        class Bike : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("The bike starts with a self-start button.");
            }
        }

        class Program
        {
            static void Main()
            {
                Vehicle myVehicle1 = new Car();
                Vehicle myVehicle2 = new Bike();

                myVehicle1.Start();
                myVehicle2.Start();
            }
        }
    }
}
