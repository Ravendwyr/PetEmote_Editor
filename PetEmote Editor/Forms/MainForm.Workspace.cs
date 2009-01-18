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
        private TreeNode AddTreeNode (string text)
        {
            TreeNode node = new TreeNode(text);
            node.Tag = new EmoteNodeProperties();

            this.TreeView_Main.Nodes.Add(node);

            return node;
        }
        
        private TreeNode AddTreeNode (EmoteNode emoteNode)
        {
            TreeNode node = new TreeNode(emoteNode.Text);
            node.Tag = emoteNode.Properties;
            node.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNode.ChildNodes));

            this.TreeView_Main.Nodes.Add(node);

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
        
        private void AddTreeNodeRange (EmoteNodeSet emoteNodeSet)
        {
            this.TreeView_Main.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(emoteNodeSet));
        }

        private void ClearWorkspace ()
        {
            this.ClearTreeView();
        }

        private void ClearTreeView ()
        {
            this.TreeView_Main.Nodes.Clear();
            this.disallowNodesContainer.Clear();
        }

        private void CheckTreeViewNodes (TreeNodeCollection nodes, bool checkedValue, bool recursive)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = checkedValue;

                if (recursive)
                    this.CheckTreeViewNodes(node.Nodes, checkedValue, true);
            }
        }

        private void CheckTreeViewNodes (TreeNodeCollection nodes, TreeNode[] checkNodes, bool recursive)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;

                foreach (TreeNode checkNode in checkNodes)
                {
                    if (checkNode == node)
                    {
                        node.Checked = true;
                        break;
                    }
                }

                if (recursive)
                    this.CheckTreeViewNodes(node.Nodes, checkNodes, true);
            }
        }

        private EmoteNodeSet ConvertTreeNodesToEmotesNodes (TreeNodeCollection treeNodes)
        {
            EmoteNodeSet emoteNodes = new EmoteNodeSet();

            foreach (TreeNode treeNode in treeNodes)
            {
                EmoteNode emoteNode = new EmoteNode();

                emoteNode.Text = treeNode.Text;
                emoteNode.Properties = (EmoteNodeProperties)treeNode.Tag;
                emoteNode.Properties.Disallow = this.ConvertTreeNodesToDisallowIndexes(treeNode);

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

        private ArrayList ConvertTreeNodesToDisallowIndexes (TreeNode treeNode)
        {
            if (!this.disallowNodesContainer.ContainsKey(treeNode))
                return new ArrayList(0);

            ArrayList disallowedNodes = (ArrayList)this.disallowNodesContainer[treeNode];
            ArrayList result = new ArrayList(disallowedNodes.Count);

            foreach (TreeNode disallowedNode in disallowedNodes)
            {
                result.Add(this.GetRootNode(disallowedNode).Index + 1);
            }

            return result;
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

        private void FillDisallowNodesContainer (TreeNodeCollection treeNodes)
        {
            this.FillDisallowNodesContainer(treeNodes, 0, 0);
        }

        private void FillDisallowNodesContainer (TreeNodeCollection treeNodes, int startIndex)
        {
            this.FillDisallowNodesContainer(treeNodes, startIndex, 0);
        }

        private void FillDisallowNodesContainer (TreeNodeCollection treeNodes, int startIndex, int shift)
        {
            foreach (TreeNode treeNode in treeNodes)
            {
                if (treeNode.Index < startIndex) continue;

                EmoteNodeProperties properties = (EmoteNodeProperties)treeNode.Tag;
                ArrayList result = new ArrayList(properties.Disallow.Count);
                
                foreach (int disallow in properties.Disallow)
                {
                    if (disallow < 1) continue;
                    result.Add(this.TreeView_Main.Nodes[disallow - 1 + shift]);
                }

                if (this.disallowNodesContainer.ContainsKey(treeNode))
                    this.disallowNodesContainer[treeNode] = result;
                else
                    this.disallowNodesContainer.Add(treeNode, result);

                this.FillDisallowNodesContainer(treeNode.Nodes);
            }
        }

        private void RemoveNodeFromDisallowNodesContainer (TreeNode treeNode)
        {
            if (this.disallowNodesContainer.ContainsKey(treeNode))
                this.disallowNodesContainer.Remove(treeNode);

            foreach (ArrayList nodeSet in this.disallowNodesContainer.Values)
            {
                if (nodeSet.Contains(treeNode))
                    nodeSet.Remove(treeNode);
            }
        }
    }
}
