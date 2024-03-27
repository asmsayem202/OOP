using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal sealed class Car<T> : FourWheeler<T> where T : class
    {
        public string ModelNumber { get; set; }
        public string MakingYear { get; set; }
        public int NumberOfSeat { get; set; }
        public int NumberOfDoor { get; set; }
        public string StartingMethod { get; set; }
        public string EngineCapacity { get; set; }
        public Car()
        {

        }
        public Car(string ModelNumber, string MakingYear, int NumberOfSeat, int NumberOfDoor, string StartingMethod, string EngineCapacity) : base()
        {

            this.ModelNumber = ModelNumber;
            this.MakingYear = MakingYear;
            this.NumberOfSeat = NumberOfSeat;
            this.NumberOfDoor = NumberOfDoor;
            this.StartingMethod = StartingMethod;
            this.EngineCapacity = EngineCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Car Information---------");
            Console.WriteLine($"Model Number:{this.ModelNumber}");
            Console.WriteLine($"Making Year:{this.MakingYear}");
            Console.WriteLine($"Number Of Seat:{this.NumberOfSeat}");
            Console.WriteLine($"Number Of Door:{this.NumberOfDoor}");
            Console.WriteLine($"Start Method:{this.StartingMethod}");
            Console.WriteLine($"Engine Capacity:{this.EngineCapacity}");
            base.DisplayInfo();
        }
    }
}
