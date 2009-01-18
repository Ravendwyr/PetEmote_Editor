using System.Globalization;

namespace PetEmote.Emotes
{
    public class EmoteConfiguration
    {
        protected EmoteNodeSet randomMessages = new EmoteNodeSet(EmoteNodeSet.EmoteNodeSetType.RandomMessages);

        public EmoteConfiguration () {
            this.Name = "Untitled";
            this.Language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            this.PetFamily = new PetFamily(this.Name, PetFamilyTypes.Unknown, PetClassTypes.Unknown);
        }

        public EmoteConfiguration (string name)
        {
            this.Name = name;
            this.Language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            this.PetFamily = new PetFamily(this.Name, PetFamilyTypes.Unknown, PetClassTypes.Unknown);
        }

        public EmoteConfiguration (string name, string language)
        {
            this.Name = name;
            this.Language = language;
            this.PetFamily = new PetFamily(this.Name, PetFamilyTypes.Unknown, PetClassTypes.Unknown);
        }

        public EmoteConfiguration (PetFamily family)
        {
            this.Name = family.Name;
            this.Language = family.Language;
            this.PetFamily = family;
        }

        public string Name { get; set; }
        public string Language { get; set; }
        public PetFamily PetFamily { get; set; }
    
        public bool IsCurrentLanguage
        {
            get {
                return this.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            }
        }
        
        public EmoteNodeSet RandomMessages
        {
            get { return this.randomMessages; }
            set { this.randomMessages = value; }
        }

        public override string ToString ()
        {
            return this.Name;
        }
    }
}
