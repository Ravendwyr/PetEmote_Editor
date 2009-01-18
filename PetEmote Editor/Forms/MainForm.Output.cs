using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PetEmote.Emotes;

namespace PetEmote.Forms
{
    partial class MainForm
    {
        private void ShowEmotePreview (TreeNode node, bool clear)
        {
            if (clear) this.ListView_Output.Items.Clear();
            this.ShowEmotePreview(node, new EmoteNodeProperties.EmoteCondition[0]);
        }

        private void ShowEmotePreview (TreeNode node, EmoteNodeProperties.EmoteCondition[] conditions)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties)node.Tag;

            EmoteNodeProperties.EmoteCondition[] allConditions = new EmoteNodeProperties.EmoteCondition[conditions.Length + (properties.Condition != EmoteNodeProperties.EmoteCondition.None ? 1 : 0)];
            conditions.CopyTo(allConditions, 0);
            if (properties.Condition != EmoteNodeProperties.EmoteCondition.None) allConditions[allConditions.Length - 1] = properties.Condition;

            if (node.Nodes.Count == 0)
            {
                this.AddOutputNode(this.ToolStripComboBox_Configuration.SelectedItem.ToString() +
                    " " + node.FullPath + ".", allConditions);
            }
            else
            {
                if (properties.MustContinue == false)
                {
                    this.AddOutputNode(this.ToolStripComboBox_Configuration.SelectedItem.ToString() +
                    " " + node.FullPath + ".", allConditions);
                }

                foreach (TreeNode childNode in node.Nodes)
                {
                    this.ShowEmotePreview(childNode, allConditions);
                }
            }
        }

        private void AddOutputNode (string text, EmoteNodeProperties.EmoteCondition condition)
        {
            this.AddOutputNode(text, new EmoteNodeProperties.EmoteCondition[] { condition });
        }

        private void AddOutputNode (string text, EmoteNodeProperties.EmoteCondition[] conditions)
        {
            string conditionsText = string.Empty;
            for (int i = 0; i < conditions.Length; i++)
                conditionsText += " " + conditions[i].ToString();

            ListViewItem item = new ListViewItem(new string[] { text, conditionsText.TrimStart(new Char[] {' '} ).Replace(" ", ", ") });
            this.ListView_Output.Items.Add(item);
        }
    }
}
