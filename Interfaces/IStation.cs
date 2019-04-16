using System.Collections.Generic;

namespace garys_generics
{
    public interface IStation<T>
    {
        int Capacity {get; set;}

        void Refuel(List<T> vehicles);
    }
}
