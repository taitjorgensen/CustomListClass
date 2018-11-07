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
            list.Add(12);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Test_AddToList_IndexOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 13;

            //Act
            list.Add(12);
            list.Add(13);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Test_AddToList_ExpandCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 21;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);
            list.Add(21);

            //Assert
            Assert.AreEqual(expected, list[9]);
        }

        [TestMethod]
        public void Test_AddToList_IndexZeroUnchanged()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 12;

            //Act
            list.Add(12);
            list.Add(13);

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

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            actual = list[list.Count];

        }

        [TestMethod]
        public void Test_RemoveFromList_IndexOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 14;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
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
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Remove(list[1]);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RemoveFromList_IndexAtCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected;
            int actual;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Remove(list[1]);

            //Assert
            actual = list[list.Count];
        }

        //[TestMethod]
        //public void Test_Combine_TwoListInstances()
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    CustomList<int> list2 = new CustomList<int>();
        //    int expected = { 1, 2, 3, 4, 5, 6 };

        //    //Act
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list2.Add(4);
        //    list2.Add(5);
        //    list2.Add(6);
        //    CustomList<int> combinedList = list + list2;

        //    //Assert
        //    Assert.AreEqual(expected, combinedList);
        //}

        //[TestMethod]
        //public void Test_ZipCombine_TwoListInstances()
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    CustomList<int> list2 = new CustomList<int>();
        //    int expected = { 1, 4, 2, 5, 3, 6 };

        //    //Act
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list2.Add(4);
        //    list2.Add(5);
        //    list2.Add(6);
        //    CustomList<int> zipCombinedList = Zip(list + list2);

        //    //Assert
        //    Assert.AreEqual(expected, zipCombinedList);
        //}
    }
}
