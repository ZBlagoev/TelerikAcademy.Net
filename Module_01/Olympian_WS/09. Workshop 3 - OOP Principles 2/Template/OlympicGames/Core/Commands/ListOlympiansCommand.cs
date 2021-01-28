using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Core.Commands.Abstracts;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command
    {
        public ListOlympiansCommand(IList<string> commandLine, IOlympicCommittee committee) 
            : base(commandLine, committee)
        {
        }

        public override string Execute()
        {
            string key = "firstname";
            string sort = "asc";
            string keySort;

            switch (this.CommandParameters.Count)
            {
                case 1:
                    key = this.CommandParameters[0];
                    break;
                case 2:
                    key = this.CommandParameters[0];
                    switch (this.CommandParameters[1])
                    {
                        case "desc":
                            sort = this.CommandParameters[1];
                            break;
                        default:
                            throw new ArgumentException("Invalid parameters!");
                    }
                    break;
                default:
                    break;
            }


            keySort = key + "-" + sort; 


            List<IOlympian> committee = new List<IOlympian>(this.Committee.Olympians);

            if (committee.Count == 0)
            {
                return "NO OLYMPIANS ADDED";
            }

            switch (keySort)
            {
                case "firstname-desc":
                    committee = committee.OrderByDescending(oly => oly.FirstName).ToList();
                    break;
                case "lastname-asc":
                    committee = committee.OrderBy(oly => oly.LastName).ToList();
                    break;
                case "lastname-desc":
                    committee = committee.OrderByDescending(oly => oly.LastName).ToList();
                    break;
                case "country-asc":
                    committee = committee.OrderBy(oly => oly.Country).ToList();
                    break;
                case "country-desc":
                    committee = committee.OrderByDescending(oly => oly.Country).ToList();
                    break;
                default:
                    committee = committee.OrderBy(oly => oly.FirstName).ToList();
                    break;
            }


            var result = new StringBuilder();
            result.AppendLine($"Sorted by [key: {key}] in [order: {sort}]");

            foreach (var obj in committee)
            {
                result.AppendLine(obj.Print());
            }

            return result.ToString().Trim();
        }
    }
}
