namespace TestProject1;

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
    public void ScenarioOne()
    {
        // Arrange
        MainWindow mainWindow = new MainWindow();

        // Act
        int actualCount = mainWindow.animalList.Count;

        // Assert
        Assert.AreEqual(3, actualCount);
    }
    
}