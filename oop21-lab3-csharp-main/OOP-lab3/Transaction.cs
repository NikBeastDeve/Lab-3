using System;
using OOP_lab3.Animals;

namespace OOP_lab3
{
    public class Transaction
    {
        DateTime dateOfTransaction;
        Human seller;
        Human buyer;
        decimal price;

        public Transaction(DateTime dateOfTransaction,
                           Human seller,
                           Human buyer,
                           decimal price)
        {
            this.dateOfTransaction = dateOfTransaction;
            this.seller = seller;
            this.buyer = buyer;
            this.price = price;
        }
    }
}
