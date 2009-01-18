using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetEmote.Emotes;

namespace PetEmote.Forms
{
    partial class MainForm
    {
        private TreeNode AddTreeNode (string text /*, EmoteNode.EmoteNodeType type*/)
        {
            TreeNode node = new TreeNode(text);
            node.Tag = new EmoteNodeProperties();

            this.currentTreeView.Nodes.Add(node);

            return node;
        }
        
        private TreeNode AddTreeNode (EmoteNode emoteNode)
        {
            TreeNode node = new TreeNode(emoteNode.Text);
            node.Tag = emoteNode.Properties;
            node.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNode.ChildNodes));

            this.currentTreeView.Nodes.Add(node);

            return node;
        }
        
        private TreeNode AddTreeNode (string text, TreeNode parentNode)
        {
            if (parentNode == null)
                return this.AddTreeNode(text);

            TreeNode node = new TreeNode(text);
            node.Tag = new EmoteNodeProperties();

            parentNode.Nodes.Add(node);

            return node;
        }
        
        private TreeNode AddTreeNode (EmoteNode emoteNode, TreeNode parentNode)
        {
            if (parentNode == null)
                return this.AddTreeNode(emoteNode);

            TreeNode node = new TreeNode(emoteNode.Text);
            node.Tag = emoteNode.Properties;
            node.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNode.ChildNodes));

            parentNode.Nodes.Add(node);

            return node;
        }
        
        private void AddTreeNodeRange (ref TreeView treeView, EmoteNodeSet emoteNodeSet)
        {
            treeView.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNodeSet));
        }

        private void ClearWorkspace ()
        {
            this.ClearTreeViews();
        }

        private void ClearTreeViews ()
        {
            this.TreeView_DefaultEmotes.Nodes.Clear();
            this.TreeView_CombatEmotes.Nodes.Clear();
            this.TreeView_FeedingEmotes.Nodes.Clear();
        }

        private EmoteNodeSet ConvertTreeNodesToEmotesNodes (TreeNodeCollection treeNodes)
        {
            EmoteNodeSet emoteNodes = new EmoteNodeSet();

            foreach (TreeNode treeNode in treeNodes)
            {
                EmoteNode emoteNode = new EmoteNode();

                emoteNode.Text = treeNode.Text;
                emoteNode.Properties = (EmoteNodeProperties)treeNode.Tag;
                
                if (treeNode.Nodes.Count > 0)
                {
                    emoteNode.ChildNodes = this.ConvertTreeNodesToEmotesNodes(treeNode.Nodes);
                }

                emoteNodes.Nodes.Add(emoteNode);
            }

            return emoteNodes;
        }

        private TreeNode[] ConvertEmotesNodesToTreeNodes (EmoteNodeSet emoteNodes)
        {
            TreeNode[] treeNodes = new TreeNode[emoteNodes.Nodes.Count];
            
            for (int i = 0; i < emoteNodes.Nodes.Count; i++)
            {
                EmoteNode emoteNode = (EmoteNode)emoteNodes.Nodes[i];
                TreeNode treeNode = new TreeNode();

                treeNode.Text = emoteNode.Text;
                treeNode.Tag = emoteNode.Properties;
                
                if (emoteNode.ChildNodes.Nodes.Count > 0)
                {
                    treeNode.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNode.ChildNodes));
                }

                treeNodes[i] = treeNode;
            }

            return treeNodes;
        }

        private TreeNode GetRootNode (TreeNode disallowedNode)
        {
            int level = disallowedNode.Level;
            TreeNode node = disallowedNode;

            while (level > 0)
            {
                node = node.Parent;
                level--;
            }

            return node;
        }
    }
}
