using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
        }

        public IReadOnlyCollection<Person> FirstTeam 
        { 
            get
            {
                return firstTeam;
            }
        
        }


        public IReadOnlyCollection<Person> ReserveTeam { get; set; }
    }
}
