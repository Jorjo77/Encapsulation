
using FootballTeamGenerator.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private readonly ICollection<Player> players;
        
        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(GlobalConstants.InvalidNameExcMsg);
                }
                this.name = value;
            }
        }

        public int Rating =>
            (int)Math.Round(this.players.Average(p => p.OveralSkill));
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlaer(string playerName)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove == null)
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.MissingPlayerExsMsg, playerName, this.Name));
            }
            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
