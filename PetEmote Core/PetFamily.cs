using System.Collections;
using System.Globalization;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public enum PetClassType
    {
        Unknown = 0,
        Hunter,
        Warlock,
        DeathKnight
    }

    public enum PetFamilyType
    {
        Unknown = 0,
        Bat,
        Bear,
        BirdOfPrey,
        Boar,
        Cat,
        Chimera,
        CoreHound,
        Crab,
        Crocolisk,
        Devilsaur,
        DragonHawk,
        Gorilla,
        Hyena,
        Moth,
        NetherRay,
        Raptor,
        Ravager,
        Rhino,
        Scorpid,
        Serpent,
        Silithid,
        Spider,
        Sporebat,
        TallStrider,
        Turtle,
        Vulture,
        WarpStalker,
        Wasp,
        WindSerpent,
        Wolf,
        Worm,
        FelGuard,
        FelHunter,
        Imp,
        Infernal,
        Succubus,
        VoidWalker,
        Ghoul
    }

    public class PetFamily
    {
        public PetFamily () : this ("Unknown") { }
        public PetFamily (string name) : this(name, PetFamilyType.Unknown, PetClassType.Unknown) { }
        public PetFamily (string name, PetFamilyType familyType, PetClassType classType) : this(name, familyType, classType, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName) { }

        public PetFamily (string name, PetFamilyType familyType, PetClassType classType, string language)
        {
            this.Name = name;
            this.FamilyType = familyType;
            this.ClassType = classType;
            this.Language = language;
        }

        public string Name { get; set; }
        public string Language { get; set; }
        public PetFamilyType FamilyType { get; set; }
        public PetClassType ClassType { get; set; }

        public override string ToString ()
        {
            return this.Name;
        }
    }
}
