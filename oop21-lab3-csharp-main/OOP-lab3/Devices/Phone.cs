using System;
using OOP_lab3.Animals;

namespace OOP_lab3.Devices
{
    public class Phone : Device
    {
        public double ScreenSize { get; set; }
        public string OS { get; set; }

        public Phone(string producer, string model, double screenSize, string os)
        {
            Producer = producer;
            Model = model;
            ScreenSize = screenSize;
            OS = os;
        }

        public override string ToString()
        {
            return $"Producer: {Producer} Model: {Model}";
        }

        public override void Sell(Human seller, Human buyer, decimal price)
        {
            if (seller.Phone == this)
            {
                if (buyer.Cash >= price)
                {
                    buyer.Cash -= price;
                    seller.Cash += price;
                    buyer.Phone = this;
                    seller.Phone = null;
                    Console.WriteLine("Phone has been sold");
                }
                else
                {
                    throw new Exception("Buyer does not have enough money");
                }
            }
            else
            {
                throw new Exception("Seller does not own the phone");
            }
        }

        public override void TurnOn()
        {
            Console.WriteLine("Phone is turned on");
        }
    }
}
