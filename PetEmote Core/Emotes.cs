using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PetEmote.Core
{
    public abstract class Emotes
    {
        protected List<EmoteConfiguration> configurations = new List<EmoteConfiguration>();

        public Emotes ()
        {
            this.PetFamilies = new List<PetFamily>();
        }

        public Emotes (DirectoryInfo directory) : this()
        {
            this.Directory = directory;
        }

        public string Version { get; set; }

        [XmlArray(ElementName = "PetFamilies")]
        public List<PetFamily> PetFamilies { get; set; }
        
        [XmlIgnore]
        public DirectoryInfo Directory { get; set; }
        
        [XmlIgnore]
        public abstract FileInfo DataFile { get; }

        [XmlIgnore]
        public abstract FileInfo ExportFile { get; }

        [XmlElement(Type = typeof(EmoteConfiguration),ElementName = "EmoteConfiguration")]
        public List<EmoteConfiguration> EmoteConfigurations
        {
            get { return this.configurations; }
            set { this.configurations = value; }
        }

        public bool Load ()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                TextReader reader = new StreamReader(this.DataFile.FullName);
                Emotes emotes = (Emotes)serializer.Deserialize(reader);
                this.EmoteConfigurations = emotes.EmoteConfigurations;
                this.PetFamilies = emotes.PetFamilies;
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                // Datei existiert noch nicht oder kann nicht gelesen werden
                return false;
            }
            catch (InvalidOperationException)
            {
                // Fehler im XML
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

            return true;
        }

        public bool Save ()
        {
            try
            {
                if (this.DataFile.Exists)
                    this.DataFile.CopyTo(this.DataFile.FullName + ".bak", true);

                this.Version = PetEmote.Core.Version.Latest;

                XmlSerializer serializer = new XmlSerializer(this.GetType());
                TextWriter writer = new StreamWriter(this.DataFile.FullName);
                serializer.Serialize(writer, this);
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

        public bool Export ()
        {
            return this.Export(false);
        }

        public bool Export (bool appendLanguage)
        {
            try
            {
                LuaTableWriter writer = new LuaTableWriter(this.ExportFile.FullName);

                foreach (EmoteConfiguration configuration in this.EmoteConfigurations)
                {
                    if (configuration.DefaultEmotes.Count > 0)
                    {
                        string[] table = LuaTableWriter.Table(
                            "PetEmote_DefaultEmotes",
                            configuration.Name + (appendLanguage ? "-" + configuration.PetFamily.Language : string.Empty),
                            this.ExportNodeSetContent(configuration.DefaultEmotes)
                        );
                        writer.Write(table);
                    }

                    if (configuration.CombatEmotes.Count > 0)
                    {
                        string[] table = LuaTableWriter.Table(
                            "PetEmote_CombatEmotes",
                            configuration.Name + (appendLanguage ? "-" + configuration.PetFamily.Language : string.Empty),
                            this.ExportNodeSetContent(configuration.CombatEmotes)
                        );
                        writer.Write(table);
                    }

                    if (configuration.FeedingEmotes.Count > 0)
                    {
                        string[] table = LuaTableWriter.Table(
                            "PetEmote_FeedingEmotes",
                            configuration.Name + (appendLanguage ? "-" + configuration.PetFamily.Language : string.Empty),
                            this.ExportNodeSetContent(configuration.FeedingEmotes)
                        );
                        writer.Write(table);
                    }
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

        private string[] ExportNodeSetContent (List<EmoteNode> nodeSet)
        {
            List<string> emotes = new List<string>();

            for (int i = 0; i < nodeSet.Count; i++)
            {
                EmoteNode node = nodeSet[i];

                List<string> contents = new List<string>();

                contents.Add(LuaTableWriter.Item("text", node.Text));

                if (node.Properties.Chance != 100)
                    contents.Add(LuaTableWriter.Item("chance", node.Properties.Chance));

                if (node.Properties.Condition != EmoteCondition.None)
                    contents.Add(LuaTableWriter.Item("condition", node.Properties.Condition));

                if (node.Properties.Keywords.Length > 0)
                    contents.Add(LuaTableWriter.Item("keywords", node.Properties.Keywords));

                if (node.ChildNodes.Count > 0) {
                    string[] childContents = LuaTableWriter.List(node.Properties.MustContinue ? "continues" : "optional", this.ExportNodeSetContent(node.ChildNodes));
                    foreach (string line in childContents) contents.Add(line);
                }

                string[] list = LuaTableWriter.List(i + 1, contents.ToArray());
                foreach (string line in list) emotes.Add(line);
            }

            return emotes.ToArray();
        }
    }
}
