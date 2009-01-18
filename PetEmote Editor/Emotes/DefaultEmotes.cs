﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PetEmote.Emotes
{
    public class DefaultEmotes
    {
        protected ArrayList configurations = new ArrayList();

        public DefaultEmotes () { }

        public DefaultEmotes (DirectoryInfo directory)
        {
            this.Directory = directory;
        }

        [XmlIgnore]
        public DirectoryInfo Directory { get; set; }
        
        [XmlIgnore]
        public virtual FileInfo DataFile
        {
            get {
                return new FileInfo(this.Directory.FullName + "\\default-emotes.xml");
            }
        }

        [XmlIgnore]
        public virtual FileInfo ExportFile
        {
            get {
                return new FileInfo(this.Directory.FullName + "\\default-emotes.lua");
            }
        }

        [XmlElement(Type = typeof(EmoteConfiguration),ElementName = "EmoteConfiguration")]
        public ArrayList EmoteConfigurations
        {
            get { return this.configurations; }
            set { this.configurations = value; }
        }

        public bool Load ()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                TextReader tr = new StreamReader(this.DataFile.FullName);
                DefaultEmotes ce = (DefaultEmotes)xs.Deserialize(tr);
                this.EmoteConfigurations = ce.EmoteConfigurations;
                tr.Close();
            }
            catch (FileNotFoundException)
            {
                // Datei existiert noch nicht oder kann nicht gelesen werden
                return false;
            }
            /*catch (InvalidOperationException)
            {
                // Fehler im XML
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }*/

            return true;
        }

        public bool Save ()
        {
            try
            {
                if (this.DataFile.Exists)
                    this.DataFile.CopyTo(this.DataFile.FullName + ".bak", true);

                XmlSerializer xs = new XmlSerializer(this.GetType());
                TextWriter tw = new StreamWriter(this.DataFile.FullName);
                xs.Serialize(tw, this);
                tw.Close();
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

            return true;
        }

        public bool Export ()
        {
            return this.Export(false);
        }

        public bool Export (bool appendLanguage)
        {
            try
            {
                if (this.ExportFile.Exists)
                    this.ExportFile.CopyTo(this.ExportFile.FullName + ".bak", true);

                LuaTableWriter writer = new LuaTableWriter(this.ExportFile.FullName);

                foreach (EmoteConfiguration configuration in this.EmoteConfigurations)
                {
                    string[] table = LuaTableWriter.Table(
                        "PetEmote_" + Enum.GetName(configuration.RandomMessages.Type.GetType(),
                        configuration.RandomMessages.Type), configuration.Name + (appendLanguage ? "-" + configuration.Language : string.Empty),
                        this.ExportNodeSetContent(configuration.RandomMessages)
                    );
                    writer.Write(table);
                }

                writer.Close();
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

            return true;
        }

        private string[] ExportNodeSetContent (EmoteNodeSet nodeSet)
        {
            ArrayList emotes = new ArrayList();

            for (int i = 0; i < nodeSet.Nodes.Count; i++)
            {
                EmoteNode node = (EmoteNode)nodeSet.Nodes[i];

                ArrayList contents = new ArrayList();

                contents.Add(LuaTableWriter.Item("text", node.Text));

                if (node.Properties.Condition != EmoteNodeProperties.EmoteCondition.None)
                    contents.Add(LuaTableWriter.Item("condition", node.Properties.Condition));
                
                if (node.Properties.Disallow.Count > 0)
                    contents.Add(LuaTableWriter.Item("disallow", (int[])node.Properties.Disallow.ToArray(typeof(int))));

                if (node.ChildNodes.Nodes.Count > 0) {
                    string[] childContents = LuaTableWriter.List(node.Properties.MustContinue ? "continues" : "optional", this.ExportNodeSetContent(node.ChildNodes));
                    foreach (string line in childContents) contents.Add(line);
                }

                string[] list = LuaTableWriter.List(i + 1, (string[])contents.ToArray(typeof(string)));
                foreach (string line in list) emotes.Add(line);
            }

            return (string[])emotes.ToArray(typeof(string));
        }
    }
}
