using TicketClassLibrary.ModelView;

namespace OreSundBroen;

public class OresundMc : MC
{
    /// <summary>
    /// This Method checks if the car has a BroBizz
    /// </summary>
    /// <returns></returns 73 kr. & 210 kr. depending on Brobizz True/false>
    public override double Price()
    {
        return BroBizz ? 73 : 210;
    }

    /// <summary>
    /// This Method Tell the new type of Vehicle after Discount Method
    /// </summary>
    /// <returns></returns>
    public override string VehicleType()
    {
        return "Oresund MC";
    }
}