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
            this.SplitContainer_TopBottom = new System.Windows.Forms.SplitContainer();
            this.ToolStripContainer_EmoteEditing = new System.Windows.Forms.ToolStripContainer();
            this.TreeView_Main = new System.Windows.Forms.TreeView();
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
            this.ToolStrip_Options = new System.Windows.Forms.ToolStrip();
            this.ToolStripMenuItem_Options = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_MustContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DisallowAll = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolStrip_Tools = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_TestConfiguration = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_CheckForProblems = new System.Windows.Forms.ToolStripButton();
            this.ListView_Output = new System.Windows.Forms.ListView();
            this.ColumnHeader_EmoteText = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader_Condition = new System.Windows.Forms.ColumnHeader();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SplitContainer_TopBottom.Panel1.SuspendLayout();
            this.SplitContainer_TopBottom.Panel2.SuspendLayout();
            this.SplitContainer_TopBottom.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.ContentPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.SuspendLayout();
            this.ToolStrip_Main.SuspendLayout();
            this.ToolStrip_EmoteEditing.SuspendLayout();
            this.ToolStrip_Options.SuspendLayout();
            this.ToolStrip_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer_TopBottom
            // 
            this.SplitContainer_TopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer_TopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer_TopBottom.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer_TopBottom.Name = "SplitContainer_TopBottom";
            this.SplitContainer_TopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer_TopBottom.Panel1
            // 
            this.SplitContainer_TopBottom.Panel1.Controls.Add(this.ToolStripContainer_EmoteEditing);
            // 
            // SplitContainer_TopBottom.Panel2
            // 
            this.SplitContainer_TopBottom.Panel2.Controls.Add(this.ListView_Output);
            this.SplitContainer_TopBottom.Size = new System.Drawing.Size(592, 571);
            this.SplitContainer_TopBottom.SplitterDistance = 396;
            this.SplitContainer_TopBottom.TabIndex = 1;
            // 
            // ToolStripContainer_EmoteEditing
            // 
            // 
            // ToolStripContainer_EmoteEditing.ContentPanel
            // 
            this.ToolStripContainer_EmoteEditing.ContentPanel.Controls.Add(this.TreeView_Main);
            this.ToolStripContainer_EmoteEditing.ContentPanel.Size = new System.Drawing.Size(592, 321);
            this.ToolStripContainer_EmoteEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer_EmoteEditing.LeftToolStripPanelVisible = false;
            this.ToolStripContainer_EmoteEditing.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer_EmoteEditing.Name = "ToolStripContainer_EmoteEditing";
            this.ToolStripContainer_EmoteEditing.RightToolStripPanelVisible = false;
            this.ToolStripContainer_EmoteEditing.Size = new System.Drawing.Size(592, 396);
            this.ToolStripContainer_EmoteEditing.TabIndex = 1;
            this.ToolStripContainer_EmoteEditing.Text = "toolStripContainer1";
            // 
            // ToolStripContainer_EmoteEditing.TopToolStripPanel
            // 
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Main);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_EmoteEditing);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Options);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Tools);
            // 
            // TreeView_Main
            // 
            this.TreeView_Main.AllowDrop = true;
            this.TreeView_Main.CheckBoxes = true;
            this.TreeView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView_Main.FullRowSelect = true;
            this.TreeView_Main.HideSelection = false;
            this.TreeView_Main.HotTracking = true;
            this.TreeView_Main.LabelEdit = true;
            this.TreeView_Main.Location = new System.Drawing.Point(0, 0);
            this.TreeView_Main.Name = "TreeView_Main";
            this.TreeView_Main.PathSeparator = " ";
            this.TreeView_Main.ShowLines = false;
            this.TreeView_Main.ShowNodeToolTips = true;
            this.TreeView_Main.Size = new System.Drawing.Size(592, 321);
            this.TreeView_Main.TabIndex = 0;
            this.TreeView_Main.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Main_AfterCheck);
            this.TreeView_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_Main_DragDrop);
            this.TreeView_Main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Main_AfterSelect);
            this.TreeView_Main.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_Main_ItemDrag);
            this.TreeView_Main.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_Main_DragOver);
            // 
            // ToolStrip_Main
            // 
            this.ToolStrip_Main.Dock = System.Windows.Forms.DockStyle.None;
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
            this.ToolStrip_Main.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip_Main.Name = "ToolStrip_Main";
            this.ToolStrip_Main.Size = new System.Drawing.Size(525, 25);
            this.ToolStrip_Main.TabIndex = 1;
            this.ToolStrip_Main.Text = "Werkzeugleiste";
            // 
            // ToolStripComboBox_Source
            // 
            this.ToolStripComboBox_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Source.Name = "ToolStripComboBox_Source";
            this.ToolStripComboBox_Source.Size = new System.Drawing.Size(75, 25);
            this.ToolStripComboBox_Source.ToolTipText = "Quelle wählen";
            // 
            // ToolStipButton_Load
            // 
            this.ToolStipButton_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Load.Image = global::PetEmote.Icons.Load;
            this.ToolStipButton_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStipButton_Load.Name = "ToolStipButton_Load";
            this.ToolStipButton_Load.Size = new System.Drawing.Size(23, 22);
            this.ToolStipButton_Load.Text = "Wiederherstellen";
            this.ToolStipButton_Load.Click += new System.EventHandler(this.ToolStripButton_Load_Click);
            // 
            // ToolStipButton_Save
            // 
            this.ToolStipButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Save.Image = global::PetEmote.Icons.Save;
            this.ToolStipButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStipButton_Save.Name = "ToolStipButton_Save";
            this.ToolStipButton_Save.Size = new System.Drawing.Size(23, 22);
            this.ToolStipButton_Save.Text = "Speichern";
            this.ToolStipButton_Save.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel_Configuration
            // 
            this.ToolStripLabel_Configuration.Name = "ToolStripLabel_Configuration";
            this.ToolStripLabel_Configuration.Size = new System.Drawing.Size(71, 22);
            this.ToolStripLabel_Configuration.Text = "Konfiguration";
            // 
            // ToolStripComboBox_Configuration
            // 
            this.ToolStripComboBox_Configuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox_Configuration.Name = "ToolStripComboBox_Configuration";
            this.ToolStripComboBox_Configuration.Size = new System.Drawing.Size(100, 25);
            this.ToolStripComboBox_Configuration.ToolTipText = "Konfiguration auswählen";
            this.ToolStripComboBox_Configuration.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox_Configuration_SelectedIndexChanged);
            // 
            // ToolStripDropDownButton_AddConfiguration
            // 
            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox_Independent});
            this.ToolStripDropDownButton_AddConfiguration.Image = global::PetEmote.Icons.AddConfiguration;
            this.ToolStripDropDownButton_AddConfiguration.Name = "ToolStripDropDownButton_AddConfiguration";
            this.ToolStripDropDownButton_AddConfiguration.Size = new System.Drawing.Size(90, 22);
            this.ToolStripDropDownButton_AddConfiguration.Text = "Hinzufügen";
            // 
            // ToolStripTextBox_Independent
            // 
            this.ToolStripTextBox_Independent.MaxLength = 32;
            this.ToolStripTextBox_Independent.Name = "ToolStripTextBox_Independent";
            this.ToolStripTextBox_Independent.Size = new System.Drawing.Size(110, 21);
            this.ToolStripTextBox_Independent.Text = "Name eines Tieres";
            this.ToolStripTextBox_Independent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox_Independent_KeyDown);
            // 
            // ToolStripButton_RemoveConfiguration
            // 
            this.ToolStripButton_RemoveConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveConfiguration.Image = global::PetEmote.Icons.RemoveConfiguration;
            this.ToolStripButton_RemoveConfiguration.Name = "ToolStripButton_RemoveConfiguration";
            this.ToolStripButton_RemoveConfiguration.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_RemoveConfiguration.Click += new System.EventHandler(this.ToolStripButton_RemoveConfiguration_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripDropDownButton_Import
            // 
            this.ToolStripDropDownButton_Import.Image = global::PetEmote.Icons.ImportConfiguration;
            this.ToolStripDropDownButton_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton_Import.Name = "ToolStripDropDownButton_Import";
            this.ToolStripDropDownButton_Import.Size = new System.Drawing.Size(92, 22);
            this.ToolStripDropDownButton_Import.Text = "Importieren";
            this.ToolStripDropDownButton_Import.ToolTipText = "Alle Emotes aus einer Standard-Konfiguration hinzufügen";
            // 
            // ToolStrip_EmoteEditing
            // 
            this.ToolStrip_EmoteEditing.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip_EmoteEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AddNode,
            this.ToolStripButton_AddChildNode,
            this.ToolStripButton_RemoveNode});
            this.ToolStrip_EmoteEditing.Location = new System.Drawing.Point(3, 25);
            this.ToolStrip_EmoteEditing.Name = "ToolStrip_EmoteEditing";
            this.ToolStrip_EmoteEditing.Size = new System.Drawing.Size(81, 25);
            this.ToolStrip_EmoteEditing.TabIndex = 0;
            // 
            // ToolStripButton_AddNode
            // 
            this.ToolStripButton_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddNode.Image = global::PetEmote.Icons.AddNode;
            this.ToolStripButton_AddNode.Name = "ToolStripButton_AddNode";
            this.ToolStripButton_AddNode.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AddNode.Click += new System.EventHandler(this.ToolStripButton_AddNode_Click);
            // 
            // ToolStripButton_AddChildNode
            // 
            this.ToolStripButton_AddChildNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AddChildNode.Image = global::PetEmote.Icons.AddChildNode;
            this.ToolStripButton_AddChildNode.Name = "ToolStripButton_AddChildNode";
            this.ToolStripButton_AddChildNode.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AddChildNode.Click += new System.EventHandler(this.ToolStripButton_AddChildNode_Click);
            // 
            // ToolStripButton_RemoveNode
            // 
            this.ToolStripButton_RemoveNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_RemoveNode.Image = global::PetEmote.Icons.RemoveNode;
            this.ToolStripButton_RemoveNode.Name = "ToolStripButton_RemoveNode";
            this.ToolStripButton_RemoveNode.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_RemoveNode.Click += new System.EventHandler(this.ToolStripButton_RemoveNode_Click);
            // 
            // ToolStrip_Options
            // 
            this.ToolStrip_Options.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Options,
            this.ToolStripSeparator3,
            this.ToolStripMenuItem_Conditions});
            this.ToolStrip_Options.Location = new System.Drawing.Point(84, 25);
            this.ToolStrip_Options.Name = "ToolStrip_Options";
            this.ToolStrip_Options.Size = new System.Drawing.Size(184, 25);
            this.ToolStrip_Options.TabIndex = 1;
            // 
            // ToolStripMenuItem_Options
            // 
            this.ToolStripMenuItem_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_MustContinue,
            this.ToolStripMenuItem_DisallowAll});
            this.ToolStripMenuItem_Options.Image = global::PetEmote.Icons.Options;
            this.ToolStripMenuItem_Options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItem_Options.Name = "ToolStripMenuItem_Options";
            this.ToolStripMenuItem_Options.Size = new System.Drawing.Size(80, 22);
            this.ToolStripMenuItem_Options.Text = "Optionen";
            this.ToolStripMenuItem_Options.ToolTipText = "Einstellungen zum ausgewählten Emote";
            // 
            // ToolStripMenuItem_MustContinue
            // 
            this.ToolStripMenuItem_MustContinue.CheckOnClick = true;
            this.ToolStripMenuItem_MustContinue.Name = "ToolStripMenuItem_MustContinue";
            this.ToolStripMenuItem_MustContinue.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_MustContinue.Text = "Fortsetzung erzwingen";
            this.ToolStripMenuItem_MustContinue.ToolTipText = "Wenn ausgewählt, wird das Emote garantiert mit einem der untergeordneten Texte fo" +
                "rtgesetzt.";
            this.ToolStripMenuItem_MustContinue.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_MustContinue_CheckedChanged);
            // 
            // ToolStripMenuItem_DisallowAll
            // 
            this.ToolStripMenuItem_DisallowAll.CheckOnClick = true;
            this.ToolStripMenuItem_DisallowAll.Name = "ToolStripMenuItem_DisallowAll";
            this.ToolStripMenuItem_DisallowAll.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_DisallowAll.Text = "Keine weiteren Emotes";
            this.ToolStripMenuItem_DisallowAll.ToolTipText = "Wenn aktiviert, beendet dieses Emote die Ausgabe. Es werden keine weiteren Textba" +
                "usteine angehängt.";
            this.ToolStripMenuItem_DisallowAll.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_DisallowAll_CheckedChanged);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.ToolStripMenuItem_Conditions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItem_Conditions.Name = "ToolStripMenuItem_Conditions";
            this.ToolStripMenuItem_Conditions.Size = new System.Drawing.Size(86, 22);
            this.ToolStripMenuItem_Conditions.Text = "Bedingung";
            this.ToolStripMenuItem_Conditions.ToolTipText = "Bedingung zum ausgewählten Emote";
            // 
            // ToolStripMenuItem_Condition_TargetExists
            // 
            this.ToolStripMenuItem_Condition_TargetExists.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetExists.Name = "ToolStripMenuItem_Condition_TargetExists";
            this.ToolStripMenuItem_Condition_TargetExists.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_TargetExists.Tag = "TargetExists";
            this.ToolStripMenuItem_Condition_TargetExists.Text = "Ziel existiert";
            this.ToolStripMenuItem_Condition_TargetExists.ToolTipText = "Der Spieler muss ein Ziel anvisiert haben.";
            this.ToolStripMenuItem_Condition_TargetExists.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsFriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Name = "ToolStripMenuItem_Condition_TargetIsFriendly";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Tag = "TargetIsFriendly";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.Text = "Ziel ist freundlich";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.ToolTipText = "Der Spieler muss ein freundliches Ziel anvisiert haben.";
            this.ToolStripMenuItem_Condition_TargetIsFriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_TargetIsUnfriendly
            // 
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Name = "ToolStripMenuItem_Condition_TargetIsUnfriendly";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Tag = "TargetIsUnfriendly";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.Text = "Ziel ist unfreundlich";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.ToolTipText = "Der Spieler muss ein unfreundliches Ziel anvisiert haben.";
            this.ToolStripMenuItem_Condition_TargetIsUnfriendly.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // ToolStripMenuItem_Condition_PetIsHappy
            // 
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsHappy.Name = "ToolStripMenuItem_Condition_PetIsHappy";
            this.ToolStripMenuItem_Condition_PetIsHappy.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PetIsHappy.Tag = "PetIsHappy";
            this.ToolStripMenuItem_Condition_PetIsHappy.Text = "Tier ist glücklich";
            this.ToolStripMenuItem_Condition_PetIsHappy.ToolTipText = "Das Tier muss glücklich sein (nur Jäger).";
            this.ToolStripMenuItem_Condition_PetIsHappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsContent
            // 
            this.ToolStripMenuItem_Condition_PetIsContent.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsContent.Name = "ToolStripMenuItem_Condition_PetIsContent";
            this.ToolStripMenuItem_Condition_PetIsContent.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PetIsContent.Tag = "PetIsContent";
            this.ToolStripMenuItem_Condition_PetIsContent.Text = "Tier ist zufrieden";
            this.ToolStripMenuItem_Condition_PetIsContent.ToolTipText = "Das Tier muss zufrieden sein (nur Jäger).";
            this.ToolStripMenuItem_Condition_PetIsContent.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsUnhappy
            // 
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Name = "ToolStripMenuItem_Condition_PetIsUnhappy";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Tag = "PetIsUnhappy";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.Text = "Tier ist unglücklich";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.ToolTipText = "Das Tier muss unglücklich sein (nur Jäger).";
            this.ToolStripMenuItem_Condition_PetIsUnhappy.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(188, 6);
            // 
            // ToolStripMenuItem_Condition_PetIsMale
            // 
            this.ToolStripMenuItem_Condition_PetIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsMale.Name = "ToolStripMenuItem_Condition_PetIsMale";
            this.ToolStripMenuItem_Condition_PetIsMale.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PetIsMale.Tag = "PetIsMale";
            this.ToolStripMenuItem_Condition_PetIsMale.Text = "Tier ist männlich";
            this.ToolStripMenuItem_Condition_PetIsMale.ToolTipText = "Das Geschlecht des Tieres muss männlich sein.";
            this.ToolStripMenuItem_Condition_PetIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PetIsFemale
            // 
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PetIsFemale.Name = "ToolStripMenuItem_Condition_PetIsFemale";
            this.ToolStripMenuItem_Condition_PetIsFemale.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PetIsFemale.Tag = "PetIsFemale";
            this.ToolStripMenuItem_Condition_PetIsFemale.Text = "Tier ist weiblich";
            this.ToolStripMenuItem_Condition_PetIsFemale.ToolTipText = "Das Geschlecht des Tieres muss weiblich sein.";
            this.ToolStripMenuItem_Condition_PetIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsMale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsMale.Name = "ToolStripMenuItem_Condition_PlayerIsMale";
            this.ToolStripMenuItem_Condition_PlayerIsMale.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PlayerIsMale.Tag = "PlayerIsMale";
            this.ToolStripMenuItem_Condition_PlayerIsMale.Text = "Charakter ist männlich";
            this.ToolStripMenuItem_Condition_PlayerIsMale.ToolTipText = "Das Geschlecht des Spielercharakters muss männlich sein.";
            this.ToolStripMenuItem_Condition_PlayerIsMale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_Condition_PlayerIsFemale
            // 
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Name = "ToolStripMenuItem_Condition_PlayerIsFemale";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Tag = "PlayerIsFemale";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.Text = "Charakter ist weiblich";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.ToolTipText = "Das Geschlecht des Spielercharakters muss weiblich sein.";
            this.ToolStripMenuItem_Condition_PlayerIsFemale.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(188, 6);
            // 
            // ToolStripMenuItem_Condition_None
            // 
            this.ToolStripMenuItem_Condition_None.CheckOnClick = true;
            this.ToolStripMenuItem_Condition_None.Name = "ToolStripMenuItem_Condition_None";
            this.ToolStripMenuItem_Condition_None.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Condition_None.Tag = "None";
            this.ToolStripMenuItem_Condition_None.Text = "Keine Bedingung";
            this.ToolStripMenuItem_Condition_None.ToolTipText = "Das Emote kann jederzeit erscheinen.";
            this.ToolStripMenuItem_Condition_None.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStrip_Tools
            // 
            this.ToolStrip_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_TestConfiguration,
            this.ToolStripButton_CheckForProblems});
            this.ToolStrip_Tools.Location = new System.Drawing.Point(269, 25);
            this.ToolStrip_Tools.Name = "ToolStrip_Tools";
            this.ToolStrip_Tools.Size = new System.Drawing.Size(89, 25);
            this.ToolStrip_Tools.TabIndex = 2;
            this.ToolStrip_Tools.Visible = false;
            // 
            // ToolStripButton_TestConfiguration
            // 
            this.ToolStripButton_TestConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_TestConfiguration.Image = global::PetEmote.Icons.INV_Misc_Spyglass_03;
            this.ToolStripButton_TestConfiguration.Name = "ToolStripButton_TestConfiguration";
            this.ToolStripButton_TestConfiguration.Size = new System.Drawing.Size(23, 22);
            // 
            // ToolStripButton_CheckForProblems
            // 
            this.ToolStripButton_CheckForProblems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_CheckForProblems.Image = global::PetEmote.Icons.INV_Musket_02;
            this.ToolStripButton_CheckForProblems.Name = "ToolStripButton_CheckForProblems";
            this.ToolStripButton_CheckForProblems.Size = new System.Drawing.Size(23, 22);
            // 
            // ListView_Output
            // 
            this.ListView_Output.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_Output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_EmoteText,
            this.ColumnHeader_Condition});
            this.ListView_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Output.FullRowSelect = true;
            this.ListView_Output.GridLines = true;
            this.ListView_Output.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_Output.Location = new System.Drawing.Point(0, 0);
            this.ListView_Output.Name = "ListView_Output";
            this.ListView_Output.ShowItemToolTips = true;
            this.ListView_Output.Size = new System.Drawing.Size(592, 171);
            this.ListView_Output.TabIndex = 0;
            this.ListView_Output.UseCompatibleStateImageBehavior = false;
            this.ListView_Output.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_EmoteText
            // 
            this.ColumnHeader_EmoteText.Text = "Emote";
            this.ColumnHeader_EmoteText.Width = 394;
            // 
            // ColumnHeader_Condition
            // 
            this.ColumnHeader_Condition.Text = "Bedingung";
            this.ColumnHeader_Condition.Width = 194;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "World of Warcraft-Verzeichnis";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 571);
            this.Controls.Add(this.SplitContainer_TopBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PetEmote Editor (Beta)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SplitContainer_TopBottom.Panel1.ResumeLayout(false);
            this.SplitContainer_TopBottom.Panel2.ResumeLayout(false);
            this.SplitContainer_TopBottom.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer_EmoteEditing.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.PerformLayout();
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.ToolStrip_EmoteEditing.ResumeLayout(false);
            this.ToolStrip_EmoteEditing.PerformLayout();
            this.ToolStrip_Options.ResumeLayout(false);
            this.ToolStrip_Options.PerformLayout();
            this.ToolStrip_Tools.ResumeLayout(false);
            this.ToolStrip_Tools.PerformLayout();
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
        private System.Windows.Forms.ToolStrip ToolStrip_Options;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMenuItem_Options;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_MustContinue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DisallowAll;
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
        private System.Windows.Forms.ToolStrip ToolStrip_Tools;
        private System.Windows.Forms.ToolStripButton ToolStripButton_TestConfiguration;
        private System.Windows.Forms.ToolStripButton ToolStripButton_CheckForProblems;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Condition_None;
    }
}

