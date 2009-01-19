using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public class EmoteNodeSet : CollectionBase
    {
        public EmoteNodeSet () { }

        public EmoteNode this[int index]
        {
            get { return (EmoteNode)List[index]; }
            set { List[index] = value; }
        }

        public virtual void Add (EmoteNode node)
        {
            List.Add(node);
        }

        public virtual void Remove (EmoteNode node)
        {
            List.Remove(node);
        }

        public bool Contains (EmoteNode node)
        {
            return List.Contains(node);
        }

        public int IndexOf (EmoteNode node)
        {
            return List.IndexOf(node);
        }

        protected override void OnValidate (object value)
        {
            base.OnValidate(value);
            if (!(value is EmoteNode)) {
                throw new ArgumentException("EmoteNodeSet only supports EmoteNode objects");
            }
        }
    }
}
