﻿/*Implement the data structure "hash table" in a class HashTable<K,T>. 
 * Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) 
 * with initial capacity of 16. When the hash table load runs over 75%, perform resizing 
 * to 2 times larger capacity. Implement the following methods and properties: 
 * Add(key, value), Find(key) -> value, Remove( key), Count, Clear(), this[], Keys. 
 * Try to make the hash table to support iterating over its elements with foreach.
 */

namespace ImplenemtHashTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HashTable<K,T>
    {
        LinkedList<KeyValuePair<K, T>>[] records = new LinkedList<KeyValuePair<K, T>>[16];

    }
}
