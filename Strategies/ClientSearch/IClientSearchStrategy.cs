using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Strategies.ClientSearch;

public interface IClientSearchStrategy
{
    bool IsMatch(Client client);
}
