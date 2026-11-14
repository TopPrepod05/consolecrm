using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public interface IOrderRepository : IRepository<Order>
{
    void Add(int clientId, string description, decimal amount);
}
