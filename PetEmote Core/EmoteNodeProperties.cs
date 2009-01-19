using System;
using System.Collections;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public class EmoteNodeProperties : ICloneable
    {
        private EmoteCondition condition = EmoteCondition.None;
        private ArrayList disallow = new ArrayList();
        private int chance = 100;
        private string[] keywords = new string[0];

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
            TargetIsSpider,
            FoodAccepted,
            FoodRefused,
            IsFirstCall,
            IsSecondCall,
            IsThirdCall,
        }

        public EmoteCondition Condition
        {
            get { return this.condition; }
            set { this.condition = value; }
        }

        public bool MustContinue { get; set; }
        
        [XmlArrayItem(Type = typeof(string), ElementName = "Keyword")]
        public string[] Keywords
        {
            get { return this.keywords; }
            set {
                if (value.Length == 1 && value[0] == string.Empty)
                    this.keywords = new string[0];
                else
                    this.keywords = value;
            }
        }

        public static string[] StringToKeywords (string keywords)
        {
            return EmoteNodeProperties.StringToKeywords(keywords, 1);
        }

        public static string[] StringToKeywords (string keywords, int minKeywordLength)
        {
            string[] source = keywords.Split(' ');
            ArrayList result = new ArrayList(source.Length);

            foreach (string keyword in source)
            {
                string k = keyword.Trim(' ', '.', '!', '?', ',', '-');
                if (k.Length >= minKeywordLength || k.StartsWith("%")) result.Add(k);
            }

            return (string[])result.ToArray(typeof(string));
        }

        public int Chance
        {
            get {
                return this.chance;
            }
            set
            {
                if (value > 200) this.chance = 200;
                else if (value < 1) this.chance = 1;
                else this.chance = value;
            }
        }

        public object Clone ()
        {
            return (EmoteNodeProperties)MemberwiseClone();
        }
    }
}
