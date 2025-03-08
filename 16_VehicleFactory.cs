using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    public class Bike
    {
        public void Ride()
        {
            Console.WriteLine("Riding a bike.");
        }
    }

    public class VehicleFactory
    {
        public static object GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                return new Bike();
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter vehicle type (Car/Bike): ");
            string vehicleType = Console.ReadLine();

            try
            {
                var vehicle = VehicleFactory.GetVehicle(vehicleType);

                if (vehicle is Car)
                {
                    (vehicle as Car).Drive();
                }
                else if (vehicle is Bike)
                {
                    (vehicle as Bike).Ride();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
