using TicketClassLibrary.ModelView;

namespace StoreBaeltTicketLibrary;

public class WeekendPrice : BaseClass
{
    public Double WeekendPriceBizz(bool weekendPrice)
    {
        //if weekendprice method is implemented 20% discount
        if (weekendPrice)
        {
            return Price * 0.80;
        }
        
        //Applies the extra 5% discount afterwards.
        return Price * 0.95;
    }
}