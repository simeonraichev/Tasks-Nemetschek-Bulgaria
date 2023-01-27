using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lifespan
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define known foods
            var knownFoods = new HashSet<string> { "plant", "meat" };

            // Define animal species
            var animalSpecies = new List<Animal>
        {
            new Animal { MaximumEnergy = 10, Diet = new HashSet<string> { "plant" } },
            new Animal { MaximumEnergy = 20, Diet = new HashSet<string> { "meat" } }
        };

            // Create a predefined number of animals from each animal species
            var animals = new List<Animal>();
            foreach (var species in animalSpecies)
            {
                for (int i = 0; i < 5; i++)
                {
                    var animal = new Animal
                    {
                        MaximumEnergy = species.MaximumEnergy,
                        Diet = species.Diet,
                        CurrentEnergy = species.MaximumEnergy
                    };
                    animals.Add(animal);
                }
            }

            // Feed every animal with random food from known foods until there are alive animals
            var lifespans = new Dictionary<Animal, int>();
            var random = new Random();
            var aliveAnimals = animals.Count;
            while (aliveAnimals > 0)
            {
                foreach (var animal in animals)
                {
                    if (animal.CurrentEnergy > 0)
                    {
                        var food = knownFoods.ElementAt(random.Next(knownFoods.Count));
                        animal.Feed(food);
                        if (!lifespans.ContainsKey(animal))
                        {
                            lifespans.Add(animal, 0);
                        }
                        lifespans[animal]++;
                        if (animal.CurrentEnergy <= 0)
                        {
                            aliveAnimals--;
                        }
                    }
                }
            }

            // Print statistics of minimum, maximum and average lifespan for every animal species
            foreach (var species in animalSpecies)
            {
                var speciesLifespans = lifespans.Where(l => l.Key.Diet == species.Diet && l.Key.MaximumEnergy == species.MaximumEnergy);
                Console.WriteLine($"Species: {species.Diet} - Maximum Energy: {species.MaximumEnergy}");
                Console.WriteLine($"Minimum lifespan: {speciesLifespans.Min(l => l.Value)}");
                Console.WriteLine($"Maximum lifespan: {speciesLifespans.Max(l => l.Value)}");
                Console.WriteLine($"Average lifespan: {speciesLifespans.Average(l => l.Value)}");
                Console.WriteLine();
            }
        }
    }
}
