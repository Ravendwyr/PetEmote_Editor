using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Collections;

namespace PetEmote.Core
{
	/// <summary>
	/// Stellt einen Textknoten dar, der Teil eines Emotes ist.
	/// </summary>
    public class EmoteNode
    {
		/// <summary>
		/// Gibt den Platzhalter für den Namen des Spielerziels zur Verwendung im Emotetext zurück.
		/// </summary>
		public const string TargetNamePlaceholder = "%t";

		/// <summary>
		/// Gibt den Platzhalter für den Namen eines Futters zur Verwendung im Emotetext zurück.
		/// </summary>
		public const string FoodNamePlaceholder = "%f";

		/// <summary>
		/// Gibt eine Auflistung der Zeichen zurück, die ein Emote als abgeschlossen
		/// kennzeichnen, wenn sie als letztes Zeichen des Textes auftreten.
		/// </summary>
		public readonly char[] CompleteChars = new char[] { '.', '!', '?' };

		/// <summary>
		/// Gibt das Zeichen zurück, dass standardmäßig zum Abschließen des Textes verwendet wird.
		/// </summary>
		public readonly char DefaultCompleteChar = '.';

		/// <summary>
		/// Erzeugt eine neue, leere Instanz eines Textknotens.
		/// </summary>
        public EmoteNode () : this(String.Empty) { }

		/// <summary>
		/// Erzeugt eine neue Instanz eines Textknotens mit einem vordefinierten Text.
		/// </summary>
		/// <param name="text">Der Text, mit dem der Knoten initialisiert wird.</param>
        public EmoteNode (string text) : this(text, new EmoteNodeProperties()) { }

		/// <summary>
		/// Erzeugt eine neue Instanz eines Textknotens mit vordefiniertem Text und Eigenschaften.
		/// </summary>
		/// <param name="text">Der Text, mit dem der Knoten initialisiert wird.</param>
		/// <param name="properties">Die Eigenschaften des neuen Knotens.</param>
        public EmoteNode (string text, EmoteNodeProperties properties) : this(text, properties, new List<EmoteNode>()) { }

		/// <summary>
		/// Erzeugt eine neue Instanz eines Textknotens mit vordefiniertem Text, Eigenschaften und untergeordneten Knoten.
		/// </summary>
		/// <param name="text">Der Text, mit dem der Knoten initialisiert wird.</param>
		/// <param name="properties">Die Eigenschaften des neuen Knotens.</param>
		/// <param name="childNodes">Die untergeordneten Knoten des neuen Knotens.</param>
        public EmoteNode (string text, EmoteNodeProperties properties, List<EmoteNode> childNodes)
        {
            this.Text = text;
            this.Properties = properties;
            this.ChildNodes = childNodes;
        }

		/// <summary>
		/// Gibt den Text des Knotens zurück oder legt ihn fest.
		/// </summary>
        public string Text { get; set; }

		/// <summary>
		/// Bietet Zugriff auf die Eigenschaften des Knotens.
		/// </summary>
        public EmoteNodeProperties Properties { get; set; }

		/// <summary>
		/// Bietet Zugriff auf eine Liste der untergeordneten Knoten.
		/// </summary>
        public List<EmoteNode> ChildNodes { get; set; }

		/// <summary>
		/// Gibt an, ob der Text das Emote durch ein Satzzeichen abschließt.
		/// </summary>
        public bool IsCompleting
        {
            get {
                if (this.Text.Length == 0) return false;

                foreach (char c in this.CompleteChars)
                {
                    char[] last = this.Text.ToCharArray(this.Text.Length - 1, 1);
                    if (c == (char)last.GetValue(0)) return true;
                }

                return false;
            }
        }

		/// <summary>
		/// Gibt die durch ein Satzzeichen beendete Variante des Textes zurück.
		/// </summary>
        public string CompletedText
        {
            get {
                return this.Text + (this.IsCompleting ? String.Empty : this.DefaultCompleteChar.ToString());
            }
        }

		/// <summary>
		/// Berechnet eine flache Auflistung von Emote-Knoten dieses Knotens
		/// einschließlich aller Unterknoten mit den dazugehörigen Eigenschaften.
		/// </summary>
		/// <returns>Eine Auflistung von Emote-Knoten, die alle möglichen Variationen dieses Knotens darstellen.</returns>
		public IEnumerable<KeyValuePair<EmoteNode, EmoteNodeProperties[]>> ToFlatNodes ()
		{
			if (this.IsCompleting || this.ChildNodes.Count == 0)
			{
				yield return new KeyValuePair<EmoteNode, EmoteNodeProperties[]>(
					new EmoteNode(this.CompletedText, this.Properties),
					new EmoteNodeProperties[] { this.Properties }
				);
				yield break;
			}

			foreach (var childNode in this.ChildNodes)
			{
				foreach (var flatChildNode in childNode.ToFlatNodes())
				{
					var properties = flatChildNode.Value.ToList();
					properties.Insert(0, this.Properties);

					yield return new KeyValuePair<EmoteNode, EmoteNodeProperties[]>(
						new EmoteNode(this.Text + " " + flatChildNode.Key.Text, this.Properties),
						properties.ToArray()
					);
				}
			}
		}
    }
}
