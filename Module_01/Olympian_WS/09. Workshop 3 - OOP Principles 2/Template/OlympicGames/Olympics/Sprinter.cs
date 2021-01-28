using System;
using System.Collections.Generic;
using System.Text;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics;

namespace OlympicGames.Olympics
{
    public class Sprinter : Olympian, ISprinter
    {
        /*fields*/
        private IDictionary<string, double> records;


        /*constructor*/

        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
            : base(firstName,lastName,country)
        {
            this.PersonalRecords = records;
        }


        /*properties*/

        public IDictionary<string, double> PersonalRecords 
        {
            get => this.records;
            private set
            {
                this.records = value;
            }
        }


        /*methods*/

        public override string Print()
        {
            var generalInfo = new StringBuilder();

            generalInfo.AppendLine($"SPRINTER: {base.Print()}");
            generalInfo.AppendLine("PERSONAL RECORDS:");
            foreach (KeyValuePair<string,double> pair in PersonalRecords)
            {
                generalInfo.AppendLine(string.Format($"{pair.Key}m: {pair.Value:#.00}s"));
            }
            generalInfo.AppendLine("####################");

            return generalInfo.ToString().Trim();
        }

    }
}
