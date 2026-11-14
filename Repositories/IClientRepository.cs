using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public interface IClientRepository : IRepository<Client>
{
    void Add(string name, string email);
}
