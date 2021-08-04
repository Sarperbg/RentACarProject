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
            Console.WriteLine("Markaya göre");
            var carsByBrand = carManager.GetCarsByBrandId(1);

            foreach (var car in carsByBrand)
            {
                Console.WriteLine(car.Id + " " + car.Description);
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
