using System;
using System.Collections.Generic;
using System.Linq;

namespace Par_progUke4
{
    public class CarShop
    {
        private List<Car> _cars;

        public CarShop()
        {
            _cars = new List<Car>()
            {
                new Car(1,"Ford","Kuga",2020,"BR32452",24000),
                new Car(2,"Toyota","Camry",2021,"BR32968",12000),
                new Car(3,"Subaru","Forester",2022,"HH32232",14000),
                new Car(4,"Ford","Focus",2023,"BR87452",4000),
                new Car(5,"Subaru","Impreza",2024,"BR32489",2000),
            };
            ShopMenu();
        }

        public void ShopMenu()
        {


            {
                Console.WriteLine("Welcome to the Car Shop!");
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Show all cars");
                Console.WriteLine("2. Show all cars by year");
                Console.WriteLine("3. Show all cars by kilometers");
                Console.WriteLine("4. Exit from menu");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input.");
                    ShopMenu();
                }

                switch (choice)
                {
                    case 1:
                        ShowAllCars();
                        Car car1 = SelectCar();
                        BuyCar(car1);
                        break;
                    case 2:
                        CarYear();
                        Car car2 = SelectCar();
                        BuyCar(car2);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        public void ShowAllCars()
        {
            foreach (var car in _cars)
            {
                Console.WriteLine($"Car Id:{car.CarId}  {car.Brand} {car.Model} {car.Year}");
            }
        }

        public void BuyCar(Car car)
        {
            if (car != null)
            {
                _cars.Remove(car);
                Console.WriteLine($"You have bought {car.Brand} {car.Model}");
            }
            else
            {
                Console.WriteLine("Unavailable for sale");
            }
        }

        public void CarYear()
        {
            Console.WriteLine("Write in a year between 2020 and 2024");
            int startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Write in maximum age of the car (max 2024)");
            int lastYear = int.Parse(Console.ReadLine());
            
            if (startYear < 2022 || startYear > 2024 || lastYear < 2020 || lastYear > 2024)
            {
                Console.WriteLine("No cars found with that age range");
                ShopMenu();
            }
            
            

            var carsYearOverview = _cars.Where(car => car.Year >= startYear && car.Year <= lastYear).ToList();
            foreach (var car in carsYearOverview)
            {
                Console.WriteLine($"Car Id:{car.CarId}  {car.Brand} {car.Model} {car.Year}");
            }
        }

        public Car SelectCar()
        {
            Console.WriteLine("Do you buy one?(y/n)");
            Car car = null;
            var userInput = Console.ReadKey();
            if (userInput.KeyChar == 'y')
            {
                Console.WriteLine("Please select Car Id");
                car = _cars.First(c => c.CarId == int.Parse(Console.ReadLine()));
            }
            return car;
        }
    }
}