using ClassLibraryCircus.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryCircus.Classes
{
    public class Wagon
    {
        public readonly List<Animal> Animals = new();
        
        public bool AnimalFitsSafelyInWagon(Animal animal)
        {
            if (AnimalIsLargerThanWagonCanContain(animal))
            {
                return false;
            }

            if (Animal.GetsEatenByOtherAnimal(animal, Animals))
            {
                return false;
            }

            if (Animal.CanEatAnimal(animal, Animals))
            {
                return false;
            }
            
            return true;
        }
        
        public void AddAnimalToWagon(Animal animal)
        {
            Animals.Add(animal);
        }

        private bool AnimalIsLargerThanWagonCanContain(Animal animal)
        {
            int wagonCapacity = GetWagonCapacity(Animals);
            return animal.Point + wagonCapacity > 10;
        }

        private static int GetWagonCapacity(List<Animal> wagon)
        {
            return wagon.Sum(animal => animal.Point);
        }
    }
}