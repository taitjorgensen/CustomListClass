﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        public T[] values;
        int count;
        int capacity;
        

        public int Length
        {
            get { return values.Length; }
        }
        public T this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }
        public int Count
        {
            get { return count; }
        }


        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 1;
            values = new T[capacity];
        }

        public IEnumerator GetEnumerator()
        {
            foreach(T index in values)
            {
                yield return index;
            }
        }

        public void Add(T value)
        {
            values[count] = value;
            count++;
            if (count == capacity)
            {
                ExpandCapacity();
            }
        }
        //public void Insert(int index, int value, CustomList<int> list)
        //{
        //    CustomList<int> newList = new CustomList<int>();
        //    CustomList<int> finalList = new CustomList<int>();
        //    int i;
        //    int j;
        //    for (i = 0; i < count; i++)
        //    {
        //        if (index == i)
        //        {
        //            newList.values[i] = value;
        //            for (j = 0; j < count; j++)
        //            {
        //                if (newList[j] == list[j])
        //                {
        //                    finalList.Add(newList[j]);
        //                }
        //                else if (newList[j] != list[j + 1])
        //                {
        //                    finalList.Add(newList[j]);
        //                }
        //                else
        //                {
        //                    finalList.Add(list[j]);
        //                }
        //                list.values = finalList.values;
        //            }
        //            break;
        //        }
        //        else if (i < index)
        //        {
        //            newList.Add(list[i]);
        //        }
        //        else
        //        {                  
        //        }
                
        //    }
        //    count++;
        //    if (count == capacity)
        //    {
        //        ExpandCapacity();
        //    }
        //}
        public void ExpandCapacity()
        {
            capacity = capacity + 8;
            T[] newValues = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newValues[i] = values[i];
            }
            values = newValues;
        }
        public void Remove(T value)
        {
            T[] arrayRemovingFrom = values;
            CustomList<T> newList = new CustomList<T>();       
            T[] newValues = new T[capacity];
            int j;
            int i = 0;
            j = i;
            for (i = 0; i < count; i++)
            {
                T compareValue = arrayRemovingFrom[i];
                if (j == i - 1)
                {
                    newList.Add(compareValue);
                    j++;
                }
                else if (value.Equals(compareValue))
                {                   
                }
                else
                {
                    newList.Add(compareValue);
                    j++;
                }
            }
            if (j == i - 1)
            {
                values = newList.values;
                count--;
            }
            else
            {
                values = newList.values;
            }
        }
        public override string ToString()
        {          
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    builder.Append(values[i]);
                }
                else
                {
                    builder.Append(values[i]).Append(" ");
                }
            }
            var newString = builder.ToString();
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++)
            {
                newList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                newList.Add(listTwo[i]);
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            int i;
            int j;
            string originalList = listOne.ToString();
            string comparingList = listTwo.ToString();
            for (i = 0; i < listOne.Count; i++)
            {

                for (j = 0; j < listTwo.Count; j++)
                {
                    if (comparingList[j] == originalList[i])
                    {
                        i++;                        
                    }
                    else if (j == listTwo.Count - 1)
                    {
                        newList.Add(listOne[i]);
                        i++;
                    }
                    else
                    {                       
                    }
                }
            }
            T[] values = newList.values;
            return newList;
        }
        public void ZipCombine(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.Count || i < listTwo.count; i++)
            {
                newList.Add(listOne.values[i]);
                newList.Add(listTwo.values[i]);
            }
            values = newList.values;
        }
    }
}
