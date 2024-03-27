using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Car<string> car = new Car<string>("BMW", "2023", 4, 4, "Auto", "2500CC"))
            {

                car.AddInteriorDesign("Color: Red", "Seat Color: Brown", "Driver position: Right");
                Console.WriteLine();
                car.DisplayInfo();
            }


            Console.WriteLine();

            using (MotorCycle<string> motorCycle = new MotorCycle<string>("Yamaha", "2022", 6, "Self Start", "250CC", "20BPH", "8000NM", "30 mpl", "Water Cooled", "ABS", "ABS"))
            {

                motorCycle.AddExteriorDesign("Color: Blue", "Headlight: LED", "Meter: Digital");

                motorCycle.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}
