using ConsoleApp4.Models;
using ConsoleApp4.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Services;

public class CrmService
{
    private IClientRepository _clientRepository;
    private IOrderRepository _orderRepository;
    public event Action<Client>? ClientAdded;

    public static CrmService Instance { get; private set; } = new(new ClientRepository("client.json"), new OrderRepository("order.json"));

    private CrmService(IClientRepository clientRepository, IOrderRepository orderRepository)
    {
        _clientRepository = clientRepository;
        _orderRepository = orderRepository;
    }

    public async Task AddClientAsync(string name, string email)
    {
        _clientRepository.Add(name, email);
        await _clientRepository.SaveAsync();
        Console.WriteLine($"Клиент {name} был добавлен!");
    }

    //public List<Order> GetOrders(int clientId) => _orderRepository.GetOrdersByClient(clientId);

    public List<Client> GetAllClients() => _clientRepository.GetAll();
    
}
