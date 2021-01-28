using System.Text;
using OlympicGames.Exceptions;
using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Core.Commands.Abstracts;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        public CreateSprinterCommand(IList<string> commandLine, IOlympicCommittee committee)
            : base(commandLine, committee)
        {
        }

        public override string Execute()
        {
            if (this.CommandParameters.Count < 3)
            {
                throw new InvalidParameterCountException();
            }

            string firstName = this.CommandParameters[0];
            string lastName = this.CommandParameters[1];
            string country = this.CommandParameters[2];

            IDictionary<string, double> records = new Dictionary<string, double>();

            if (this.CommandParameters.Count > 3)
            {
                for (int i = 3; i < CommandParameters.Count; i++)
                {
                    string key = CommandParameters[i].Substring(0, CommandParameters[i].IndexOf("/"));

                    //int meters;
                    //bool isValidDistance = int.TryParse(key, out meters);

                    //if (!isValidDistance || meters <= 0)
                    //{
                    //    throw new InvalidParameterTypeException("Record", "a number");
                    //}

                    double value;
                    bool isValidTime = double.TryParse(CommandParameters[i].Substring(CommandParameters[i].IndexOf("/") + 1), out value);

                    if (!isValidTime || value <= 0.0)
                    {
                        throw new InvalidParameterTypeException("Record", "number");
                    }

                    records.Add(key, value);
                }
            }

            
            IOlympian olympian = this.Factory.CreateSprinter(firstName, lastName, country, records);

            this.Committee.Add(olympian);

            var result = new StringBuilder();

            result.AppendLine("Created sprinter");
            result.AppendLine(olympian.Print());

            return result.ToString().Trim();
        }
    }
}
