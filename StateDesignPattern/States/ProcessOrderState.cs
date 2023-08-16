namespace StateDesignPattern.States
{
    public class ProcessOrderState : BaseOrderState
    {      
        public void CreateOrderLines()
        {
            Console.WriteLine("Order lines created");
        }

        public override void ProcessOrder()
        {
            CreateOrderLines();
        }

        public override void ProcessOrderNext()
        {
            CreateOrderLines();
        }
    }
}