
namespace TicketClassLibrary.ModelView;


/// <summary>
/// Abstract BaseClass provides some implementation
/// but leaves Methods to the Sub-classes that inherits.
/// </summary>
public abstract class BaseClass
{
    /// <summary>
    /// Method given to the property "licenseplate".
    /// Methods ensures Numberplate info is atleast 7 or fewer characters.
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
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
    
    /// <summary>
    /// Virtual makes it possible to override and change date in SubClasses
    /// </summary>
    public virtual DateTime Date { get; set; }
    
    /// <summary>
    /// Virtual makes it possible to override and change price in SubClasses
    /// </summary>
    public virtual double Price { get; set; }
    
    /// <summary>
    /// Method to calculate the 5% discount given from BroBizz
    /// </summary>
    /// <param name="useBrobizz"></param>
    /// <returns></returns>
    public virtual double CalculatePrice(bool useBrobizz)
    {
        if (useBrobizz)
        {
            return Price * 0.95; // Applies 5% discount
        }
        return Price;
    }
    
}