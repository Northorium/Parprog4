namespace Par_progUke4;

public class Car
{
    public int CarId { get; private set; }
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }
    public string PlateNumber { get; private set; }
    public int Kilometer { get; private set; }

    public Car(int carId,string brand, string model, int year, string plateNumber, int kilometer)
    {
        CarId=carId;
        Brand = brand;
        Model = model;
        Year = year;
        PlateNumber = plateNumber;
        Kilometer = kilometer;
    }
    
}