using System;
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
            CustomList<string> colorList = new CustomList<string>();
            CustomList<string> colorListTwo = new CustomList<string>();
            colorList.Add("green");
            colorList.Add("red");
            colorList.Add("yellow");
            colorListTwo.Add("blue");
            colorListTwo.Add("orange");
            colorListTwo.Add("red");
            CustomList<string> newColorList = colorList - colorListTwo;
        }
    }
}
