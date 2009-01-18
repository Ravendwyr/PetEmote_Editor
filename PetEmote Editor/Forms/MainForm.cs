using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PetEmote.Emotes;
using PetEmote.Properties;

namespace PetEmote.Forms
{
    public partial class MainForm : Form
    {
        private DefaultEmotes defaultEmotes;
        private CustomEmotes customEmotes;
        private DefaultEmotes currentEmotes;
        private EmoteConfiguration currentEmoteConfiguration;
        
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
            
            if (dir == null)
            {
                Application.Exit();
                return;
            }
            
            this.defaultEmotes = new DefaultEmotes(dir);
            this.customEmotes = new CustomEmotes(dir);

            XmlVersionConverter defaultConverter = new XmlVersionConverter(this.defaultEmotes.DataFile.FullName);
            
            if (defaultConverter.IsObsolete) {
                defaultConverter.ConvertToLatest();
                defaultConverter.Save(this.defaultEmotes.DataFile.FullName);
            }

            XmlVersionConverter customConverter = new XmlVersionConverter(this.customEmotes.DataFile.FullName);
            
            if (customConverter.IsObsolete) {
                customConverter.ConvertToLatest();
                customConverter.Save(this.customEmotes.DataFile.FullName);
            }

            this.defaultEmotes.Load();
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
            if (this.ToolStripComboBox_Configuration.SelectedItem == null) return;
            this.TreeView_RandomEmotes.SelectedNode = this.AddTreeNode(Resources.Other_NewEmote);
            this.TreeView_RandomEmotes.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_AddChildNode_Click(object sender, EventArgs e)
        {
            if (this.TreeView_RandomEmotes.SelectedNode == null) return;
            this.TreeView_RandomEmotes.SelectedNode = this.AddTreeNode(Resources.Other_NewSubordinaryEmote, this.TreeView_RandomEmotes.SelectedNode);
            this.TreeView_RandomEmotes.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_Save_Click(object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.RandomMessages = this.ConvertTreeNodesToEmotesNodes(this.TreeView_RandomEmotes.Nodes);
            }

            this.currentEmotes.EmoteConfigurations.Clear();

            foreach (EmoteConfiguration config in this.ToolStripComboBox_Configuration.Items)
            {
                this.currentEmotes.EmoteConfigurations.Add(config);
            }

            if (!this.currentEmotes.Save())
            {
                if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                {
                    this.ToolStripButton_Save_Click(sender, e);
                }
            }

            if (!this.currentEmotes.Export(this.currentEmotes.GetType() == typeof(DefaultEmotes)))
            {
                if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                {
                    this.ToolStripButton_Save_Click(sender, e);
                }
            }
        }

        private void ToolStripComboBox_Configuration_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.RandomMessages = this.ConvertTreeNodesToEmotesNodes(this.TreeView_RandomEmotes.Nodes);
            }

            this.currentEmoteConfiguration = (EmoteConfiguration) this.ToolStripComboBox_Configuration.SelectedItem;
            this.ClearTreeView();
            
            this.TreeView_RandomEmotes.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(this.currentEmoteConfiguration.RandomMessages));
        }

        private void TreeView_Main_AfterSelect (object sender, TreeViewEventArgs e)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties) e.Node.Tag;

            this.ToolStripMenuItem_MustContinue.Checked = properties.MustContinue;
            this.ToolStripMenuItem_MustContinue.Enabled = e.Node.Nodes.Count > 0;

            this.ToolStripComboBox_Chance.Text = properties.Chance.ToString();
            this.TextBox_Keywords.Text = String.Join(" ", properties.Keywords);
            
            this.SetSelectedMenuItem(this.ToolStripMenuItem_Conditions.DropDownItems, properties.Condition.ToString());
            
            this.ShowEmotePreview(e.Node, true);
        }

        private void ToolStripButton_RemoveConfiguration_Click (object sender, EventArgs e)
        {
            if (this.ToolStripComboBox_Configuration.SelectedIndex > -1)
            {
                if (MessageBox.Show(Resources.Message_ConfirmDeleteConfiguration, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                this.ToolStripComboBox_Configuration.Items.RemoveAt(this.ToolStripComboBox_Configuration.SelectedIndex);
                this.ClearTreeView();
                this.ToolStripComboBox_Configuration.SelectedIndex = this.ToolStripComboBox_Configuration.Items.Count - 1;
            }
        }

        private void ToolStripButton_RemoveNode_Click (object sender, EventArgs e)
        {
            if (this.TreeView_RandomEmotes.SelectedNode != null)
            {
                this.TreeView_RandomEmotes.SelectedNode.Remove();
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
            int oldNodesCount = this.TreeView_RandomEmotes.Nodes.Count;
            this.AddTreeNodeRange(config.RandomMessages);
        }

        private void TreeView_Main_ItemDrag (object sender, ItemDragEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            TreeNode node = (TreeNode)e.Item;
            tree.SelectedNode = node;
            
            if (node != null)
            {
                EmoteNodeProperties properties = (EmoteNodeProperties)node.Tag;
                TreeNode nodeCloned = (TreeNode)node.Clone();
                nodeCloned.Tag = properties.Clone();
                tree.DoDragDrop(nodeCloned, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        private void TreeView_Main_DragOver (object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            e.Effect = DragDropEffects.None;

            if (e.Data.GetData(typeof(TreeNode)) != null)
            {
                Point pt = tree.PointToClient(new Point(e.X, e.Y));
                TreeNode node = tree.GetNodeAt(pt);

                if (tree.SelectedNode.IsExpanded) tree.SelectedNode.Collapse();

                if (node != tree.SelectedNode)
                {
                    if (Control.ModifierKeys == Keys.Control || Control.ModifierKeys == Keys.ControlKey)
                        e.Effect = DragDropEffects.Copy;
                    else
                        e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void TreeView_Main_DragDrop (object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            
            Point pt = tree.PointToClient(new Point(e.X, e.Y));
            
            TreeNode node = tree.GetNodeAt(pt);

            if (node != null) {
                node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
                node.Expand();
            } else {
                tree.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
            }

            if (e.Effect == DragDropEffects.Move)
                tree.SelectedNode.Remove();

            tree.SelectedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
        }

        private void ToolStripMenuItem_MustContinue_CheckedChanged (object sender, EventArgs e)
        {
            if (this.TreeView_RandomEmotes.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_RandomEmotes.SelectedNode.Tag;
            config.MustContinue = this.ToolStripMenuItem_MustContinue.Checked;
        }

        private void ToolStripMenuItem_Condition_CheckedChanged (object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.CheckState == CheckState.Checked)
            {
                if (this.TreeView_RandomEmotes.SelectedNode == null) return;
                EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_RandomEmotes.SelectedNode.Tag;
                config.Condition = (EmoteNodeProperties.EmoteCondition)Enum.Parse(config.Condition.GetType(), menuItem.Tag.ToString());
                this.UncheckAllMenuItemsExcept(this.ToolStripMenuItem_Conditions.DropDownItems, menuItem);
            }
        }

        private void ToolStripComboBox_Chance_TextChanged (object sender, EventArgs e)
        {
            if (this.TreeView_RandomEmotes.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_RandomEmotes.SelectedNode.Tag;

            try {
                config.Chance = int.Parse(this.ToolStripComboBox_Chance.Text);
            }
            catch (FormatException) { }
        }

        private void TextBox_Keywords_TextChanged (object sender, EventArgs e)
        {
            if (this.TreeView_RandomEmotes.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.TreeView_RandomEmotes.SelectedNode.Tag;
            config.Keywords = EmoteNodeProperties.StringToKeywords(this.TextBox_Keywords.Text);
        }

        private void TreeView_Main_AfterLabelEdit (object sender, NodeLabelEditEventArgs e)
        {
            if (this.TextBox_Keywords.Text.Length == 0 && e.Label != null)
                this.TextBox_Keywords.Text = String.Join(" ", EmoteNodeProperties.StringToKeywords(e.Label));
        }
    }
}
