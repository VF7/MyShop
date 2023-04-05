using MyShop.Data.Models;

namespace MyShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int CarId);
    }
}
