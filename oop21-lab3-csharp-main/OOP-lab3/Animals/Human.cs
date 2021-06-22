using System;
using System.Collections.Generic;
using OOP_lab3.Devices;
using System.Linq;

namespace OOP_lab3.Animals
{
    public class Human : Animal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Phone { get; set; }
        public Car[] garage { get; set; }
        public decimal Cash { get; set; }
        public string[] FingerNames { get; set; }
        public decimal Salary {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0.0m)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("NOBODY WILL PAY FOR WORKING");
                    salary = 0.0m;
                }
            }
        }

        private List<Animal> pets;
        private decimal salary;
        private readonly int FINGER_COUNT = 10;
        private readonly static string HUMAN_SPECIE = "homo sapiens";
        private int parkingSpot = 0;
        

        public Human(decimal salary) : base(HUMAN_SPECIE)
        {
            Salary = salary;
            FingerNames = new string[FINGER_COUNT];
            garage = new Car[2];
        }

        public Human(int garageCount) : base(HUMAN_SPECIE)
        {
            garage = new Car[garageCount];
        }

        public void AddPet(Animal pet)
        {
            if (pets == null)
            {
                pets = new List<Animal>();
            }
            pets.Add(pet);
        }

        public List<Animal> getPets()
        {
            return pets;
        }

        public void getCar(int spot)
        {
            parkingSpot = spot;
        }

        public int setCar()
        {
            return parkingSpot;
        }

        public decimal valueOfAllCars()
        {
            decimal count = 0.0M;
            foreach (Car item in garage)
            {
                count += item.Value;
            }

            return count;
        }

        public List<Car> getCarsSortedByYear()
        {
            List<Car> sortedCars = new List<Car>();
            sortedCars = garage.OrderBy(o => o.YearOfProduction).ToList();
            return sortedCars;
        }

        public bool HasEverOwnedCar()
        {
            return garage.Length > 0;
        }

        public bool HasEverOwnedCar(Car car)
        {
            return car.owners.Contains(this);
        }

        public bool boolEverSoldTo(Car car, Human human)
        {
            return car.owners.Contains(this) && car.owners.Contains(human);
        }

        public int TimesCarBeenSold(Car car)
        {
            return car.owners.Count;
        }
    }
}
