using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //            carManager.Add(new Car { Description = "Güzel Araç", BrandId = 1, ColorId = 2, DailyPrice = 110, ModelYear = 2002 });
            //            carManager.Add(new Car { Description = "Fantastik, doktordan bir araç", BrandId = 1, ColorId = 1, DailyPrice = 600, ModelYear = 2021 }
            //);
            //            carManager.Add(new Car { Description = "Tertemiz elektrikli bir araç", BrandId = 2, ColorId = 1, DailyPrice = 200, ModelYear = 2014 });


            Console.WriteLine("Markaya göre");
            Console.WriteLine("------");
            var carsByBrand = carManager.GetCarsByBrandId(1);
            foreach (var car in carsByBrand)
            {
                Console.WriteLine("Marka Id"+car.Id + "Günlük Ücret" +car.DailyPrice + car.Description);
            }
            Console.WriteLine("Renge göre");
            var carsByColorId = carManager.GetCarsByColorId(1);
            foreach (var car in carsByColorId)
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }
            

        }
    }
}
