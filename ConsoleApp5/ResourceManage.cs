namespace Variant1;

using System.Collections.Generic;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    
    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    
    public void OpenAll()
    {
        foreach (T t in _resources)
        {
            t.Open();
        }
    }
    
    public void CloseAll()
    {
        foreach (T t in _resources)
        {
            t.Close();
        }
    }
}