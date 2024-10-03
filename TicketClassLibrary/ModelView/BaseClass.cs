namespace TicketClassLibrary.ModelView;

//Abstract Baseclass provides some implementation
//but leaves Methods to the Sub-classes that inherits.
public abstract class BaseClass
{
    public string Licenseplate { get; set; }
        
    public DateTime Date { get; set; }
}