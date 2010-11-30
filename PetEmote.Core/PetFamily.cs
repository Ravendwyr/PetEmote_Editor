using System.Collections;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace PetEmote.Core
{
	/// <summary>
	/// Enthält alle Charakterklassen, die Begleiter unterstützen.
	/// </summary>
    public enum PetClassType
    {
        Unknown = 0,
        Hunter,
        Warlock,
        DeathKnight,
		Mage
    }

	/// <summary>
	/// Enthält alle kontrollierbaren Begleiter, die von PetEmote unterstütz
	/// werden, unabhängig von der dazugehörigen Charakterklasse.
	/// </summary>
    public enum PetFamilyType
    {
        Unknown = 0,
        Bat,
        Bear,
		Beetle,
        BirdOfPrey,
        Boar,
        Cat,
        Chimaera,
        CoreHound,
        Crab,
        Crocolisk,
        Devilsaur,
		Dog,
        DragonHawk,
		Fox,
        Gorilla,
        Hyena,
		Monkey,
        Moth,
        NetherRay,
        Raptor,
        Ravager,
        Rhino,
        Scorpid,
        Serpent,
		ShaleSpider,
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
        VoidWalker,
        Ghoul,
		WaterElemental
    }

	/// <summary>
	/// Stellt eine Tierart dar.
	/// </summary>
    public class PetFamily
    {
		/// <summary>
		/// Erzeugt eine neue, neutrale Instanz einer Tierart.
		/// </summary>
        public PetFamily () : this ("Unknown") { }

		/// <summary>
		/// Erzeugt eine neue Instanz einer Tierart mit einem vorgegebenen Namen.
		/// </summary>
		/// <param name="name">Der Name der Tierart oder des Tieres.</param>
        public PetFamily (string name) : this(name, PetFamilyType.Unknown, PetClassType.Unknown) { }

		/// <summary>
		/// Erzegt eine neue Instanz einer bestimmten Tierart.
		/// </summary>
		/// <param name="name">Der Name der Tierart oder des Tieres.</param>
		/// <param name="familyType">Die Art des Tieres.</param>
		/// <param name="classType">Die Charakterklasse, zu der die Tierart gehört.</param>
        public PetFamily (string name, PetFamilyType familyType, PetClassType classType) : this(name, familyType, classType, CultureInfo.CurrentUICulture.TwoLetterISOLanguageName) { }

		/// <summary>
		/// Erzeugt eine neue Instanz einer bestimmten Tierart für eine bestimmte Sprache.
		/// </summary>
		/// <param name="name">Der Name der Tierart oder des Tieres.</param>
		/// <param name="familyType">Die Art des Tieres.</param>
		/// <param name="classType">Die Charakterklasse, zu der die Tierart gehört.</param>
		/// <param name="language">Die Sprache, für die die Tierart angelegt ist.</param>
        public PetFamily (string name, PetFamilyType familyType, PetClassType classType, string language)
        {
            this.Name = name;
            this.FamilyType = familyType;
            this.ClassType = classType;
            this.Language = language;
        }

		/// <summary>
		/// Gibt den Namen der Tierart oder des Tieres zurück oder legt ihn fest.
		/// </summary>
        public string Name { get; set; }

		/// <summary>
		/// Gibt die Sprache zurück, für die die Tierart angelegt ist, oder legt sie fest.
		/// </summary>
        public string Language { get; set; }

		/// <summary>
		/// Gibt die Art des Tieres zurück oder legt sie fest.
		/// </summary>
        public PetFamilyType FamilyType { get; set; }

		/// <summary>
		/// Gibt die Charakterklasse der Tierart zurück oder legt sie fest.
		/// </summary>
        public PetClassType ClassType { get; set; }

		/// <summary>
		/// Gibt die String-Entsprechung der Tierart zurück.
		/// </summary>
		/// <returns>Der Name der Tierart oder des Tieres.</returns>
        public override string ToString ()
        {
            return this.Name;
        }

		/// <summary>
		/// Gibt eine Auflistung aller von PetEmote untersützter Tierarten zurück.
		/// </summary>
		/// <returns>Eine Liste aller unterstützer Tierarten.</returns>
		public static IEnumerable<PetFamily> GetList ()
		{
			yield return new PetFamily("Aasvogel", PetFamilyType.Vulture, PetClassType.Hunter, "de");
			yield return new PetFamily("Bär", PetFamilyType.Bear, PetClassType.Hunter, "de");
			yield return new PetFamily("Drachenfalke", PetFamilyType.DragonHawk, PetClassType.Hunter, "de");
			yield return new PetFamily("Eber", PetFamilyType.Boar, PetClassType.Hunter, "de");
			yield return new PetFamily("Felshetzer", PetFamilyType.Ravager, PetClassType.Hunter, "de");
			yield return new PetFamily("Fledermaus", PetFamilyType.Bat, PetClassType.Hunter, "de");
			yield return new PetFamily("Geisterbestie", PetFamilyType.SpiritBeast, PetClassType.Hunter, "de");
			yield return new PetFamily("Gorilla", PetFamilyType.Gorilla, PetClassType.Hunter, "de");
			yield return new PetFamily("Hyäne", PetFamilyType.Hyena, PetClassType.Hunter, "de");
			yield return new PetFamily("Katze", PetFamilyType.Cat, PetClassType.Hunter, "de");
			yield return new PetFamily("Kernhund", PetFamilyType.CoreHound, PetClassType.Hunter, "de");
			yield return new PetFamily("Krebs", PetFamilyType.Crab, PetClassType.Hunter, "de");
			yield return new PetFamily("Krokilisk", PetFamilyType.Crocolisk, PetClassType.Hunter, "de");
			yield return new PetFamily("Motte", PetFamilyType.Moth, PetClassType.Hunter, "de");
			yield return new PetFamily("Netherrochen", PetFamilyType.NetherRay, PetClassType.Hunter, "de");
			yield return new PetFamily("Raptor", PetFamilyType.Raptor, PetClassType.Hunter, "de");
			yield return new PetFamily("Raubvogel", PetFamilyType.BirdOfPrey, PetClassType.Hunter, "de");
			yield return new PetFamily("Rhinozeros", PetFamilyType.Rhino, PetClassType.Hunter, "de");
			yield return new PetFamily("Schildkröte", PetFamilyType.Turtle, PetClassType.Hunter, "de");
			yield return new PetFamily("Schimäre", PetFamilyType.Chimaera, PetClassType.Hunter, "de");
			yield return new PetFamily("Schlange", PetFamilyType.Serpent, PetClassType.Hunter, "de");
			yield return new PetFamily("Silithid", PetFamilyType.Silithid, PetClassType.Hunter, "de");
			yield return new PetFamily("Skorpid", PetFamilyType.Scorpid, PetClassType.Hunter, "de");
			yield return new PetFamily("Sphärenjäger", PetFamilyType.WarpStalker, PetClassType.Hunter, "de");
			yield return new PetFamily("Spinne", PetFamilyType.Spider, PetClassType.Hunter, "de");
			yield return new PetFamily("Sporensegler", PetFamilyType.Sporebat, PetClassType.Hunter, "de");
			yield return new PetFamily("Teufelssaurier", PetFamilyType.Devilsaur, PetClassType.Hunter, "de");
			yield return new PetFamily("Weitschreiter", PetFamilyType.TallStrider, PetClassType.Hunter, "de");
			yield return new PetFamily("Wespe", PetFamilyType.Wasp, PetClassType.Hunter, "de");
			yield return new PetFamily("Windnatter", PetFamilyType.WindSerpent, PetClassType.Hunter, "de");
			yield return new PetFamily("Wolf", PetFamilyType.Wolf, PetClassType.Hunter, "de");
			yield return new PetFamily("Wurm", PetFamilyType.Worm, PetClassType.Hunter, "de");

			yield return new PetFamily("Höllenbestie", PetFamilyType.Infernal, PetClassType.Warlock, "de");
			yield return new PetFamily("Leerwandler", PetFamilyType.VoidWalker, PetClassType.Warlock, "de");
			yield return new PetFamily("Sukkubus", PetFamilyType.Succubus, PetClassType.Warlock, "de");
			yield return new PetFamily("Teufelsjäger", PetFamilyType.FelHunter, PetClassType.Warlock, "de");
			yield return new PetFamily("Teufelswache", PetFamilyType.FelGuard, PetClassType.Warlock, "de");
			yield return new PetFamily("Wichtel", PetFamilyType.Imp, PetClassType.Warlock, "de");

			yield return new PetFamily("Ghul", PetFamilyType.Ghoul, PetClassType.DeathKnight, "de");

			yield return new PetFamily("Wasserelementar", PetFamilyType.WaterElemental, PetClassType.Mage, "de");

			yield return new PetFamily("Bat", PetFamilyType.Bat, PetClassType.Hunter, "en");
			yield return new PetFamily("Bear", PetFamilyType.Bear, PetClassType.Hunter, "en");
			yield return new PetFamily("Bird of Prey", PetFamilyType.BirdOfPrey, PetClassType.Hunter, "en");
			yield return new PetFamily("Boar", PetFamilyType.Boar, PetClassType.Hunter, "en");
			yield return new PetFamily("Carrion Bird", PetFamilyType.Vulture, PetClassType.Hunter, "en");
			yield return new PetFamily("Cat", PetFamilyType.Cat, PetClassType.Hunter, "en");
			yield return new PetFamily("Chimera", PetFamilyType.Chimaera, PetClassType.Hunter, "en");
			yield return new PetFamily("Core Hound", PetFamilyType.CoreHound, PetClassType.Hunter, "en");
			yield return new PetFamily("Crab", PetFamilyType.Crab, PetClassType.Hunter, "en");
			yield return new PetFamily("Crocolisk", PetFamilyType.Crocolisk, PetClassType.Hunter, "en");
			yield return new PetFamily("Devilsaur", PetFamilyType.Devilsaur, PetClassType.Hunter, "en");
			yield return new PetFamily("Dragonhawk", PetFamilyType.DragonHawk, PetClassType.Hunter, "en");
			yield return new PetFamily("Gorilla", PetFamilyType.Gorilla, PetClassType.Hunter, "en");
			yield return new PetFamily("Hyena", PetFamilyType.Hyena, PetClassType.Hunter, "en");
			yield return new PetFamily("Moth", PetFamilyType.Moth, PetClassType.Hunter, "en");
			yield return new PetFamily("Nether Ray", PetFamilyType.NetherRay, PetClassType.Hunter, "en");
			yield return new PetFamily("Raptor", PetFamilyType.Raptor, PetClassType.Hunter, "en");
			yield return new PetFamily("Ravager", PetFamilyType.Ravager, PetClassType.Hunter, "en");
			yield return new PetFamily("Rhino", PetFamilyType.Rhino, PetClassType.Hunter, "en");
			yield return new PetFamily("Scorpid", PetFamilyType.Scorpid, PetClassType.Hunter, "en");
			yield return new PetFamily("Serpent", PetFamilyType.Serpent, PetClassType.Hunter, "en");
			yield return new PetFamily("Silithid", PetFamilyType.Silithid, PetClassType.Hunter, "en");
			yield return new PetFamily("Spider", PetFamilyType.Spider, PetClassType.Hunter, "en");
			yield return new PetFamily("Spirit Beast", PetFamilyType.SpiritBeast, PetClassType.Hunter, "en");
			yield return new PetFamily("Sporebat", PetFamilyType.Sporebat, PetClassType.Hunter, "en");
			yield return new PetFamily("Tallstrider", PetFamilyType.TallStrider, PetClassType.Hunter, "en");
			yield return new PetFamily("Turtle", PetFamilyType.Turtle, PetClassType.Hunter, "en");
			yield return new PetFamily("Warp Stalker", PetFamilyType.WarpStalker, PetClassType.Hunter, "en");
			yield return new PetFamily("Wasp", PetFamilyType.Wasp, PetClassType.Hunter, "en");
			yield return new PetFamily("Wind Serpent", PetFamilyType.WindSerpent, PetClassType.Hunter, "en");
			yield return new PetFamily("Wolf", PetFamilyType.Wolf, PetClassType.Hunter, "en");
			yield return new PetFamily("Worm", PetFamilyType.Worm, PetClassType.Hunter, "en");

			yield return new PetFamily("Felguard", PetFamilyType.FelGuard, PetClassType.Warlock, "en");
			yield return new PetFamily("Felhunter", PetFamilyType.FelHunter, PetClassType.Warlock, "en");
			yield return new PetFamily("Imp", PetFamilyType.Imp, PetClassType.Warlock, "en");
			yield return new PetFamily("Infernal", PetFamilyType.Infernal, PetClassType.Warlock, "en");
			yield return new PetFamily("Succubus", PetFamilyType.Succubus, PetClassType.Warlock, "en");
			yield return new PetFamily("Voidwalker", PetFamilyType.VoidWalker, PetClassType.Warlock, "en");

			yield return new PetFamily("Ghoul", PetFamilyType.Ghoul, PetClassType.DeathKnight, "en");

			yield return new PetFamily("Water Elemental", PetFamilyType.WaterElemental, PetClassType.Mage, "en");
		}
	}
}
