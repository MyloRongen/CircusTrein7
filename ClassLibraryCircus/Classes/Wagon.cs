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
        private readonly List<Animal> Animals = new();
        
        public bool TryAddAnimalInWagon(Animal animal)
        {
            if (AnimalIsLargerThanWagonCanContain(animal))
            {
                return false;
            }

            if (animal.GetsEatenByOtherAnimal(Animals))
            {
                return false;
            }

            if (animal.CanEatAnimal(Animals))
            {
                return false;
            }

            AddAnimalToWagon(animal);
            return true;
        }
        
        private void AddAnimalToWagon(Animal animal)
        {
            Animals.Add(animal);
        }

        private bool AnimalIsLargerThanWagonCanContain(Animal animal)
        {
            int wagonCapacity = GetWagonCapacity(Animals);
            return animal.Point + wagonCapacity > 10;
        }

        private static int GetWagonCapacity(List<Animal> animals)
        {
            return animals.Sum(animal => animal.Point);
        }

        public List<Animal> GetAnimalsFromWagon()
        {
            return Animals;
        }
    }
}