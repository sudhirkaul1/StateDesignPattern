using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.States
{
    public class NewOrderState : BaseOrderState
    {
       
        public override void CheckStock()
        {
            Console.WriteLine("Stock available");
            this._orderBooking .TransitionTo(new ProcessOrderState());
        }

        public override void ProcessOrderNext()
        {
            CheckStock();
        }
    }
}
