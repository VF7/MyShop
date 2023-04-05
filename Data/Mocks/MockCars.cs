using MyShop.Data.Interfaces;
using MyShop.Data.Models;

namespace MyShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car>{
                    new Car{
                        Name = "Tesla Model X", 
                        ShortDescription = "Шустрий автомобіль", 
                        LongDescription = "Сучасний, швидкий, екологічний, тяговитий, тихий автомобіль від компанії Тесла", 
                        Image = "https://teslaone.com.ua/img/tesla-x/options-pic-6.jpg", 
                        Price = 55000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car{
                        Name = "BMW X5",
                        ShortDescription = "X5",
                        LongDescription = "BMW X5 комфорт, шикарне керування",
                        Image = "https://www.bmw.ua/content/dam/bmw/common/all-models/x-series/x5/2021/highlights/bmw-x5-onepager-mc-new-edition-hero-desktop.jpg/jcr:content/renditions/cq5dam.resized.img.1680.large.time1660301981118.jpg",
                        Price = 99000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<Car> GetFavCars { get ; set; }

        public Car GetObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
