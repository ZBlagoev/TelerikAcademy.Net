using System;
using System.Collections.Generic;
using System.Text;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        public CreateBoxerCommand(IList<string> commandLine, IOlympicCommittee committee)
            : base(commandLine, committee)
        {
        }

        public override string Execute()
        {
            if (this.CommandParameters.Count != 6)
            {
                throw new ArgumentOutOfRangeException("ERROR: Parameters count is not valid!");
            }

            string firstName = this.CommandParameters[0];
            string lastName = this.CommandParameters[1];
            string country = this.CommandParameters[2];
            string category = CommandParameters[3];


            int wins;

            bool isIntWins = int.TryParse(this.CommandParameters[4], out wins);

            if (!isIntWins)
            {
                throw new ArgumentException("ERRROR: Wins must be an intager number!");
            }

            int losses;

            bool isIntLosses = int.TryParse(this.CommandParameters[5], out losses);

            if (!isIntLosses)
            {
                throw new ArgumentException("ERRROR: Losses must be an intager number!");
            }


            IOlympian olympian = this.Factory.CreateBoxer(firstName, lastName, country, category, wins, losses);

            this.Committee.Add(olympian);

            var result = new StringBuilder();

            result.AppendLine("Created boxer");
            result.AppendLine(olympian.Print());

            return result.ToString().Trim();
        }
    }
}
