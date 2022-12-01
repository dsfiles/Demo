public class Vehicle
{
    private string vin, make, model;
    private int mileage;
    public Vehicle() // constructor #1
    {
        vin = "N/A"; make = "N/A"; model = "N/A";
        mileage = 0;
    }
    public Vehicle(string vin, string make, string model, int mileage)
    {  // constructor #2 with parameters
        this.vin = vin;
        this.make = make;
        this.model = model;
        this.mileage = mileage;
    }
    public void Drive(int miles)
    {
        mileage += miles;
    }
    public void Display()
    {
        Console.WriteLine($"vin: {vin}, make: {make}, model: {model}, mileage: {mileage}");
    }
}