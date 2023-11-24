using static Car.Car;

namespace Car;

public class Program
{
    public static void Main(string[] args)

    {
        var Toyota = new Car(1, "Camry", 2022, "Jonathan Adebayo", "Blue", 2022, FuelType.Gasoline, EngineType.V6 );
        var Mercedes = new Car(2, " OM629", 2021, "Adewale Adelaja", "Red", 2021 , FuelType.Diesel, EngineType.V8);
        var Audi = new Car(3, "Q4", 2023, "Samuel James", "Black",2022,FuelType.Electric, EngineType.Etron);

        Console.WriteLine("Car details");

        Console.WriteLine("\nCar Details:");
        Console.WriteLine("Toyota:");
        Toyota.DisplayCarDetails();

        Console.WriteLine("\nMercedes:");
        Mercedes.DisplayCarDetails();

        Console.WriteLine("\nAudi:");
        Audi.DisplayCarDetails();

    }

}




class Car 
{
     public int CarId { get; set; }   
    public string CarType { get; set; }   
    public int CarModel{ get; set; }
    public string CarOwner {  get; set; }  
    public string   CarColour {  get; set; }  
    public int CarYear { get; set; }
    public FuelType Fuel { get; set; }
    public EngineType Engine { get; set; }



    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric
    }

    public enum EngineType
    {
        V6,
        V8,
       Etron
    }



    
    public Car(int carId, string carType, int carModel, string carOwner, string carColour, int carYear,FuelType fuel,EngineType engine)
    {
        CarId = carId;
        CarType = carType;
        CarModel = carModel;
        CarOwner = carOwner;
        CarColour = carColour;
        CarYear = carYear;
        Fuel = fuel;
        Engine = engine;


       
    }
   
    public void DisplayCarDetails()
    {
        Console.WriteLine($"  CarId: {CarId}");
        Console.WriteLine($"  CarType: {CarType}");
        Console.WriteLine($"  CarModel: {CarModel}");
        Console.WriteLine($"  CarOwner: {CarOwner}");
        Console.WriteLine($"  CarColour: {CarColour}");
        Console.WriteLine($"  CarYear: {CarYear}");
        Console.WriteLine($"  Fuel: {Fuel}");
        Console.WriteLine($"  Engine: {Engine}");

    }

    

}