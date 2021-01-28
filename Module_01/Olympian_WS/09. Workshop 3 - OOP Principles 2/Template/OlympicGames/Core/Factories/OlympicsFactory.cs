using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }
    }
}
