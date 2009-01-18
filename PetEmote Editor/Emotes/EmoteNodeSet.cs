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
        protected ArrayList nodes = new ArrayList();

        public EmoteNodeSet () { }

        [XmlElement(Type = typeof(EmoteNode), ElementName = "Node")]
        public ArrayList Nodes
        {
            get { return this.nodes; }
            set { this.nodes = value; }
        }
    }
}
