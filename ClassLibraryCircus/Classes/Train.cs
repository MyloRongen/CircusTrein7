using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircus.Enums;

namespace ClassLibraryCircus.Classes
{
    public class Train
    {
        public readonly List<Wagon> Wagons = new();
        public readonly List<Animal> Animals = new();

        public void SortAnimals()
        {
            List<Animal> sortedAnimals = Animals.OrderBy(a => a.Type == AnimalType.Carnivore ? 0 : 1).ToList();

            foreach (Animal animal in sortedAnimals)
            {
                bool hasBeenAddedToWagon = false;
                
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.AnimalFitsSafelyInWagon(animal))
                    {
                        wagon.AddAnimalToWagon(animal);
                        hasBeenAddedToWagon = true;
                        break;
                    }
                }

                if (!hasBeenAddedToWagon)
                {
                    AddNewWagonToTrain(animal);
                }
            }
        }
        
        private void AddNewWagonToTrain(Animal animal)
        {
            Wagon newWagon = new Wagon();
            newWagon.AddAnimalToWagon(animal);
            Wagons.Add(newWagon);
        }
    }
}
