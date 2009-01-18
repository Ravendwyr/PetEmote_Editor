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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStripContainer_EmoteEditing = new System.Windows.Forms.ToolStripContainer();
            this.TreeView_Main = new System.Windows.Forms.TreeView();
            this.ToolStrip_Tools = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_TestConfiguration = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_CheckForProblems = new System.Windows.Forms.ToolStripButton();
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
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Condition_None = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Options = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_MustContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DisallowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer_TopBottom = new System.Windows.Forms.SplitContainer();
            this.ListView_Output = new System.Windows.Forms.ListView();
            this.ColumnHeader_EmoteText = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader_Condition = new System.Windows.Forms.ColumnHeader();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolStripContainer_EmoteEditing.ContentPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.SuspendLayout();
            this.ToolStrip_Tools.SuspendLayout();
            this.ToolStrip_Main.SuspendLayout();
            this.ToolStrip_EmoteEditing.SuspendLayout();
            this.SplitContainer_TopBottom.Panel1.SuspendLayout();
            this.SplitContainer_TopBottom.Panel2.SuspendLayout();
            this.SplitContainer_TopBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripContainer_EmoteEditing
            // 
            // 
            // ToolStripContainer_EmoteEditing.ContentPanel
            // 
            this.ToolStripContainer_EmoteEditing.ContentPanel.Controls.Add(this.TreeView_Main);
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.ContentPanel, "ToolStripContainer_EmoteEditing.ContentPanel");
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing, "ToolStripContainer_EmoteEditing");
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanelVisible = false;
            this.ToolStripContainer_EmoteEditing.Name = "ToolStripContainer_EmoteEditing";
            this.ToolStripContainer_EmoteEditing.RightToolStripPanelVisible = false;
            // 
            // ToolStripContainer_EmoteEditing.TopToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Tools);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Main);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_EmoteEditing);
            // 
            // TreeView_Main
            // 
            this.TreeView_Main.AllowDrop = true;
            this.TreeView_Main.CheckBoxes = true;
            resources.ApplyResources(this.TreeView_Main, "TreeView_Main");
            this.TreeView_Main.FullRowSelect = true;
            this.TreeView_Main.HideSelection = false;
            this.TreeView_Main.HotTracking = true;
            this.TreeView_Main.LabelEdit = true;
            this.TreeView_Main.Name = "TreeView_Main";
            this.TreeView_Main.PathSeparator = " ";
            this.TreeView_Main.ShowLines = false;
            this.TreeView_Main.ShowNodeToolTips = true;
            this.TreeView_Main.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Main_AfterCheck);
            this.TreeView_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_Main_DragDrop);
            this.TreeView_Main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Main_AfterSelect);
            this.TreeView_Main.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_Main_ItemDrag);
            this.TreeView_Main.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_Main_DragOver);
            // 
            // ToolStrip_Tools
            // 
            resources.ApplyResources(this.ToolStrip_Tools, "ToolStrip_Tools");
            this.ToolStrip_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_TestConfiguration,
            this.ToolStripButton_CheckForProblems});
            this.ToolStrip_Tools.Name = "ToolStrip_Tools";
            // 
            // ToolStripButton_TestConfiguration
            // 
            this.ToolStripButton_TestConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_TestConfiguration.Image = global::PetEmote.Icons.INV_Misc_Spyglass_03;
            this.ToolStripButton_TestConfiguration.Name = "ToolStripButton_TestConfiguration";
            resources.ApplyResources(this.ToolStripButton_TestConfiguration, "ToolStripButton_TestConfiguration");
            // 
            // ToolStripButton_CheckForProblems
            // 
            this.ToolStripButton_CheckForProblems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_CheckForProblems.Image = global::PetEmote.Icons.INV_Musket_02;
            this.ToolStripButton_CheckForProblems.Name = "ToolStripButton_CheckForProblems";
            resources.ApplyResources(this.ToolStripButton_CheckForProblems, "ToolStripButton_CheckForProblems");
            // 
            // ToolStrip_Main
            // 
            resources.ApplyResources(this.ToolStrip_Main, "ToolStrip_Main");
            this.ToolStrip_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.ToolStrip_Main.Stretch = true;
            // 
            // ToolStripComboBox_Source
            // 
            this.ToolStripComboBox_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Source.Name = "ToolStripComboBox_Source";
            resources.ApplyResources(this.ToolStripComboBox_Source, "ToolStripComboBox_Source");
            // 
            // ToolStipButton_Load
            // 
            this.ToolStipButton_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Load.Image = global::PetEmote.Icons.Load;
            resources.ApplyResources(this.ToolStipButton_Load, "ToolStipButton_Load");
            this.ToolStipButton_Load.Name = "ToolStipButton_Load";
            this.ToolStipButton_Load.Click += new System.EventHandler(this.ToolStripButton_Load_Click);
            // 
            // ToolStipButton_Save
            // 
            this.ToolStipButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Save.Image = global::PetEmote.Icons.Save;
            resources.ApplyResources(this.ToolStipButton_Save, "ToolStipButton_Save");
            this.ToolStipButton_Save.Name = "ToolStipButton_Save";
            this.ToolStipButton_Save.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            // 
            // ToolStripLabel_Configuration
            // 
            this.ToolStripLabel_Configuration.Name = "ToolStripLabel_Configuration";
            resources.ApplyResources(this.ToolStripLabel_Configuration, "ToolStripLabel_Configuration");
            // 
            // ToolStripComboBox_Configuration
            // 
            this.ToolStripComboBox_Configuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Configuration.Name = "ToolStripComboBox_Configuration";
            resources.ApplyResources(this.ToolStripComboBox_Configuration, "ToolStripComboBox_Configuration");
            this.ToolStripComboBox_Configuration.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox_Configuration_SelectedIndexChanged);
            // 
            // ToolStripDropDownButton_AddConfiguration
            // 
            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox_Independent});
            this.ToolStripDropDownButton_AddConfiguration.Image = global::PetEmote.Icons.AddConfiguration;
            this.ToolStripDropDownButton_AddConfiguration.Name = "ToolStripDropDownButton_AddConfiguration";
            resources.ApplyResources(this.ToolStripDropDownButton_AddConfiguration, "ToolStripDropDownButton_AddConfiguration");
            // 
            // ToolStripTextBox_Independent
            // 
            resources.ApplyResources(this.ToolStripTextBox_Independent, "ToolStripTextBox_Independent");
            this.ToolStripTextBox_Independent.Name = "ToolStripTextBox_Independent";
            this.ToolStripTextBox_Independent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox_Independent_KeyDown);
            // 
            // ToolStripButton_RemoveConfiguration
            // 
            this.ToolStripButton_RemoveConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveConfiguration.Image = global::PetEmote.Icons.RemoveConfiguration;
            this.ToolStripButton_RemoveConfiguration.Name = "ToolStripButton_RemoveConfiguration";
            resources.ApplyResources(this.ToolStripButton_RemoveConfiguration, "ToolStripButton_RemoveConfiguration");
            this.ToolStripButton_RemoveConfiguration.Click += new System.EventHandler(this.ToolStripButton_RemoveConfiguration_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            resources.ApplyResources(this.ToolStripSeparator2, "ToolStripSeparator2");
            // 
            // ToolStripDropDownButton_Import
            // 
            this.ToolStripDropDownButton_Import.Image = global::PetEmote.Icons.ImportConfiguration;
            resources.ApplyResources(this.ToolStripDropDownButton_Import, "ToolStripDropDownButton_Import");
            this.ToolStripDropDownButton_Import.Name = "ToolStripDropDownButton_Import";
            // 
            // ToolStrip_EmoteEditing
            // 
            resources.ApplyResources(this.ToolStrip_EmoteEditing, "ToolStrip_EmoteEditing");
            this.ToolStrip_EmoteEditing.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip_EmoteEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AddNode,
            this.ToolStripButton_AddChildNode,
            this.ToolStripButton_RemoveNode,
            this.ToolStripSeparator3,
            this.ToolStripMenuItem_Conditions,
            this.ToolStripMenuItem_Options});
            this.ToolStrip_EmoteEditing.Name = "ToolStrip_EmoteEditing";
            this.ToolStrip_EmoteEditing.Stretch = true;
            // 
            // ToolStripButton_AddNode
            // 
            this.ToolStripButton_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddNode.Image = global::PetEmote.Icons.AddNode;
            this.ToolStripButton_AddNode.Name = "ToolStripButton_AddNode";
            resources.ApplyResources(this.ToolStripButton_AddNode, "ToolStripButton_AddNode");
            this.ToolStripButton_AddNode.Click += new System.EventHandler(this.ToolStripButton_AddNode_Click);
            // 
            // ToolStripButton_AddChildNode
            // 
            this.ToolStripButton_AddChildNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddChildNode.Image = global::PetEmote.Icons.AddChildNode;
            this.ToolStripButton_AddChildNode.Name = "ToolStripButton_AddChildNode";
            resources.ApplyResources(this.ToolStripButton_AddChildNode, "ToolStripButton_AddChildNode");
            this.ToolStripButton_AddChildNode.Click += new System.EventHandler(this.ToolStripButton_AddChildNode_Click);
            // 
            // ToolStripButton_RemoveNode
            // 
            this.ToolStripButton_RemoveNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveNode.Image = global::PetEmote.Icons.RemoveNode;
            this.ToolStripButton_RemoveNode.Name = "ToolStripButton_RemoveNode";
            resources.ApplyResources(this.ToolStripButton_RemoveNode, "ToolStripButton_RemoveNode");
            this.ToolStripButton_RemoveNode.Click += new System.EventHandler(this.ToolStripButton_RemoveNode_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            resources.ApplyResources(this.ToolStripSeparator3, "ToolStripSeparator3");
            // 
            // ToolStripMenuItem_Conditions
            // 
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
            this.ToolStripSeparator6,
            this.ToolStripMenuItem_Condition_None});
            this.ToolStripMenuItem_Conditions.Image = global::PetEmote.Icons.Condition;
            resources.ApplyResources(this.ToolStripMenuItem_Conditions, "ToolStripMenuItem_Conditions");
            this.ToolStripMenuItem_Conditions.Name = "ToolStripMenuItem_Conditions";
            // 
            // ToolStripMenuItem_Condition_TargetExists
            // 
            this.ToolStripMenuItem_Condition_TargetExists.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetExists.Name = "ToolStripMenuItem_Condition_TargetExists";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetExists, "ToolStripMenuItem_Condition_TargetExists");
            this.ToolStripMenuItem_Condition_TargetExists.Tag = "TargetExists";
            this.ToolStripMenuItem_Condition_TargetExists.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsFriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Name = "ToolStripMenuItem_Condition_TargetIsFriendly";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetIsFriendly, "ToolStripMenuItem_Condition_TargetIsFriendly");
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Tag = "TargetIsFriendly";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsUnfriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Name = "ToolStripMenuItem_Condition_TargetIsUnfriendly";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_TargetIsUnfriendly, "ToolStripMenuItem_Condition_TargetIsUnfriendly");
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Tag = "TargetIsUnfriendly";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            resources.ApplyResources(this.ToolStripSeparator4, "ToolStripSeparator4");
            // 
            // ToolStripMenuItem_Condition_PetIsHappy
            // 
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsHappy.Name = "ToolStripMenuItem_Condition_PetIsHappy";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsHappy, "ToolStripMenuItem_Condition_PetIsHappy");
            this.ToolStripMenuItem_Condition_PetIsHappy.Tag = "PetIsHappy";
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsContent
            // 
            this.ToolStripMenuItem_Condition_PetIsContent.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsContent.Name = "ToolStripMenuItem_Condition_PetIsContent";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsContent, "ToolStripMenuItem_Condition_PetIsContent");
            this.ToolStripMenuItem_Condition_PetIsContent.Tag = "PetIsContent";
            this.ToolStripMenuItem_Condition_PetIsContent.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsUnhappy
            // 
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Name = "ToolStripMenuItem_Condition_PetIsUnhappy";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsUnhappy, "ToolStripMenuItem_Condition_PetIsUnhappy");
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Tag = "PetIsUnhappy";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            resources.ApplyResources(this.ToolStripSeparator5, "ToolStripSeparator5");
            // 
            // ToolStripMenuItem_Condition_PetIsMale
            // 
            this.ToolStripMenuItem_Condition_PetIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsMale.Name = "ToolStripMenuItem_Condition_PetIsMale";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsMale, "ToolStripMenuItem_Condition_PetIsMale");
            this.ToolStripMenuItem_Condition_PetIsMale.Tag = "PetIsMale";
            this.ToolStripMenuItem_Condition_PetIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsFemale
            // 
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsFemale.Name = "ToolStripMenuItem_Condition_PetIsFemale";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PetIsFemale, "ToolStripMenuItem_Condition_PetIsFemale");
            this.ToolStripMenuItem_Condition_PetIsFemale.Tag = "PetIsFemale";
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsMale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsMale.Name = "ToolStripMenuItem_Condition_PlayerIsMale";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PlayerIsMale, "ToolStripMenuItem_Condition_PlayerIsMale");
            this.ToolStripMenuItem_Condition_PlayerIsMale.Tag = "PlayerIsMale";
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsFemale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Name = "ToolStripMenuItem_Condition_PlayerIsFemale";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_PlayerIsFemale, "ToolStripMenuItem_Condition_PlayerIsFemale");
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Tag = "PlayerIsFemale";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            resources.ApplyResources(this.ToolStripSeparator6, "ToolStripSeparator6");
            // 
            // ToolStripMenuItem_Condition_None
            // 
            this.ToolStripMenuItem_Condition_None.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_None.Name = "ToolStripMenuItem_Condition_None";
            resources.ApplyResources(this.ToolStripMenuItem_Condition_None, "ToolStripMenuItem_Condition_None");
            this.ToolStripMenuItem_Condition_None.Tag = "None";
            this.ToolStripMenuItem_Condition_None.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Options
            // 
            this.ToolStripMenuItem_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_MustContinue,
            this.ToolStripMenuItem_DisallowAll});
            this.ToolStripMenuItem_Options.Image = global::PetEmote.Icons.Options;
            resources.ApplyResources(this.ToolStripMenuItem_Options, "ToolStripMenuItem_Options");
            this.ToolStripMenuItem_Options.Name = "ToolStripMenuItem_Options";
            // 
            // ToolStripMenuItem_MustContinue
            // 
            this.ToolStripMenuItem_MustContinue.CheckOnClick = true;
            this.ToolStripMenuItem_MustContinue.Name = "ToolStripMenuItem_MustContinue";
            resources.ApplyResources(this.ToolStripMenuItem_MustContinue, "ToolStripMenuItem_MustContinue");
            this.ToolStripMenuItem_MustContinue.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_MustContinue_CheckedChanged);
            // 
            // ToolStripMenuItem_DisallowAll
            // 
            this.ToolStripMenuItem_DisallowAll.CheckOnClick = true;
            this.ToolStripMenuItem_DisallowAll.Name = "ToolStripMenuItem_DisallowAll";
            resources.ApplyResources(this.ToolStripMenuItem_DisallowAll, "ToolStripMenuItem_DisallowAll");
            this.ToolStripMenuItem_DisallowAll.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_DisallowAll_CheckedChanged);
            // 
            // SplitContainer_TopBottom
            // 
            resources.ApplyResources(this.SplitContainer_TopBottom, "SplitContainer_TopBottom");
            this.SplitContainer_TopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer_TopBottom.Name = "SplitContainer_TopBottom";
            // 
            // SplitContainer_TopBottom.Panel1
            // 
            this.SplitContainer_TopBottom.Panel1.Controls.Add(this.ToolStripContainer_EmoteEditing);
            // 
            // SplitContainer_TopBottom.Panel2
            // 
            this.SplitContainer_TopBottom.Panel2.Controls.Add(this.ListView_Output);
            // 
            // ListView_Output
            // 
            this.ListView_Output.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_Output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_EmoteText,
            this.ColumnHeader_Condition});
            resources.ApplyResources(this.ListView_Output, "ListView_Output");
            this.ListView_Output.FullRowSelect = true;
            this.ListView_Output.GridLines = true;
            this.ListView_Output.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_Output.Name = "ListView_Output";
            this.ListView_Output.ShowItemToolTips = true;
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer_TopBottom);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ToolStripContainer_EmoteEditing.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer_EmoteEditing.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.PerformLayout();
            this.ToolStrip_Tools.ResumeLayout(false);
            this.ToolStrip_Tools.PerformLayout();
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.ToolStrip_EmoteEditing.ResumeLayout(false);
            this.ToolStrip_EmoteEditing.PerformLayout();
            this.SplitContainer_TopBottom.Panel1.ResumeLayout(false);
            this.SplitContainer_TopBottom.Panel2.ResumeLayout(false);
            this.SplitContainer_TopBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView_Main;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DisallowAll;
    }
}

