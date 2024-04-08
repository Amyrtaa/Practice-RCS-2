using System;
using System.ComponentModel;

class Counter
{
    public int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int startValue)
    {
        value = startValue;
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value--;
    }

    public int Value 
    { 
        get { return value; }
    }
}

class ConsoleApp4
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Console.WriteLine("Руковтоство");
        Console.WriteLine("Увеличение счётчика <+>, уменьшения счётчика <->, вывод счетчика на экран <1>, счётчик с произвольным значением <2>");
        while (true)
        {
            string R = Console.ReadLine();
            if (R.Contains("+"))
            {
                counter.Increment();
            }
            else if (R.Contains("-"))
            {
                counter.Decrement();
            }
            else if (R == "1")
            {
                Console.WriteLine("Counter value: " + counter.Value);
            }
            else if (R == "2")
            {
                Console.WriteLine("Введите произвольное значение счетчика: ");
                int start = int.Parse(Console.ReadLine());
                Counter counter2 = new Counter(start);
                counter = counter2;
            }
        }
    }
}