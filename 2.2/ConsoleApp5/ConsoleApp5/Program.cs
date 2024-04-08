using System;


class MyClass : IDisposable
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public MyClass(int property1, string property2)
    {
        Property1 = property1;
        Property2 = property2;
    }

    public MyClass()
    {
        Property1 = 0;
        Property2 = "default";
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Property 1: {Property1}, Property 2: {Property2}");
    }
    
    public void Dispose()
    {
        Console.WriteLine($"Dispons Property 1: {Property1}, Property 2: {Property2}");
    }
}

class ConsoleApp5
{
    static void Main(string[] args)
    {
        using (MyClass obj1 = new MyClass(10, "Hello"))
        {
            obj1.DisplayProperties();
        }

        using (MyClass obj2 = new MyClass(3, "dks"))
        {
            obj2.DisplayProperties();
        }
    }
}