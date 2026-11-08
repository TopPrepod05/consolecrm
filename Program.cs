using ConsoleApp4;
using ConsoleApp4.Repositories;

var clientRep = new ClientRepository("client.json");


clientRep.Add("kasum228", "kasum@max.ru");

var cl = clientRep.GetById(1);

Console.WriteLine($"{cl?.Id} {cl?.Name} {cl?.Email}");