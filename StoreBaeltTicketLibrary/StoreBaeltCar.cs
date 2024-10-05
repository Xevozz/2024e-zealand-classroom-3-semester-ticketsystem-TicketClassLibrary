using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary;

public class StoreBaeltCar : Car
{
    public override double Price()
    {
        double finalprice = 240;

        if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                //Defines the 20% discount for cars only.
                finalprice *= 0.80;
            }

        if (BroBizz)
            {
                //Defines the 5% discount for BroBizz Users
                finalprice *= 0.95;
            }
        
        return finalprice;
    }

    public override string VehicleType()
        {
            return "StoreBaeltCar";
        }
}