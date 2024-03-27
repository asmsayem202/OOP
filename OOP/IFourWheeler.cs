using System.Collections.Generic;

namespace OOP
{
    internal interface IFourWheeler<T> where T : class
    {
        List<T> InteriorDesign { get; set; }

        void AddInteriorDesign(params T[] InteriorDesign);
        void DisplayInfo();
        IEnumerator<T> GetEnumerator();
    }
}