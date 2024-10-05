using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary;

public class StoreBaeltRepository : IStoreBaeltRepository
{
    private static readonly List<Vehicle> Vehicles = new List<Vehicle>();

    /// <inheritdoc />
    public Vehicle Add(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    
        return vehicle;
    }

    /// <inheritdoc />
    public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
    {
        return Vehicles
            .Where(x => x.Licenseplate == licensePlate)
            .ToList();
    }

    /// <inheritdoc />
    public List<Vehicle> GetAll()
    {
        return Vehicles;
    }
}