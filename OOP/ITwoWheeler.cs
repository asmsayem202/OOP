using System.Collections.Generic;

namespace OOP
{
    internal interface ITwoWheeler<T> where T : class
    {
        List<T> ExteriorDesign { get; set; }

        void AddExteriorDesign(params T[] ExteriorDesign);
        void DisplayInfo();
        IEnumerator<T> GetEnumerator();
    }
}