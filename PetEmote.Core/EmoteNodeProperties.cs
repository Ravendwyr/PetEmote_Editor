using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PetEmote.Core
{
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

    public class EmoteNodeProperties : ICloneable
    {
        private EmoteCondition condition = EmoteCondition.None;
        private int chance = 100;
        private string[] keywords = new string[0];

        public EmoteNodeProperties () { }
        
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

        public void ImportKeywords (string keywords)
        {
            this.ImportKeywords(keywords, 1);
        }

        public void ImportKeywords (string keywords, int minKeywordLength)
        {
            string[] source = keywords.Split(' ');
            List<string> result = new List<string>(source.Length);

            foreach (string keyword in source)
            {
                string k = keyword.Trim(' ', '.', '!', '?', ',', '-');
                if (k.Length >= minKeywordLength || k.StartsWith("%")) result.Add(k);
            }

            this.Keywords = result.ToArray();
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
