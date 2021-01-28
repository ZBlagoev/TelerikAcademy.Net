using System.Collections.Generic;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;

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
            // TODO: Implement this
            throw new System.NotImplementedException();
        }
    }
}
