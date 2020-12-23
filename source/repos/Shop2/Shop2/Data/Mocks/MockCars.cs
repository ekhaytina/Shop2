using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop2.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {name="Auto1", desc="описание",img="/img/1000.jpg",price=45000,available=true,Category=_categoryCars.AllCategories.First()},
                    new Car {name="Auto2", desc="описание",img="/img/2000.jpg",price=45100,available=false,Category=_categoryCars.AllCategories.Last()},
                    new Car {name="Auto3", desc="описание",img="/img/3000.jpg",price=4000,available=true,Category=_categoryCars.AllCategories.First()},
                    new Car {name="Auto4", desc="описание",img="/img/4000.jpg",price=4500,available=true,Category=_categoryCars.AllCategories.First()},
                    new Car {name="Auto5", desc="описание",img="/img/5000.jpg",price=60000,available=true,Category=_categoryCars.AllCategories.Last()}
                };
            }
        }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
