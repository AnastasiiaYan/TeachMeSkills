namespace OOP_Task3;

public class TaskExecution
{
    static void Main()
    {
        Bus bus = new Bus("ул. Савушкина", 777, new DateTime(2024, 01, 12, 10, 00, 00), 20);
        Console.WriteLine(bus.Destination);
        Console.WriteLine(bus.Number);
        Console.WriteLine(bus.DepartureTime);
        Console.WriteLine(bus.NumberOfSeats);

        PublicTransport[] publicTransport = 
        {
            new Bus("ул. Савушкина", 777, new DateTime(2024, 01, 02, 10, 00, 00), 20),
            new Trolleybus("ул. Народная", 12, new DateTime(2024, 01, 12, 12, 00, 00), 18),
            new Tramcar("ул. Новгородская", 749, new DateTime(2024, 01, 03, 13, 00, 00), 35),
            new RiverTram("наб. Макарова", 1, new DateTime(2024, 01, 02, 18, 15, 00), 10),
            new Subway("Девяткино", 70041, new DateTime(2024, 01, 01, 19, 30, 00), 1490)
        };
        var sortedArray = publicTransport.OrderBy(x => x.NumberOfSeats);
        foreach (PublicTransport transport in sortedArray)
        {
            transport.PrintTransportInfo();
        }
        
        Console.Write("Введите пункт назначения: ");
        string? Destination = Console.ReadLine();

        int foundTransportCounter = 0;
        foreach (PublicTransport transport in publicTransport)
        {
            if (transport.Destination == Destination)
            {
                transport.PrintTransportInfo();
                foundTransportCounter++;
            }
        }
        if (foundTransportCounter == 0)
        {
            Console.WriteLine("Не найден транспорт до заданного пункта назначения");
        }

        Console.Write("Введите время отправления: ");
        string? departureTime = Console.ReadLine();
        DateTime convertedDepartureTime = Convert.ToDateTime(departureTime);

        foundTransportCounter = 0;
        foreach (PublicTransport transport in publicTransport)
        {
            if (transport.DepartureTime >= convertedDepartureTime)
            {
                transport.PrintTransportInfo();
                foundTransportCounter++;
            }
        }
        if (foundTransportCounter == 0)
        {
            Console.WriteLine("Не найден транспорт на заданную дату и время");
        }
    }
}