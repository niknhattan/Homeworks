﻿namespace ShortestSequenceOfOperations
{
    using System;
    class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
