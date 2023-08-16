using StateDesignPattern.States;

namespace StateDesignPattern.BusinessLogic;
public class OrderBooking
{

    private BaseOrderState? State { get; set; }

    public OrderBooking(BaseOrderState state)
    {
        TransitionTo(state);
    }
     public void TransitionTo(BaseOrderState state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        State = state;
        state.ChangeState(this);
    }
     public void BookOrder()
    {
        State.CheckStock();
    }

    public void ProcessOrder()
    {
        State.ProcessOrder();
    }

    public void ProcessOrderNext()
    {
        State.ProcessOrderNext();
    }



    

}
