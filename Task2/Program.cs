using System;

class Vehicle
{
    private double x;
    private double y;
    private double z;
    private double price;
    private double speed;
    private uint year;

    public Vehicle(double x, double y, double z, double price, double speed, uint year)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Coordinates: ({x}, {y}, {z})");
        Console.WriteLine($"Price: {price:C}");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year: {year}");
    }
}

class Plane : Vehicle
{
    private double altitude;
    private int passengerCount;

    public Plane(double x, double y, double z, double price, double speed, uint year, double altitude, int passengerCount)
        : base(x, y, z, price, speed, year)
    {
        this.altitude = altitude;
        this.passengerCount = passengerCount;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Altitude: {altitude} meters");
        Console.WriteLine($"Passenger Count: {passengerCount}");
    }
}

class Car : Vehicle
{
    public Car(double x, double y, double z, double price, double speed, uint year)
        : base(x, y, z, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengerCount;
    private string port;

    public Ship(double x, double y, double z, double price, double speed, uint year, int passengerCount, string port)
        : base(x, y, z, price, speed, year)
    {
        this.passengerCount = passengerCount;
        this.port = port;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Passenger Count: {passengerCount}");
        Console.WriteLine($"Port: {port}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Plane(10, 20, 30, 60000000, 800, 2019, 10000, 250);
        Vehicle vehicle2 = new Car(50, 60, 70, 300000, 180, 2023);
        Vehicle vehicle3 = new Ship(30, 40, 50, 200000000, 30, 2017, 500, "Singapore");

        Console.WriteLine("Vehicle 1:");
        vehicle1.ShowInfo();

        Console.WriteLine("\nVehicle 2:");
        vehicle2.ShowInfo();

        Console.WriteLine("\nVehicle 3:");
        vehicle3.ShowInfo();
    }
}
