using InterfaceExercise;
using System;

public class Car : IVehicle, ICompany
{
	public Car()
	{
        hasTrunk = true;
        topSpeed = 160.5;
        Logo = "Suburu";
        CompanyName = "Suburu";
        Wheels = 4;
        Seats = 2;
        isDriveable = true;
        Model = "WRX";
    }
	public bool hasTrunk { get; set; }
	public double topSpeed { get; set; }
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    public int Wheels { get; set; }
    public int Seats { get; set; }
    public bool isDriveable { get; set; }
    public string Model { get; set; }
}
