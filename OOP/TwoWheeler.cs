using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class TwoWheeler<T> : Vehicle, IEnumerable<T>, ITwoWheeler<T> where T : class
    {

        public List<T> ExteriorDesign { get; set; } = new List<T>();
        public TwoWheeler() : base()
        {
            base.VehicleType = VehicleType.TwoWheeler;
        }
        public virtual void AddExteriorDesign(params T[] ExteriorDesign)
        {
            this.ExteriorDesign.AddRange(ExteriorDesign);
        }


        public override void DisplayInfo()
        {
            foreach (var item in ExteriorDesign)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)ExteriorDesign).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)ExteriorDesign).GetEnumerator();
        }
    }
}
