using Npgsql;

namespace GarageConsoleApp;

/// <summary>
/// Класс DatabaseRequests
/// содержит методы для отправки запросов к БД
/// </summary>
public static class DatabaseRequests
{
    /// <summary>
    /// Метод GetTypeCarQuery
    /// отправляет запрос в БД на получение списка типов машин
    /// выводит в консоль список типов машин
    /// </summary>
    public static void GetTypeCarQuery()
    {
        // Сохраняем в переменную запрос на получение всех данных и таблицы type_car
        var querySql = "SELECT * FROM type_car";
        // Создаем команду(запрос) cmd, передаем в нее запрос и соединение к БД
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        // Выполняем команду(запрос)
        // результат команды сохранится в переменную reader
        using var reader = cmd.ExecuteReader();
        
        // Выводим данные которые вернула БД
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Название: {reader[1]}");
        }
    }

    /// <summary>
    /// Метод AddTypeCarQuery
    /// отправляет запрос в БД на добавление типа машины
    /// </summary>
    public static void AddTypeCarQuery(string name)
    {
        var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод AddDriverQuery
    /// отправляет запрос в БД на добавление водителей
    /// </summary>
    public static void AddDriverQuery(string firstName, string lastName, string birthdate)
    {
        var querySql = $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{birthdate}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод GetDriverQuery
    /// отправляет запрос в БД на получение списка водителей
    /// выводит в консоль данные о водителях
    /// </summary>
    public static void GetDriverQuery()
    {
        var querySql = "SELECT * FROM driver";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
        }
    }

    /// <summary>
    /// Метод AddRightsCategoryQuery
    /// отправляет запрос в БД на добавление категорий прав
    /// </summary>
    public static void AddRightsCategoryQuery(string name)
    {
        var querySql = $"INSERT INTO rights_category(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод AddDriverRightsCategoryQuery
    /// отправляет запрос в БД на добавление категории прав водителю
    /// </summary>
    public static void AddDriverRightsCategoryQuery(int driver, int rightsCategory)
    {
        var querySql = $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ({driver}, {rightsCategory})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод GetDriverRightsCategoryQuery
    /// отправляет запрос в БД на получение категорий водителей
    /// выводит в консоль информацию о категориях прав водителей
    /// </summary>
    public static void GetDriverRightsCategoryQuery(int driver)
    {
        var querySql = "SELECT dr.first_name, dr.last_name, rc.name " +
                       "FROM driver_rights_category " +
                       "INNER JOIN driver dr on driver_rights_category.id_driver = dr.id " +
                       "INNER JOIN rights_category rc on rc.id = driver_rights_category.id_rights_category " +
                       $"WHERE dr.id = {driver};";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
        }
    }

    public static void GetCarQuery()
    {
        var querySql = "SELECT * FROM car";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader[0]}, ID тип машины: {reader[1]}, Название машины: {reader[2]}, Государственный номер {reader[3]}, Номер пассажира: {reader[4]}");
        }
    }

    public static void AddCarQuery(int typeCar, string nameCar, string stateNumber, int passengers)
    {
        var querySql = $"INSERT INTO car(id_type_car, name, state_number, number_passengers) VALUES ({typeCar}, '{nameCar}', '{stateNumber}', {passengers})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    public static void GetItineraryQuery()
    {
        var querySql = $"SELECT * FROM itinerary";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();
        
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader[0]}, Маршрут: {reader[1]}");
        }
    }

    public static void AddItineraryQuery(string newItinerary)
    {
        var querySql = $"INSERT INTO itinerary(name) VALUES ('{newItinerary}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    public static void GetRouteQuery()
    {
        var querySql = $"SELECT * FROM route";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]}, Id водителя: {reader[1]}, Id машины: {reader[2]}, Id маршрута: {reader[3]}, Номер пассажира: {reader[4]}");
        }
    }

    public static void AddRouteQuery(int idDriver, int idCar, int idItinerary, int passenger)
    {
        var querySql = $"INSERT INTO route(id_driver, id_car, id_itinerary, number_passengers) VALUES ({idDriver}, {idCar}, {idItinerary}, {passenger})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
}