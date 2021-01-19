using System;
using System.Collections.Generic;
using System.Text;

namespace Order_WithProducts
{
    class InternationalOrder : Order, IOrder
    {
        /*fields*/
        /****************************************************************************/




        /*constructor*/
        /****************************************************************************/

        public InternationalOrder(string recipient, Currency currency, DateTime deliveryOn, string carrier, int customsPercentage) : base(recipient, currency, deliveryOn)
        {
            this.Carrier = carrier;
            this.CustomsPercentage = customsPercentage;

        }


        /*properties*/
        /****************************************************************************/

        public string Carrier { get; private set; }
        public int CustomsPercentage { get; private set; }


        /*methods*/
        /****************************************************************************/

        public new string DisplayGeneralInfo()
        {
            string dateFormat = this.DisplayDeliveryDate();

            return $"International order to {this.Recipient} | Delivery on: {dateFormat} | Total: {this.DisplayPrice()} | Carrier: {this.Carrier} | *NOTE* - customs of {this.CustomsPercentage}% expected but to be calculated on arrival";
        }


    }
}
