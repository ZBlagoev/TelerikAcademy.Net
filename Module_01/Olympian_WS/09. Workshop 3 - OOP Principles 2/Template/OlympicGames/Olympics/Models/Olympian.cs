using System;
using System.Text;
using OlympicGames.Exceptions;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Olympics
{
    public abstract class Olympian : IOlympian
    {
        /*fields*/

        private string firstName;
        private string lastName;
        private string country;


        /*constructor*/

        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }


        /*properties*/

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (!ValidateField(value,2,20))
                {
                    throw new InvalidParameterTypeException("First name", "between 2 and 20 characters long");
                }

                this.firstName = value;
            }
        }

        public string LastName 
        {
            get => this.lastName;
            private set
            {
                if (!ValidateField(value,2,20))
                {
                    throw new InvalidParameterTypeException("Last name", "between 2 and 20 characters long");
                }

                this.lastName = value;
            }
        }

        public string Country 
        {
            get => this.country;
            private set
            {
                if (!ValidateField(value, 3, 25))
                {
                    throw new InvalidParameterTypeException("Country", "3 and 25 characters long");
                }

                this.country = value;
            }
        }


        /*methods*/

        private bool ValidateField(string value, int min, int max)
        {
            bool isValid = false;

            if (value.Length >= min && value.Length <= max)
            {
                isValid = true;
            }

            return isValid;
        }

        public virtual string Print()
        {
            var generalInfo = new StringBuilder();

            generalInfo.AppendLine($"{this.FirstName} {this.LastName} from {this.Country}");

            return generalInfo.ToString().Trim();
        }
    }
}
