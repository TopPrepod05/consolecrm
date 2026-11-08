namespace ConsoleApp4.Models;

public class Order
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateOnly DueDate { get; set; }

    public Order(int id, int clientId, string description, decimal amount, DateOnly dueDate)
    {
        Id = id;
        ClientId = clientId;
        Description = description;
        Amount = amount;
        DueDate = dueDate;
    }
}
