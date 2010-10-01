using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public class DefaultEmotes : Emotes
    {
        public DefaultEmotes () : base() { }

        public DefaultEmotes (DirectoryInfo directory) : base(directory) { }

        [XmlIgnore]
        public override FileInfo DataFile
        {
            get { return new FileInfo(Path.Combine(this.Directory.FullName, "default-emotes.xml")); }
        }

        [XmlIgnore]
        public override FileInfo ExportFile
        {
            get { return new FileInfo(Path.Combine(this.Directory.FullName, "default-emotes.lua")); }
        }
	}
}
