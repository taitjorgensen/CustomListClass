using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Test_Add_IndexZero()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Act
            list.Add(16);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Test_AddToList_IndexOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;

            //Act
            list.Add(16);
            list.Add(17);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Test_AddToList_IndexZeroUnchanged()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            //Act
            list.Add(16);
            list.Add(17);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Add_IndexAtCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int actual;
            //int expected;

            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            actual = list[list.Count];

            //Assert
            //Assert.AreEqual(expected, list[list.Count]);
        }

        [TestMethod]
        public void Test_RemoveFromList_IndexOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 18;

            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Remove(list[1]);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Test_RemoveFromList_UpdateCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;

            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Remove(list[1]);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RemoveFromList_IndexCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;
            int actual;

            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Remove(list[1]);
            actual = list[list.Count];

            //Assert
            Assert.AreEqual(expected, list[1]);
        }
    }
}
