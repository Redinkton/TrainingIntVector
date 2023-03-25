using System.Collections;

namespace TrainingIntVector.Tests
{
    [TestClass]
    public class IntVectorTests
    {
        private IntVector IntVector1 { get; set; }
        private int[] TestArray { get; set; }

        [TestMethod]
        public void Add_FifthElement()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector();

            // Act
            FillArray();

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void Remove_ByIndex()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 2, 5, 53, 11, 134, 8, 54, 1, 5 });
            TestArray = new int[] { 2, 5, 53, 11, 134, 54, 1 };

            // Act
            IntVector1.RemoveAt(5);
            IntVector1.RemoveAt(IntVector1.Length - 1);

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void RemoveAll_5()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5, 414, 5, 5, 5, 11, 999 });
            TestArray = new int[] { 24, 13, 4, 99, 414, 11, 999 };

            // Act
            IntVector1.RemoveAllThisInstances(5);

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ClearAllElements()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            TestArray = new int[] {};

            // Act
            IntVector1.Clear();

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void EditOneElement()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            TestArray = new int[] { 1, 5, 13, 4, 5, 99, 5 };

            // Act
            IntVector1[0]=1;

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ChangeIndex()
        {
            // Arrange
            bool expected = true;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });
            TestArray = new int[] { 888, 77, 6, 555, 44, 99, 5 };

            // Act
            IntVector1.AddAtIndex(0, 888);
            IntVector1.AddAtIndex(1, 77);
            IntVector1.AddAtIndex(2, 6);
            IntVector1.AddAtIndex(3, 555);
            IntVector1.AddAtIndex(4, 44);

            // Assert
            bool actual = Equals(TestArray);
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ReturnLength()
        {
            // Arrange
            int expected = 7;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5 });

            // Act
            int actual = IntVector1.Length;

            // Assert
            Assert.AreEqual(expected, actual, "Correctly");
        }

        [TestMethod]
        public void ReturnCapacity()
        {
            // Arrange
            int expected = 12;
            IntVector1 = new IntVector(new int[] { 24, 5, 13, 4, 5, 99, 5, 235, 0 });

            // Act
            int actual = IntVector1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual, "Correctly");
        }

        #region Helpers
        private bool Equals(int[] other)
        {
            if (other != null)
            {
                for (int i = 0; i < IntVector1.Length; i++)
                {
                    if (IntVector1[i] != TestArray[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        private void FillArray()
        {
            TestArray = new int[100000];
            int i = 0;
            while (i < 99999)
            {
                IntVector1.AddNewElement(i);
                TestArray[i] = i;
                i++;
            }
        }
        #endregion
    }
}