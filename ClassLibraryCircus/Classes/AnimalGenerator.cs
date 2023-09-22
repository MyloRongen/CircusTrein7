using ClassLibraryCircus.Enums;

namespace ClassLibraryCircus.Classes;

public class AnimalGenerator
{
    private readonly Random _rnd = new();
    
    public void MakeRandomAnimals(Train train)
    {
        for (int i = 0; i < 6; i++)
        {
            AnimalSize animalSize = SetSize();
            AnimalType animalType = SetType();
            Animal animal = new(animalType, animalSize);
            train.Animals.Add(animal);
        }
    }

    private AnimalType SetType()
    {
        int enumLength = Enum.GetNames(typeof(AnimalType)).Length;
        int valueAnimalType = _rnd.Next(0, enumLength);
        AnimalType animalType = (AnimalType)Enum.GetValues(typeof(AnimalType)).GetValue(valueAnimalType)!;
        return animalType;
    }
    
    private AnimalSize SetSize()
    {
        int enumLength = Enum.GetNames(typeof(AnimalSize)).Length;
        int valueAnimalSize = _rnd.Next(0, enumLength);
        AnimalSize animalSize = (AnimalSize)Enum.GetValues(typeof(AnimalSize)).GetValue(valueAnimalSize)!;
        return animalSize;
    }
}