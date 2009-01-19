using System.Collections;
using System.Globalization;
using System.Xml.Serialization;
//using System.Drawing;
//using PetEmote.Graphics;

namespace PetEmote.Core
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
        SpiritBeast,
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

            //this.imagesTable.Add(PetFamilyTypes.Unknown, IconsWoW.INV_Misc_QuestionMark);
            //this.imagesTable.Add(PetFamilyTypes.Bat, IconsWoW.Ability_Hunter_Pet_Bat);
            //this.imagesTable.Add(PetFamilyTypes.Bear, IconsWoW.Ability_Hunter_Pet_Bear);
            //this.imagesTable.Add(PetFamilyTypes.BirdOfPrey, IconsWoW.Ability_Hunter_Pet_Owl);
            //this.imagesTable.Add(PetFamilyTypes.Boar, IconsWoW.Ability_Hunter_Pet_Boar);
            //this.imagesTable.Add(PetFamilyTypes.Cat, IconsWoW.Ability_Hunter_Pet_Cat);
            //this.imagesTable.Add(PetFamilyTypes.Chimera, IconsWoW.Ability_Hunter_Pet_Chimera);
            //this.imagesTable.Add(PetFamilyTypes.CoreHound, IconsWoW.Ability_Hunter_Pet_CoreHound);
            //this.imagesTable.Add(PetFamilyTypes.Crab, IconsWoW.Ability_Hunter_Pet_Crab);
            //this.imagesTable.Add(PetFamilyTypes.Crocolisk, IconsWoW.Ability_Hunter_Pet_Crocolisk);
            //this.imagesTable.Add(PetFamilyTypes.Devilsaur, IconsWoW.Ability_Hunter_Pet_Devilsaur);
            //this.imagesTable.Add(PetFamilyTypes.DragonHawk, IconsWoW.Ability_Hunter_Pet_DragonHawk);
            //this.imagesTable.Add(PetFamilyTypes.Gorilla, IconsWoW.Ability_Hunter_Pet_Gorilla);
            //this.imagesTable.Add(PetFamilyTypes.Hyena, IconsWoW.Ability_Hunter_Pet_Hyena);
            //this.imagesTable.Add(PetFamilyTypes.Moth, IconsWoW.Ability_Hunter_Pet_Moth);
            //this.imagesTable.Add(PetFamilyTypes.NetherRay, IconsWoW.Ability_Hunter_Pet_NetherRay);
            //this.imagesTable.Add(PetFamilyTypes.Raptor, IconsWoW.Ability_Hunter_Pet_Raptor);
            //this.imagesTable.Add(PetFamilyTypes.Ravager, IconsWoW.Ability_Hunter_Pet_Ravager);
            //this.imagesTable.Add(PetFamilyTypes.Rhino, IconsWoW.Ability_Hunter_Pet_Rhino);
            //this.imagesTable.Add(PetFamilyTypes.Scorpid, IconsWoW.Ability_Hunter_Pet_Scorpid);
            //this.imagesTable.Add(PetFamilyTypes.Serpent, IconsWoW.Spell_Nature_GuardianWard);
            //this.imagesTable.Add(PetFamilyTypes.Silithid, IconsWoW.Ability_Hunter_Pet_Silithid);
            //this.imagesTable.Add(PetFamilyTypes.Spider, IconsWoW.Ability_Hunter_Pet_Spider);
            //this.imagesTable.Add(PetFamilyTypes.SpiritBeast, IconsWoW.Ability_Druid_PrimalPrecision);
            //this.imagesTable.Add(PetFamilyTypes.Sporebat, IconsWoW.Ability_Hunter_Pet_Sporebat);
            //this.imagesTable.Add(PetFamilyTypes.TallStrider, IconsWoW.Ability_Hunter_Pet_TallStrider);
            //this.imagesTable.Add(PetFamilyTypes.Turtle, IconsWoW.Ability_Hunter_Pet_Turtle);
            //this.imagesTable.Add(PetFamilyTypes.Vulture, IconsWoW.Ability_Hunter_Pet_Vulture);
            //this.imagesTable.Add(PetFamilyTypes.WarpStalker, IconsWoW.Ability_Hunter_Pet_WarpStalker);
            //this.imagesTable.Add(PetFamilyTypes.Wasp, IconsWoW.Ability_Hunter_Pet_Wasp);
            //this.imagesTable.Add(PetFamilyTypes.WindSerpent, IconsWoW.Ability_Hunter_Pet_WindSerpent);
            //this.imagesTable.Add(PetFamilyTypes.Wolf, IconsWoW.Ability_Hunter_Pet_Wolf);
            //this.imagesTable.Add(PetFamilyTypes.Worm, IconsWoW.Ability_Hunter_Pet_Worm);
            
            //this.imagesTable.Add(PetFamilyTypes.FelGuard, IconsWoW.Spell_Shadow_SummonFelGuard);
            //this.imagesTable.Add(PetFamilyTypes.FelHunter, IconsWoW.Spell_Shadow_SummonFelHunter);
            //this.imagesTable.Add(PetFamilyTypes.Imp, IconsWoW.Spell_Shadow_SummonImp);
            //this.imagesTable.Add(PetFamilyTypes.Infernal, IconsWoW.Spell_Shadow_SummonInfernal);
            //this.imagesTable.Add(PetFamilyTypes.Succubus, IconsWoW.Spell_Shadow_SummonSuccubus);
            //this.imagesTable.Add(PetFamilyTypes.VoidWalker, IconsWoW.Spell_Shadow_SummonVoidWalker);
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
        
        //[XmlIgnore]
        //public Image Image {
        //    get
        //    {
        //        return (Image)this.imagesTable[this.FamilyType];
        //    }
        //}

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
                new PetFamily("Aasvogel", PetFamilyTypes.Vulture, PetClassTypes.Hunter, "de"),
                new PetFamily("Bär", PetFamilyTypes.Bear, PetClassTypes.Hunter, "de"),
                new PetFamily("Drachenfalke", PetFamilyTypes.DragonHawk, PetClassTypes.Hunter, "de"),
                new PetFamily("Eber", PetFamilyTypes.Boar, PetClassTypes.Hunter, "de"),
                new PetFamily("Felshetzer", PetFamilyTypes.Ravager, PetClassTypes.Hunter, "de"),
                new PetFamily("Fledermaus", PetFamilyTypes.Bat, PetClassTypes.Hunter, "de"),
                new PetFamily("Gorilla", PetFamilyTypes.Gorilla, PetClassTypes.Hunter, "de"),
                new PetFamily("Hyäne", PetFamilyTypes.Hyena, PetClassTypes.Hunter, "de"),
                new PetFamily("Katze", PetFamilyTypes.Cat, PetClassTypes.Hunter, "de"),
                new PetFamily("Kernhund", PetFamilyTypes.CoreHound, PetClassTypes.Hunter, "de"),
                new PetFamily("Krebs", PetFamilyTypes.Crab, PetClassTypes.Hunter, "de"),
                new PetFamily("Krokilisk", PetFamilyTypes.Crocolisk, PetClassTypes.Hunter, "de"),
                new PetFamily("Motte", PetFamilyTypes.Moth, PetClassTypes.Hunter, "de"),
                new PetFamily("Netherrochen", PetFamilyTypes.NetherRay, PetClassTypes.Hunter, "de"),
                new PetFamily("Raptor", PetFamilyTypes.Raptor, PetClassTypes.Hunter, "de"),
                new PetFamily("Raubvogel", PetFamilyTypes.BirdOfPrey, PetClassTypes.Hunter, "de"),
                new PetFamily("Rhinozeros", PetFamilyTypes.Rhino, PetClassTypes.Hunter, "de"),
                new PetFamily("Schildkröte", PetFamilyTypes.Turtle, PetClassTypes.Hunter, "de"),
                new PetFamily("Schimäre", PetFamilyTypes.Chimera, PetClassTypes.Hunter, "de"),
                new PetFamily("Schlange", PetFamilyTypes.Serpent, PetClassTypes.Hunter, "de"),
                new PetFamily("Silithid", PetFamilyTypes.Silithid, PetClassTypes.Hunter, "de"),
                new PetFamily("Skorpid", PetFamilyTypes.Scorpid, PetClassTypes.Hunter, "de"),
                new PetFamily("Sphärenjäger", PetFamilyTypes.WarpStalker, PetClassTypes.Hunter, "de"),
                new PetFamily("Spinne", PetFamilyTypes.Spider, PetClassTypes.Hunter, "de"),
                new PetFamily("Spirit Beast", PetFamilyTypes.SpiritBeast, PetClassTypes.Hunter, "de"),
                new PetFamily("Sporensegler", PetFamilyTypes.Sporebat, PetClassTypes.Hunter, "de"),
                new PetFamily("Teufelssaurier", PetFamilyTypes.Devilsaur, PetClassTypes.Hunter, "de"),
                new PetFamily("Weitschreiter", PetFamilyTypes.TallStrider, PetClassTypes.Hunter, "de"),
                new PetFamily("Wespe", PetFamilyTypes.Wasp, PetClassTypes.Hunter, "de"),
                new PetFamily("Windnatter", PetFamilyTypes.WindSerpent, PetClassTypes.Hunter, "de"),
                new PetFamily("Wolf", PetFamilyTypes.Wolf, PetClassTypes.Hunter, "de"),
                new PetFamily("Wurm", PetFamilyTypes.Worm, PetClassTypes.Hunter, "de"),

                new PetFamily("Höllenbestie", PetFamilyTypes.Infernal, PetClassTypes.Warlock, "de"),
                new PetFamily("Leerwandler", PetFamilyTypes.VoidWalker, PetClassTypes.Warlock, "de"),
                new PetFamily("Sukkubus", PetFamilyTypes.Succubus, PetClassTypes.Warlock, "de"),
                new PetFamily("Teufelsjäger", PetFamilyTypes.FelHunter, PetClassTypes.Warlock, "de"),
                new PetFamily("Teufelswache", PetFamilyTypes.FelGuard, PetClassTypes.Warlock, "de"),
                new PetFamily("Wichtel", PetFamilyTypes.Imp, PetClassTypes.Warlock, "de"),
                
                new PetFamily("Bat", PetFamilyTypes.Bat, PetClassTypes.Hunter, "en"),
                new PetFamily("Bear", PetFamilyTypes.Bear, PetClassTypes.Hunter, "en"),
                new PetFamily("Bird of Prey", PetFamilyTypes.BirdOfPrey, PetClassTypes.Hunter, "en"),
                new PetFamily("Boar", PetFamilyTypes.Boar, PetClassTypes.Hunter, "en"),
                new PetFamily("Carrion Bird", PetFamilyTypes.Vulture, PetClassTypes.Hunter, "en"),
                new PetFamily("Cat", PetFamilyTypes.Cat, PetClassTypes.Hunter, "en"),
                new PetFamily("Chimera", PetFamilyTypes.Chimera, PetClassTypes.Hunter, "en"),
                new PetFamily("Core Hound", PetFamilyTypes.CoreHound, PetClassTypes.Hunter, "en"),
                new PetFamily("Crab", PetFamilyTypes.Crab, PetClassTypes.Hunter, "en"),
                new PetFamily("Crocolisk", PetFamilyTypes.Crocolisk, PetClassTypes.Hunter, "en"),
                new PetFamily("Devilsaur", PetFamilyTypes.Devilsaur, PetClassTypes.Hunter, "en"),
                new PetFamily("Dragonhawk", PetFamilyTypes.DragonHawk, PetClassTypes.Hunter, "en"),
                new PetFamily("Gorilla", PetFamilyTypes.Gorilla, PetClassTypes.Hunter, "en"),
                new PetFamily("Hyena", PetFamilyTypes.Hyena, PetClassTypes.Hunter, "en"),
                new PetFamily("Moth", PetFamilyTypes.Moth, PetClassTypes.Hunter, "en"),
                new PetFamily("Nether Ray", PetFamilyTypes.NetherRay, PetClassTypes.Hunter, "en"),
                new PetFamily("Raptor", PetFamilyTypes.Raptor, PetClassTypes.Hunter, "en"),
                new PetFamily("Ravager", PetFamilyTypes.Ravager, PetClassTypes.Hunter, "en"),
                new PetFamily("Rhino", PetFamilyTypes.Rhino, PetClassTypes.Hunter, "en"),
                new PetFamily("Scorpid", PetFamilyTypes.Scorpid, PetClassTypes.Hunter, "en"),
                new PetFamily("Serpent", PetFamilyTypes.Serpent, PetClassTypes.Hunter, "en"),
                new PetFamily("Silithid", PetFamilyTypes.Silithid, PetClassTypes.Hunter, "en"),
                new PetFamily("Spider", PetFamilyTypes.Spider, PetClassTypes.Hunter, "en"),
                new PetFamily("Spirit Beast", PetFamilyTypes.SpiritBeast, PetClassTypes.Hunter, "en"),
                new PetFamily("Sporebat", PetFamilyTypes.Sporebat, PetClassTypes.Hunter, "en"),
                new PetFamily("Tallstrider", PetFamilyTypes.TallStrider, PetClassTypes.Hunter, "en"),
                new PetFamily("Turtle", PetFamilyTypes.Turtle, PetClassTypes.Hunter, "en"),
                new PetFamily("Warp Stalker", PetFamilyTypes.WarpStalker, PetClassTypes.Hunter, "en"),
                new PetFamily("Wasp", PetFamilyTypes.Wasp, PetClassTypes.Hunter, "en"),
                new PetFamily("Wind Serpent", PetFamilyTypes.WindSerpent, PetClassTypes.Hunter, "en"),
                new PetFamily("Wolf", PetFamilyTypes.Wolf, PetClassTypes.Hunter, "en"),
                new PetFamily("Worm", PetFamilyTypes.Worm, PetClassTypes.Hunter, "en"),
                
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
