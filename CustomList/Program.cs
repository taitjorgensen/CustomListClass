﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(5);
            numbers.Add(12);
            numbers.ToString();
        }
    }
}
