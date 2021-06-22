using System;
using OOP_lab3.Animals;
using System.Collections.Generic;

namespace OOP_lab3.Devices
{
    public class Car : Device
    {
        public List<Human> owners = new List<Human>();
        public List<Transaction> transactions = new List<Transaction>();
        public double EngineSize { get; set; }
        public string FuelType { get; set; }
        public double CurrentFuel { get; set; }
        
        readonly double MAX_FUEL = 1.0;

        public Car()
        {
        }

        public override void Sell(Human seller, Human buyer, decimal price)
        {
            if (owners.Count > 0)
            {
                var currentOwner = owners[owners.Count - 1];

                if (currentOwner == seller)
                {
                    owners.Add(buyer);
                    var transaction = new Transaction(new DateTime(), seller, buyer, price);
                    transactions.Add(transaction);
                }
                else
                {
                    throw new InvalidOperationException("He is not the owner");
                }
            }


            //if (seller.Car == this)
            //{
            //    if (buyer.Cash >= price)
            //    {
            //        buyer.Cash -= price;
            //        seller.Cash += price;
            //        buyer.Car = this;
            //        seller.Car = null;
            //        Console.WriteLine("Car has been sold");
            //    }
            //    else
            //    {
            //        throw new Exception("Buyer does not have enough money");
            //    }
            //}
            //else
            //{
            //    throw new Exception("Seller does not own the car");
            //}
        }

        public override void TurnOn()
        {
            Console.WriteLine("Car is turned on");
        }

        public void Refuel()
        {
            CurrentFuel = MAX_FUEL;
        }
    }
}
