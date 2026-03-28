namespace Variant1;
public abstract class Resource
{
    public string Name { get; }
    public bool IsOpen { get; protected set; }
    public abstract void Open();
    public abstract void Close();
    
    protected Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }
    
}