namespace ConcoleApp5;
public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; //створюємо int
        object A = a; //копіюємо a в object(купа)
        int unA = (int)A; //дістаєм значення a назад(стек)
        
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"boxedA = {A}");
        Console.WriteLine($"unboxedA = {unA}");
        
    }
}