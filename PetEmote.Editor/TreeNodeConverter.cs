using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetEmote.Core;

namespace PetEmote.Editor
{
	/// <summary>
	/// Stellt Methoden zur Konvertierung von TreeNodes in EmoteNodes und umgekehrt zur Verfügung.
	/// </summary>
	public class TreeNodeConverter
	{
		/// <summary>
		/// Konvertiert eine TreeNodeCollection in eine Auflistung von EmoteNodes.
		/// </summary>
		/// <param name="treeNodeCollection">Die TreeNodeCollection, die konvertiert werden soll.</param>
		/// <returns>Eine Auflistung von EmoteNodes.</returns>
		public static IEnumerable<EmoteNode> TreeNodeCollectionToEmoteNodes (TreeNodeCollection treeNodeCollection)
		{
			foreach (TreeNode treeNode in treeNodeCollection)
			{
				yield return TreeNodeConverter.TreeNodeToEmoteNode(treeNode);
			}
		}

		/// <summary>
		/// Konvertiert einen TreeNode in einen EmoteNode.
		/// </summary>
		/// <param name="treeNode">Der TreeNode, der konvertiert werden soll.</param>
		/// <returns>Der erzeugte EmoteNode.</returns>
		public static EmoteNode TreeNodeToEmoteNode (TreeNode treeNode)
		{
			EmoteNode emoteNode = new EmoteNode();

			emoteNode.Text = treeNode.Text;
			emoteNode.Properties = (EmoteNodeProperties)treeNode.Tag;

			if (treeNode.Nodes.Count > 0) {
				emoteNode.ChildNodes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(treeNode.Nodes).ToList();
			}

			return emoteNode;
		}

		/// <summary>
		/// Konvertiert eine Auflistung von EmoteNodes in eine Auflistung von TreeNodes.
		/// </summary>
		/// <param name="emoteNodes">Die Auflistung von EmoteNodes, die konvertiert werden soll.</param>
		/// <returns>Eine Auflistung von TreeNodes.</returns>
		public static IEnumerable<TreeNode> EmoteNodesToTreeNodes (IEnumerable<EmoteNode> emoteNodes)
		{
			foreach (EmoteNode emoteNode in emoteNodes)
			{
				yield return TreeNodeConverter.EmoteNodeToTreeNode(emoteNode);
			}
		}

		/// <summary>
		/// Konvertiert einen EmoteNode in einen TreeNode.
		/// </summary>
		/// <param name="emoteNode">Der EmoteNode, der konvertiert werden soll.</param>
		/// <returns>Der erzeugte TreeNode.</returns>
		public static TreeNode EmoteNodeToTreeNode (EmoteNode emoteNode)
		{
			TreeNode treeNode = new TreeNode();

			treeNode.Text = emoteNode.Text;
			treeNode.Tag = emoteNode.Properties;

			if (emoteNode.ChildNodes.Count > 0) {
				treeNode.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(emoteNode.ChildNodes).ToArray());
			}

			return treeNode;
		}
	}
}
