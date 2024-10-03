namespace TicketClassLibrary.ModelView;

//Abstract Baseclass provides some implementation
//but leaves Methods to the Sub-classes that inherits.
public abstract class BaseClass
{
    public string Licenseplate
    {
        get { return Licenseplate; }
        set
        {
            //If value is less or equal 7, throw exception
            if (value.Length <= 7)
            {
                throw new ArgumentException("Der skal være minimum 7 tegn.");
            }
            Licenseplate = value;
        }
    }

    public DateTime Date { get; set; }
}