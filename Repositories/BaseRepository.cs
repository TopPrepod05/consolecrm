using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    protected string _filename = string.Empty;
    protected List<T> _items = [];
    protected int _nextId = 1;

    public BaseRepository(string filename)
    {
        var folder = Path.Combine(
            Environment
                    .GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "MyCRM");
        Directory.CreateDirectory(folder);
        var path = Path.Combine(folder, filename);
        _filename = path;
        Load();
    }

    private void Load()
    {
        if (!File.Exists(_filename)) return;
        string json = File.ReadAllText(_filename);
        _items = JsonConvert.DeserializeObject<List<T>>(json) ?? [];
    }

    public async Task SaveAsync()
    {
        string json = JsonConvert.SerializeObject(_items, Formatting.Indented);
        await File.WriteAllTextAsync(json, _filename);
    }

    public List<T> GetAll() => _items;
    public void Add(T item) => _items.Add(item);
    public abstract T? GetById(int id);
}
