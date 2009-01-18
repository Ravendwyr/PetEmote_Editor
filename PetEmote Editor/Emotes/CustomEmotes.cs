using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PetEmote.Emotes
{
    public class CustomEmotes : DefaultEmotes
    {
        public CustomEmotes () : base() { }
        public CustomEmotes (DirectoryInfo directory) : base(directory) { }

        [XmlIgnore]
        public override FileInfo DataFile
        {
            get {
                return new FileInfo(this.Directory.FullName + "\\custom-emotes.xml");
            }
        }

        [XmlIgnore]
        public override FileInfo ExportFile
        {
            get {
                return new FileInfo(this.Directory.FullName + "\\custom-emotes.lua");
            }
        }
    }
}
