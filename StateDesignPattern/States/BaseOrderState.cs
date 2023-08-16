using StateDesignPattern.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.States
{
    public abstract class BaseOrderState
    {
        public OrderBooking _orderBooking;

        public virtual void ChangeState(OrderBooking orderBooking)
        {
            _orderBooking = orderBooking;
        }

        public virtual void CheckStock() { }
        public virtual void ProcessOrder() { }

        public abstract void ProcessOrderNext();

    }
}
