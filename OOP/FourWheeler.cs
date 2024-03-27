using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class FourWheeler<T> : Vehicle, IEnumerable<T>, IFourWheeler<T> where T : class
    {

        public List<T> InteriorDesign { get; set; }
        public FourWheeler() : base(VehicleType.FourWheeler)
        {
            InteriorDesign = new List<T>();
        }

        public virtual void AddInteriorDesign(params T[] InteriorDesign)
        {
            this.InteriorDesign.AddRange(InteriorDesign);
        }


        public override void DisplayInfo()
        {
            foreach (var item in InteriorDesign)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)InteriorDesign).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)InteriorDesign).GetEnumerator();
        }

    }
}
