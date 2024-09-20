using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task_8_10
{
    internal class Box<T> : IEnumerable<T>
    {
        public List<T> Values { get; set; } = new List<T>();

        public void Add(T element)
        {
            Values.Add(element);
        }

        public void Remove(int index)
        {
            Values.RemoveAt(index);
        }

        public bool Contains(T element)
        {
            return Values.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = Values[firstIndex];
            Values[firstIndex] = Values[secondIndex];
            Values[secondIndex] = temp;
        }

        public int CountGreaterThen(T element)
        {
            int count = 0;

            for (int i = 0; i < Values.Count; i++)
            {
                if (Values[i].Equals(element)) count++;
            }

            return count;
        }

        public T Max()
        {
            return Values.Max();
        }

        public T Min()
        {
            return Values.Min();
        }

        public void Print()
        {
            foreach (var value in Values)
            {
                Console.WriteLine(value);
            }
        }

        public void Sort()
        {
            Values.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}