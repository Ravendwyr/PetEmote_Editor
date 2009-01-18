using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PetEmote.Emotes
{
    public class EmoteNodeSet
    {
        public enum EmoteNodeSetType {
            Inherit = 0,
            RandomMessages = 1,
            Default = 1,
            MoreToCome
        }

        protected ArrayList nodes = new ArrayList();

        public EmoteNodeSet () {
            this.Type = EmoteNodeSetType.Default;
        }

        public EmoteNodeSet (EmoteNodeSetType type) {
            this.Type = type;
        }

        [XmlIgnore]
        public EmoteNodeSetType Type { get; set; }

        [XmlElement(Type = typeof(EmoteNode), ElementName = "Node")]
        public ArrayList Nodes
        {
            get { return this.nodes; }
            set { this.nodes = value; }
        }
    }
}
