using System;
using System.Drawing;
using System.Globalization;
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
        private TreeView currentTreeView;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.LoadSettings();

            this.ToolStripComboBox_Source.Items.AddRange(new string[] { "Default", "Custom" });
            this.ToolStripComboBox_Source.SelectedIndex = 1;
            this.ToolStripComboBox_Source.Visible = Control.ModifierKeys == Keys.Shift;
            this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];

            this.FillAddConfigurationMenu();
            
            this.ToolStipButton_Load.PerformClick();
        }

        private void TabControl_EmoteConfigurations_SelectedIndexChanged (object sender, EventArgs e)
        {
            this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];
        }

        private void LoadSettings ()
        {
            this.CheckBox_KeywordsAutoFill.Checked = Properties.Settings.Default.KeywordsAutoFill;
            this.NumericUpDown_KeywordsMinLength.Value = (decimal)Properties.Settings.Default.KeywordsMinLength;
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
            if (e.Label != null && (this.CheckBox_KeywordsAutoFill.Checked || this.TextBox_Keywords.Text.Length == 0))
                this.TextBox_Keywords.Text = String.Join(" ", EmoteNodeProperties.StringToKeywords(e.Label, (int)this.NumericUpDown_KeywordsMinLength.Value));
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
            Properties.Settings.Default.KeywordsAutoFill = this.CheckBox_KeywordsAutoFill.Checked;
            Properties.Settings.Default.Save();
        }

        private void TextBox_Keywords_TextChanged (object sender, EventArgs e)
        {
            if (this.currentTreeView.SelectedNode == null) return;
            EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
            config.Keywords = EmoteNodeProperties.StringToKeywords(this.TextBox_Keywords.Text);
        }

        private void NumericUpDown_KeywordsMinLength_ValueChanged (object sender, EventArgs e)
        {
            Properties.Settings.Default.KeywordsMinLength = (int)NumericUpDown_KeywordsMinLength.Value;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region ToolStrip_Main Controls

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

            if (defaultConverter.IsObsolete)
            {
                defaultConverter.ConvertToLatest();
                defaultConverter.Save(this.defaultEmotes.DataFile.FullName);
            }

            XmlVersionConverter customConverter = new XmlVersionConverter(this.customEmotes.DataFile.FullName);

            if (customConverter.IsObsolete)
            {
                customConverter.ConvertToLatest();
                customConverter.Save(this.customEmotes.DataFile.FullName);
            }

            this.defaultEmotes.Load();
            this.customEmotes.Load();

            if (this.ToolStripComboBox_Source.SelectedIndex == 0)
            {
                this.currentEmotes = this.defaultEmotes;
            }
            else
            {
                this.currentEmotes = this.customEmotes;
            }

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
                config.Condition = (EmoteNodeProperties.EmoteCondition)Enum.Parse(config.Condition.GetType(), menuItem.Tag.ToString());
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
        }

        private void FillAddConfigurationMenu ()
        {
            ToolStripMenuItem hunter = new ToolStripMenuItem(Resources.ClassName_Hunter);
            hunter.Name = "ToolStripMenuItem_AddConfiguration_Hunter";
            hunter.Image = Icons.INV_Weapon_Bow_07;

            ToolStripMenuItem warlock = new ToolStripMenuItem(Resources.ClassName_Warlock);
            warlock.Name = "ToolStripMenuItem_AddConfiguration_Warlock";
            warlock.Image = Icons.Spell_Nature_Drowsy;

            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.Insert(0, warlock);
            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.Insert(0, hunter);

            foreach (PetFamily family in PetFamily.List())
            {
                if (family.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName)
                {
                    ToolStripMenuItem familyItem = new ToolStripMenuItem(family.Name);

                    familyItem.Name = "ToolStripMenuItem_AddConfiguration_" + family.Name.GetHashCode().ToString();
                    familyItem.Image = family.Image;
                    familyItem.Tag = family;
                    familyItem.Click += new EventHandler(this.ToolStripMenuItem_AddConfiguration_Click);

                    if (family.ClassType == PetClassTypes.Hunter)
                        hunter.DropDownItems.Add(familyItem);
                    else if (family.ClassType == PetClassTypes.Warlock)
                        warlock.DropDownItems.Add(familyItem);
                    else
                        this.ToolStripDropDownButton_AddConfiguration.DropDownItems.Add(familyItem);
                }
            }
        }

        private void FillImportMenu ()
        {
            ToolStripMenuItem hunter = new ToolStripMenuItem(Resources.ClassName_Hunter);
            hunter.Name = "ToolStripMenuItem_Import_Hunter";
            hunter.Image = Icons.INV_Weapon_Bow_07;

            ToolStripMenuItem warlock = new ToolStripMenuItem(Resources.ClassName_Warlock);
            warlock.Name = "ToolStripMenuItem_Import_Warlock";
            warlock.Image = Icons.Spell_Nature_Drowsy;

            this.ToolStripDropDownButton_Import.DropDownItems.Clear();
            this.ToolStripDropDownButton_Import.DropDownItems.Add(hunter);
            this.ToolStripDropDownButton_Import.DropDownItems.Add(warlock);

            foreach (EmoteConfiguration config in this.defaultEmotes.EmoteConfigurations)
            {
                if (config.IsCurrentLanguage)
                {
                    ToolStripMenuItem familyItem = new ToolStripMenuItem(config.Name);

                    familyItem.Name = "ToolStripMenuItem_Import_" + config.Name.GetHashCode().ToString();
                    familyItem.Image = config.PetFamily.Image;
                    familyItem.Tag = config;
                    familyItem.Click += new EventHandler(this.ToolStripMenuItem_Import_Click);

                    if (config.PetFamily.ClassType == PetClassTypes.Hunter)
                        hunter.DropDownItems.Add(familyItem);
                    else if (config.PetFamily.ClassType == PetClassTypes.Warlock)
                        warlock.DropDownItems.Add(familyItem);
                    else
                        this.ToolStripDropDownButton_Import.DropDownItems.Add(familyItem);
                }
            }

            if (hunter.DropDownItems.Count == 0) hunter.Enabled = false;
            if (warlock.DropDownItems.Count == 0) warlock.Enabled = false;
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
                this.ToolStripComboBox_Configuration.SelectedIndex = this.ToolStripComboBox_Configuration.Items.Add(new EmoteConfiguration(text));
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
            this.ShowEmotePreview(node, new EmoteNodeProperties.EmoteCondition[0]);
        }

        private void ShowEmotePreview (TreeNode node, EmoteNodeProperties.EmoteCondition[] conditions)
        {
            EmoteNodeProperties properties = (EmoteNodeProperties)node.Tag;

            EmoteNodeProperties.EmoteCondition[] allConditions = new EmoteNodeProperties.EmoteCondition[conditions.Length + (properties.Condition != EmoteNodeProperties.EmoteCondition.None ? 1 : 0)];
            conditions.CopyTo(allConditions, 0);
            if (properties.Condition != EmoteNodeProperties.EmoteCondition.None) allConditions[allConditions.Length - 1] = properties.Condition;

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

        private void AddOutputNode (string text, EmoteNodeProperties.EmoteCondition condition)
        {
            this.AddOutputNode(text, new EmoteNodeProperties.EmoteCondition[] { condition });
        }

        private void AddOutputNode (string text, EmoteNodeProperties.EmoteCondition[] conditions)
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

                emoteNodes.Add(emoteNode);
            }

            return emoteNodes;
        }

        private TreeNode[] ConvertEmotesNodesToTreeNodes (EmoteNodeSet emoteNodes)
        {
            TreeNode[] treeNodes = new TreeNode[emoteNodes.Count];

            for (int i = 0; i < emoteNodes.Count; i++)
            {
                EmoteNode emoteNode = (EmoteNode)emoteNodes[i];
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