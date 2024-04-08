using System;
using System.Collections.Generic;

class Train
{
    public string ItamName { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }

    public Train(string itemName, int trainNumber, DateTime departureTime)
    {
        ItamName = itemName;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public void TrainInfo()
    {
        Console.WriteLine($"Нвзвание пункта назначения: {ItamName}");
        Console.WriteLine($"Номер поезда: {TrainNumber}");
        Console.WriteLine($"Время отправления: {DepartureTime:T}");
    }
}

class TrainManager
{
    public List<Train> trains = new List<Train>();

    public void AddTrain(string itemName, int trainNumber, DateTime departureTime)
    {
        trains.Add(new Train(itemName, trainNumber, departureTime));
    }

    public Train FindTrainByNumber(int trainNumber)
    {
        foreach (Train train in trains)
        {
            if (train.TrainNumber == trainNumber)
            {
                return train;
            }
        }

        return null;
    }
}

class ConsoleApp2
{
    static void Main(string[] args)
    {
        TrainManager trainManager = new TrainManager();
        trainManager.AddTrain("Москва", 111, new DateTime(2024,5,1,7,7,7));
        trainManager.AddTrain("Казань", 542, new DateTime(2024,5,2,8,0,0));
        trainManager.AddTrain("Томск", 777, new DateTime(2024,5,5,9,0,0));
        
        Console.Write("Введите номер поезда: ");
        int n = int.Parse(Console.ReadLine());
        Train train = trainManager.FindTrainByNumber(n);
        if (train != null)
        {
            train.TrainInfo();
        }
        else
        {
            Console.WriteLine("Такого поезда нет");
        }
    }
}