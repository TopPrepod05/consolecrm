using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public class ClientRepository : BaseRepository<Client>, IClientRepository
{
    public ClientRepository(string filename) : base(filename)
    {
        if (_items.Count > 0) _nextId = _items.Max(c => c.Id) + 1;
    }

    public void Add(string name, string email)
    {
        var client = new Client(_nextId, name, email);
        _items.Add(client);
    }

    public override Client? GetById(int id) => _items.FirstOrDefault(c => c.Id == id);
}
