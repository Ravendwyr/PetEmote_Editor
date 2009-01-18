namespace PetEmote.Emotes
{
    public class EmoteNode
    {
        private char[] completeChars = new char[] { '.', '!', '?' };
        
        public EmoteNode () : this(string.Empty) { }
        public EmoteNode (string text) : this(text, new EmoteNodeProperties()) { }
        public EmoteNode (string text, EmoteNodeProperties properties) : this(text, properties, new EmoteNodeSet()) { }

        public EmoteNode (string text, EmoteNodeProperties properties, EmoteNodeSet childNodes)
        {
            this.Text = text;
            this.Properties = properties;
            this.ChildNodes = childNodes;
        }

        public string Text { get; set; }
        public EmoteNodeProperties Properties { get; set; }
        public EmoteNodeSet ChildNodes { get; set; }

        public bool IsCompleting
        {
            get
            {
                if (this.Text.Length == 0) return false;

                foreach (char c in this.completeChars)
                {
                    char[] last = this.Text.ToCharArray(this.Text.Length - 1, 1);
                    if (c == (char)last.GetValue(0)) return true;
                }

                return false;
            }
        }

        public string CompletedText
        {
            get
            {
                return this.Text + (this.IsCompleting ? string.Empty : ".");
            }
        }
    }
}
