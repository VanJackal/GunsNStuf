using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GunsNStuf.Data.Registries;

public class Registry<T>
{
    private List<T> _db = new();

    /// <summary>
    /// add a new item to the registry
    /// </summary>
    /// <param name="item">item to add</param>
    public void Add(T item)
    {
        _db.Add(item);
    }

    /// <summary>
    /// get all registry items
    /// </summary>
    /// <returns>list of items</returns>
    public ReadOnlyCollection<T> GetAll()
    {
        return _db.AsReadOnly();
    }
}