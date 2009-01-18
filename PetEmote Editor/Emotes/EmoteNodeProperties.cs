using System;
using System.Collections;
using System.Xml.Serialization;

namespace PetEmote.Emotes
{
    public class EmoteNodeProperties : ICloneable
    {
        private EmoteCondition condition = EmoteCondition.None;
        private ArrayList disallow = new ArrayList();

        public EmoteNodeProperties () { }
        
        public enum EmoteCondition
        {
            None,
            TargetExists,
            TargetIsFriendly,
            TargetIsUnfriendly,
            PetIsUnhappy,
            PetIsContent,
            PetIsHappy,
            PetIsMale,
            PetIsFemale,
            PlayerIsMale,
            PlayerIsFemale,
            TargetIsSpider
        }

        public EmoteCondition Condition
        {
            get { return this.condition; }
            set { this.condition = value; }
        }

        public bool MustContinue { get; set; }
        public bool DisallowAll { get; set; }

        [XmlArrayItem(Type = typeof(int), ElementName = "Index")]
        public ArrayList Disallow
        {
            get
            {
                if (this.DisallowAll || this.disallow.Contains(0))
                {
                    ArrayList disallowAll = new ArrayList(1);
                    disallowAll.Add(0);
                    return disallowAll;
                }

                return this.disallow;
            }
            set
            {
                this.disallow = value;
            }
        }

        public object Clone ()
        {
            return (EmoteNodeProperties)MemberwiseClone();
        }
    }
}
