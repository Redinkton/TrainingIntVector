namespace TrainingIntVector.Tests
{
    [TestClass]
    public class IntVectorTests
    {
        public IntVector IntVector1 = new IntVector();
        public IntVector IntVector2 = new IntVector();

        //Уже лучше?
        [TestMethod]
        public void Add_FifthElement()
        {
            // Arrange
            bool expected = true;

            // Act
            FillArray();

            // Assert
            bool actual = Equals(IntVector2); // возможно будут вопросы к такой строке
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void Remove_ByIndex()
        {
            // Arrange
            bool expected = true;

            // Act
            FillArray();
            IntVector2.RemoveAt(5);
            IntVector2.RemoveAt(IntVector2.ReturnLength() - 1);

            IntVector1.RemoveAt(5);
            IntVector1.RemoveAt(IntVector1.ReturnLength() - 1);

            // Assert
            bool actual = Equals(IntVector2);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void RemoveAll_5()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            IntVector2 = new IntVector(new int[] { 24, 13, 4, 99 });

            // Act
            IntVector1.RemoveAllThisInstances(5);
            IntVector2.RemoveAllThisInstances(5);

            // Assert
            bool actual = Equals(IntVector2);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ClearAllElements()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            IntVector2 = new IntVector();

            // Act
            IntVector1.Clear();

            // Assert
            bool actual = Equals(IntVector2);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void EditOneElement()
        {
            // Arrange
            int expected = 1;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            IntVector2 = new IntVector(new int[] { 1, 5, 13, 4, 5, 99, 5 });

            // Act
            IntVector1[0]=1;

            // Assert
            int actual = IntVector2[0];
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ChangeIndex()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 999, 5, 99, 5 });

            // Act
            IntVector1.AddAtIndex(3, 999);

            // Assert
            bool actual = true;
            Assert.AreEqual(expected, actual, "Correctly");
        }

        #region Helpers
        private bool Equals(IntVector other)
        {
            if (other != null)
            {
                for (int i = 0; i < IntVector1.ReturnLength(); i++)
                {
                    if (IntVector1[i] != other[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        private void FillArray()
        {
            int i = 0;
            while (i < 99999)
            {
                IntVector1.AddNewElement(i);
                IntVector2.AddNewElement(i);
                i++;
            }
        }
        #endregion
    }
}