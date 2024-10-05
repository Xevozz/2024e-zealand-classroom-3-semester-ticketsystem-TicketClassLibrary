namespace TicketClassLibrary.ModelView;

/// <inheritdoc />
public class Mc : BaseClass
{
    //public string Licenseplate { set; get; }
    
    
    /// <summary>
    /// Overrides original property given in BaseClass
    /// </summary>
    public override DateTime Date { get; set; }
    
    
    /// <summary>
    /// Specific property given to MC Class
    /// </summary>
    public DateTime date { set; get; }
    
    
    /// <summary>
    /// Override the virtual class in BaseClass - Fixed price at 125.
    /// </summary>
    public override double Price => 125;

    
    /// <summary>
    /// returns the "MC" object (MotorCycle)
    /// </summary>
    /// <returns></returns>
    public string VehicleType()
    {
        return "MC";
    }
    
    /// <summary>
    /// Constructor for the properties gives to the MC Class.
    /// </summary>
    /// <param name="licenseplate"></param>
    /// <param name="date"></param>
    public Mc(string licenseplate, DateTime date)
    {
        Licenseplate = licenseplate;
        this.date = date;
    }
    
    
    
}
