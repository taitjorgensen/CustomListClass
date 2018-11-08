﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Test_Count_IndexZero()
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
        public void Test_Add__String()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "purple";

            //Act
            list.Add("red");
            list.Add("blue");
            list.Add("purple");

            //Assert
            Assert.AreEqual(expected, list[2]);
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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_Range_IndexAt1000()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int actual;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            int outOfRange = list[1000];

            actual = outOfRange;

        }
        [TestMethod]
        public void Test_Range_IndexCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 0;
            int actual = list[list.Count];

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);

            //Assert
            Assert.AreEqual(expected, actual);
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
        public void Test_RemoveFromList_EntireList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 0;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.Remove(list[i]);
            }
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Test_RemoveFromList_IndexAtCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Remove(list[1]);
            actual = list[list.Count];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Combine_TwoListInstances()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            //int expected = { 1, 2, 3, 4, 5, 6 };

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            //CustomList<int> combinedList = list + list2;

            //Assert
            //Assert.AreEqual(expected, combinedList);
        }

        [TestMethod]
        public void Test_ZipCombine_TwoListInstances()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            //int expected = { 1, 4, 2, 5, 3, 6 };

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            //CustomList<int> zipCombinedList = Zip(list + list2);

            //Assert
            //Assert.AreEqual(expected, zipCombinedList);
        }

        [TestMethod]
        public void Test_ToString_Integers()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "12 13 14 ";

            //Act
            list.Add(12);
            list.Add(13);
            list.Add(14);
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ToString_Strings()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Go Pack Go ! ";

            //Act
            list.Add("Go");
            list.Add("Pack");
            list.Add("Go");
            list.Add("!");
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
