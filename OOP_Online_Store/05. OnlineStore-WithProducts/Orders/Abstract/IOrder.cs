using System;
using System.Collections.Generic;
using System.Text;

namespace Order_WithProducts
{
    interface IOrder
    {
        /*properties*/
        /****************************************************************************/

        public string Recipient { get; }
        public Currency Currency { get; }   
        DateTime DeliveryOn { get; }


        /*methods*/
        /****************************************************************************/

        void AddItem(Product product);
        decimal CalculateTotalPrice();
        string DisplayPrice();
        string DisplayDeliveryDate();
        string DisplayGeneralInfo();
        string DisplayOrderItems();


    }
}
