using System;
using OOP_lab3.Animals;

namespace OOP_lab3.Devices
{
    public abstract class Device : ISellable
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public decimal Value { get; set; }

        public Device()
        {
        }

        public abstract void TurnOn();
        public abstract void Sell(Human seller, Human buyer, decimal price);
    }
}
