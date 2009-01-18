namespace PetEmote.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStripContainer_EmoteEditing = new System.Windows.Forms.ToolStripContainer();
            this.TabControl_EmoteConfigurations = new System.Windows.Forms.TabControl();
            this.TabPage_DefaultEmotes = new System.Windows.Forms.TabPage();
            this.TreeView_DefaultEmotes = new System.Windows.Forms.TreeView();
            this.TabPage_CombatEmotes = new System.Windows.Forms.TabPage();
            this.TreeView_CombatEmotes = new System.Windows.Forms.TreeView();
            this.TabPage_FeedingEmotes = new System.Windows.Forms.TabPage();
            this.TreeView_FeedingEmotes = new System.Windows.Forms.TreeView();
            this.Panel_Keywords = new System.Windows.Forms.Panel();
            this.Panel_KeywordsTextBox = new System.Windows.Forms.Panel();
            this.TextBox_Keywords = new System.Windows.Forms.TextBox();
            this.NumericUpDown_KeywordsMinLength = new System.Windows.Forms.NumericUpDown();
            this.Panel_KeywordsLabel = new System.Windows.Forms.Panel();
            this.CheckBox_KeywordsAutoFill = new System.Windows.Forms.CheckBox();
            this.ToolStrip_Tools = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_TestConfiguration = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_CheckForProblems = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip_EmoteEditing = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_AddNode = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_AddChildNode = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_RemoveNode = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Conditions = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Condition_TargetExists = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_TargetIsFriendly = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Condition_PetIsHappy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_PetIsContent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_PetIsUnhappy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Condition_PetIsMale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_PetIsFemale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_PlayerIsMale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Condition_PlayerIsFemale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Condition_None = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Options = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_MustContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Chance = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripComboBox_Chance = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.ToolStripComboBox_Source = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStipButton_Load = new System.Windows.Forms.ToolStripButton();
            this.ToolStipButton_Save = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Configuration = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripComboBox_Configuration = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripDropDownButton_AddConfiguration = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripTextBox_Independent = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripButton_RemoveConfiguration = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDropDownButton_Import = new System.Windows.Forms.ToolStripDropDownButton();
            this.ImageList_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.SplitContainer_TopBottom = new System.Windows.Forms.SplitContainer();
            this.ListView_Output = new System.Windows.Forms.ListView();
            this.ColumnHeader_EmoteText = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader_Condition = new System.Windows.Forms.ColumnHeader();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTip_Help = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStripContainer_EmoteEditing.ContentPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.SuspendLayout();
            this.TabControl_EmoteConfigurations.SuspendLayout();
            this.TabPage_DefaultEmotes.SuspendLayout();
            this.TabPage_CombatEmotes.SuspendLayout();
            this.TabPage_FeedingEmotes.SuspendLayout();
            this.Panel_Keywords.SuspendLayout();
            this.Panel_KeywordsTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_KeywordsMinLength)).BeginInit();
            this.Panel_KeywordsLabel.SuspendLayout();
            this.ToolStrip_Tools.SuspendLayout();
            this.ToolStrip_EmoteEditing.SuspendLayout();
            this.ToolStrip_Main.SuspendLayout();
            this.SplitContainer_TopBottom.Panel1.SuspendLayout();
            this.SplitContainer_TopBottom.Panel2.SuspendLayout();
            this.SplitContainer_TopBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripContainer_EmoteEditing
            // 
            this.ToolStripContainer_EmoteEditing.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.AccessibleName = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing, "ToolStripContainer_EmoteEditing");
            // 
            // ToolStripContainer_EmoteEditing.BottomToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.BottomToolStripPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.BottomToolStripPanel.AccessibleName = null;
            this.ToolStripContainer_EmoteEditing.BottomToolStripPanel.BackgroundImage = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.BottomToolStripPanel, "ToolStripContainer_EmoteEditing.BottomToolStripPanel");
            this.ToolStripContainer_EmoteEditing.BottomToolStripPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.BottomToolStripPanel, resources.GetString("ToolStripContainer_EmoteEditing.BottomToolStripPanel.ToolTip"));
            // 
            // ToolStripContainer_EmoteEditing.ContentPanel
            // 
            this.ToolStripContainer_EmoteEditing.ContentPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.ContentPanel.AccessibleName = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.ContentPanel, "ToolStripContainer_EmoteEditing.ContentPanel");
            this.ToolStripContainer_EmoteEditing.ContentPanel.BackgroundImage = null;
            this.ToolStripContainer_EmoteEditing.ContentPanel.Controls.Add(this.TabControl_EmoteConfigurations);
            this.ToolStripContainer_EmoteEditing.ContentPanel.Controls.Add(this.Panel_Keywords);
            this.ToolStripContainer_EmoteEditing.ContentPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.ContentPanel, resources.GetString("ToolStripContainer_EmoteEditing.ContentPanel.ToolTip"));
            this.ToolStripContainer_EmoteEditing.Font = null;
            // 
            // ToolStripContainer_EmoteEditing.LeftToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanel.AccessibleName = null;
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanel.BackgroundImage = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.LeftToolStripPanel, "ToolStripContainer_EmoteEditing.LeftToolStripPanel");
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.LeftToolStripPanel, resources.GetString("ToolStripContainer_EmoteEditing.LeftToolStripPanel.ToolTip"));
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanelVisible = false;
            this.ToolStripContainer_EmoteEditing.Name = "ToolStripContainer_EmoteEditing";
            // 
            // ToolStripContainer_EmoteEditing.RightToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.RightToolStripPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.RightToolStripPanel.AccessibleName = null;
            this.ToolStripContainer_EmoteEditing.RightToolStripPanel.BackgroundImage = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.RightToolStripPanel, "ToolStripContainer_EmoteEditing.RightToolStripPanel");
            this.ToolStripContainer_EmoteEditing.RightToolStripPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.RightToolStripPanel, resources.GetString("ToolStripContainer_EmoteEditing.RightToolStripPanel.ToolTip"));
            this.ToolStripContainer_EmoteEditing.RightToolStripPanelVisible = false;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing, resources.GetString("ToolStripContainer_EmoteEditing.ToolTip"));
            // 
            // ToolStripContainer_EmoteEditing.TopToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.AccessibleName = null;
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.BackgroundImage = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.TopToolStripPanel, "ToolStripContainer_EmoteEditing.TopToolStripPanel");
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Tools);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_EmoteEditing);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Main);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.TopToolStripPanel, resources.GetString("ToolStripContainer_EmoteEditing.TopToolStripPanel.ToolTip"));
            // 
            // TabControl_EmoteConfigurations
            // 
            this.TabControl_EmoteConfigurations.AccessibleDescription = null;
            this.TabControl_EmoteConfigurations.AccessibleName = null;
            resources.ApplyResources(this.TabControl_EmoteConfigurations, "TabControl_EmoteConfigurations");
            this.TabControl_EmoteConfigurations.BackgroundImage = null;
            this.TabControl_EmoteConfigurations.Controls.Add(this.TabPage_DefaultEmotes);
            this.TabControl_EmoteConfigurations.Controls.Add(this.TabPage_CombatEmotes);
            this.TabControl_EmoteConfigurations.Controls.Add(this.TabPage_FeedingEmotes);
            this.TabControl_EmoteConfigurations.Font = null;
            this.TabControl_EmoteConfigurations.HotTrack = true;
            this.TabControl_EmoteConfigurations.Multiline = true;
            this.TabControl_EmoteConfigurations.Name = "TabControl_EmoteConfigurations";
            this.TabControl_EmoteConfigurations.SelectedIndex = 0;
            this.ToolTip_Help.SetToolTip(this.TabControl_EmoteConfigurations, resources.GetString("TabControl_EmoteConfigurations.ToolTip"));
            this.TabControl_EmoteConfigurations.SelectedIndexChanged += new System.EventHandler(this.TabControl_EmoteConfigurations_SelectedIndexChanged);
            // 
            // TabPage_DefaultEmotes
            // 
            this.TabPage_DefaultEmotes.AccessibleDescription = null;
            this.TabPage_DefaultEmotes.AccessibleName = null;
            resources.ApplyResources(this.TabPage_DefaultEmotes, "TabPage_DefaultEmotes");
            this.TabPage_DefaultEmotes.BackgroundImage = null;
            this.TabPage_DefaultEmotes.Controls.Add(this.TreeView_DefaultEmotes);
            this.TabPage_DefaultEmotes.Font = null;
            this.TabPage_DefaultEmotes.Name = "TabPage_DefaultEmotes";
            this.ToolTip_Help.SetToolTip(this.TabPage_DefaultEmotes, resources.GetString("TabPage_DefaultEmotes.ToolTip"));
            this.TabPage_DefaultEmotes.UseVisualStyleBackColor = true;
            // 
            // TreeView_DefaultEmotes
            // 
            this.TreeView_DefaultEmotes.AccessibleDescription = null;
            this.TreeView_DefaultEmotes.AccessibleName = null;
            this.TreeView_DefaultEmotes.AllowDrop = true;
            resources.ApplyResources(this.TreeView_DefaultEmotes, "TreeView_DefaultEmotes");
            this.TreeView_DefaultEmotes.BackgroundImage = null;
            this.TreeView_DefaultEmotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeView_DefaultEmotes.Font = null;
            this.TreeView_DefaultEmotes.HideSelection = false;
            this.TreeView_DefaultEmotes.HotTracking = true;
            this.TreeView_DefaultEmotes.LabelEdit = true;
            this.TreeView_DefaultEmotes.Name = "TreeView_DefaultEmotes";
            this.TreeView_DefaultEmotes.PathSeparator = " ";
            this.TreeView_DefaultEmotes.ShowNodeToolTips = true;
            this.ToolTip_Help.SetToolTip(this.TreeView_DefaultEmotes, resources.GetString("TreeView_DefaultEmotes.ToolTip"));
            this.TreeView_DefaultEmotes.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.TreeView_DefaultEmotes.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView_DefaultEmotes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView_DefaultEmotes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView_DefaultEmotes.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            // 
            // TabPage_CombatEmotes
            // 
            this.TabPage_CombatEmotes.AccessibleDescription = null;
            this.TabPage_CombatEmotes.AccessibleName = null;
            resources.ApplyResources(this.TabPage_CombatEmotes, "TabPage_CombatEmotes");
            this.TabPage_CombatEmotes.BackgroundImage = null;
            this.TabPage_CombatEmotes.Controls.Add(this.TreeView_CombatEmotes);
            this.TabPage_CombatEmotes.Font = null;
            this.TabPage_CombatEmotes.Name = "TabPage_CombatEmotes";
            this.ToolTip_Help.SetToolTip(this.TabPage_CombatEmotes, resources.GetString("TabPage_CombatEmotes.ToolTip"));
            this.TabPage_CombatEmotes.UseVisualStyleBackColor = true;
            // 
            // TreeView_CombatEmotes
            // 
            this.TreeView_CombatEmotes.AccessibleDescription = null;
            this.TreeView_CombatEmotes.AccessibleName = null;
            this.TreeView_CombatEmotes.AllowDrop = true;
            resources.ApplyResources(this.TreeView_CombatEmotes, "TreeView_CombatEmotes");
            this.TreeView_CombatEmotes.BackgroundImage = null;
            this.TreeView_CombatEmotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeView_CombatEmotes.Font = null;
            this.TreeView_CombatEmotes.HideSelection = false;
            this.TreeView_CombatEmotes.HotTracking = true;
            this.TreeView_CombatEmotes.LabelEdit = true;
            this.TreeView_CombatEmotes.Name = "TreeView_CombatEmotes";
            this.TreeView_CombatEmotes.PathSeparator = " ";
            this.TreeView_CombatEmotes.ShowNodeToolTips = true;
            this.ToolTip_Help.SetToolTip(this.TreeView_CombatEmotes, resources.GetString("TreeView_CombatEmotes.ToolTip"));
            this.TreeView_CombatEmotes.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.TreeView_CombatEmotes.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView_CombatEmotes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView_CombatEmotes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView_CombatEmotes.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            // 
            // TabPage_FeedingEmotes
            // 
            this.TabPage_FeedingEmotes.AccessibleDescription = null;
            this.TabPage_FeedingEmotes.AccessibleName = null;
            resources.ApplyResources(this.TabPage_FeedingEmotes, "TabPage_FeedingEmotes");
            this.TabPage_FeedingEmotes.BackgroundImage = null;
            this.TabPage_FeedingEmotes.Controls.Add(this.TreeView_FeedingEmotes);
            this.TabPage_FeedingEmotes.Font = null;
            this.TabPage_FeedingEmotes.Name = "TabPage_FeedingEmotes";
            this.ToolTip_Help.SetToolTip(this.TabPage_FeedingEmotes, resources.GetString("TabPage_FeedingEmotes.ToolTip"));
            this.TabPage_FeedingEmotes.UseVisualStyleBackColor = true;
            // 
            // TreeView_FeedingEmotes
            // 
            this.TreeView_FeedingEmotes.AccessibleDescription = null;
            this.TreeView_FeedingEmotes.AccessibleName = null;
            this.TreeView_FeedingEmotes.AllowDrop = true;
            resources.ApplyResources(this.TreeView_FeedingEmotes, "TreeView_FeedingEmotes");
            this.TreeView_FeedingEmotes.BackgroundImage = null;
            this.TreeView_FeedingEmotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeView_FeedingEmotes.Font = null;
            this.TreeView_FeedingEmotes.HideSelection = false;
            this.TreeView_FeedingEmotes.HotTracking = true;
            this.TreeView_FeedingEmotes.LabelEdit = true;
            this.TreeView_FeedingEmotes.Name = "TreeView_FeedingEmotes";
            this.TreeView_FeedingEmotes.PathSeparator = " ";
            this.TreeView_FeedingEmotes.ShowNodeToolTips = true;
            this.ToolTip_Help.SetToolTip(this.TreeView_FeedingEmotes, resources.GetString("TreeView_FeedingEmotes.ToolTip"));
            this.TreeView_FeedingEmotes.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.TreeView_FeedingEmotes.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView_FeedingEmotes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView_FeedingEmotes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView_FeedingEmotes.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            // 
            // Panel_Keywords
            // 
            this.Panel_Keywords.AccessibleDescription = null;
            this.Panel_Keywords.AccessibleName = null;
            resources.ApplyResources(this.Panel_Keywords, "Panel_Keywords");
            this.Panel_Keywords.BackgroundImage = null;
            this.Panel_Keywords.Controls.Add(this.Panel_KeywordsTextBox);
            this.Panel_Keywords.Controls.Add(this.Panel_KeywordsLabel);
            this.Panel_Keywords.Font = null;
            this.Panel_Keywords.Name = "Panel_Keywords";
            this.ToolTip_Help.SetToolTip(this.Panel_Keywords, resources.GetString("Panel_Keywords.ToolTip"));
            // 
            // Panel_KeywordsTextBox
            // 
            this.Panel_KeywordsTextBox.AccessibleDescription = null;
            this.Panel_KeywordsTextBox.AccessibleName = null;
            resources.ApplyResources(this.Panel_KeywordsTextBox, "Panel_KeywordsTextBox");
            this.Panel_KeywordsTextBox.BackgroundImage = null;
            this.Panel_KeywordsTextBox.Controls.Add(this.TextBox_Keywords);
            this.Panel_KeywordsTextBox.Controls.Add(this.NumericUpDown_KeywordsMinLength);
            this.Panel_KeywordsTextBox.Font = null;
            this.Panel_KeywordsTextBox.Name = "Panel_KeywordsTextBox";
            this.ToolTip_Help.SetToolTip(this.Panel_KeywordsTextBox, resources.GetString("Panel_KeywordsTextBox.ToolTip"));
            // 
            // TextBox_Keywords
            // 
            this.TextBox_Keywords.AccessibleDescription = null;
            this.TextBox_Keywords.AccessibleName = null;
            resources.ApplyResources(this.TextBox_Keywords, "TextBox_Keywords");
            this.TextBox_Keywords.BackgroundImage = null;
            this.TextBox_Keywords.Font = null;
            this.TextBox_Keywords.Name = "TextBox_Keywords";
            this.ToolTip_Help.SetToolTip(this.TextBox_Keywords, resources.GetString("TextBox_Keywords.ToolTip"));
            this.TextBox_Keywords.TextChanged += new System.EventHandler(this.TextBox_Keywords_TextChanged);
            // 
            // NumericUpDown_KeywordsMinLength
            // 
            this.NumericUpDown_KeywordsMinLength.AccessibleDescription = null;
            this.NumericUpDown_KeywordsMinLength.AccessibleName = null;
            resources.ApplyResources(this.NumericUpDown_KeywordsMinLength, "NumericUpDown_KeywordsMinLength");
            this.NumericUpDown_KeywordsMinLength.Font = null;
            this.NumericUpDown_KeywordsMinLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_KeywordsMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_KeywordsMinLength.Name = "NumericUpDown_KeywordsMinLength";
            this.ToolTip_Help.SetToolTip(this.NumericUpDown_KeywordsMinLength, resources.GetString("NumericUpDown_KeywordsMinLength.ToolTip"));
            this.NumericUpDown_KeywordsMinLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDown_KeywordsMinLength.ValueChanged += new System.EventHandler(this.NumericUpDown_KeywordsMinLength_ValueChanged);
            // 
            // Panel_KeywordsLabel
            // 
            this.Panel_KeywordsLabel.AccessibleDescription = null;
            this.Panel_KeywordsLabel.AccessibleName = null;
            resources.ApplyResources(this.Panel_KeywordsLabel, "Panel_KeywordsLabel");
            this.Panel_KeywordsLabel.BackgroundImage = null;
            this.Panel_KeywordsLabel.Controls.Add(this.CheckBox_KeywordsAutoFill);
            this.Panel_KeywordsLabel.Font = null;
            this.Panel_KeywordsLabel.Name = "Panel_KeywordsLabel";
            this.ToolTip_Help.SetToolTip(this.Panel_KeywordsLabel, resources.GetString("Panel_KeywordsLabel.ToolTip"));
            // 
            // CheckBox_KeywordsAutoFill
            // 
            this.CheckBox_KeywordsAutoFill.AccessibleDescription = null;
            this.CheckBox_KeywordsAutoFill.AccessibleName = null;
            resources.ApplyResources(this.CheckBox_KeywordsAutoFill, "CheckBox_KeywordsAutoFill");
            this.CheckBox_KeywordsAutoFill.BackgroundImage = null;
            this.CheckBox_KeywordsAutoFill.Checked = true;
            this.CheckBox_KeywordsAutoFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_KeywordsAutoFill.Font = null;
            this.CheckBox_KeywordsAutoFill.Name = "CheckBox_KeywordsAutoFill";
            this.ToolTip_Help.SetToolTip(this.CheckBox_KeywordsAutoFill, resources.GetString("CheckBox_KeywordsAutoFill.ToolTip"));
            this.CheckBox_KeywordsAutoFill.UseVisualStyleBackColor = true;
            this.CheckBox_KeywordsAutoFill.CheckedChanged += new System.EventHandler(this.CheckBox_KeywordsAutoFill_CheckedChanged);
            // 
            // ToolStrip_Tools
            // 
            this.ToolStrip_Tools.AccessibleDescription = null;
            this.ToolStrip_Tools.AccessibleName = null;
            resources.ApplyResources(this.ToolStrip_Tools, "ToolStrip_Tools");
            this.ToolStrip_Tools.BackgroundImage = null;
            this.ToolStrip_Tools.Font = null;
            this.ToolStrip_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_TestConfiguration,
            this.ToolStripButton_CheckForProblems});
            this.ToolStrip_Tools.Name = "ToolStrip_Tools";
            this.ToolTip_Help.SetToolTip(this.ToolStrip_Tools, resources.GetString("ToolStrip_Tools.ToolTip"));
            // 
            // ToolStripButton_TestConfiguration
            // 
            this.ToolStripButton_TestConfiguration.AccessibleDescription = null;
            this.ToolStripButton_TestConfiguration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_TestConfiguration, "ToolStripButton_TestConfiguration");
            this.ToolStripButton_TestConfiguration.BackgroundImage = null;
            this.ToolStripButton_TestConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_TestConfiguration.Image = global::PetEmote.Icons.INV_Misc_Spyglass_03;
            this.ToolStripButton_TestConfiguration.Name = "ToolStripButton_TestConfiguration";
            // 
            // ToolStripButton_CheckForProblems
            // 
            this.ToolStripButton_CheckForProblems.AccessibleDescription = null;
            this.ToolStripButton_CheckForProblems.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_CheckForProblems, "ToolStripButton_CheckForProblems");
            this.ToolStripButton_CheckForProblems.BackgroundImage = null;
            this.ToolStripButton_CheckForProblems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_CheckForProblems.Image = global::PetEmote.Icons.INV_Musket_02;
            this.ToolStripButton_CheckForProblems.Name = "ToolStripButton_CheckForProblems";
            // 
            // ToolStrip_EmoteEditing
            // 
            this.ToolStrip_EmoteEditing.AccessibleDescription = null;
            this.ToolStrip_EmoteEditing.AccessibleName = null;
            resources.ApplyResources(this.ToolStrip_EmoteEditing, "ToolStrip_EmoteEditing");
            this.ToolStrip_EmoteEditing.BackgroundImage = null;
            this.ToolStrip_EmoteEditing.Font = null;
            this.ToolStrip_EmoteEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AddNode,
            this.ToolStripButton_AddChildNode,
            this.ToolStripButton_RemoveNode,
            this.ToolStripSeparator3,
            this.ToolStripMenuItem_Conditions,
            this.ToolStripMenuItem_Options,
            this.ToolStripSeparator7,
            this.ToolStripLabel_Chance,
            this.ToolStripComboBox_Chance});
            this.ToolStrip_EmoteEditing.Name = "ToolStrip_EmoteEditing";
            this.ToolTip_Help.SetToolTip(this.ToolStrip_EmoteEditing, resources.GetString("ToolStrip_EmoteEditing.ToolTip"));
            // 
            // ToolStripButton_AddNode
            // 
            this.ToolStripButton_AddNode.AccessibleDescription = null;
            this.ToolStripButton_AddNode.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_AddNode, "ToolStripButton_AddNode");
            this.ToolStripButton_AddNode.BackgroundImage = null;
            this.ToolStripButton_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddNode.Image = global::PetEmote.Icons.AddNode;
            this.ToolStripButton_AddNode.Name = "ToolStripButton_AddNode";
            this.ToolStripButton_AddNode.Click += new System.EventHandler(this.ToolStripButton_AddNode_Click);
            // 
            // ToolStripButton_AddChildNode
            // 
            this.ToolStripButton_AddChildNode.AccessibleDescription = null;
            this.ToolStripButton_AddChildNode.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_AddChildNode, "ToolStripButton_AddChildNode");
            this.ToolStripButton_AddChildNode.BackgroundImage = null;
            this.ToolStripButton_AddChildNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddChildNode.Name = "ToolStripButton_AddChildNode";
            this.ToolStripButton_AddChildNode.Click += new System.EventHandler(this.ToolStripButton_AddChildNode_Click);
            // 
            // ToolStripButton_RemoveNode
            // 
            this.ToolStripButton_RemoveNode.AccessibleDescription = null;
            this.ToolStripButton_RemoveNode.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_RemoveNode, "ToolStripButton_RemoveNode");
            this.ToolStripButton_RemoveNode.BackgroundImage = null;
            this.ToolStripButton_RemoveNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveNode.Image = global::PetEmote.Icons.RemoveNode;
            this.ToolStripButton_RemoveNode.Name = "ToolStripButton_RemoveNode";
            this.ToolStripButton_RemoveNode.Click += new System.EventHandler(this.ToolStripButton_RemoveNode_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.AccessibleDescription = null;
            this.ToolStripSeparator3.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator3, "ToolStripSeparator3");
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            // 
            // ToolStripMenuItem_Conditions
            // 
            this.ToolStripMenuItem_Conditions.AccessibleDescription = null;
            this.ToolStripMenuItem_Conditions.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Conditions, "ToolStripMenuItem_Conditions");
            this.ToolStripMenuItem_Conditions.BackgroundImage = null;
            this.ToolStripMenuItem_Conditions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Condition_TargetExists,
            this.ToolStripMenuItem_Condition_TargetIsFriendly,
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly,
            this.ToolStripSeparator4,
            this.ToolStripMenuItem_Condition_PetIsHappy,
            this.ToolStripMenuItem_Condition_PetIsContent,
            this.ToolStripMenuItem_Condition_PetIsUnhappy,
            this.ToolStripSeparator5,
            this.ToolStripMenuItem_Condition_PetIsMale,
            this.ToolStripMenuItem_Condition_PetIsFemale,
            this.ToolStripMenuItem_Condition_PlayerIsMale,
            this.ToolStripMenuItem_Condition_PlayerIsFemale,
            this.ToolStripSeparator8,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.ToolStripSeparator9,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.ToolStripSeparator6,
            this.ToolStripMenuItem_Condition_None});
            this.ToolStripMenuItem_Conditions.Image = global::PetEmote.Icons.Condition;
            this.ToolStripMenuItem_Conditions.Name = "ToolStripMenuItem_Conditions";
            // 
            // ToolStripMenuItem_Condition_TargetExists
            // 
            this.ToolStripMenuItem_Condition_TargetExists.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_TargetExists.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetExists, "ToolStripMenuItem_Condition_TargetExists");
            this.ToolStripMenuItem_Condition_TargetExists.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_TargetExists.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetExists.Name = "ToolStripMenuItem_Condition_TargetExists";
            this.ToolStripMenuItem_Condition_TargetExists.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_TargetExists.Tag = "TargetExists";
            this.ToolStripMenuItem_Condition_TargetExists.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsFriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsFriendly.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetIsFriendly, "ToolStripMenuItem_Condition_TargetIsFriendly");
            this.ToolStripMenuItem_Condition_TargetIsFriendly.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Name = "ToolStripMenuItem_Condition_TargetIsFriendly";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Tag = "TargetIsFriendly";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsUnfriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetIsUnfriendly, "ToolStripMenuItem_Condition_TargetIsUnfriendly");
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Name = "ToolStripMenuItem_Condition_TargetIsUnfriendly";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Tag = "TargetIsUnfriendly";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.AccessibleDescription = null;
            this.ToolStripSeparator4.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator4, "ToolStripSeparator4");
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            // 
            // ToolStripMenuItem_Condition_PetIsHappy
            // 
            this.ToolStripMenuItem_Condition_PetIsHappy.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PetIsHappy.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsHappy, "ToolStripMenuItem_Condition_PetIsHappy");
            this.ToolStripMenuItem_Condition_PetIsHappy.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsHappy.Name = "ToolStripMenuItem_Condition_PetIsHappy";
            this.ToolStripMenuItem_Condition_PetIsHappy.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PetIsHappy.Tag = "PetIsHappy";
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsContent
            // 
            this.ToolStripMenuItem_Condition_PetIsContent.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PetIsContent.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsContent, "ToolStripMenuItem_Condition_PetIsContent");
            this.ToolStripMenuItem_Condition_PetIsContent.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PetIsContent.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsContent.Name = "ToolStripMenuItem_Condition_PetIsContent";
            this.ToolStripMenuItem_Condition_PetIsContent.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PetIsContent.Tag = "PetIsContent";
            this.ToolStripMenuItem_Condition_PetIsContent.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsUnhappy
            // 
            this.ToolStripMenuItem_Condition_PetIsUnhappy.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsUnhappy, "ToolStripMenuItem_Condition_PetIsUnhappy");
            this.ToolStripMenuItem_Condition_PetIsUnhappy.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Name = "ToolStripMenuItem_Condition_PetIsUnhappy";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Tag = "PetIsUnhappy";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.AccessibleDescription = null;
            this.ToolStripSeparator5.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator5, "ToolStripSeparator5");
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            // 
            // ToolStripMenuItem_Condition_PetIsMale
            // 
            this.ToolStripMenuItem_Condition_PetIsMale.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PetIsMale.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsMale, "ToolStripMenuItem_Condition_PetIsMale");
            this.ToolStripMenuItem_Condition_PetIsMale.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PetIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsMale.Name = "ToolStripMenuItem_Condition_PetIsMale";
            this.ToolStripMenuItem_Condition_PetIsMale.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PetIsMale.Tag = "PetIsMale";
            this.ToolStripMenuItem_Condition_PetIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsFemale
            // 
            this.ToolStripMenuItem_Condition_PetIsFemale.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PetIsFemale.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsFemale, "ToolStripMenuItem_Condition_PetIsFemale");
            this.ToolStripMenuItem_Condition_PetIsFemale.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsFemale.Name = "ToolStripMenuItem_Condition_PetIsFemale";
            this.ToolStripMenuItem_Condition_PetIsFemale.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PetIsFemale.Tag = "PetIsFemale";
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsMale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsMale.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PlayerIsMale.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PlayerIsMale, "ToolStripMenuItem_Condition_PlayerIsMale");
            this.ToolStripMenuItem_Condition_PlayerIsMale.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsMale.Name = "ToolStripMenuItem_Condition_PlayerIsMale";
            this.ToolStripMenuItem_Condition_PlayerIsMale.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PlayerIsMale.Tag = "PlayerIsMale";
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsFemale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsFemale.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PlayerIsFemale, "ToolStripMenuItem_Condition_PlayerIsFemale");
            this.ToolStripMenuItem_Condition_PlayerIsFemale.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Name = "ToolStripMenuItem_Condition_PlayerIsFemale";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Tag = "PlayerIsFemale";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.AccessibleDescription = null;
            this.ToolStripSeparator8.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator8, "ToolStripSeparator8");
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleDescription = null;
            this.toolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.BackgroundImage = null;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = null;
            this.toolStripMenuItem1.Tag = "FoodAccepted";
            this.toolStripMenuItem1.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleDescription = null;
            this.toolStripMenuItem2.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.BackgroundImage = null;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeyDisplayString = null;
            this.toolStripMenuItem2.Tag = "FoodRefused";
            this.toolStripMenuItem2.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.AccessibleDescription = null;
            this.ToolStripSeparator9.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator9, "ToolStripSeparator9");
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleDescription = null;
            this.toolStripMenuItem3.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.BackgroundImage = null;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeyDisplayString = null;
            this.toolStripMenuItem3.Tag = "IsFirstCall";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AccessibleDescription = null;
            this.toolStripMenuItem4.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.BackgroundImage = null;
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeyDisplayString = null;
            this.toolStripMenuItem4.Tag = "IsSecondCall";
            this.toolStripMenuItem4.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AccessibleDescription = null;
            this.toolStripMenuItem5.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.BackgroundImage = null;
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeyDisplayString = null;
            this.toolStripMenuItem5.Tag = "IsThirdCall";
            this.toolStripMenuItem5.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.AccessibleDescription = null;
            this.ToolStripSeparator6.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator6, "ToolStripSeparator6");
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            // 
            // ToolStripMenuItem_Condition_None
            // 
            this.ToolStripMenuItem_Condition_None.AccessibleDescription = null;
            this.ToolStripMenuItem_Condition_None.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Condition_None, "ToolStripMenuItem_Condition_None");
            this.ToolStripMenuItem_Condition_None.BackgroundImage = null;
            this.ToolStripMenuItem_Condition_None.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_None.Name = "ToolStripMenuItem_Condition_None";
            this.ToolStripMenuItem_Condition_None.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_Condition_None.Tag = "None";
            this.ToolStripMenuItem_Condition_None.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Options
            // 
            this.ToolStripMenuItem_Options.AccessibleDescription = null;
            this.ToolStripMenuItem_Options.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_Options, "ToolStripMenuItem_Options");
            this.ToolStripMenuItem_Options.BackgroundImage = null;
            this.ToolStripMenuItem_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_MustContinue});
            this.ToolStripMenuItem_Options.Image = global::PetEmote.Icons.Options;
            this.ToolStripMenuItem_Options.Name = "ToolStripMenuItem_Options";
            // 
            // ToolStripMenuItem_MustContinue
            // 
            this.ToolStripMenuItem_MustContinue.AccessibleDescription = null;
            this.ToolStripMenuItem_MustContinue.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_MustContinue, "ToolStripMenuItem_MustContinue");
            this.ToolStripMenuItem_MustContinue.BackgroundImage = null;
            this.ToolStripMenuItem_MustContinue.CheckOnClick = true;
            this.ToolStripMenuItem_MustContinue.Name = "ToolStripMenuItem_MustContinue";
            this.ToolStripMenuItem_MustContinue.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_MustContinue.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_MustContinue_CheckedChanged);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.AccessibleDescription = null;
            this.ToolStripSeparator7.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator7, "ToolStripSeparator7");
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            // 
            // ToolStripLabel_Chance
            // 
            this.ToolStripLabel_Chance.AccessibleDescription = null;
            this.ToolStripLabel_Chance.AccessibleName = null;
            resources.ApplyResources(this.ToolStripLabel_Chance, "ToolStripLabel_Chance");
            this.ToolStripLabel_Chance.BackgroundImage = null;
            this.ToolStripLabel_Chance.Name = "ToolStripLabel_Chance";
            // 
            // ToolStripComboBox_Chance
            // 
            this.ToolStripComboBox_Chance.AccessibleDescription = null;
            this.ToolStripComboBox_Chance.AccessibleName = null;
            this.ToolStripComboBox_Chance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ToolStripComboBox_Chance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            resources.ApplyResources(this.ToolStripComboBox_Chance, "ToolStripComboBox_Chance");
            this.ToolStripComboBox_Chance.Items.AddRange(new object[] {
            resources.GetString("ToolStripComboBox_Chance.Items"),
            resources.GetString("ToolStripComboBox_Chance.Items1"),
            resources.GetString("ToolStripComboBox_Chance.Items2"),
            resources.GetString("ToolStripComboBox_Chance.Items3"),
            resources.GetString("ToolStripComboBox_Chance.Items4"),
            resources.GetString("ToolStripComboBox_Chance.Items5"),
            resources.GetString("ToolStripComboBox_Chance.Items6"),
            resources.GetString("ToolStripComboBox_Chance.Items7")});
            this.ToolStripComboBox_Chance.Name = "ToolStripComboBox_Chance";
            this.ToolStripComboBox_Chance.TextChanged += new System.EventHandler(this.ToolStripComboBox_Chance_TextChanged);
            // 
            // ToolStrip_Main
            // 
            this.ToolStrip_Main.AccessibleDescription = null;
            this.ToolStrip_Main.AccessibleName = null;
            resources.ApplyResources(this.ToolStrip_Main, "ToolStrip_Main");
            this.ToolStrip_Main.BackgroundImage = null;
            this.ToolStrip_Main.Font = null;
            this.ToolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripComboBox_Source,
            this.ToolStipButton_Load,
            this.ToolStipButton_Save,
            this.ToolStripSeparator1,
            this.ToolStripLabel_Configuration,
            this.ToolStripComboBox_Configuration,
            this.ToolStripDropDownButton_AddConfiguration,
            this.ToolStripButton_RemoveConfiguration,
            this.ToolStripSeparator2,
            this.ToolStripDropDownButton_Import});
            this.ToolStrip_Main.Name = "ToolStrip_Main";
            this.ToolTip_Help.SetToolTip(this.ToolStrip_Main, resources.GetString("ToolStrip_Main.ToolTip"));
            // 
            // ToolStripComboBox_Source
            // 
            this.ToolStripComboBox_Source.AccessibleDescription = null;
            this.ToolStripComboBox_Source.AccessibleName = null;
            resources.ApplyResources(this.ToolStripComboBox_Source, "ToolStripComboBox_Source");
            this.ToolStripComboBox_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Source.Name = "ToolStripComboBox_Source";
            // 
            // ToolStipButton_Load
            // 
            this.ToolStipButton_Load.AccessibleDescription = null;
            this.ToolStipButton_Load.AccessibleName = null;
            resources.ApplyResources(this.ToolStipButton_Load, "ToolStipButton_Load");
            this.ToolStipButton_Load.BackgroundImage = null;
            this.ToolStipButton_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Load.Image = global::PetEmote.Icons.Load;
            this.ToolStipButton_Load.Name = "ToolStipButton_Load";
            this.ToolStipButton_Load.Click += new System.EventHandler(this.ToolStripButton_Load_Click);
            // 
            // ToolStipButton_Save
            // 
            this.ToolStipButton_Save.AccessibleDescription = null;
            this.ToolStipButton_Save.AccessibleName = null;
            resources.ApplyResources(this.ToolStipButton_Save, "ToolStipButton_Save");
            this.ToolStipButton_Save.BackgroundImage = null;
            this.ToolStipButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Save.Image = global::PetEmote.Icons.Save;
            this.ToolStipButton_Save.Name = "ToolStipButton_Save";
            this.ToolStipButton_Save.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.AccessibleDescription = null;
            this.ToolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // ToolStripLabel_Configuration
            // 
            this.ToolStripLabel_Configuration.AccessibleDescription = null;
            this.ToolStripLabel_Configuration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripLabel_Configuration, "ToolStripLabel_Configuration");
            this.ToolStripLabel_Configuration.BackgroundImage = null;
            this.ToolStripLabel_Configuration.Name = "ToolStripLabel_Configuration";
            // 
            // ToolStripComboBox_Configuration
            // 
            this.ToolStripComboBox_Configuration.AccessibleDescription = null;
            this.ToolStripComboBox_Configuration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripComboBox_Configuration, "ToolStripComboBox_Configuration");
            this.ToolStripComboBox_Configuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Configuration.Name = "ToolStripComboBox_Configuration";
            this.ToolStripComboBox_Configuration.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox_Configuration_SelectedIndexChanged);
            // 
            // ToolStripDropDownButton_AddConfiguration
            // 
            this.ToolStripDropDownButton_AddConfiguration.AccessibleDescription = null;
            this.ToolStripDropDownButton_AddConfiguration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripDropDownButton_AddConfiguration, "ToolStripDropDownButton_AddConfiguration");
            this.ToolStripDropDownButton_AddConfiguration.BackgroundImage = null;
            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox_Independent});
            this.ToolStripDropDownButton_AddConfiguration.Image = global::PetEmote.Icons.AddConfiguration;
            this.ToolStripDropDownButton_AddConfiguration.Name = "ToolStripDropDownButton_AddConfiguration";
            // 
            // ToolStripTextBox_Independent
            // 
            this.ToolStripTextBox_Independent.AccessibleDescription = null;
            this.ToolStripTextBox_Independent.AccessibleName = null;
            resources.ApplyResources(this.ToolStripTextBox_Independent, "ToolStripTextBox_Independent");
            this.ToolStripTextBox_Independent.Name = "ToolStripTextBox_Independent";
            this.ToolStripTextBox_Independent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox_Independent_KeyDown);
            // 
            // ToolStripButton_RemoveConfiguration
            // 
            this.ToolStripButton_RemoveConfiguration.AccessibleDescription = null;
            this.ToolStripButton_RemoveConfiguration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_RemoveConfiguration, "ToolStripButton_RemoveConfiguration");
            this.ToolStripButton_RemoveConfiguration.BackgroundImage = null;
            this.ToolStripButton_RemoveConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveConfiguration.Image = global::PetEmote.Icons.RemoveConfiguration;
            this.ToolStripButton_RemoveConfiguration.Name = "ToolStripButton_RemoveConfiguration";
            this.ToolStripButton_RemoveConfiguration.Click += new System.EventHandler(this.ToolStripButton_RemoveConfiguration_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.AccessibleDescription = null;
            this.ToolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator2, "ToolStripSeparator2");
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            // 
            // ToolStripDropDownButton_Import
            // 
            this.ToolStripDropDownButton_Import.AccessibleDescription = null;
            this.ToolStripDropDownButton_Import.AccessibleName = null;
            resources.ApplyResources(this.ToolStripDropDownButton_Import, "ToolStripDropDownButton_Import");
            this.ToolStripDropDownButton_Import.BackgroundImage = null;
            this.ToolStripDropDownButton_Import.Image = global::PetEmote.Icons.ImportConfiguration;
            this.ToolStripDropDownButton_Import.Name = "ToolStripDropDownButton_Import";
            // 
            // ImageList_TreeView
            // 
            this.ImageList_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_TreeView.ImageStream")));
            this.ImageList_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_TreeView.Images.SetKeyName(0, "AddNode.ico");
            this.ImageList_TreeView.Images.SetKeyName(1, "AddChildNode.ico");
            this.ImageList_TreeView.Images.SetKeyName(2, "RemoveNode.ico");
            // 
            // SplitContainer_TopBottom
            // 
            this.SplitContainer_TopBottom.AccessibleDescription = null;
            this.SplitContainer_TopBottom.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_TopBottom, "SplitContainer_TopBottom");
            this.SplitContainer_TopBottom.BackgroundImage = null;
            this.SplitContainer_TopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer_TopBottom.Font = null;
            this.SplitContainer_TopBottom.Name = "SplitContainer_TopBottom";
            // 
            // SplitContainer_TopBottom.Panel1
            // 
            this.SplitContainer_TopBottom.Panel1.AccessibleDescription = null;
            this.SplitContainer_TopBottom.Panel1.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_TopBottom.Panel1, "SplitContainer_TopBottom.Panel1");
            this.SplitContainer_TopBottom.Panel1.BackgroundImage = null;
            this.SplitContainer_TopBottom.Panel1.Controls.Add(this.ToolStripContainer_EmoteEditing);
            this.SplitContainer_TopBottom.Panel1.Font = null;
            this.ToolTip_Help.SetToolTip(this.SplitContainer_TopBottom.Panel1, resources.GetString("SplitContainer_TopBottom.Panel1.ToolTip"));
            // 
            // SplitContainer_TopBottom.Panel2
            // 
            this.SplitContainer_TopBottom.Panel2.AccessibleDescription = null;
            this.SplitContainer_TopBottom.Panel2.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_TopBottom.Panel2, "SplitContainer_TopBottom.Panel2");
            this.SplitContainer_TopBottom.Panel2.BackgroundImage = null;
            this.SplitContainer_TopBottom.Panel2.Controls.Add(this.ListView_Output);
            this.SplitContainer_TopBottom.Panel2.Font = null;
            this.ToolTip_Help.SetToolTip(this.SplitContainer_TopBottom.Panel2, resources.GetString("SplitContainer_TopBottom.Panel2.ToolTip"));
            this.ToolTip_Help.SetToolTip(this.SplitContainer_TopBottom, resources.GetString("SplitContainer_TopBottom.ToolTip"));
            // 
            // ListView_Output
            // 
            this.ListView_Output.AccessibleDescription = null;
            this.ListView_Output.AccessibleName = null;
            this.ListView_Output.Activation = System.Windows.Forms.ItemActivation.OneClick;
            resources.ApplyResources(this.ListView_Output, "ListView_Output");
            this.ListView_Output.BackgroundImage = null;
            this.ListView_Output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_EmoteText,
            this.ColumnHeader_Condition});
            this.ListView_Output.Font = null;
            this.ListView_Output.FullRowSelect = true;
            this.ListView_Output.GridLines = true;
            this.ListView_Output.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_Output.Name = "ListView_Output";
            this.ListView_Output.ShowItemToolTips = true;
            this.ToolTip_Help.SetToolTip(this.ListView_Output, resources.GetString("ListView_Output.ToolTip"));
            this.ListView_Output.UseCompatibleStateImageBehavior = false;
            this.ListView_Output.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_EmoteText
            // 
            resources.ApplyResources(this.ColumnHeader_EmoteText, "ColumnHeader_EmoteText");
            // 
            // ColumnHeader_Condition
            // 
            resources.ApplyResources(this.ColumnHeader_Condition, "ColumnHeader_Condition");
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // ToolTip_Help
            // 
            this.ToolTip_Help.AutomaticDelay = 100;
            this.ToolTip_Help.AutoPopDelay = 10000;
            this.ToolTip_Help.InitialDelay = 100;
            this.ToolTip_Help.ReshowDelay = 20;
            this.ToolTip_Help.ShowAlways = true;
            this.ToolTip_Help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_Help.ToolTipTitle = "PetEmote Hilfe";
            this.ToolTip_Help.UseFading = false;
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.SplitContainer_TopBottom);
            this.Font = null;
            this.Name = "MainForm";
            this.ToolTip_Help.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ToolStripContainer_EmoteEditing.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer_EmoteEditing.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.PerformLayout();
            this.TabControl_EmoteConfigurations.ResumeLayout(false);
            this.TabPage_DefaultEmotes.ResumeLayout(false);
            this.TabPage_CombatEmotes.ResumeLayout(false);
            this.TabPage_FeedingEmotes.ResumeLayout(false);
            this.Panel_Keywords.ResumeLayout(false);
            this.Panel_KeywordsTextBox.ResumeLayout(false);
            this.Panel_KeywordsTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_KeywordsMinLength)).EndInit();
            this.Panel_KeywordsLabel.ResumeLayout(false);
            this.Panel_KeywordsLabel.PerformLayout();
            this.ToolStrip_Tools.ResumeLayout(false);
            this.ToolStrip_Tools.PerformLayout();
            this.ToolStrip_EmoteEditing.ResumeLayout(false);
            this.ToolStrip_EmoteEditing.PerformLayout();
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.SplitContainer_TopBottom.Panel1.ResumeLayout(false);
            this.SplitContainer_TopBottom.Panel2.ResumeLayout(false);
            this.SplitContainer_TopBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView_DefaultEmotes;
        private System.Windows.Forms.ToolStrip ToolStrip_Main;
        private System.Windows.Forms.ToolStripButton ToolStipButton_Load;
        private System.Windows.Forms.ToolStripButton ToolStipButton_Save;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.SplitContainer SplitContainer_TopBottom;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBox_Configuration;
        private System.Windows.Forms.ToolStripButton ToolStripButton_RemoveConfiguration;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_Configuration;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton_AddConfiguration;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_Independent;
        private System.Windows.Forms.ListView ListView_Output;
        private System.Windows.Forms.ColumnHeader ColumnHeader_EmoteText;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Condition;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton_Import;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBox_Source;
        private System.Windows.Forms.ToolStripContainer ToolStripContainer_EmoteEditing;
        private System.Windows.Forms.ToolStrip ToolStrip_EmoteEditing;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AddNode;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AddChildNode;
        private System.Windows.Forms.ToolStripButton ToolStripButton_RemoveNode;
        private System.Windows.Forms.ToolStrip ToolStrip_Tools;
        private System.Windows.Forms.ToolStripButton ToolStripButton_TestConfiguration;
        private System.Windows.Forms.ToolStripButton ToolStripButton_CheckForProblems;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMenuItem_Conditions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_TargetExists;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_TargetIsFriendly;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_TargetIsUnfriendly;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PetIsHappy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PetIsContent;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PetIsUnhappy;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PetIsMale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PetIsFemale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PlayerIsMale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_PlayerIsFemale;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_None;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMenuItem_Options;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_MustContinue;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBox_Chance;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_Chance;
        private System.Windows.Forms.Panel Panel_Keywords;
        private System.Windows.Forms.TabControl TabControl_EmoteConfigurations;
        private System.Windows.Forms.TabPage TabPage_DefaultEmotes;
        private System.Windows.Forms.TabPage TabPage_CombatEmotes;
        private System.Windows.Forms.TextBox TextBox_Keywords;
        private System.Windows.Forms.CheckBox CheckBox_KeywordsAutoFill;
        private System.Windows.Forms.Panel Panel_KeywordsTextBox;
        private System.Windows.Forms.Panel Panel_KeywordsLabel;
        private System.Windows.Forms.ToolTip ToolTip_Help;
        private System.Windows.Forms.ImageList ImageList_TreeView;
        private System.Windows.Forms.TabPage TabPage_FeedingEmotes;
        private System.Windows.Forms.TreeView TreeView_CombatEmotes;
        private System.Windows.Forms.TreeView TreeView_FeedingEmotes;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.NumericUpDown NumericUpDown_KeywordsMinLength;
    }
}

