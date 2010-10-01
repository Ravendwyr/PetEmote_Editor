using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetEmote.Core
{
    public class PetFamilyFactory
    {
        public static List<PetFamily> GetList ()
        {
            List<PetFamily> families = new List<PetFamily>();

            families.Add(new PetFamily("Aasvogel", PetFamilyType.Vulture, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Bär", PetFamilyType.Bear, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Drachenfalke", PetFamilyType.DragonHawk, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Eber", PetFamilyType.Boar, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Felshetzer", PetFamilyType.Ravager, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Fledermaus", PetFamilyType.Bat, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Geisterbestie", PetFamilyType.SpiritBeast, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Gorilla", PetFamilyType.Gorilla, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Hyäne", PetFamilyType.Hyena, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Katze", PetFamilyType.Cat, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Kernhund", PetFamilyType.CoreHound, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Krebs", PetFamilyType.Crab, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Krokilisk", PetFamilyType.Crocolisk, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Motte", PetFamilyType.Moth, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Netherrochen", PetFamilyType.NetherRay, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Raptor", PetFamilyType.Raptor, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Raubvogel", PetFamilyType.BirdOfPrey, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Rhinozeros", PetFamilyType.Rhino, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Schildkröte", PetFamilyType.Turtle, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Schimäre", PetFamilyType.Chimera, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Schlange", PetFamilyType.Serpent, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Silithid", PetFamilyType.Silithid, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Skorpid", PetFamilyType.Scorpid, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Sphärenjäger", PetFamilyType.WarpStalker, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Spinne", PetFamilyType.Spider, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Sporensegler", PetFamilyType.Sporebat, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Teufelssaurier", PetFamilyType.Devilsaur, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Weitschreiter", PetFamilyType.TallStrider, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Wespe", PetFamilyType.Wasp, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Windnatter", PetFamilyType.WindSerpent, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Wolf", PetFamilyType.Wolf, PetClassType.Hunter, "de"));
            families.Add(new PetFamily("Wurm", PetFamilyType.Worm, PetClassType.Hunter, "de"));

            families.Add(new PetFamily("Höllenbestie", PetFamilyType.Infernal, PetClassType.Warlock, "de"));
            families.Add(new PetFamily("Leerwandler", PetFamilyType.VoidWalker, PetClassType.Warlock, "de"));
            families.Add(new PetFamily("Sukkubus", PetFamilyType.Succubus, PetClassType.Warlock, "de"));
            families.Add(new PetFamily("Teufelsjäger", PetFamilyType.FelHunter, PetClassType.Warlock, "de"));
            families.Add(new PetFamily("Teufelswache", PetFamilyType.FelGuard, PetClassType.Warlock, "de"));
            families.Add(new PetFamily("Wichtel", PetFamilyType.Imp, PetClassType.Warlock, "de"));
            
            families.Add(new PetFamily("Bat", PetFamilyType.Bat, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Bear", PetFamilyType.Bear, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Bird of Prey", PetFamilyType.BirdOfPrey, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Boar", PetFamilyType.Boar, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Carrion Bird", PetFamilyType.Vulture, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Cat", PetFamilyType.Cat, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Chimera", PetFamilyType.Chimera, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Core Hound", PetFamilyType.CoreHound, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Crab", PetFamilyType.Crab, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Crocolisk", PetFamilyType.Crocolisk, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Devilsaur", PetFamilyType.Devilsaur, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Dragonhawk", PetFamilyType.DragonHawk, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Gorilla", PetFamilyType.Gorilla, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Hyena", PetFamilyType.Hyena, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Moth", PetFamilyType.Moth, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Nether Ray", PetFamilyType.NetherRay, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Raptor", PetFamilyType.Raptor, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Ravager", PetFamilyType.Ravager, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Rhino", PetFamilyType.Rhino, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Scorpid", PetFamilyType.Scorpid, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Serpent", PetFamilyType.Serpent, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Silithid", PetFamilyType.Silithid, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Spider", PetFamilyType.Spider, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Spirit Beast", PetFamilyType.SpiritBeast, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Sporebat", PetFamilyType.Sporebat, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Tallstrider", PetFamilyType.TallStrider, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Turtle", PetFamilyType.Turtle, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Warp Stalker", PetFamilyType.WarpStalker, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Wasp", PetFamilyType.Wasp, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Wind Serpent", PetFamilyType.WindSerpent, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Wolf", PetFamilyType.Wolf, PetClassType.Hunter, "en"));
            families.Add(new PetFamily("Worm", PetFamilyType.Worm, PetClassType.Hunter, "en"));
            
            families.Add(new PetFamily("Felguard", PetFamilyType.FelGuard, PetClassType.Warlock, "en"));
            families.Add(new PetFamily("Felhunter", PetFamilyType.FelHunter, PetClassType.Warlock, "en"));
            families.Add(new PetFamily("Imp", PetFamilyType.Imp, PetClassType.Warlock, "en"));
            families.Add(new PetFamily("Infernal", PetFamilyType.Infernal, PetClassType.Warlock, "en"));
            families.Add(new PetFamily("Succubus", PetFamilyType.Succubus, PetClassType.Warlock, "en"));
            families.Add(new PetFamily("Voidwalker", PetFamilyType.VoidWalker, PetClassType.Warlock, "en"));

            return families;
        }
    }
}
