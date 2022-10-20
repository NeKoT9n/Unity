using System.Collections.Generic;
using WEB.Data.Models;

namespace WEB.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        Car GetCar(int carID);
    }
}