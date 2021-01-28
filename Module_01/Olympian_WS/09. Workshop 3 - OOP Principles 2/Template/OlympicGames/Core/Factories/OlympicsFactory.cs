using System;
using OlympicGames.Exceptions;
using System.Collections.Generic;
using OlympicGames.Olympics;
using OlympicGames.Olympics.Enums;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            BoxingCategory boxingCategory;

            bool isValidCommand = Enum.TryParse(category, ignoreCase: true, out boxingCategory);

            if (!isValidCommand)
            {
                throw new InvalidParameterTypeException("Boxer category", "one of: Flyweight, Featherweight, Lightweight, Middleweight, Heavyweight");
            }

            return new Boxer(firstName, lastName, country, boxingCategory, wins, losses);

        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
        {
            return new Sprinter(firstName, lastName, country, records);
        }
    }
}
