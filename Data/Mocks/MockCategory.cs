using MyShop.Data.Interfaces;
using MyShop.Data.Models;

namespace MyShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Електромобілі", Description = "Сучасний вид транспорту"},
                    new Category{CategoryName = "Класичні автомобілі", Description = "Автомобілі з ДВЗ"}
                };
            }
        }
    }
}
