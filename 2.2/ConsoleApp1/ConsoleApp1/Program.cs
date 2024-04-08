using System;
using System.Formats.Asn1;
using System.Xml.Serialization;

class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public Student(string lastName, DateTime dateOfBirth, int groupNumber, int[] grades)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public void ChangeLastName(string newLastName)
    {
        LastName = newLastName;
    }

    public void ChangeDateOfBirth(DateTime newDateOfBirth)
    {
        DateOfBirth = newDateOfBirth;
    }

    public void ChangeGroupNumber(int newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.WriteLine("Успеваемость:");
        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Оценка за предмет {i + 1}: {Grades[i]}");
        }
    }
}

class ConsoleApp1
{
    static void Main(string[] args)
    {
        string last_name = Console.ReadLine();
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year, month, day);
        int group_number = int.Parse(Console.ReadLine());
        int[] U = {5, 4, 5, 4, 4};
        
        Student student = new Student(last_name, date, group_number, U);
        
        student.PrintStudentInfo();

        Console.WriteLine("Руковотство");
        Console.WriteLine("Вывод информации - 1, Изменение фамилии - 2, Изменение даты рождения - 3, Изменение номера группы - 4, Закончить - 5");
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                student.PrintStudentInfo();
            }
            else if (n == 2)
            {
                Console.WriteLine("Изменение фамилии");
                Console.Write("Введите новую фамилию: ");
                string el = Console.ReadLine();
                student.ChangeLastName(el);
            }
            else if (n == 3)
            {
                Console.WriteLine("Изменение даты рождения");
                Console.Write("День: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("Месяц: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Год: ");
                int y = int.Parse(Console.ReadLine());

                student.ChangeDateOfBirth(new DateTime(y, m, d));
            }
            else if (n == 4)
            {
                Console.WriteLine("Изменение номера группы");
                int number = int.Parse(Console.ReadLine());
                student.ChangeGroupNumber(number);
            }
            else if (n == 5)
            {
                break;
                
            }
        }
    }
}