using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PetEmote.Emotes;

namespace PetEmote.Forms
{
    public partial class MainForm : Form
    {
        private DefaultEmotes defaultEmotes;
        private CustomEmotes customEmotes;
        private DefaultEmotes currentEmotes;
        private EmoteConfiguration currentEmoteConfiguration;
        private Hashtable disallowNodesContainer = new Hashtable();

        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ToolStripComboBox_Source.Items.AddRange(new string[] { "Default", "Custom" });
            this.ToolStripComboBox_Source.SelectedIndex = 1;
            this.ToolStripComboBox_Source.Visible = Control.ModifierKeys == Keys.Shift;

            this.FillAddConfigurationMenu();
            
            this.ToolStipButton_Load.PerformClick();
        }

        private void ToolStripButton_Load_Click (object sender, EventArgs e)
        {
            this.UnloadConfigurations();

            DirectoryInfo dir = this.GetPetEmoteDirectory();
            
            this.defaultEmotes = new DefaultEmotes(dir);
            this.defaultEmotes.Load();

            this.customEmotes = new CustomEmotes(dir);
            this.customEmotes.Load();

            if (this.ToolStripComboBox_Source.SelectedIndex == 0) {
                this.currentEmotes = this.defaultEmotes;
            } else {
                this.currentEmotes = this.customEmotes;
            }

            this.FillConfigurationsMenu();
            this.FillImportMenu();
        }

        private void ToolStripButton_AddNode_Click (object sender, EventArgs e)
        {
            this.TreeView_Main.SelectedNode = this.AddTreeNode("Neues Emote");
            this.TreeView_Main.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_AddChildNode_Click(object sender, EventArgs e)
        {
            this.TreeView_Main.SelectedNode = this.AddTreeNode("Neues untergeordnetes Emote", this.TreeView_Main.SelectedNode);
            this.TreeView_Main.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_Save_Click(object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.RandomMessages = this.ConvertTreeNodesToEmotesNodes(this.TreeView_Main.Nodes);
            }

            this.currentEmotes.EmoteConfigurations.Clear();

            foreach (EmoteConfiguration config in this.ToolStripComboBox_Configuration.Items)
            {
                this.currentEmotes.EmoteConfigurations.Add(config);
            }

            if (!this.currentEmotes.Save())
            {
                if (MessageBox.Show("Die Konfiguration wurde nicht gespeichert. Möglicherweise ist die Datei schreibgeschützt.", Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                {
                    this.ToolStripButton_Save_Click(sender, e);
                }
            }

            if (!this.currentEmotes.Export(this.currentEmotes.GetType() == typeof(DefaultEmotes)))
            {
                if (MessageBox.Show("Die Konfiguration wurde nicht exportiert. Möglicherweise ist die Datei schreibgeschützt.", Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                {
                    this.ToolStripButton_Save_Click(sender, e);
                }
            }
        }

        private void ToolStripComboBox_Configuration_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.RandomMessages = this.ConvertTreeNodesToEmotesNodes(this.TreeView_Main.Nodes);
            }

            this.currentEmoteConfiguration = (EmoteConfiguration) this.ToolStripComboBox_Configuration.SelectedItem;
            this.ClearTreeView();
            
            this.TreeView_Main.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(this.currentEmoteConfiguration.RandomMessages));
            this.FillDisallowNodesContainer(this.TreeView_Main.Nodes);
        }

        private void TreeView_Main_AfterSelect (object sender, TreeViewEventArgs e)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties) e.Node.Tag;

            this.ToolStripMenuItem_MustContinue.Checked = properties.MustContinue;
            this.ToolStripMenuItem_MustContinue.Enabled = e.Node.Nodes.Count > 0;

            this.ToolStripMenuItem_DisallowAll.Checked = properties.DisallowAll || properties.Disallow.Contains(0);
            
            this.SetSelectedMenuItem(this.ToolStripMenuItem_Conditions.DropDownItems, properties.Condition.ToString());
            
            if (this.disallowNodesContainer.ContainsKey(e.Node))
            {
                ArrayList checkNodes = (ArrayList)this.disallowNodesContainer[e.Node];
                this.CheckTreeViewNodes(this.TreeView_Main.Nodes, (TreeNode[])checkNodes.ToArray(typeof(TreeNode)), true);
            }
            else
            {
                this.CheckTreeViewNodes(this.TreeView_Main.Nodes, false, true);
            }

            this.ShowEmotePreview(e.Node, true);
        }

        private void ToolStripButton_RemoveConfiguration_Click (object sender, EventArgs e)
        {
            if (this.ToolStripComboBox_Configuration.SelectedIndex > -1)
            {
                this.ToolStripComboBox_Configuration.Items.RemoveAt(this.ToolStripComboBox_Configuration.SelectedIndex);
                this.ToolStripComboBox_Configuration.Text = string.Empty;
                this.ClearTreeView();
                this.ToolStripComboBox_Configuration.SelectedIndex = this.ToolStripComboBox_Configuration.Items.Count - 1;
            }
        }

        private void ToolStripButton_RemoveNode_Click (object sender, EventArgs e)
        {
            if (this.TreeView_Main.SelectedNode != null)
            {
                this.RemoveNodeFromDisallowNodesContainer(this.TreeView_Main.SelectedNode);
                this.TreeView_Main.SelectedNode.Remove();
            }
        }

        private void ToolStripTextBox_Independent_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.HandleConfigurationSelection(this.ToolStripTextBox_Independent.Text);
                this.ToolStripDropDownButton_AddConfiguration.HideDropDown();
            }
        }

        private void ToolStripMenuItem_AddConfiguration_Click (object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            this.HandleConfigurationSelection(menuItem.Text);
        }
        
        private void ToolStripMenuItem_Import_Click (object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            EmoteConfiguration config = (EmoteConfiguration)menuItem.Tag;
            int oldNodesCount = this.TreeView_Main.Nodes.Count;
            this.AddTreeNodeRange(config.RandomMessages);
            this.FillDisallowNodesContainer(this.TreeView_Main.Nodes, oldNodesCount, oldNodesCount);
        }

        private void TreeView_Main_AfterCheck (object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                if (this.disallowNodesContainer.ContainsKey(this.TreeView_Main.SelectedNode))
                {
                    ArrayList nodes = (ArrayList)this.disallowNodesContainer[this.TreeView_Main.SelectedNode];
                    if (!nodes.Contains(e.Node)) nodes.Add(e.Node);
                }
                else
                {
                    ArrayList nodes = new ArrayList();
                    nodes.Add(e.Node);
                    this.disallowNodesContainer.Add(this.TreeView_Main.SelectedNode, nodes);
                }
            }
            else
            {
                if (this.disallowNodesContainer.ContainsKey(this.TreeView_Main.SelectedNode))
                {
                    ArrayList nodes = (ArrayList)this.disallowNodesContainer[this.TreeView_Main.SelectedNode];
                    nodes.Remove(e.Node);
                }
            }
        }

        private void TreeView_Main_ItemDrag (object sender, ItemDragEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            TreeNode node = (TreeNode)e.Item;
            tree.SelectedNode = node;
            
            if (node != null)
                tree.DoDragDrop(node.Clone(), DragDropEffects.Copy);
        }

        private void TreeView_Main_DragOver (object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            e.Effect = DragDropEffects.None;

            if (e.Data.GetData(typeof(TreeNode)) != null)
            {
                Point pt = new Point(e.X, e.Y);
                pt = tree.PointToClient(pt);

                TreeNode node = tree.GetNodeAt(pt);
                if (node != null)
                    e.Effect = DragDropEffects.Copy;
            }
        }

        private void TreeView_Main_DragDrop (object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            
            Point pt = new Point(e.X, e.Y);
            pt = tree.PointToClient(pt);
            
            TreeNode node = tree.GetNodeAt(pt);
            node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
            node.Expand();

            tree.SelectedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
        }

        private void ToolStripMenuItem_MustContinue_CheckedChanged (object sender, EventArgs e)
        {
            if (this.TreeView_Main.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_Main.SelectedNode.Tag;
            config.MustContinue = this.ToolStripMenuItem_MustContinue.Checked;
        }

        private void ToolStripMenuItem_DisallowAll_CheckedChanged (object sender, EventArgs e)
        {
            if (this.TreeView_Main.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_Main.SelectedNode.Tag;
            config.DisallowAll = this.ToolStripMenuItem_DisallowAll.Checked;
        }

        private void ToolStripMenuItem_Condition_CheckedChanged (object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.CheckState == CheckState.Checked)
            {
                if (this.TreeView_Main.SelectedNode == null) return;
                EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_Main.SelectedNode.Tag;
                config.Condition = (EmoteNodeProperties.EmoteCondition)Enum.Parse(config.Condition.GetType(), menuItem.Tag.ToString());
                this.UncheckAllMenuItemsExcept(this.ToolStripMenuItem_Conditions.DropDownItems, menuItem);
            }
        }
    }
}
