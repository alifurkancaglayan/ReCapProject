using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //AddCarTest();
            //AddColor();
            //AddBrand();
            //DeleteBrand();
            // DeleteColor();
            //DeleteCar();
            //UpdateCar();
            //UpdateBrand();
            //UpdateColor();
            //AddUser();
            //AddCustomer();
            //AddRental();
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }


        }
        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental {  CarId = 2, CustomerId = 1, RentDate = new DateTime(2022, 09, 15), ReturnDate = new DateTime(2022, 10, 15) };
            Rental rental2 = new Rental {  CarId = 3, CustomerId = 2, RentDate = new DateTime(2022, 08, 12), ReturnDate = new DateTime(2022, 09, 15) };

            rentalManager.Add(rental1);
            rentalManager.Add(rental2);
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            Customer customer1 = new Customer {  UserId = 1, CompanyName = "Ekermak" };
            Customer customer2 = new Customer {  UserId = 2, CompanyName = "Turkcell" };

            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user1 = new User {  FirstName = "Fatih", LastName = "Selvi",  Email= "fatih@gmail.com" };
            User user2 = new User {  FirstName = "Yiğit", LastName = "Akkuş", Email = "yigit@gmail.com" };

            userManager.Add(user1);
            userManager.Add(user2);
        }


        private static void UpdateColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 2, ColorName = "Kırmızı" });
        }

        private static void UpdateBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Isuzu" });
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 3, BrandId = 2, ModelYear = 2015, CarName = "Eski Araba", ColorId = 1, DailyPrice = 5000, Description = "Çok eski" });
        }

        private static void DeleteCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 1 });
        }

        private static void DeleteColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 3 });
        }

        private static void DeleteBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 1 });
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Honda" });
            brandManager.Add(new Brand { BrandName = "BMW" });
            brandManager.Add(new Brand { BrandName = "Mercedes" });
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Mavi" });
            colorManager.Add(new Color { ColorName = "Siyah" });
            colorManager.Add(new Color { ColorName = "Sarı" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName+"/"+car.BrandName+"/"+car.ColorName+"/"+car.DailyPrice);
            }
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarName = "Yeni Araba", BrandId = 2,ColorId = 1, DailyPrice = 50000, Description = "Çok yeni", ModelYear = 2022 });
            carManager.Add(new Car { CarName = "Eski Araba", BrandId = 2,ColorId = 2, DailyPrice = 20000, Description = "Çok eski", ModelYear = 1950 });
            carManager.Add(new Car { CarName = "Normal Araba", BrandId = 3,ColorId = 1, DailyPrice = 10000, Description = "çok normal", ModelYear = 2005 });
        }
    }
}
