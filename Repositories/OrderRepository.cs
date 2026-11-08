using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public class OrderRepository : BaseRepository<Order>
{
    public OrderRepository(string filename) : base(filename)
    {
        if (_items.Count > 0) _nextId = _items.Max(c => c.Id) + 1;
    }

    public void Add(int clientId, string description, decimal amount)
    {
        DateOnly dd = DateOnly.FromDateTime(DateTime.Now.AddDays(30));
        var order = new Order(_nextId, clientId, description, amount, dd);
        _items.Add(order);
    }

    public override Order? GetById(int id) => _items.FirstOrDefault(c => c.Id == id);
    public List<Order> GetOrdersByClient(int clientId) => 
        _items.Where(c => c.ClientId == clientId).ToList();
}