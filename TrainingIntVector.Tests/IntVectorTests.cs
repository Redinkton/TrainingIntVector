namespace TrainingIntVector.Tests
{
    [TestClass]
    public class IntVectorTests
    {
        [TestMethod]
        public void Add_FifthElement()
        {
            // Arrange
            int expected = 5;
            IntVector intVector = new IntVector();

            // Act
            intVector.AddNewElement(1);
            intVector.AddNewElement(2);
            intVector.AddNewElement(3);
            intVector.AddNewElement(4);
            intVector.AddNewElement(5);

            // Assert
            int actual = intVector[4];
            Assert.AreEqual(expected, actual, "Correctly");
        }
    }
}