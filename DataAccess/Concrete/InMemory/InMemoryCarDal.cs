using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,Description="Sedan Araç",ModelYear=2021,DailyPrice=250000},
                new Car{Id=2,BrandId=2,ColorId=1,Description="Suv Araç",ModelYear=2005,DailyPrice=10000},
                new Car{Id=3,BrandId=1,ColorId=2,Description="Hackpack Araç",ModelYear=2016,DailyPrice=150000},
                new Car{Id=4,BrandId=4,ColorId=3,Description="Klasik Araç",ModelYear=1980,DailyPrice=170000},
                new Car{Id=5,BrandId=3,ColorId=4,Description="Yük Aracı",ModelYear=1990,DailyPrice=70000},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(_carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();

        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
