using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T value;
        CustomList<T> customList = new CustomList<int>();

        public CustomList(T value)
        {
            this.value = value;
        }
    }
}
