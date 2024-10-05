
namespace TicketClassLibrary.ModelView;


/// <summary>
/// Abstract BaseClass provides some implementation
/// but leaves Methods to the Sub-classes that inherits.
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// This property is used for LisencePlate
    /// </summary>
    private string _licensePlate;

    /// <summary>
    /// This property is used for LisencePlate
    /// </summary>
    private DateTime _date;
    
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
                _licensePlate = value;
            }
        }
    
    /// <summary>
    /// Property added to be used for the 5% discount
    /// </summary>
    public bool BroBizz { get; set; }
    
    /// <summary>
    /// this property gets the "time" and "date" and sets it accordingly.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Abstract classes isn't instatiated directly, and is made for a baseclass,
    /// so subclasses can instantiate it when inherited/called.
    /// This Method is used by Sub-classes.
    /// </summary>
    public abstract double Price();

    /// <summary>
    /// Abstract classes isn't instatiated directly, and is made for a baseclass,
    /// so subclasses can instantiate it when inherited/called.
    /// This Method is used by Sub-classes.
    /// </summary>
    /// <returns></returns>
    public abstract string VehicleType();
    
}