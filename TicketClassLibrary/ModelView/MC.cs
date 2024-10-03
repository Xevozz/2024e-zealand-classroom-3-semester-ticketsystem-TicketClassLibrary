namespace TicketClassLibrary.ModelView;

public class Mc : BaseClass
{
    public string Licenseplate { set; get; }
    
    public DateTime date { set; get; }
    
    public double Price()
    {
        return 125;
    }

    public string VehicleType()
    {
        return "MC";
    }

    public Mc(string licenseplate, DateTime date)
    {
        Licenseplate = licenseplate;
        this.date = date;
    }
    
    

    public void Deconstruct(out string licenseplate, out DateTime date)
    {
        licenseplate = Licenseplate;
        date = Date;
    }
}
