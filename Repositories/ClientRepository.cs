using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public class ClientRepository : BaseRepository<Client>
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

    public Client? GetById(int id) => _items.FirstOrDefault(c => c.Id == id);
}
