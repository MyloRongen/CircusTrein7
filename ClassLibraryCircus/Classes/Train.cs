using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircus.Enums;
using static System.Collections.Specialized.BitVector32;

namespace ClassLibraryCircus.Classes
{
    public class Train
    {
        private readonly List<Wagon> Wagons = new();
        private readonly List<Animal> Animals = new();

        public void SortAnimals()
        {
            List<Animal> sortedAnimals = SortAnimalsByType();

            foreach (Animal animal in sortedAnimals)
            {
                if (!TryAddAnimalToWagon(animal))
                {
                    AddNewWagonToTrain(animal);
                }
            }
        }

        private bool TryAddAnimalToWagon(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.TryAddAnimalInWagon(animal))
                {
                    return true;
                }
            }

            return false;
        }

        private List<Animal> SortAnimalsByType()
        {
            return Animals.OrderBy(a => a.Type == AnimalType.Carnivore ? 0 : 1).ToList();
        }

        private void AddNewWagonToTrain(Animal animal)
        {
            Wagon newWagon = new();
            newWagon.TryAddAnimalInWagon(animal);
            Wagons.Add(newWagon);
        }

        public List<Wagon> GetWagonsFromTrain()
        {
            return Wagons;
        }

        public List<Animal> GetAnimalsFromTrain()
        {
            return Animals;
        }

        public void AddAnimalToTrain(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
