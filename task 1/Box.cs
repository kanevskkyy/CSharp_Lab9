using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            if (Value is IList list)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }

        public override string ToString()
        {
            return $"System32.{typeof(T).Name} : {Value}";
        }
    }
}