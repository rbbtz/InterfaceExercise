using InterfaceExercise;
using System;

public class SUV : IVehicle, ICompany
{
	public SUV()
	{
        hasHatch = true;
        Rows = 3;
        Logo = "Honda";
        CompanyName = "Honda";
        Wheels = 4;
        Seats = 8;
        isDriveable = true;
        Model = "Oddesey";
    }
	public bool hasHatch { get; set; }
	public int Rows { get; set; }
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    public int Wheels { get; set; }
    public int Seats { get; set; }
    public bool isDriveable { get; set; }
    public string Model { get; set; }
}
