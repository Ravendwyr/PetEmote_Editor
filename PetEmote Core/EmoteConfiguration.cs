using System.Globalization;

namespace PetEmote.Core
{
    public class EmoteConfiguration
    {
        public EmoteConfiguration () : this ("Untitled") { }
        public EmoteConfiguration (string name) : this (name, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName) { }
        public EmoteConfiguration (string name, string language) : this (new PetFamily(name, PetFamilyTypes.Unknown, PetClassTypes.Unknown, language)) { }

        public EmoteConfiguration (PetFamily family)
        {
            this.Name = family.Name;
            this.Language = family.Language;
            this.PetFamily = family;

            this.DefaultEmotes = new EmoteNodeSet();
            this.CombatEmotes = new EmoteNodeSet();
            this.FeedingEmotes = new EmoteNodeSet();
        }

        public string Name { get; set; }
        public string Language { get; set; }
        public PetFamily PetFamily { get; set; }
        public EmoteNodeSet DefaultEmotes { get; set; }
        public EmoteNodeSet CombatEmotes { get; set; }
        public EmoteNodeSet FeedingEmotes { get; set; }

        public bool IsCurrentLanguage
        {
            get {
                return this.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            }
        }

        public override string ToString ()
        {
            return this.Name;
        }
    }
}
