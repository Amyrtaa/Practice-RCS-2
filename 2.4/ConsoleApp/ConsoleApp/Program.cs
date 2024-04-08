using System;
using System.Collections.Generic;

class Roman
{
    private static Dictionary<char, int> RomanMap = new Dictionary<char, int> { {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000} };

    public static int ConvertToInteger(string roman)
    {
        int result = 0;
        int pred = 0;

        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int value = RomanMap[roman[i]];

            if (value < pred)
            {
                result -= value;
            }
            else
            {
                result += value;
            }

            pred = value;
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите римское число: ");
        string romanNumber = Console.ReadLine().ToUpper();
        
        int integerValue = Roman.ConvertToInteger(romanNumber);
        Console.WriteLine($"Целое число: {integerValue}");
    }
}