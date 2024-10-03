namespace TicketClassLibrary.ModelView
{
    public class Car : BaseClass
    {
        //public string Licenseplate { set; get; }
        
        public override double Price => 240;

        public string VehicleType()
        {
            return "Car";
        }

        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        public override string ToString()
        {
            return
                $"{nameof(Licenseplate)}: {Licenseplate}, {nameof(Date)}: {Date}, {nameof(Price)}: {Price}, {nameof(VehicleType)}: {VehicleType}";
        }
    }
}
