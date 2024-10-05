using TicketClassLibrary.ModelView;

namespace OreSundBroen;

public class OresundCar : Vehicle
{
    /// <summary>
    /// This Method checks if the car has a BroBizz
    /// </summary>
    /// <returns></returns 161 kr & 410 kr depending on Brobizz True/false>
    public override double Price()
        {
            return BroBizz ? 161 : 410;
        }

    /// <summary>
    /// This Method Tell the new type of Vehicle after Discount Method
    /// </summary>
    /// <returns></returns>
    public override string VehicleType()
        {
            return "Oresund Car";
        }
}