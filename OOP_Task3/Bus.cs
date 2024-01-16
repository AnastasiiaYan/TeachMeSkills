namespace OOP_Task3;

public class Bus : PublicTransport
{
    private string destination;
    private int number;
    private DateTime departureTime;
    private int numberOfSeats;

    public new string Destination 
    { 
        get { return destination; }
        set { destination = value; }
    }
    public new int Number 
    { 
        get { return number; }
        set { number = value; }
    }
    public new DateTime DepartureTime
    { 
        get { return departureTime; }
        set { departureTime = value; }
    }
    public new int NumberOfSeats 
    {
        get { return numberOfSeats; }
        set { numberOfSeats = value; }
    }

    public Bus(string destination, int number, DateTime departureTime, int numberOfSeats)
    {
        this.destination = destination;
        this.number = number;
        this.departureTime = departureTime;
        this.numberOfSeats = numberOfSeats;
    }

    public override TransportType GetTransportType()
    {
        return TransportType.Ground;
    }

    public override void PrintTransportInfo()
    {
        Console.WriteLine($"Пункт назначения: {destination}");
        Console.WriteLine($"Номер транспорта: {number}");
        Console.WriteLine($"Время отправления: {departureTime}");
        Console.WriteLine($"Кол-во мест: {numberOfSeats}");
    }
}