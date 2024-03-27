using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal sealed class MotorCycle<T> : TwoWheeler<T> where T : class
    {
        public string ModelNumber { get; set; }
        public string MakingYear { get; set; }
        public int NumberOfGear { get; set; }
        public string StartingMethod { get; set; }
        public string EngineCapacity { get; set; }
        public string MaximumPower { get; set; }
        public string MaximumTorque { get; set; }
        public string Mileage { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }
        public MotorCycle()
        {

        }
        public MotorCycle(string ModelNumber, string MakingYear, int NumberOfGear, string StartingMethod, string EngineCapacity, string MaximumPower, string MaximumTorque, string Mileage, string Cooling, string FrontBrake, string RearBrake) : base()
        {

            this.ModelNumber = ModelNumber;
            this.MakingYear = MakingYear;
            this.NumberOfGear = NumberOfGear;
            this.StartingMethod = StartingMethod;
            this.EngineCapacity = EngineCapacity;
            this.MaximumPower = MaximumPower;
            this.MaximumTorque = MaximumTorque;
            this.Mileage = Mileage;
            this.Cooling = Cooling;
            this.RearBrake = RearBrake;
            this.FrontBrake = FrontBrake;

        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Motor Cycle Information---------");
            Console.WriteLine($"Model Number:{this.ModelNumber}");
            Console.WriteLine($"Making Year:{this.MakingYear}");
            Console.WriteLine($"Number Of Gear:{this.NumberOfGear}");
            Console.WriteLine($"Start Method:{this.StartingMethod}");
            Console.WriteLine($"Engine Capacity in CC:{this.EngineCapacity}");
            Console.WriteLine($"Maximum Power in BPH:{this.MaximumPower}");
            Console.WriteLine($"Maximum Torque in NM:{this.MaximumTorque}");
            Console.WriteLine($"Mileage :{this.Mileage}");
            Console.WriteLine($"Cooling Type:{this.Cooling}");
            Console.WriteLine($"Front Brake:{this.FrontBrake}");
            Console.WriteLine($"Rear Brake:{this.RearBrake}");
            base.DisplayInfo();
        }
    }
}
