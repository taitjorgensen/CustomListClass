using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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
            capacity = 8;
            values = new T[capacity];
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
        public void ExpandCapacity()
        {
            capacity = capacity * 2;
            T[] newValues = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newValues[i] = values[i];
            }
            values = newValues;
        }
        public void Remove(T value)
        {

        }


        //public static CustomList operator +(T values, T values2)
        //{
        //    combinedList = new CustomList<T>();
        //    for (int i = 0; i <= (values.length + values2.length); i++)
        //    {
        //        combinedList.Add(values[i]);
        //        combinedList.Add(values2[i]);
        //    }
        //    return combinedList;
        //}
        //public static implicit operator T(combinedList)
        //{

        //}
    }
}
