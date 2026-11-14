using ConsoleApp4.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4;

public class ConsoleUI
{
    public CrmService crmService { get; set; }
    public ConsoleUI(CrmService crmService)
    {
        this.crmService = crmService;
    }

    public async Task Run()
    {
        // Здесь будет запуск приложения

        await crmService.AddClientAsync("Juan", "juan@gmail.com");
        Console.WriteLine("Мы добавили пользователя: Juan");
    }


}
