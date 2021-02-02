using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1 ,BrandId=1, ColorId=1, ModelYear=2012, DailyPrice=440000, Description="Mercedes"},
                new Car {Id=2 ,BrandId=2, ColorId=2, ModelYear=2002, DailyPrice=143500, Description="Opel"},
                new Car {Id=3 ,BrandId=3, ColorId=4, ModelYear=2017, DailyPrice=124000, Description="Ford"},
                new Car {Id=4 ,BrandId=4, ColorId=2, ModelYear=2021, DailyPrice=660000, Description="Audi"},
                new Car {Id=5 ,BrandId=3, ColorId=1, ModelYear=2009, DailyPrice=214000, Description="Toyota"},
                new Car {Id=6 ,BrandId=1, ColorId=3, ModelYear=2004, DailyPrice=96000, Description="Lexus"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
