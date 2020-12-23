using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System.Collections.Generic;

namespace Shop2.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName ="Электромобили", desc="Современный вид транспорта"},
                    new Category {categoryName ="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
