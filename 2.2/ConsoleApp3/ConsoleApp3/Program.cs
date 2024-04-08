using System;

class TwoNumbers
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public TwoNumbers(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public void DisplayNumbers()
    {
        Console.WriteLine($"Number 1: {Number1}");
        Console.WriteLine($"Number 2: {Number2}");
    }

    public void ChangeNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }

    public int SumOfNumbers()
    {
        return Number1 + Number2;
    }

    public int MaxNumber()
    {
        return Math.Max(Number1, Number2);
    }
}

class ConsoleApp3
{
    static void Main(string[] args)
    {
        TwoNumbers twoNumbers = new TwoNumbers(14, 7);
        Console.WriteLine("Руковотство");
        Console.WriteLine("1 - Вывод на экран, 2 - Изменение чисел, 3 - Нахождение сумма чисел, 4 - Нахождение наибольшего значения, 5 - Закончить");
        while (true)
        {
            Console.Write("Введите действие: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                twoNumbers.DisplayNumbers();
            }
            else if (n == 2)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                twoNumbers.ChangeNumbers(a, b);
            }
            else if (n == 3)
            {
                Console.WriteLine($"Сумма: {twoNumbers.SumOfNumbers()}");
            }
            else if (n == 4)
            {
                Console.WriteLine($"Максимальное число: {twoNumbers.MaxNumber()}");
            }
            else if (n == 5)
            {
                break;
            }
        }
    }
}