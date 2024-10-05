using TicketClassLibrary.ModelView;

namespace StoreBaeltTicketLibrary;

/// <summary>
/// Conbtains the Method needed for StorebealtRepository
/// </summary>
public interface IStoreBaeltRepository
{
    /// <summary>
    /// Hwej
    /// </summary>
    /// <param name="vehicle"></param>
    /// <returns></returns>
    Vehicle Add(Vehicle vehicle);
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<Vehicle> GetAll();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="licensePlate"></param>
    /// <returns></returns>
    List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
}