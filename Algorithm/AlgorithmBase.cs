using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<int> Items { get; set; } = new List<int>();

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
