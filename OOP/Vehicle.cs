using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
        public enum VehicleType
        {
            TwoWheeler,
            FourWheeler
        }
        internal abstract class Vehicle : IDisposable
        {
            public VehicleType VehicleType { get; set; }

            public Vehicle()
            {
            }

            public Vehicle(VehicleType vehicleType)
            {
                this.VehicleType = vehicleType;
            }

            public abstract void DisplayInfo();


            public virtual void Dispose() { }
        }
    }

