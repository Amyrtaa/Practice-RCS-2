using System;

class Calculation
{
    private string CalculationLine = "default";

    public void SetCalculationLine(string calculationLine)
    {
        CalculationLine = calculationLine;
    }

    public void SetLastSymbolCalculationLine(string symbols)
    {
        CalculationLine += symbols;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine(CalculationLine);
    }

    public char GetLastSymbol()
    {
        return CalculationLine[CalculationLine.Length-1];
    }

    public void DeleteLastSymbol()
    {
        string newString = "";
        for (int i = 0; i < CalculationLine.Length - 1; i++)
        {
            newString += CalculationLine[i];
        }

        CalculationLine = newString;
    }
}

class ConsoleApp3
{
    static void Main(string[] args)
    {
        Calculation calculation = new Calculation();
        char str;
        Console.Write("1 - новая строка, 2 - прибавить значения, 3 - Ввывести строку," +
                      " 4 - последний символ строки, 5 - удаление последнего символа");
        Console.WriteLine();
        while (true)
        {
            Console.Write("Введите действие: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.Write("Изменение значения свойства: ");
                string newString = Console.ReadLine();
                calculation.SetCalculationLine(newString);
            }
            else if (n == 2)
            {
                Console.Write("Прибавить значения в конец строки: ");
                string symbols = Console.ReadLine();
                calculation.SetLastSymbolCalculationLine(symbols);
            }
            else if (n == 3)
            {
                Console.Write("Нынешняя строка: ");
                calculation.GetCalculationLine();
            }
            else if (n == 4)
            {
                Console.Write("Последний символ строки: ");
                str = calculation.GetLastSymbol();
                Console.WriteLine(str);
            }
            else if (n == 5)
            {
                str = calculation.GetLastSymbol();
                Console.WriteLine($"Удаление последнего символа строки: {str.ToString()}");
                calculation.DeleteLastSymbol();
            }
        }
    }
}