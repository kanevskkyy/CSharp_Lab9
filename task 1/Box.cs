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

        public int CompareElements(object comparedElement)
        {
            int count = 0;

            if (Value is IList list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is IComparable currentElement && comparedElement is IComparable)
                    {
                        // Порівнюємо поточний елемент зі значенням comparedElement
                        if (currentElement.CompareTo(comparedElement) > 0)
                        {
                            count++;  // Лічильник збільшується, якщо елемент більше
                        }
                    }
                }
            }

            return count;
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