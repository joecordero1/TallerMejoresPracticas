using System.Collections.Generic;
using DesignPatterns.Models;

public class VehicleCollection
{
    public ICollection<Vehicle> Vehicles { get; private set; }

    public VehicleCollection()
    {
        Vehicles = new List<Vehicle>();
    }
}
