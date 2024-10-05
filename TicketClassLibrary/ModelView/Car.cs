namespace TicketClassLibrary.ModelView
{
    /// <inheritdoc />
    public class Car : BaseClass
    {
        //public string Licenseplate { set; get; }
        
        /// <summary>
        /// Override the virtual class in BaseClass - Fixed price at 240.
        /// </summary>
        public override double Price => 240;

        /// <summary>
        /// returns the "MC" object (MotorCycle)
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// Constructor for the properties gives to the MC Class.
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// TwoString added for easily accesible properties throughout the solution.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return
                $"{nameof(Licenseplate)}: {Licenseplate}, {nameof(Date)}: {Date}, {nameof(Price)}: {Price}, {nameof(VehicleType)}: {VehicleType}";
        }
    }
}
