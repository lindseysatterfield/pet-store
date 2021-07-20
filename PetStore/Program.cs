using PetStore.Pets;
using System;


namespace PetStore
{
    class Program
    {
        // static means shared across all instances
        static void Main(string[] args)
        {
            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            // property is privately settably only
            //melba.Weight -= 15;
            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();
            melba.Eat("Healthy food");

            var barley = new Dog("Barley", 50, "Medium");
            //barley.Name = "Barley";
            //barley.Size = "Medium";
            //barley.Weight = 50;
            barley.Bark();
            barley.Eat("table scraps");

            // this won't work, can't dynamically add properties to a class in C#
            // melba.CoatType = "Short";
        }
    }
}
