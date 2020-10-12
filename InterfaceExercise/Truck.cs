using InterfaceExercise;
using System;

public class Truck : IVehicle, ICompany
{
	public Truck()
	{
        hasBed = true;
        carryingCap = 1595.32;
        Logo = "Toyota";
        CompanyName = "Toyota";
        Wheels = 4;
        Seats = 5;
        isDriveable = true;
        Model = "Tundra";
	}
	public bool hasBed { get; set; }
	public double carryingCap { get; set; }
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    public int Wheels { get; set; }
    public int Seats { get; set; }
    public bool isDriveable { get; set; }
    public string Model { get; set; }
}
