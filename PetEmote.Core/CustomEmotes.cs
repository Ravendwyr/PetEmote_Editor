using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public class CustomEmotes : Emotes
    {
        public CustomEmotes () : base() { }

        public CustomEmotes (DirectoryInfo directory) : base(directory) { }

        [XmlIgnore]
        public override FileInfo DataFile
        {
            get { return new FileInfo(Path.Combine(this.Directory.FullName, "custom-emotes.xml")); }
        }

        [XmlIgnore]
        public override FileInfo ExportFile
        {
            get { return new FileInfo(Path.Combine(this.Directory.FullName, "custom-emotes.lua")); }
        }
    }
}
