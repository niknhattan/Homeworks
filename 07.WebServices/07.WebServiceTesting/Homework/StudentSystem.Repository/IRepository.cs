﻿namespace SchoolSystem.Repository
{
    using System;
    using System.Linq;

    public interface IRepository<T>
        where T: class
    {
        IQueryable<T> All();

        T Get(int id);

        T Add(T item);

        void Delete(int id);

        void Update(int id, T item);
    }
}
