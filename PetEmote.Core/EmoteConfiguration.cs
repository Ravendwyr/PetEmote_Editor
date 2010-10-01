using System.Collections.Generic;
using System.Globalization;

namespace PetEmote.Core
{
    public class EmoteConfiguration
    {
        public EmoteConfiguration () : this ("Untitled", new PetFamily()) { }

        public EmoteConfiguration (string name, PetFamily family)
        {
            this.Name = name;
            this.PetFamily = family;

            this.DefaultEmotes = new List<EmoteNode>();
            this.CombatEmotes = new List<EmoteNode>();
            this.FeedingEmotes = new List<EmoteNode>();
        }

        public string Name { get; set; }
        public PetFamily PetFamily { get; set; }
        public List<EmoteNode> DefaultEmotes { get; set; }
        public List<EmoteNode> CombatEmotes { get; set; }
        public List<EmoteNode> FeedingEmotes { get; set; }

        public override string ToString ()
        {
            return this.Name;
        }
    }
}
