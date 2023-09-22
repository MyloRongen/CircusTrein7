using Circustrein.Classes;
using Circustrein.Enums;

namespace TestProject5;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void SceneraioOne()
    {
        // Arrange
        InitializeAnimal wagons = new InitializeAnimal();

        wagons.animals.Add(new Animal(AnimalType.carnivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Medium));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Medium));
        wagons.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Large));
        
        // Act
        int actualCount = wagons.train.Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(2));
    }
}