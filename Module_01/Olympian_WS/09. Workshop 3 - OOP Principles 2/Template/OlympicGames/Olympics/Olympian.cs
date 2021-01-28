using System;
using System.Collections.Generic;
using System.Text;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;

namespace OlympicGames.Olympics
{
    class Olympian : IOlympian
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
            set
            {
                if (!ValidateField(value,2,20))
                {
                    throw new ArgumentOutOfRangeException("ERROR: First name must be between 2 and 20 characters long!");
                }

                this.firstName = value;
            }
        }

        public string LastName 
        {
            get => this.lastName;
            set
            {
                if (!ValidateField(value,2,20))
                {
                    throw new ArgumentOutOfRangeException("ERROR: Last name must be between 2 and 20 characters long!");
                }

                this.lastName = value;
            }
        }

        public string Country 
        {
            get => this.country;
            set
            {
                if (!ValidateField(value, 3, 25))
                {
                    throw new ArgumentOutOfRangeException("ERROR: Country must be between 3 and 25 characters long!");
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
