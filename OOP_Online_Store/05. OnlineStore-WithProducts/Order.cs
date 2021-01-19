using System;
using System.Collections.Generic;
using System.Text;

namespace Order_WithProducts
{
    class Order : IOrder
    {
        /*fields*/
        /****************************************************************************/

        private string recipient;
        //private Currency currency;
        //private DateTime deliveryOn;
        private List<Product> items;


        /*constructor*/
        /****************************************************************************/

        public Order(string recipient, Currency currency, DateTime deliveryOn)
        {
            this.Recipient = recipient;
            this.Currency = currency;
            this.DeliveryOn = deliveryOn;
            this.items = new List<Product>();
        }


        /*properties*/
        /****************************************************************************/

        public string Recipient 
        {
            get => this.recipient;
            private set
            {
                if (value.Length < 3 || value.Length > 35)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.recipient = value ?? throw new ArgumentNullException();
            }
        }

        public Currency Currency { get; set; }

        public DateTime DeliveryOn { get; set; }

        /*methods*/
        /****************************************************************************/

        public void AddItem(Product item)
        {
            if (this.items.Contains(item))
            {
                throw new InvalidOperationException("Item already in order");
            }

            this.items.Add(item);
        }

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }

            if (this.Currency == Currency.BGN)
            {
                total = total * 1.75m;
            }

            return total;
        }

        public string DisplayPrice()
        {
            return $"{this.CalculateTotalPrice()} {this.Currency}";
        }

        public string DisplayDeliveryDate()
        {
            return this.DeliveryOn.ToShortDateString();
        }

        public string DisplayGeneralInfo()
        {
            string dateFormat = this.DisplayDeliveryDate();

            return $"Order to {this.recipient} | Delivery on: {dateFormat} | Total: {this.DisplayPrice()}";
        }

        public string DisplayOrderItems()
        {
            if (this.items.Count == 0)
            {
                return "No items";
            }

            StringBuilder sb = new StringBuilder();
            foreach (Product item in this.items)
            {
                sb.AppendLine($"  {item.DisplayInfo()}");
            }

            return sb.ToString();
        }
    }
}
