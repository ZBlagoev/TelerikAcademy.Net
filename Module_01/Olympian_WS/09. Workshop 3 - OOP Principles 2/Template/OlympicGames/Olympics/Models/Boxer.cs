using System;
using System.Collections.Generic;
using System.Text;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics;

namespace OlympicGames.Olympics
{
    public class Boxer : Olympian, IBoxer
    {
        /*fields*/

        private readonly BoxingCategory category;
        private int wins;
        private int losses;


        /*constructor*/

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int loses) 
            : base(firstName,lastName,country)
        {
            this.category = category;   
            this.Wins = wins;
            this.Losses = loses;
        }


        /*properties*/

        public BoxingCategory Category
        {
            get => this.category;
        }

        public int Wins 
        {
            get => this.wins;
            private set
            {
                if (!ValidateField(value,0,100))
                {
                    throw new ArgumentOutOfRangeException("ERROR: Wins must be between 0 and 100!");
                }

                this.wins = value;
            }
        }

        public int Losses
        {
            get => this.losses;
            private set
            {
                if (!ValidateField(value, 0, 100))
                {
                    throw new ArgumentOutOfRangeException("ERROR: Losses must be between 0 and 100!");
                }

                this.losses = value;
            }
        }

        /*methods*/

        private bool ValidateField(int value, int min, int max)
        {
            bool isValid = false;

            if (value >= min && value <= max)
            {
                isValid = true;
            }

            return isValid;
        }

        public override string Print()
        {
            var generalInfo = new StringBuilder();

            generalInfo.AppendLine($"BOXER: {base.Print()}");
            generalInfo.AppendLine($"Category: {this.Category}");
            generalInfo.AppendLine($"Wins: {this.Wins}");
            generalInfo.AppendLine($"Losses: {this.Losses}");
            //generalInfo.AppendLine("####################");

            return generalInfo.ToString().Trim();
        }
    }
}
