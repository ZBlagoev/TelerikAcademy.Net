using System;

namespace Order_WithProducts
{
    public class Product
    {
        /*fields*/
        /****************************************************************************/

        private string name;
        private decimal price;
        private readonly Currency currency;


        /*constructor*/
        /****************************************************************************/

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this.currency = Currency.USD; 
        }


        /*properties*/
        /****************************************************************************/

        public string Name 
        { 
            get => this.name;
            set
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Product name must be between 2 and 15 chars.");
                }
                this.name = value ?? throw new ArgumentNullException("Product name must be not be empty.");
            }
        }

        public decimal Price 
        { 
            get => this.price;
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentOutOfRangeException("Product price must not be negative or zero.");
                }
                this.price = value;
            }
        }

        public Currency Currency { get => this.currency; }


        /*methods*/
        /****************************************************************************/

        public string DisplayInfo()
        {
            return $"{this.Name} - {this.Price} {this.Currency}";
        }
    }
}
