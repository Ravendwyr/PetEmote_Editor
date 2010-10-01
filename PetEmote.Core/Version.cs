using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetEmote.Core
{
	/// <summary>
	/// Stellt eine Version des PetEmote-Kerns dar.
	/// </summary>
    public struct Version
    {
		/// <summary>
		/// Erzeugt eine neue Instanz einer Version unter Angabe von Werten.
		/// </summary>
		/// <param name="major">Die Hauptversion.</param>
		/// <param name="minor">Die Nebenversion.</param>
		/// <param name="build">Die Buildnummer.</param>
		public Version(int major, int minor, int build)
		{
			this.Major = major;
			this.Minor = minor;
			this.Build = build;
		}

		/// <summary>
		/// Gibt die Hauptversion zurück oder legt sie fest.
		/// </summary>
		public int Major;

		/// <summary>
		/// Gibt die Nebenversion zurück oder legt sie fest.
		/// </summary>
		public int Minor;

		/// <summary>
		/// Gibt die Buildnummer zurück oder legt sie fest.
		/// </summary>
		public int Build;

		/// <summary>
		/// Gibt an, ob die Version eine valide, existierende Version ist.
		/// </summary>
		public bool IsValid
		{
			get { return Version.History.Contains(this); }
		}

		/// <summary>
		/// Gibt die String-Entsprechung der Version zurück.
		/// </summary>
		/// <returns>Eine Zeichenkette, die die Version darstellt.</returns>
		public override string ToString()
		{
			return String.Format("{0}.{1}.{2}", this.Major, this.Minor, this.Build);
		}

		/// <summary>
		/// Gibt die Versionsgeschichte des PetEmote-Kerns zurück,
		/// in der alle bisherigen Versionen aufgeführt werden.
		/// </summary>
		public static IEnumerable<Version> History
		{
			get
			{
				yield return new Version(0, 0, 0);
				yield return new Version(1, 5, 2);
				yield return new Version(1, 5, 3);
				yield return new Version(1, 6, 0);
				yield return new Version(1, 6, 1);
				yield return new Version(1, 6, 2);
				yield return new Version(1, 6, 3);
				yield return new Version(1, 6, 4);
				yield return new Version(1, 6, 5);
				yield return new Version(1, 6, 6);
			}
		}

		/// <summary>
		/// Gibt die aktuelle Version des PetEmote-Kerns zurück.
		/// </summary>
        public static Version Latest
        {
			get { return Version.History.Last(); }
        }

		/// <summary>
		/// Versucht, eine Zeichenkette als Version zu interpretieren.
		/// </summary>
		/// <param name="version">Eine Zeichenkette, die als Version interpretiert werden soll.</param>
		/// <returns>Das Ergebnis der Konvertierung.</returns>
		/// <exception cref="FormatException">Tritt auf, wenn die Zeichenkette nicht als Version interpretiert werden kann.</exception>
        public static Version Parse (string version)
        {
			try {
				int[] values = version.Split('.').Select(v => int.Parse(v)).ToArray();
				return new Version(values[0], values[1], values[2]);
			}
			catch (FormatException ex) {
				throw ex;
			}
			catch (IndexOutOfRangeException) {
				throw new FormatException();
			}
        }
    }
}
