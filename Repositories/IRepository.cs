using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public interface IRepository<T> where T : class
{
    List<T> GetAll();
    void Add(T entity);
    T? GetById(int id);
    Task SaveAsync();
}
