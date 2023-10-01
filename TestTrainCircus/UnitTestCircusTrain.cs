using ClassLibraryCircus.Classes;
using ClassLibraryCircus.Enums;

namespace TestTrainCircus;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void ScenarioOne()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(2));
    }
    
    
    [Test]
    public void ScenarioTwo()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
              
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(2));
    }
    
    [Test]
    public void ScenarioThree()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(4));
    }
    
    [Test]
    public void ScenarioFour()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));

        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(5));
    }
    
    [Test]
    public void ScenarioFive()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));

        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(2));
    }
    
    [Test]
    public void ScenarioSix()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));

        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));

        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(3));
    }
    
    [Test]
    public void ScenarioSeven()
    {
        // Arrange
        Train train = new();

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(13));
    }
    
    [Test]
    public void ScenarioEight()
    {
        // Arrange
        Train train = new();
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));

        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(6));
    }
    
    [Test]
    public void ScenarioNine()
    {
        // Arrange
        Train train = new();
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Small));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Herbivore, AnimalSize.Large));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Small));
        
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Medium));

        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));
        train.AddAnimalToTrain(new Animal(AnimalType.Carnivore, AnimalSize.Large));

        train.SortAnimals();
        
        // Act
        int actualCount = train.GetWagonsFromTrain().Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(8));
    }
}