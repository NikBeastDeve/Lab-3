using System;
namespace OOP_lab3.Animals
{
    public class Animal : IFeedable
    {

        readonly static Double DEFAULT_DOG_WEIGHT = 6.0;
        readonly static Double DEFAULT_CAT_WEIGHT = 1.0;
        readonly static Double DEFAULT_ELEPHANT_WEIGHT = 2000.0;
        readonly static Double DEFAULT_WEIGHT = 0.5;

        public string Name { get; set; }
        public string Species { get; }
        public double Weight { get; set; }

        public Animal(string species)
        {
            Species = species;
            switch (species)
            {
                case "dog":
                    Weight = DEFAULT_DOG_WEIGHT;
                    break;
                case "cat":
                    Weight = DEFAULT_CAT_WEIGHT;
                    break;
                case "elephant":
                    Weight = DEFAULT_ELEPHANT_WEIGHT;
                    break;
                default:
                    Weight = DEFAULT_WEIGHT;
                    break;
            }
        }

        public void PrintWeight()
        {
            Console.WriteLine(Weight);
        }

        public void Feed()
        {
            Weight += 1.0;
        }

        public void Feed(double foodWeight)
        {
            Weight += foodWeight;
        }
    }
}
