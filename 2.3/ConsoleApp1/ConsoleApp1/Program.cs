using System;

class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Rate { get; set; }
    public int Days { get; set; }

    public Worker(string name,string surname,int rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
        
    public void GetSalary()
    {
        Console.WriteLine($"Заработанная плата работника за {Days}: {Days * Rate} руб.");
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
        
        worker.GetSalary();
    }
}