namespace PetEmote.Emotes
{
    public class EmoteNode
    {
        public EmoteNode () : this(string.Empty) { }
        public EmoteNode (string text) : this(text, new EmoteNodeProperties()) { }
        public EmoteNode (string text, EmoteNodeProperties properties) : this(text, properties, new EmoteNodeSet(EmoteNodeSet.EmoteNodeSetType.Inherit)) { }

        public EmoteNode (string text, EmoteNodeProperties properties, EmoteNodeSet childNodes)
        {
            this.Text = text;
            this.Properties = properties;
            this.ChildNodes = childNodes;
        }

        public string Text { get; set; }
        public EmoteNodeProperties Properties { get; set; }
        public EmoteNodeSet ChildNodes { get; set; }
    }
}
