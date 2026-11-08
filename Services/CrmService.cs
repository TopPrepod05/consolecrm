using ConsoleApp4.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Services;

public class CrmService
{
    private ClientRepository _clientRepository;
    private OrderRepository _orderRepository;

    public static CrmService Instance { get; private set; } = new();

    private CrmService()
    {
        _clientRepository = new("clients.json");
        _orderRepository = new("orders.json");
    }

    public async Task AddClientAsync(string name, string email)
    {
        _clientRepository.Add(name, email);
        await _clientRepository.SaveAsync();
        Console.WriteLine($"Клиент {name} был добавлен!");
    }

    public List<Client> GetAllClients() => _clientRepository.GetAll();
    
}
