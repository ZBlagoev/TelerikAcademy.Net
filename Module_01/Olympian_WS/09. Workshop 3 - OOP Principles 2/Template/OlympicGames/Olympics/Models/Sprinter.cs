using System.Text;
using System.Collections.Generic;
using OlympicGames.Olympics.Contracts;

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

            if (PersonalRecords.Count == 0)
            {
                generalInfo.AppendLine("NO PERSONAL RECORDS SET");
            }
            else
            {
                foreach (KeyValuePair<string, double> pair in PersonalRecords)
                {
                    generalInfo.AppendLine(string.Format($"{pair.Key}m: {pair.Value:#.00}s"));
                }
            }
            
            return generalInfo.ToString().Trim();
        }

    }
}
