using TicketClassLibrary.ModelView;

namespace StoreBaeltTicketLibrary;

public class StoreBaeltCar : Car
{
    /// <summary>
    /// Overrides the Price and checks date/day and gives discounts accordingly
    /// </summary>
    /// <returns></returns>
    public override double Price()
    {
        var finalprice = 240d;

        if (Date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
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

    /// <summary>
    /// returns new Vehicletype "StorebaeltCar" which inclused the discounts.
    /// </summary>
    /// <returns></returns>
    public override string VehicleType()
    {
        return "StoreBaeltCar";
    }
}