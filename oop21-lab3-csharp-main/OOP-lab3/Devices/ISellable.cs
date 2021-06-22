using System;
using OOP_lab3.Animals;

namespace OOP_lab3.Devices
{
    public interface ISellable
    {
        void Sell(Human seller, Human buyer, decimal price);
    }
}
