using ConsoleApp4;
using ConsoleApp4.Services;

var crmService = CrmService.Instance;

var consoleUI = new ConsoleUI(crmService);

await consoleUI.Run();