﻿namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {        
            int iMin;

            for (int j = 0; j < collection.Count - 1; j++)
            {
                iMin = j;
                for (int i = j + 1; i < collection.Count; i++)
                {
                    if (collection[i].CompareTo(collection[iMin]) < 0)
                    {
                        iMin = i;
                    }
                }
                
                if (iMin != j)
                {
                    T oldValue = collection[j];
                    collection[j] = collection[iMin];
                    collection[iMin] = oldValue; 
                }
            }
        }
    }
}
