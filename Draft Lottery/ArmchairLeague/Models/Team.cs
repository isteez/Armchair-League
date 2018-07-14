using System;
namespace ArmchairLeague.Models
{
    public class Team
    {
		public string Name { get; set; }
		public string PhotoURL { get; set; }

        public Team(string name, string photoURL)
        {
            this.Name = name;
            this.PhotoURL = photoURL;
        }
    }
}
