namespace TrainingIntVector.Tests
{
    [TestClass]
    public class IntVectorTests
    {
        [TestMethod]
        public void Add_FifthElement()
        {
            // Arrange
            int expected = 6;
            IntVector intVector = new IntVector(new int[] { 1, 2, 3, 4, 5 });

            // Act
            intVector.AddNewElement(6);

            // Assert
            int actual = intVector[5];
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void Remove_ByIndex()
        {
            // Arrange
            int expected = 10;
            IntVector intVector = new IntVector(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            // Act
            intVector.RemoveAt(5);

            // Assert
            int actual = intVector.ReturnLength();
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void RemoveAll_5()
        {
            // Arrange
            int expected = 4;
            IntVector intVector = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });

            // Act
            intVector.RemoveAllThisInstances(5);

            // Assert
            int actual = intVector.ReturnLength();
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ClearAllElements()
        {
            // Arrange
            int expected = 0;
            IntVector intVector = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });

            // Act
            intVector.Clear();

            // Assert
            int actual = intVector.ReturnLength();
            Assert.AreEqual(expected, actual, "Correctly");
        }
    }
}