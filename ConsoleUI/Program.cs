using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 3, ColorId = 3, DailyPrice = 175, Description = "Mercedes", ModelYear = 2010 });



            foreach (var cars in carManager.GetCarDeatils())
            {
                Console.WriteLine(cars.CarName + " - " + cars.DailyPrice + " - " + cars.ColorName + " - " + cars.BrandName);
            }

            //Car car = new Car
            //{
            //    BrandId = 1,
            //    ColorId = 1,
            //    DailyPrice = 150,
            //    Description = "s",
            //    ModelYear = 2015
            //};

            //carManager.Add(new Car { BrandId = 2, DailyPrice = 200, ColorId = 3, Description = "Audi", ModelYear = 2010 });


            //carManager.Add(car);

            //carManager.Add(new Car { BrandId=1, ColorId=3, DailyPrice=175, Description="BMW 3.20" , ModelYear=2017 });

        }

    }
}
