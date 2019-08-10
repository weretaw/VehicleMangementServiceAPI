using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMangementService.Models
{
  public class Vehicle
  {
    public int? VehicleId { get; set; }
    public string Model { get; set; }
    public string Owner { get; set; }
    public string Year { get; set; }
    public string LicenseNumber { get; set; }
    public string Power { get; set; }
    public string TopSpeed { get; set; }
    public int kmPerHour { get; set; }
    public string Torque { get; set; }
    public string CO2Emissions { get; set; }
    public string EuroEmissStand { get; set; }
    public string MilesPerTank { get; set; }
    public double Height { get; set; }
    public string Wheelbase { get; set; }
    public string TurningCircile { get; set; }
    public double EngineSize { get; set; }
    public string Cylinders { get; set; }
    public string Valves { get; set; }
    public string FuelType { get; set; }
    public string Transmission { get; set; }
    public string GearBox { get; set; }
    public string Drivertrain { get; set; }
    public double Length { get; set; }

  }
}
