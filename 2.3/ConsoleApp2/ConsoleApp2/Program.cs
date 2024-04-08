using System;

class Worker
{
    private string Name { get; set; }
    private string Surname { get; set; }
    private int Rate { get; set; }
    private int Days { get; set; }

    public Worker(string name,string surname,int rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetSurname()
    {
        return Surname;
    }

    public int GetRate()
    {
        return Rate;
    }

    public int GetDays()
    {
        return Days;
    }    
    
    public void GetSalary()
    {
        Console.WriteLine($"Заработанная плата: {Days * Rate} руб.");
    }
}

class ConsoleApp1
{
    static void Main(string[] args)
    {
        Console.Write("Введите ставку за день работы: ");
        int rate = int.Parse(Console.ReadLine());
        Console.Write("Введите количество отработанных дней: ");
        int days = int.Parse(Console.ReadLine());
        
        Worker worker = new Worker("Амыртаа-Билик", "Чооду", rate, days);
        
        Console.WriteLine("Информация о сотруднике: ");
        Console.WriteLine($"Name: {worker.GetName()} \nSurname: {worker.GetSurname()} " +
                          $"\nRate: {worker.GetRate()} \nDays: {worker.GetDays()}");
        worker.GetSalary();
    }
}