using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary;

    public class StoreBaeltRepo : IStoreBaeltRepo
        {
            
            public static List<Vehicle> Vehicles = new List<Vehicle>();

            
            public Vehicle Add(Vehicle vehicle);
            {
                Vehicles.Add(Vehicle);

                return Vehicle;
            }

            
            public Vehicle? GetLicensePlate(string licensePlate)
                {
                    return Vehicle.Find(x => x.LicensePlate == licensePlate);
                }

            
            public IEnumerable<Vehicle> GetAllVehicles()
                {
                    return Vehicles;
                }
        }