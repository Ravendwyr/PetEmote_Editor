using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace PetEmote.Emotes
{
    class XmlVersionConverter
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
                return this.doc.DocumentElement.FirstChild.InnerText != Version.Latest;
            }
        }

        public void ConvertToLatest ()
        {
            if (this.doc.DocumentElement.FirstChild.Name != "Version") {

                XmlNode node = this.doc.CreateElement("Version");
                node.InnerText = "0.0.0";
                this.doc.DocumentElement.InsertBefore(node, this.doc.DocumentElement.FirstChild);
            }

            XmlNodeList nodes;

            switch (this.doc.DocumentElement.FirstChild.InnerText)
            {
                case "0.0.0":

                    nodes = this.doc.SelectNodes("//*/Node");

                    foreach (XmlNode node in nodes)
                    {
                        if (node.SelectSingleNode("Text") != null)
                        {
                            string[] keywords = EmoteNodeProperties.StringToKeywords(node.SelectSingleNode("Text").InnerText, 4);

                            if (node.SelectSingleNode("Properties/Keywords") == null)
                            {
                                if (node.SelectSingleNode("Properties") == null)
                                    node.AppendChild(this.doc.CreateElement("Properties"));
                                
                                XmlNode keywordsNode = this.doc.CreateElement("Keywords");
                                foreach (string keyword in keywords)
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

                    nodes = this.doc.SelectNodes("//*/RandomMessages");
                    
                    foreach (XmlNode node in nodes)
                    {
                        XmlNode newNode = this.doc.CreateElement("DefaultEmotes");

                        while (node.HasChildNodes)
                            newNode.AppendChild(node.FirstChild);
                        
                        node.ParentNode.ReplaceChild(newNode, node);
                    }

                    goto default;
                    
                default:
                    this.doc.DocumentElement.FirstChild.InnerText = Version.Latest;
                    break;
            }
        }

        public void Save (string filename)
        {
            this.doc.Save(filename);
        }
    }
}
