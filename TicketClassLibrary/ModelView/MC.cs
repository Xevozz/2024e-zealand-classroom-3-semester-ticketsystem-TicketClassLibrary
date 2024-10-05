namespace TicketClassLibrary.ModelView;

/// <inheritdoc />
public class MC : Vehicle
{
    /// <summary>
    /// Override the virtual class in BaseClass - Fixed price at 125 + 5% discount with BroBizz.
    /// </summary>
    public override double Price()
        {
            if (BroBizz)
            {
                return 125 * 0.95;
            }
            else
            {
                return 125;
            }
        }

    
    /// <summary>
    /// returns the vehicle "MC" object.
    /// </summary>
    /// <returns></returns>
    public override string VehicleType()
        {
            return "MC";
        }
    
}
