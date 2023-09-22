using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircus.Enums;

namespace ClassLibraryCircus.Classes
{
    public class Animal
    {
        public AnimalType Type { get; }
        public AnimalSize Size { get; }
        public int Point => (int)Size;

        public Animal(AnimalType type, AnimalSize size)
        {
            Type = type;
            Size = size;
        }
        
        public static bool GetsEatenByOtherAnimal(Animal animal, List<Animal> animalsInWagon)
        {
            return animalsInWagon.Any(a => a.Type == AnimalType.Carnivore && animal.Point <= a.Point);
        }
    
        public static bool CanEatAnimal(Animal animal, List<Animal> animalsInWagon)
        {
            if (animal.Type == AnimalType.Carnivore)
            {
                return animalsInWagon.Any(a => a.Point <= animal.Point);
            }
            
            return false;
        }
    }
}
