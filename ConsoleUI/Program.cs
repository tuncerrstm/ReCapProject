using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
        }

        private static void CarTest()
        {
            Console.WriteLine("CAR TEST:");
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("GetAll:");
            var resultGetAll = carManager.GetAll();
            if (resultGetAll.Success)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(resultGetAll.Message);
            }

            Console.WriteLine("GetById:");
            Console.WriteLine(carManager.GetById(1).Data.CarName);

            Console.WriteLine("GetCarsByBrandId:");
            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("GetCarsByColorId:");
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("GetCarsByDailyPrice:");
            var resultDailyPrice = carManager.GetCarsByDailyPrice(100, 300);
            if (resultDailyPrice.Success)
            {
                foreach (var car in resultDailyPrice.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(resultDailyPrice.Message);
            }

            Console.WriteLine("GetDetailsOfCars:");
            foreach (var car in carManager.GetDetailsOfCars().Data)
            {
                Console.WriteLine("Car Name: " + car.CarName + " - Brand Name: " + car.BrandName + " - Color Name:" + car.ColorName + " - Daily Price: " + car.DailyPrice);
            }

            Console.WriteLine("GetCarDetails:");
            Console.WriteLine("Car Name: " + carManager.GetCarDetails(1).Data.CarName + " - Brand Name: " + carManager.GetCarDetails(1).Data.BrandName + " - Color Name: " + carManager.GetCarDetails(1).Data.ColorName + " - Daily Price: " + carManager.GetCarDetails(1).Data.DailyPrice);

            Console.WriteLine("Add:");
            var resultAdd = carManager.Add(new Car { CarId = 6, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "x", ModelYear = 2016, CarName = "Araba66" });
            Console.WriteLine(resultAdd.Message);
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("Update:");
            var resultUpdate = carManager.Update(new Car { CarId = 6, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "x", ModelYear = 2016, CarName = "Araba6" });
            Console.WriteLine(resultUpdate.Message);
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("Delete:");
            var resultDelete = carManager.Delete(new Car { CarId = 6 });
            Console.WriteLine(resultDelete.Message);
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("Adding Process Fail:");
            Console.WriteLine(carManager.Add(new Car { CarId = 6, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "x", ModelYear = 2016, CarName = "A" }).Message);
        }

        private static void ColorTest()
        {
            Console.WriteLine("COLOR TEST:");
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("GetAll:");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            Console.WriteLine("GetById:");
            Console.WriteLine(colorManager.GetById(1).Data.ColorId + " " + colorManager.GetById(1).Data.ColorName);

            Console.WriteLine("Add:");
            var resultAdd = colorManager.Add(new Color { ColorId = 6, ColorName = "Lacivert" });
            Console.WriteLine(resultAdd.Message);
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            Console.WriteLine("Update:");
            var resultUpdate = colorManager.Update(new Color { ColorId = 6, ColorName = "Yeşil" });
            Console.WriteLine(resultUpdate.Message);
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            Console.WriteLine("Delete:");
            var resultDelete = colorManager.Delete(new Color { ColorId = 6 });
            Console.WriteLine(resultDelete.Message);
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
        }
    }
}
