namespace OOP_Task3;

abstract public class PublicTransport
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
    public abstract TransportType GetTransportType();

    public abstract void PrintTransportInfo();   
}