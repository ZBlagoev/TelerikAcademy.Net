using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using System;

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
            if (this.olympians.Contains(olympian))
            {
                throw new ArgumentException("Olympian already exists");
            }

            this.olympians.Add(olympian);
        }
    }
}
