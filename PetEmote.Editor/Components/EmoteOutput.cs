using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetEmote.Core;

namespace PetEmote.Editor.Components
{
	/// <summary>
	/// Ermöglicht die Ausgabe von Emotes.
	/// </summary>
	public partial class EmoteOutput : UserControl
	{
		/// <summary>
		/// Erzeugt eine neue Instanz eines Controls für die Emote-Ausgabe.
		/// </summary>
		public EmoteOutput ()
		{
			this.InitializeComponent();

			this.PetName = "Unknown";
			this.TargetName = EmoteNode.TargetNamePlaceholder;
			this.FoodName = EmoteNode.FoodNamePlaceholder;
		}

		/// <summary>
		/// Gibt den Namen des Tieres zurück, der dem Emote vorangestellt wird, oder legt ihn fest.
		/// </summary>
		public string PetName { get; set; }

		/// <summary>
		/// Gibt den Namen des Spielerziels zurück, durch den Referenzen auf
		/// Ziele innerhalb von Emotes ersetzt werden, oder legt ihn fest.
		/// </summary>
		public string TargetName { get; set; }

		/// <summary>
		/// Gibt den Namen des Futters zurück, durch den Referenzen auf Futter
		/// innerhalb von Emotes ersetzt werden, oder legt ihn fest.
		/// </summary>
		public string FoodName { get; set; }

		/// <summary>
		/// Löscht alle Emotes aus der Liste.
		/// </summary>
		public void Clear ()
		{
			this.ListView.Items.Clear();
		}

		/// <summary>
		/// Fügt der Liste einen Eintrag hinzu.
		/// </summary>
		/// <param name="text">Der Text des Emotes.</param>
		/// <param name="conditions">Die Bedingungen des Emotes.</param>
		public void AddEmote (string text, params EmoteCondition[] conditions)
		{
			string conditionsAsString = String.Join(", ", conditions.Select(c => c.ToString()).ToArray());

			text = text.Replace(EmoteNode.TargetNamePlaceholder, this.TargetName);
			text = text.Replace(EmoteNode.FoodNamePlaceholder, this.FoodName);

			text = String.Concat(this.PetName, " ", text);

			this.ListView.Items.Add(
				new ListViewItem(new string[] { text, conditionsAsString })
			);
		}

		/// <summary>
		/// Fügt der Liste einen kompletten Emote-Knoten einschließlich aller Unterknoten hinzu.
		/// </summary>
		/// <param name="emoteNode">Der Emote-Knoten, der hinzugefügt werden soll.</param>
		public void AddEmoteNode (EmoteNode emoteNode)
		{
			foreach (var flatNode in emoteNode.ToFlatNodes())
			{
				this.AddEmote(flatNode.Key.Text, flatNode.Value.Where(c => c.Condition != EmoteCondition.None).Select(c => c.Condition).Distinct().ToArray());
			}
		}
	}
}
