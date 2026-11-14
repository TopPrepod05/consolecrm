using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Strategies.ClientSearch;

public class SearchClientByName(string n) : IClientSearchStrategy
{
    public string Name { get; set; } = n.ToLower();
    public bool IsMatch(Client client) => client.Name.ToLower().Contains(Name);
}
