public delegate void SimpleDelegate();

public class DelegateExample
{
    public required SimpleDelegate myDelegate;
    public void SayHello()
    {
        Console.WriteLine("Hello, world!");
    }
}