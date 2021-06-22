using System;
using System.Collections.Generic;
using OOP_lab3.Animals;
using System.Linq;
using OOP_lab3.Devices;

namespace OOP_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Human(1000.0m)
            {
                FirstName = "Jan",
                LastName = "Kowalski"
            };

            var dog = new Animal("dog")
            {
                Name = "Szarik"
            };
            var cat = new Animal("cat")
            {
                Name = "Puszek"
            };

            me.AddPet(dog);
            me.AddPet(cat);
            List<Animal> pets = me.getPets();
            foreach(Animal pet in pets)
            {
                Console.WriteLine(pet.Name);
            }

            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"Pet number {i} is named {pets[i].Name} and weights {pets[i].Weight}");
            }


            var sortedPets = pets.OrderBy(x => x.Weight);

            foreach (Animal pet in sortedPets)
            {
                Console.WriteLine($"Pet named {pet.Name} weights {pet.Weight}");
            }

            pets.Sort((x, y) => {
                if (x.Weight < y.Weight)
                {
                    return -1;
                }
                if (x.Weight == y.Weight)
                {
                    return 0;
                }
                if (x.Weight > y.Weight)
                {
                    return 1;
                }
                return 0;
            });

            foreach (Animal pet in pets)
            {
                Console.WriteLine($"Pet named {pet.Name} weights {pet.Weight}");
            }

            me.FingerNames[0] = "Left pinkie";
            me.FingerNames[1] = "Left ring";
            me.FingerNames[2] = "Left middle";
            me.FingerNames[3] = "Left index";
            me.FingerNames[4] = "Left thumb";

            me.FingerNames[5] = "Right thumb";
            me.FingerNames[6] = "Right index";
            me.FingerNames[7] = "Right middle";
            me.FingerNames[8] = "Right ring";
            me.FingerNames[9] = "Right pinkie";

            Console.WriteLine($"I have {me.FingerNames.Length} fingers");

            foreach(var fingerName in me.FingerNames)
            {
                Console.WriteLine(fingerName);
            }

            var sortedFingers = me.FingerNames.OrderBy(x => x);


            foreach (var fingerName in sortedFingers)
            {
                Console.WriteLine(fingerName);
            }

            Array.Sort(me.FingerNames);

            foreach (var fingerName in me.FingerNames)
            {
                Console.WriteLine(fingerName);
            }

            Phone onePlus = new Phone("onePlus",
                    "8Pro",
                    2.3,
                    "Android");

            Phone iPhone6 = new Phone("Apple", "6s", 5.0, "iOS");

            Console.WriteLine("phone: " + onePlus);
            Console.WriteLine("phone: " + iPhone6);
            Console.WriteLine("human: " + me);


            onePlus.TurnOn();

            var fiat = new Car
            {
                EngineSize = 1.9,
                FuelType = "Diesel",
                Producer = "Fiat",
                Model = "Bravo"
            };

            Console.WriteLine(iPhone6.Model);
            Console.WriteLine(iPhone6.Producer);
            Console.WriteLine(iPhone6.OS);
            Console.WriteLine(iPhone6.ScreenSize);


            fiat.TurnOn();
            iPhone6.TurnOn();
        }
    }
}
