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

            this.DefaultEmotes = new EmoteNodeSet();
            this.CombatEmotes = new EmoteNodeSet();
            this.FeedingEmotes = new EmoteNodeSet();
        }

        public string Name { get; set; }
        public PetFamily PetFamily { get; set; }
        public EmoteNodeSet DefaultEmotes { get; set; }
        public EmoteNodeSet CombatEmotes { get; set; }
        public EmoteNodeSet FeedingEmotes { get; set; }

        public bool IsCurrentLanguage
        {
            get {
                return this.PetFamily.IsCurrentLanguage;
            }
        }

        public override string ToString ()
        {
            return this.Name;
        }
    }
}
