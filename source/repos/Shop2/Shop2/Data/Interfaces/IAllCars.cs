using Shop2.Data.Models;
using System.Collections.Generic;

namespace Shop2.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }

        Car getObjectCar(int carID);
    }
}
