using System;
using System.Collections.Generic;
using System.Text;

namespace Order_WithProducts
{
    class DomesticOrder : Order
    {
        public DomesticOrder(string recipient, Currency currency, DateTime deliveryOn) : base(recipient, currency, deliveryOn)
        {

        }

        public override string DisplayGeneralInfo()
        {
            string dateFormat = this.DisplayDeliveryDate();

            return $"Order to {this.Recipient} | Delivery on: {dateFormat} | Total: {this.DisplayPrice()}";
        }
    }
}
