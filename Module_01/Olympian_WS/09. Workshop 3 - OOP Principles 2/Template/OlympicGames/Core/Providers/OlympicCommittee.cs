using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using System;
using System.Linq;

namespace OlympicGames.Core.Providers
{
    public class OlympicCommittee : IOlympicCommittee
    {
        private readonly List<IOlympian> olympians = new List<IOlympian>();

        public IReadOnlyList<IOlympian> Olympians
        {
            get
            {
                return this.olympians;
            }
        }

        public void Add(IOlympian olympian)
        {
            bool contains = this.olympians.Any(obj =>
            (obj.Country == olympian.Country
            && obj.FirstName == olympian.FirstName
            && obj.LastName == olympian.LastName));

            if (contains)
            {
                throw new ArgumentException("Olympian already exists");
            }

            this.olympians.Add(olympian);
        }
    }
}
