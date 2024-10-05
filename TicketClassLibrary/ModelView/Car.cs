namespace TicketClassLibrary.ModelView
{
    /// <inheritdoc />
    public class Car : Vehicle
    {
        /// <summary>
        /// Override the virtual class in BaseClass - Fixed price at 240 + 5% discount with BroBizz.
        /// </summary>
        public override double Price()
        {
            if (BroBizz)
            {
                return 240 * 0.95;
            }

            return 240;
        }

        /// <summary>
        /// returns the vehicle "Car" object
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}