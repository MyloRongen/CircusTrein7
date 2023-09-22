namespace TestCircus;

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
        MainWindow mainWindow = new MainWindow();

        mainWindow.animals.Add(new Animal(AnimalType.carnivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Small));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Medium));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Medium));
        mainWindow.animals.Add(new Animal(AnimalType.herbivore, AnimalSize.Large));
        
        // Act
        int actualCount = mainWindow.train.Count;

        // Assert
        Assert.That(actualCount, Is.EqualTo(2));
    }
}