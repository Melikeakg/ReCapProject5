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
            //CarTest();

            //ColorTest();

            //BrandTest();

            //UserTest();
            //RentalTest();
            CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { CompanyName = "A.Ş", UserId = 2 });
            var result = customerManager.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CustomerId + " " + customer.CompanyName );
                }
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { CustomerId = 1, RentalId = 2, RentDate = DateTime.Now});
            
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rent in result.Data)
                {
                    Console.WriteLine( rent.RentDate + " " + rent.RentalId);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { FirstName = "Ali", LastName = "Karadağ", Email = "a@gmail.com", Password = "1245" });
            var result = userManager.GetAll();
            if (result.Success)
            { 
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 250, Description = "Tucson", ModelYear = 2012 });

            var result = carManager.GetCarDeatils();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
