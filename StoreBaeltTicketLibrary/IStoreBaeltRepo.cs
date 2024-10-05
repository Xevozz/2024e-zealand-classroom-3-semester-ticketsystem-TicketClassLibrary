using TicketClassLibrary.ModelView;

namespace StoreBaeltTicketLibrary;

public interface IStoreBaeltRepo
{
    Vehicle Add(Vehicle vehicle);
    
    IEnumerable<Vehicle> GetAll();
    
    Vehicle? GetLicensePlate(string licensePlate);
}