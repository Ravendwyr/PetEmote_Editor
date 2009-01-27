using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PetEmote.Core;
using PetEmote.Editor.Properties;

namespace PetEmote.Editor.Forms
{
    public partial class MainForm : Form
    {
        private DefaultEmotes defaultEmotes;
        private CustomEmotes customEmotes;
        private Emotes currentEmotes;
        private EmoteConfiguration currentEmoteConfiguration;
        private TreeView currentTreeView;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.LoadSettings();

            this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];
            
            this.Revert();

            this.FillAddConfigurationMenu();
        }

        private void TabControl_EmoteConfigurations_SelectedIndexChanged (object sender, EventArgs e)
        {
            this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];
        }

        private void LoadSettings ()
        {
            //this.CheckBox_KeywordsAutoFill.Checked = Settings.Default.KeywordsAutoFill;
            //this.NumericUpDown_KeywordsMinLength.Value = (decimal)Settings.Default.KeywordsMinLength;
        }

        #region TreeView Controls

        private void TreeView_AfterSelect (object sender, TreeViewEventArgs e)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties) e.Node.Tag;

            this.ToolStripMenuItem_MustContinue.Checked = properties.MustContinue;
            this.ToolStripMenuItem_MustContinue.Enabled = e.Node.Nodes.Count > 0;

            this.ToolStripComboBox_Chance.Text = properties.Chance.ToString();
            this.TextBox_Keywords.Text = String.Join(" ", properties.Keywords);
            
            this.SetSelectedMenuItem(this.ToolStripMenuItem_Conditions.DropDownItems, properties.Condition.ToString());
            
            this.ShowEmotePreview(e.Node, true);
        }

        private void TreeView_AfterLabelEdit (object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && (this.CheckBox_KeywordsAutoFill.Checked || this.TextBox_Keywords.Text.Length == 0)) {
                EmoteNodeProperties properties = new EmoteNodeProperties();
                properties.ImportKeywords(e.Label, (int)this.NumericUpDown_KeywordsMinLength.Value);
                this.TextBox_Keywords.Text = String.Join(" ", properties.Keywords);
            }
        }

        private void TreeView_ItemDrag (object sender, ItemDragEventArgs e)
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

        private void TreeView_DragOver (object sender, DragEventArgs e)
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

        private void TreeView_DragDrop (object sender, DragEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            Point pt = tree.PointToClient(new Point(e.X, e.Y));

            TreeNode node = tree.GetNodeAt(pt);

            if (node != null)
            {
                node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
                node.Expand();
            }
            else
            {
                tree.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
            }

            if (e.Effect == DragDropEffects.Move)
                tree.SelectedNode.Remove();

            tree.SelectedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
        }

        #endregion

        #region Keywords Controls

        private void CheckBox_KeywordsAutoFill_CheckedChanged (object sender, EventArgs e)
        {
            this.TextBox_Keywords.Enabled = !this.CheckBox_KeywordsAutoFill.Checked;
            //Settings.Default.KeywordsAutoFill = this.CheckBox_KeywordsAutoFill.Checked;
            //Settings.Default.Save();
        }

        private void TextBox_Keywords_TextChanged (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
            config.ImportKeywords(this.TextBox_Keywords.Text);
        }

        private void NumericUpDown_KeywordsMinLength_ValueChanged (object sender, EventArgs e)
        {
            //Settings.Default.KeywordsMinLength = (int)NumericUpDown_KeywordsMinLength.Value;
            //Settings.Default.Save();
        }

        #endregion

        #region ToolStrip_Main Controls

        private void revertToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Revert();
        }

        private void Revert ()
        {
            this.UnloadConfigurations();

            DirectoryInfo dir = this.GetPetEmoteDirectory();

            if (dir == null) {
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

            if (Control.ModifierKeys == Keys.Shift)
                this.currentEmotes = this.defaultEmotes;
            else
                this.currentEmotes = this.customEmotes;

            this.FillConfigurationsMenu();
            this.FillImportMenu();
        }

        private void ToolStripButton_Save_Click (object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.DefaultEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_DefaultEmotes.Nodes);
                this.currentEmoteConfiguration.CombatEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_CombatEmotes.Nodes);
                this.currentEmoteConfiguration.FeedingEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_FeedingEmotes.Nodes);
            }

            this.currentEmotes.EmoteConfigurations.Clear();

            foreach (EmoteConfiguration config in this.ToolStripComboBox_Configuration.Items)
                this.currentEmotes.EmoteConfigurations.Add(config);

            // Speichern (xml)
            if (!this.currentEmotes.Save())
                if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                    this.ToolStripButton_Save_Click(sender, e);

            // Exportieren (lua)
            if (!this.currentEmotes.Export(this.currentEmotes.GetType() == typeof(DefaultEmotes)))
                if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                    this.ToolStripButton_Save_Click(sender, e);
        }

        private void ToolStripComboBox_Configuration_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (this.currentEmoteConfiguration != null)
            {
                this.currentEmoteConfiguration.DefaultEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_DefaultEmotes.Nodes);
                this.currentEmoteConfiguration.CombatEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_CombatEmotes.Nodes);
                this.currentEmoteConfiguration.FeedingEmotes = this.ConvertTreeNodesToEmotesNodes(this.TreeView_FeedingEmotes.Nodes);
            }

            this.currentEmoteConfiguration = (EmoteConfiguration)this.ToolStripComboBox_Configuration.SelectedItem;
            this.ClearTreeViews();

            this.TreeView_DefaultEmotes.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(this.currentEmoteConfiguration.DefaultEmotes));
            this.TreeView_CombatEmotes.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(this.currentEmoteConfiguration.CombatEmotes));
            this.TreeView_FeedingEmotes.Nodes.AddRange(this.ConvertEmotesNodesToTreeNodes(this.currentEmoteConfiguration.FeedingEmotes));
        }

        private void ToolStripButton_RemoveConfiguration_Click (object sender, EventArgs e)
        {
            if (this.ToolStripComboBox_Configuration.SelectedIndex > -1)
            {
                if (MessageBox.Show(Resources.Message_ConfirmDeleteConfiguration, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                this.ToolStripComboBox_Configuration.Items.RemoveAt(this.ToolStripComboBox_Configuration.SelectedIndex);
                this.ClearTreeViews();
                this.ToolStripComboBox_Configuration.SelectedIndex = this.ToolStripComboBox_Configuration.Items.Count - 1;
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
            
            this.AddTreeNodeRange(ref this.TreeView_DefaultEmotes, config.DefaultEmotes);
            this.AddTreeNodeRange(ref this.TreeView_CombatEmotes, config.CombatEmotes);
            this.AddTreeNodeRange(ref this.TreeView_FeedingEmotes, config.FeedingEmotes);
        }

        #endregion

        #region ToolStrip_EmoteEditing Controls

        private void ToolStripButton_AddNode_Click (object sender, EventArgs e)
        {
            if (this.ToolStripComboBox_Configuration.SelectedItem == null) return;
            this.currentTreeView.SelectedNode = this.AddTreeNode(Resources.Other_NewEmote);
            this.currentTreeView.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_AddChildNode_Click (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode == null) return;
            this.currentTreeView.SelectedNode = this.AddTreeNode(Resources.Other_NewSubordinaryEmote, this.currentTreeView.SelectedNode);
            this.currentTreeView.SelectedNode.BeginEdit();
        }

        private void ToolStripButton_RemoveNode_Click (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode != null)
                this.currentTreeView.SelectedNode.Remove();
        }

        private void ToolStripMenuItem_MustContinue_CheckedChanged (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
            config.MustContinue = this.ToolStripMenuItem_MustContinue.Checked;
        }

        private void ToolStripMenuItem_Condition_CheckedChanged (object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.CheckState == CheckState.Checked)
            {
                if (this.currentTreeView.SelectedNode == null) return;
                EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
                config.Condition = (EmoteCondition)Enum.Parse(config.Condition.GetType(), menuItem.Tag.ToString());
                this.UncheckAllMenuItemsExcept(this.ToolStripMenuItem_Conditions.DropDownItems, menuItem);
            }
        }

        private void ToolStripComboBox_Chance_TextChanged (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;

            try {
                config.Chance = int.Parse(this.ToolStripComboBox_Chance.Text);
            }
            catch (FormatException) { }
        }

        #endregion

        #region Files

        private DirectoryInfo GetPetEmoteDirectory ()
        {
            DirectoryInfo dir;
            string path = this.GetPathFromRegistry();

            if (path == null)
            {
                path = GetPathFromSearchDialog();
                if (path == null) return null;
            }

            dir = new DirectoryInfo(path);

            if (!dir.Exists)
            {
                path = GetPathFromSearchDialog();
                if (path == null) return null;
            }

            path += "\\Interface\\AddOns\\PetEmote";

            dir = new DirectoryInfo(path);

            if (!dir.Exists)
            {
                MessageBox.Show(Resources.Message_PetEmoteNotFound, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            return dir;
        }

        private string GetPathFromSearchDialog ()
        {
            try
            {
                if (MessageBox.Show(Resources.Message_WorldOfWarcraftNotFound, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return null;
                if (this.folderBrowserDialog.ShowDialog(this) != DialogResult.OK) return null;
                return this.folderBrowserDialog.SelectedPath;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetPathFromRegistry ()
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Blizzard Entertainment").OpenSubKey("World of Warcraft");
                return key.GetValue("InstallPath").ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Menu

        private void FillConfigurationsMenu ()
        {
            foreach (EmoteConfiguration config in this.currentEmotes.EmoteConfigurations)
                this.ToolStripComboBox_Configuration.Items.Add(config);

            if (this.ToolStripComboBox_Configuration.Items.Count > 0)
                this.ToolStripComboBox_Configuration.SelectedIndex = 0;


            foreach (EmoteConfiguration config in this.currentEmotes.EmoteConfigurations) {
                ListViewItem item = new ListViewItem(config.Name, 0, this.ListView_Configurations.Groups["ListViewGroup_" + config.PetFamily.ClassType.ToString()]);
                item.Tag = config;
                this.ListView_Configurations.Items.Add(item);
            }

            if (this.ListView_Configurations.Items.Count > 0)
                this.ListView_Configurations.Items[0].Selected = true;
        }

        private void FillAddConfigurationMenu ()
        {
            var families =
                from family in this.defaultEmotes.PetFamilies
                where family.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName
                group family by family.ClassType into classGroup
                select classGroup;

            IconFactory icons = new IconFactory();

            foreach (var classGroup in families)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(Resources.ResourceManager.GetString("ClassName_" + classGroup.Key.ToString()));
                menuItem.Name = "ToolStripMenuItem_AddConfiguration_" + classGroup.Key.ToString();
                menuItem.Image = icons.GetClassIcon(classGroup.Key);
                this.ToolStripDropDownButton_AddConfiguration.DropDownItems.Insert(ToolStripDropDownButton_AddConfiguration.DropDownItems.Count - 2, menuItem);

                foreach (PetFamily family in classGroup)
                {
                    ToolStripMenuItem familyItem = new ToolStripMenuItem(family.Name);

                    familyItem.Name = "ToolStripMenuItem_AddConfiguration_" + family.Name.GetHashCode().ToString();
                    familyItem.Image = icons.GetPetFamilyIcon(family.FamilyType);
                    familyItem.Tag = family;
                    familyItem.Click += new EventHandler(this.ToolStripMenuItem_AddConfiguration_Click);

                    menuItem.DropDownItems.Add(familyItem);
                }
            }
        }

        private void FillImportMenu ()
        {
            this.ToolStripDropDownButton_Import.DropDownItems.Clear();

            var configurations =
                from config in this.defaultEmotes.EmoteConfigurations
                where config.PetFamily.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName
                group config by config.PetFamily.ClassType into classGroup
                select classGroup;

            IconFactory icons = new IconFactory();

            foreach (var classGroup in configurations)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(Resources.ResourceManager.GetString("ClassName_" + classGroup.Key.ToString()));
                menuItem.Name = "ToolStripMenuItem_Import_" + classGroup.Key.ToString();
                menuItem.Image = icons.GetClassIcon(classGroup.Key);
                this.ToolStripDropDownButton_Import.DropDownItems.Add(menuItem);

                foreach (EmoteConfiguration config in classGroup)
                {
                    ToolStripMenuItem familyItem = new ToolStripMenuItem(config.Name);

                    familyItem.Name = "ToolStripMenuItem_Import_" + config.Name.GetHashCode().ToString();
                    familyItem.Image = icons.GetPetFamilyIcon(config.PetFamily.FamilyType);
                    familyItem.Tag = config;
                    familyItem.Click += new EventHandler(this.ToolStripMenuItem_Import_Click);

                    menuItem.DropDownItems.Add(familyItem);
                }
            }
        }

        private void HandleConfigurationSelection (string text)
        {
            if (text == string.Empty) return;

            int foundIndex = this.ToolStripComboBox_Configuration.FindStringExact(text);

            if (foundIndex > -1)
            {
                this.ToolStripComboBox_Configuration.SelectedIndex = foundIndex;
            }
            else
            {
                this.ToolStripComboBox_Configuration.SelectedIndex = this.ToolStripComboBox_Configuration.Items.Add(new EmoteConfiguration(text, new PetFamily()));
                this.AddTreeNode(Resources.Other_NewEmote).BeginEdit();
            }
        }

        private void UnloadConfigurations ()
        {
            this.ToolStripComboBox_Configuration.Items.Clear();
            this.ToolStripComboBox_Configuration.SelectedIndex = -1;
        }

        private bool SetSelectedMenuItem (ToolStripItemCollection items, string itemTagValue)
        {
            bool found = false;

            foreach (ToolStripItem item in items)
            {
                if (item.GetType() == typeof(ToolStripMenuItem))
                {
                    ToolStripMenuItem itemTypeChecked = (ToolStripMenuItem)item;

                    if (item.Tag.ToString() == itemTagValue)
                        itemTypeChecked.Checked = found = true;
                    else
                        itemTypeChecked.Checked = false;

                    if (itemTypeChecked.DropDownItems.Count > 0)
                        if (this.SetSelectedMenuItem(itemTypeChecked.DropDownItems, itemTagValue))
                            itemTypeChecked.CheckState = CheckState.Indeterminate;
                }
            }

            return found;
        }

        private bool UncheckAllMenuItemsExcept (ToolStripItemCollection items, ToolStripMenuItem exceptItem)
        {
            bool found = false;

            foreach (ToolStripItem item in items)
            {
                if (item.GetType() == exceptItem.GetType())
                {
                    ToolStripMenuItem itemTypeChecked = (ToolStripMenuItem)item;

                    if (itemTypeChecked != exceptItem)
                        itemTypeChecked.Checked = false;
                    else
                        found = true;

                    if (itemTypeChecked.DropDownItems.Count > 0)
                        if (this.UncheckAllMenuItemsExcept(itemTypeChecked.DropDownItems, exceptItem))
                            itemTypeChecked.CheckState = CheckState.Indeterminate;
                }
            }

            return found;
        }

        #endregion

        #region Output

        private void ShowEmotePreview (TreeNode node, bool clear)
        {
            if (clear) this.ListView_Output.Items.Clear();
            this.ShowEmotePreview(node, new EmoteCondition[0]);
        }

        private void ShowEmotePreview (TreeNode node, EmoteCondition[] conditions)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties)node.Tag;

            EmoteCondition[] allConditions = new EmoteCondition[conditions.Length + (properties.Condition != EmoteCondition.None ? 1 : 0)];
            conditions.CopyTo(allConditions, 0);
            if (properties.Condition != EmoteCondition.None) allConditions[allConditions.Length - 1] = properties.Condition;

            EmoteNode dummyEmoteNode = new EmoteNode(node.FullPath, properties);

            if (node.Nodes.Count == 0)
            {
                this.AddOutputNode(this.ToolStripComboBox_Configuration.SelectedItem.ToString() +
                    " " + dummyEmoteNode.CompletedText, allConditions);
            }
            else
            {
                if (properties.MustContinue == false)
                {
                    this.AddOutputNode(this.ToolStripComboBox_Configuration.SelectedItem.ToString() +
                    " " + dummyEmoteNode.CompletedText, allConditions);
                }

                foreach (TreeNode childNode in node.Nodes)
                {
                    this.ShowEmotePreview(childNode, allConditions);
                }
            }
        }

        private void AddOutputNode (string text, EmoteCondition condition)
        {
            this.AddOutputNode(text, new EmoteCondition[] { condition });
        }

        private void AddOutputNode (string text, EmoteCondition[] conditions)
        {
            string conditionsText = string.Empty;
            for (int i = 0; i < conditions.Length; i++)
                conditionsText += " " + conditions[i].ToString();

            ListViewItem item = new ListViewItem(new string[] { text, conditionsText.TrimStart(new Char[] { ' ' }).Replace(" ", ", ") });
            this.ListView_Output.Items.Add(item);
        }

        #endregion

        #region Workspace

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

        private void AddTreeNodeRange (ref TreeView treeView, List<EmoteNode> emoteNodeSet)
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

        private List<EmoteNode> ConvertTreeNodesToEmotesNodes (TreeNodeCollection treeNodes)
        {
            List<EmoteNode> emoteNodes = new List<EmoteNode>();

            foreach (TreeNode treeNode in treeNodes)
            {
                EmoteNode emoteNode = new EmoteNode();

                emoteNode.Text = treeNode.Text;
                emoteNode.Properties = (EmoteNodeProperties)treeNode.Tag;

                if (treeNode.Nodes.Count > 0)
                {
                    emoteNode.ChildNodes = this.ConvertTreeNodesToEmotesNodes(treeNode.Nodes);
                }

                emoteNodes.Add(emoteNode);
            }

            return emoteNodes;
        }

        private TreeNode[] ConvertEmotesNodesToTreeNodes (List<EmoteNode> emoteNodes)
        {
            TreeNode[] treeNodes = new TreeNode[emoteNodes.Count];

            for (int i = 0; i < emoteNodes.Count; i++)
            {
                EmoteNode emoteNode = emoteNodes[i];
                TreeNode treeNode = new TreeNode();

                treeNode.Text = emoteNode.Text;
                treeNode.Tag = emoteNode.Properties;

                if (emoteNode.ChildNodes.Count > 0)
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

        #endregion


    }
}