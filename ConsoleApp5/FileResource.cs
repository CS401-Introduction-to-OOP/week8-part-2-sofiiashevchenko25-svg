namespace Variant1;
public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
        
    }
    public override void Open()
    {

        if (IsOpen)
        {
            Console.WriteLine($"Open{Name}");
        }
        else
        {
            throw new Exception();
        }
        
    }
    
    public override void Close()
    {
        if (!IsOpen)
        {
            Console.WriteLine($"Close{Name}");
        }
        else
        {
            throw new Exception();;
        }
    }
    
    public void Dispose()
    {
        Close();
        Console.WriteLine($"dispose {Name}");
    }
}