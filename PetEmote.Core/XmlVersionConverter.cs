using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace PetEmote.Core
{
    public class XmlVersionConverter
    {
        private XmlDocument doc;

        public XmlVersionConverter (string filename)
        {
            FileInfo file = new FileInfo(filename);

            if (file.Exists)
            {
                this.doc = new XmlDocument();
                this.doc.Load(file.FullName);
            }
        }

        public bool IsObsolete
        {
            get {
                if (this.doc == null) return false;
                if (this.doc.DocumentElement.FirstChild.Name != "Version") return true;
                return this.doc.DocumentElement.FirstChild.InnerText != Version.Latest.ToString();
            }
        }

        public void ConvertToLatest ()
        {
            if (this.doc.DocumentElement.FirstChild.Name != "Version")
			{
				XmlNode node = this.doc.CreateElement("Version");
                node.InnerText = "0.0.0";
                this.doc.DocumentElement.InsertBefore(node, this.doc.DocumentElement.FirstChild);
            }

            XmlNodeList nodes;

            switch (this.doc.DocumentElement.FirstChild.InnerText)
            {
                case "0.0.0":

                    nodes = this.doc.SelectNodes("//*/Node");
                    EmoteNodeProperties properties = new EmoteNodeProperties();

                    foreach (XmlNode node in nodes)
                    {
                        if (node.SelectSingleNode("Text") != null)
                        {
                            properties.ImportKeywords(node.SelectSingleNode("Text").InnerText, 2);

                            if (node.SelectSingleNode("Properties/Keywords") == null)
                            {
                                if (node.SelectSingleNode("Properties") == null)
                                    node.AppendChild(this.doc.CreateElement("Properties"));
                                
                                XmlNode keywordsNode = this.doc.CreateElement("Keywords");
                                foreach (string keyword in properties.Keywords)
                                {
                                    XmlNode k = this.doc.CreateElement("Keyword");
                                    k.InnerText = keyword;
                                    keywordsNode.AppendChild(k);
                                }

                                node.SelectSingleNode("Properties").AppendChild(keywordsNode);
                            }
                        }
                    }

                    goto case "1.5.2";

                case "1.5.2":

                    this.RenameNodes(this.doc.SelectNodes("//*/RandomMessages"), "DefaultEmotes");
                    this.RenameNodes(this.doc.SelectNodes("//*/Node"), "EmoteNode");

                    goto case "1.5.3";

                case "1.5.3":
				case "1.6.0":
				case "1.6.1":
				case "1.6.2":
				case "1.6.3":
				case "1.6.4":
				case "1.6.5":
                    
                default:
                    this.doc.DocumentElement.FirstChild.InnerText = Version.Latest.ToString();
                    break;
            }
        }

        public void Save (string filename)
        {
            this.doc.Save(filename);
        }

        private void RenameNodes (XmlNodeList nodes, string newName)
        {
            foreach (XmlNode node in nodes)
            {
                XmlNode newNode = this.doc.CreateElement(newName);

                while (node.HasChildNodes)
                    newNode.AppendChild(node.FirstChild);

                node.ParentNode.ReplaceChild(newNode, node);
            }
        }
    }
}
