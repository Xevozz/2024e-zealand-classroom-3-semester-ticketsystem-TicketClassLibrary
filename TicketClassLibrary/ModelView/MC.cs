namespace TicketClassLibrary.ModelView;

public class Mc : BaseClass
{
    //public string Licenseplate { set; get; }
    public override DateTime Date { get; set; }
    public DateTime date { set; get; }

    
    public override double Price => 125;

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
