namespace OOP_Task3;

public class Tramcar : PublicTransport
{
    private string destination;
    private int number;
    private DateTime departureTime;
    private int numberOfSeats;

    public string Destination 
    { 
        get { return destination; }
        set { destination = value; }
    }
    public int Number 
    { 
        get { return number; }
        set { number = value; }
    }
    public DateTime DepartureTime
    { 
        get { return departureTime; }
        set { departureTime = value; }
    }
    public int NumberOfSeats 
    {
        get { return numberOfSeats; }
        set { numberOfSeats = value; }
    }

    public Tramcar(string destination, int number, DateTime departureTime, int numberOfSeats)
    {
        this.destination = destination;
        this.number = number;
        this.departureTime = departureTime;
        this.numberOfSeats = numberOfSeats;
    }
    public override TransportType GetTransportType()
    {
        return TransportType.Rail;
    }

    public override void PrintTransportInfo()
    {
        Console.WriteLine($"Пункт назначения: {destination}");
        Console.WriteLine($"Номер транспорта: {number}");
        Console.WriteLine($"Время отправления: {departureTime}");
        Console.WriteLine($"Кол-во мест: {numberOfSeats}");
    }    
}
