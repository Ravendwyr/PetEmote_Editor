using System.Collections;
using System.Globalization;
using System.Xml.Serialization;
using System.Drawing;

namespace PetEmote.Emotes
{
    public enum PetClassTypes
    {
        Unknown = 0,
        Hunter,
        Warlock
    }

    public enum PetFamilyTypes
    {
        Unknown = 0,
        Bat,
        Bear,
        Boar,
        Cat,
        Crab,
        Crocolisk,
        DragonHawk,
        Gorilla,
        Hyena,
        NetherRay,
        Owl,
        Raptor,
        Ravager,
        Scorpid,
        Serpent,
        Spider,
        Sporebat,
        TallStrider,
        Turtle,
        Vulture,
        WarpStalker,
        WindSerpent,
        Wolf,
        FelGuard,
        FelHunter,
        Imp,
        Infernal,
        Succubus,
        VoidWalker
    }

    public class PetFamily
    {
        private PetFamilyTypes familyType;
        private PetClassTypes classType;
        private Hashtable imagesTable;

        public PetFamily () : this ("Unknown") { }
        public PetFamily (string name) : this(name, PetFamilyTypes.Unknown) { }
        public PetFamily (string name, PetFamilyTypes familyType) : this(name, familyType, PetClassTypes.Unknown) { }
        public PetFamily (string name, PetFamilyTypes familyType, PetClassTypes classType) : this(name, familyType, classType, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName) { }

        public PetFamily (string name, PetFamilyTypes familyType, PetClassTypes classType, string language)
        {
            this.Name = name;
            this.FamilyType = familyType;
            this.ClassType = classType;
            this.Language = language;

            this.imagesTable = new Hashtable();

            this.imagesTable.Add(PetFamilyTypes.Unknown, Icons.INV_Misc_QuestionMark);

            this.imagesTable.Add(PetFamilyTypes.Bat, Icons.Ability_Hunter_Pet_Bat);
            this.imagesTable.Add(PetFamilyTypes.Bear, Icons.Ability_Hunter_Pet_Bear);
            this.imagesTable.Add(PetFamilyTypes.Boar, Icons.Ability_Hunter_Pet_Boar);
            this.imagesTable.Add(PetFamilyTypes.Cat, Icons.Ability_Hunter_Pet_Cat);
            this.imagesTable.Add(PetFamilyTypes.Crab, Icons.Ability_Hunter_Pet_Crab);
            this.imagesTable.Add(PetFamilyTypes.Crocolisk, Icons.Ability_Hunter_Pet_Crocolis);
            this.imagesTable.Add(PetFamilyTypes.DragonHawk, Icons.Ability_Hunter_Pet_DragonHa);
            this.imagesTable.Add(PetFamilyTypes.Gorilla, Icons.Ability_Hunter_Pet_Gorilla);
            this.imagesTable.Add(PetFamilyTypes.Hyena, Icons.Ability_Hunter_Pet_Hyena);
            this.imagesTable.Add(PetFamilyTypes.NetherRay, Icons.Ability_Hunter_Pet_NetherRa);
            this.imagesTable.Add(PetFamilyTypes.Owl, Icons.Ability_Hunter_Pet_Owl);
            this.imagesTable.Add(PetFamilyTypes.Raptor, Icons.Ability_Hunter_Pet_Raptor);
            this.imagesTable.Add(PetFamilyTypes.Ravager, Icons.Ability_Hunter_Pet_Ravager);
            this.imagesTable.Add(PetFamilyTypes.Scorpid, Icons.Ability_Hunter_Pet_Scorpid);
            this.imagesTable.Add(PetFamilyTypes.Serpent, Icons.Ability_Hunter_Pet_Serpent);
            this.imagesTable.Add(PetFamilyTypes.Spider, Icons.Ability_Hunter_Pet_Spider);
            this.imagesTable.Add(PetFamilyTypes.Sporebat, Icons.Ability_Hunter_Pet_Sporebat);
            this.imagesTable.Add(PetFamilyTypes.TallStrider, Icons.Ability_Hunter_Pet_TallStri);
            this.imagesTable.Add(PetFamilyTypes.Turtle, Icons.Ability_Hunter_Pet_Turtle);
            this.imagesTable.Add(PetFamilyTypes.Vulture, Icons.Ability_Hunter_Pet_Vulture);
            this.imagesTable.Add(PetFamilyTypes.WarpStalker, Icons.Ability_Hunter_Pet_WarpStal);
            this.imagesTable.Add(PetFamilyTypes.WindSerpent, Icons.Ability_Hunter_Pet_WindSerp);
            this.imagesTable.Add(PetFamilyTypes.Wolf, Icons.Ability_Hunter_Pet_Wolf);
            
            this.imagesTable.Add(PetFamilyTypes.FelGuard, Icons.Spell_Shadow_SummonFelGuard);
            this.imagesTable.Add(PetFamilyTypes.FelHunter, Icons.Spell_Shadow_SummonFelHunte);
            this.imagesTable.Add(PetFamilyTypes.Imp, Icons.Spell_Shadow_SummonImp);
            this.imagesTable.Add(PetFamilyTypes.Infernal, Icons.Spell_Shadow_SummonInfernal);
            this.imagesTable.Add(PetFamilyTypes.Succubus, Icons.Spell_Shadow_SummonSuccubus);
            this.imagesTable.Add(PetFamilyTypes.VoidWalker, Icons.Spell_Shadow_SummonVoidWalk);
        }

        public string Name { get; set; }
        public string Language { get; set; }

        public PetFamilyTypes FamilyType
        {
            get {
                return this.familyType;
            }
            set {
                this.familyType = value;
            }
        }

        public PetClassTypes ClassType
        {
            get {
                return this.classType;
            }
            set {
                this.classType = value;
            }
        }
        
        [XmlIgnore]
        public Image Image {
            get
            {
                return (Image)this.imagesTable[this.FamilyType];
            }
        }

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

        public static PetFamily[] List ()
        {
            return new PetFamily[]
            {
                new PetFamily("Fledermaus", PetFamilyTypes.Bat, PetClassTypes.Hunter, "de"),
                new PetFamily("Bär", PetFamilyTypes.Bear, PetClassTypes.Hunter, "de"),
                new PetFamily("Eber", PetFamilyTypes.Boar, PetClassTypes.Hunter, "de"),
                new PetFamily("Katze", PetFamilyTypes.Cat, PetClassTypes.Hunter, "de"),
                new PetFamily("Krebs", PetFamilyTypes.Crab, PetClassTypes.Hunter, "de"),
                new PetFamily("Krokilisk", PetFamilyTypes.Crocolisk, PetClassTypes.Hunter, "de"),
                new PetFamily("Drachenfalke", PetFamilyTypes.DragonHawk, PetClassTypes.Hunter, "de"),
                new PetFamily("Gorilla", PetFamilyTypes.Gorilla, PetClassTypes.Hunter, "de"),
                new PetFamily("Hyäne", PetFamilyTypes.Hyena, PetClassTypes.Hunter, "de"),
                new PetFamily("Netherrochen", PetFamilyTypes.NetherRay, PetClassTypes.Hunter, "de"),
                new PetFamily("Eule", PetFamilyTypes.Owl, PetClassTypes.Hunter, "de"),
                new PetFamily("Raptor", PetFamilyTypes.Raptor, PetClassTypes.Hunter, "de"),
                new PetFamily("Felshetzer", PetFamilyTypes.Ravager, PetClassTypes.Hunter, "de"),
                new PetFamily("Skorpid", PetFamilyTypes.Scorpid, PetClassTypes.Hunter, "de"),
                new PetFamily("Schlange", PetFamilyTypes.Serpent, PetClassTypes.Hunter, "de"),
                new PetFamily("Spinne", PetFamilyTypes.Spider, PetClassTypes.Hunter, "de"),
                new PetFamily("Sporensegler", PetFamilyTypes.Sporebat, PetClassTypes.Hunter, "de"),
                new PetFamily("Weitschreiter", PetFamilyTypes.TallStrider, PetClassTypes.Hunter, "de"),
                new PetFamily("Schildkröte", PetFamilyTypes.Turtle, PetClassTypes.Hunter, "de"),
                new PetFamily("Aasvogel", PetFamilyTypes.Vulture, PetClassTypes.Hunter, "de"),
                new PetFamily("Sphärenjäger", PetFamilyTypes.WarpStalker, PetClassTypes.Hunter, "de"),
                new PetFamily("Windnatter", PetFamilyTypes.WindSerpent, PetClassTypes.Hunter, "de"),
                new PetFamily("Wolf", PetFamilyTypes.Wolf, PetClassTypes.Hunter, "de"),

                new PetFamily("Teufelswache", PetFamilyTypes.FelGuard, PetClassTypes.Warlock, "de"),
                new PetFamily("Teufelsjäger", PetFamilyTypes.FelHunter, PetClassTypes.Warlock, "de"),
                new PetFamily("Wichtel", PetFamilyTypes.Imp, PetClassTypes.Warlock, "de"),
                new PetFamily("Höllenbestie", PetFamilyTypes.Infernal, PetClassTypes.Warlock, "de"),
                new PetFamily("Sukkubus", PetFamilyTypes.Succubus, PetClassTypes.Warlock, "de"),
                new PetFamily("Leerwandler", PetFamilyTypes.VoidWalker, PetClassTypes.Warlock, "de"),
                
                new PetFamily("Bat", PetFamilyTypes.Bat, PetClassTypes.Hunter, "en"),
                new PetFamily("Bear", PetFamilyTypes.Bear, PetClassTypes.Hunter, "en"),
                new PetFamily("Boar", PetFamilyTypes.Boar, PetClassTypes.Hunter, "en"),
                new PetFamily("Cat", PetFamilyTypes.Cat, PetClassTypes.Hunter, "en"),
                new PetFamily("Crab", PetFamilyTypes.Crab, PetClassTypes.Hunter, "en"),
                new PetFamily("Crocolisk", PetFamilyTypes.Crocolisk, PetClassTypes.Hunter, "en"),
                new PetFamily("Dragonhawk", PetFamilyTypes.DragonHawk, PetClassTypes.Hunter, "en"),
                new PetFamily("Gorilla", PetFamilyTypes.Gorilla, PetClassTypes.Hunter, "en"),
                new PetFamily("Hyena", PetFamilyTypes.Hyena, PetClassTypes.Hunter, "en"),
                new PetFamily("Nether Ray", PetFamilyTypes.NetherRay, PetClassTypes.Hunter, "en"),
                new PetFamily("Owl", PetFamilyTypes.Owl, PetClassTypes.Hunter, "en"),
                new PetFamily("Raptor", PetFamilyTypes.Raptor, PetClassTypes.Hunter, "en"),
                new PetFamily("Ravager", PetFamilyTypes.Ravager, PetClassTypes.Hunter, "en"),
                new PetFamily("Scorpid", PetFamilyTypes.Scorpid, PetClassTypes.Hunter, "en"),
                new PetFamily("Serpent", PetFamilyTypes.Serpent, PetClassTypes.Hunter, "en"),
                new PetFamily("Spider", PetFamilyTypes.Spider, PetClassTypes.Hunter, "en"),
                new PetFamily("Sporebat", PetFamilyTypes.Sporebat, PetClassTypes.Hunter, "en"),
                new PetFamily("Tallstrider", PetFamilyTypes.TallStrider, PetClassTypes.Hunter, "en"),
                new PetFamily("Turtle", PetFamilyTypes.Turtle, PetClassTypes.Hunter, "en"),
                new PetFamily("Carrion Bird", PetFamilyTypes.Vulture, PetClassTypes.Hunter, "en"),
                new PetFamily("Warp Stalker", PetFamilyTypes.WarpStalker, PetClassTypes.Hunter, "en"),
                new PetFamily("Wind Serpent", PetFamilyTypes.WindSerpent, PetClassTypes.Hunter, "en"),
                new PetFamily("Wolf", PetFamilyTypes.Wolf, PetClassTypes.Hunter, "en"),
                
                new PetFamily("Felguard", PetFamilyTypes.FelGuard, PetClassTypes.Warlock, "en"),
                new PetFamily("Felhunter", PetFamilyTypes.FelHunter, PetClassTypes.Warlock, "en"),
                new PetFamily("Imp", PetFamilyTypes.Imp, PetClassTypes.Warlock, "en"),
                new PetFamily("Infernal", PetFamilyTypes.Infernal, PetClassTypes.Warlock, "en"),
                new PetFamily("Succubus", PetFamilyTypes.Succubus, PetClassTypes.Warlock, "en"),
                new PetFamily("Voidwalker", PetFamilyTypes.VoidWalker, PetClassTypes.Warlock, "en")
            };
        }
    }
}
