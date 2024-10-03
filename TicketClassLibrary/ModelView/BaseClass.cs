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
                throw new ArgumentException("Maks 7 tegn.");
            }
            Licenseplate = value;
        }
    }

    //Virtual makes it poossible to override and change price/date in sub-classes
    public virtual DateTime Date { get; set; }
    
    public virtual double Price { get; set; }
    
    public virtual double CalculatePrice(bool useBrobizz)
    {
        if (useBrobizz)
        {
            return Price * 0.95; // Applies 5% discount
        }
        return Price;
    }
    
}