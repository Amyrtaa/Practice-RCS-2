namespace GarageConsoleApp;

public class Program 
{
    public static void Main(string[] args)
    {
        Instructions();
        App();
    }

    static void Instructions()
    {
        Console.WriteLine("Для просмотра и добавления типов машин - 1");
        Console.WriteLine("Для просмотра и добваления водителей и их прав - 2");
        Console.WriteLine("Для просмотра и добавления машин - 3");
        Console.WriteLine("Для просмотра и добавления маршрутов - 4");
        Console.WriteLine("Для просмотра и добавления рейсов - 5");
        Console.WriteLine("Если все поняли пропустите перед тем как начать работу с БД, нажав <Enter>");
        Console.ReadLine();
    }
    
    static void App()
    {
        while (true)
        {
            Console.WriteLine("\nГлавые действия");
            Console.Write("Введите действие от 1 до 5: ");
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.WriteLine("1 - посмотреть, 2 - добавить");
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                if (1 == n)
                {
                    Console.WriteLine("Список типов машин: ");
                    DatabaseRequests.GetTypeCarQuery();
                }
                else if (2 == n)
                {
                    Console.WriteLine("\nДобавление нового типа машин");
                    Console.Write("Введите тип машины: ");
                    string name = Console.ReadLine();
                    DatabaseRequests.AddTypeCarQuery(name);
                }
            }
            else if (N == 2)
            {
                Console.WriteLine("1 - посмотреть список водителей, 2 - посмотреть список прав водителей");
                Console.WriteLine("3 - добавить водителя, 4 - добавить права водителя");
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                if (1 == n)
                {
                    Console.WriteLine("Список водителей: ");
                    DatabaseRequests.GetDriverQuery();
                }
                if (2 == n)
                {
                    Console.WriteLine();
                    Console.WriteLine("Категоря прав водителей");
                    Console.Write("Введите ID водителя: ");
                    int driver = int.Parse(Console.ReadLine());
                    DatabaseRequests.GetDriverRightsCategoryQuery(driver);
                }
                else if (3 == n)
                { 
                    Console.WriteLine("Ввдеите данные водителя");
                    Console.Write("Введите Имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введите Фамилию: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Дата рождения водителя");
                    Console.Write("Введите день: ");
                    int day = int.Parse(Console.ReadLine());
                    Console.Write("Введите месяц: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.Write("Введите год: ");
                    int year = int.Parse(Console.ReadLine());
                    //DateTime birthdate = new DateTime(year, month, day);
                    string birthdate = $"{year}-{month}-{day}";
                    DatabaseRequests.AddDriverQuery(firstName, lastName, birthdate);
                }
                else if (4 == n)
                {
                    Console.WriteLine("\nДобавление категорию прав водютеля (есть 3 категории прав: 1 - A; 2 - B; 3 -C)");
                    Console.Write("Введите ID водителя: ");
                    int driver = int.Parse(Console.ReadLine());
                    Console.Write("Введите категорию прав водителю: ");
                    int rightsCategory = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddDriverRightsCategoryQuery(driver, rightsCategory);
                }
            }
            else if (N == 3)
            {
                Console.WriteLine("1 - посмотреть, 2 - добавить");
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Машины:");
                    DatabaseRequests.GetCarQuery();
                }
                else if (n == 2)
                {
                    Console.WriteLine("Введите данные новой машины");
                    Console.Write("Введите Id типа машины: ");
                    int typeCar = int.Parse(Console.ReadLine());
                    Console.Write("Введите имя машины: ");
                    string nameCar = Console.ReadLine();
                    Console.Write("Введите номер машины: ");
                    string stateNumber = Console.ReadLine();
                    Console.Write("Введите номер пассажира: ");
                    int passengers = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddCarQuery(typeCar, nameCar, stateNumber, passengers);
                }
            }
            else if (N == 4)
            {
                Console.WriteLine("Маршрут");
                Console.WriteLine("1 - просмотр, 2 - добавить");
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Маршруты: ");
                    DatabaseRequests.GetItineraryQuery();
                }
                else if (n == 2)
                {
                    Console.WriteLine("Добавление нового маршрута, пример: <Москва-Рим>");
                    Console.Write("Введите маршрут: ");
                    string ininerary = Console.ReadLine();
                    DatabaseRequests.AddItineraryQuery(ininerary);
                }
            }
            else if (N == 5)
            {
                Console.WriteLine("Рейсы");
                Console.WriteLine("1 - просмотр, 2 - добавить");
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                if (1 == n)
                {
                    Console.WriteLine("Рейсы: ");
                    DatabaseRequests.GetRouteQuery();
                }
                else if (2 == n)
                {
                    Console.WriteLine("Добавление нового рейса");
                    Console.Write("Введите id водителя: ");
                    int IdDriver = int.Parse(Console.ReadLine());
                    Console.Write("Введите id машины: ");
                    int IdCar = int.Parse(Console.ReadLine());
                    Console.Write("Введите id маршрута: ");
                    int IdItinerary = int.Parse(Console.ReadLine());
                    Console.Write("Введите номер пассажира: ");
                    int Passengers = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddRouteQuery(IdDriver, IdCar, IdItinerary, Passengers);
                }
            }
            else
            {
                Console.WriteLine("Такого действия нет");
                break;
            }
        }
    }
}