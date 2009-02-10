namespace PetEmote.Editor.Forms
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
            this.SplitContainer_LeftRight = new System.Windows.Forms.SplitContainer();
            this.ListView_Configurations = new System.Windows.Forms.ListView();
            this.ContextMenuStrip_ConfigurationsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList_PetFamilies = new System.Windows.Forms.ImageList(this.components);
            this.SplitContainer_TopBottom = new System.Windows.Forms.SplitContainer();
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
            this.ListView_Output = new System.Windows.Forms.ListView();
            this.ColumnHeader_EmoteText = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader_Condition = new System.Windows.Forms.ColumnHeader();
            this.ToolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.ToolStipButton_Save = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_Revert = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDropDownButton_AddConfiguration = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripTextBox_Independent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton_RemoveConfiguration = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDropDownButton_Import = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
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
            this.ToolStripMenuItem_FoodAccepted = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FoodRefused = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_IsFirstCall = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_IsSecondCall = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_IsThirdCall = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Condition_None = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Options = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_MustContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Chance = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripComboBox_Chance = new System.Windows.Forms.ToolStripComboBox();
            this.ContextMenuStrip_EmoteTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTip_Help = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_Configuration = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.petFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripContainer_EmoteEditing.ContentPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer_EmoteEditing.SuspendLayout();
            this.SplitContainer_LeftRight.Panel1.SuspendLayout();
            this.SplitContainer_LeftRight.Panel2.SuspendLayout();
            this.SplitContainer_LeftRight.SuspendLayout();
            this.ContextMenuStrip_ConfigurationsMenu.SuspendLayout();
            this.SplitContainer_TopBottom.Panel1.SuspendLayout();
            this.SplitContainer_TopBottom.Panel2.SuspendLayout();
            this.SplitContainer_TopBottom.SuspendLayout();
            this.TabControl_EmoteConfigurations.SuspendLayout();
            this.TabPage_DefaultEmotes.SuspendLayout();
            this.TabPage_CombatEmotes.SuspendLayout();
            this.TabPage_FeedingEmotes.SuspendLayout();
            this.Panel_Keywords.SuspendLayout();
            this.Panel_KeywordsTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_KeywordsMinLength)).BeginInit();
            this.Panel_KeywordsLabel.SuspendLayout();
            this.ToolStrip_Main.SuspendLayout();
            this.ContextMenuStrip_EmoteTree.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.ContextMenuStrip_Configuration.SuspendLayout();
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
            this.ToolStripContainer_EmoteEditing.BottomToolStripPanelVisible = false;
            // 
            // ToolStripContainer_EmoteEditing.ContentPanel
            // 
            this.ToolStripContainer_EmoteEditing.ContentPanel.AccessibleDescription = null;
            this.ToolStripContainer_EmoteEditing.ContentPanel.AccessibleName = null;
            resources.ApplyResources(this.ToolStripContainer_EmoteEditing.ContentPanel, "ToolStripContainer_EmoteEditing.ContentPanel");
            this.ToolStripContainer_EmoteEditing.ContentPanel.BackgroundImage = null;
            this.ToolStripContainer_EmoteEditing.ContentPanel.Controls.Add(this.SplitContainer_LeftRight);
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
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Controls.Add(this.ToolStrip_Main);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.Font = null;
            this.ToolTip_Help.SetToolTip(this.ToolStripContainer_EmoteEditing.TopToolStripPanel, resources.GetString("ToolStripContainer_EmoteEditing.TopToolStripPanel.ToolTip"));
            // 
            // SplitContainer_LeftRight
            // 
            this.SplitContainer_LeftRight.AccessibleDescription = null;
            this.SplitContainer_LeftRight.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_LeftRight, "SplitContainer_LeftRight");
            this.SplitContainer_LeftRight.BackgroundImage = null;
            this.SplitContainer_LeftRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer_LeftRight.Font = null;
            this.SplitContainer_LeftRight.Name = "SplitContainer_LeftRight";
            // 
            // SplitContainer_LeftRight.Panel1
            // 
            this.SplitContainer_LeftRight.Panel1.AccessibleDescription = null;
            this.SplitContainer_LeftRight.Panel1.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_LeftRight.Panel1, "SplitContainer_LeftRight.Panel1");
            this.SplitContainer_LeftRight.Panel1.BackgroundImage = null;
            this.SplitContainer_LeftRight.Panel1.Controls.Add(this.ListView_Configurations);
            this.SplitContainer_LeftRight.Panel1.Font = null;
            this.ToolTip_Help.SetToolTip(this.SplitContainer_LeftRight.Panel1, resources.GetString("SplitContainer_LeftRight.Panel1.ToolTip"));
            // 
            // SplitContainer_LeftRight.Panel2
            // 
            this.SplitContainer_LeftRight.Panel2.AccessibleDescription = null;
            this.SplitContainer_LeftRight.Panel2.AccessibleName = null;
            resources.ApplyResources(this.SplitContainer_LeftRight.Panel2, "SplitContainer_LeftRight.Panel2");
            this.SplitContainer_LeftRight.Panel2.BackgroundImage = null;
            this.SplitContainer_LeftRight.Panel2.Controls.Add(this.SplitContainer_TopBottom);
            this.SplitContainer_LeftRight.Panel2.Font = null;
            this.ToolTip_Help.SetToolTip(this.SplitContainer_LeftRight.Panel2, resources.GetString("SplitContainer_LeftRight.Panel2.ToolTip"));
            this.ToolTip_Help.SetToolTip(this.SplitContainer_LeftRight, resources.GetString("SplitContainer_LeftRight.ToolTip"));
            // 
            // ListView_Configurations
            // 
            this.ListView_Configurations.AccessibleDescription = null;
            this.ListView_Configurations.AccessibleName = null;
            resources.ApplyResources(this.ListView_Configurations, "ListView_Configurations");
            this.ListView_Configurations.BackColor = System.Drawing.Color.GhostWhite;
            this.ListView_Configurations.BackgroundImage = null;
            this.ListView_Configurations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_Configurations.ContextMenuStrip = this.ContextMenuStrip_ConfigurationsMenu;
            this.ListView_Configurations.Font = null;
            this.ListView_Configurations.ForeColor = System.Drawing.Color.DimGray;
            this.ListView_Configurations.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListView_Configurations.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListView_Configurations.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListView_Configurations.Groups2"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListView_Configurations.Groups3")))});
            this.ListView_Configurations.HideSelection = false;
            this.ListView_Configurations.LabelEdit = true;
            this.ListView_Configurations.LargeImageList = this.ImageList_PetFamilies;
            this.ListView_Configurations.MultiSelect = false;
            this.ListView_Configurations.Name = "ListView_Configurations";
            this.ListView_Configurations.SmallImageList = this.ImageList_PetFamilies;
            this.ListView_Configurations.StateImageList = this.ImageList_PetFamilies;
            this.ListView_Configurations.TileSize = new System.Drawing.Size(168, 20);
            this.ToolTip_Help.SetToolTip(this.ListView_Configurations, resources.GetString("ListView_Configurations.ToolTip"));
            this.ListView_Configurations.UseCompatibleStateImageBehavior = false;
            this.ListView_Configurations.View = System.Windows.Forms.View.Tile;
            this.ListView_Configurations.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView_Configurations_AfterLabelEdit);
            this.ListView_Configurations.SelectedIndexChanged += new System.EventHandler(this.ListView_Configurations_SelectedIndexChanged);
            // 
            // ContextMenuStrip_ConfigurationsMenu
            // 
            this.ContextMenuStrip_ConfigurationsMenu.AccessibleDescription = null;
            this.ContextMenuStrip_ConfigurationsMenu.AccessibleName = null;
            resources.ApplyResources(this.ContextMenuStrip_ConfigurationsMenu, "ContextMenuStrip_ConfigurationsMenu");
            this.ContextMenuStrip_ConfigurationsMenu.BackgroundImage = null;
            this.ContextMenuStrip_ConfigurationsMenu.Font = null;
            this.ContextMenuStrip_ConfigurationsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConfigurationToolStripMenuItem});
            this.ContextMenuStrip_ConfigurationsMenu.Name = "ContextMenuStrip_ConfigurationsMenu";
            this.ToolTip_Help.SetToolTip(this.ContextMenuStrip_ConfigurationsMenu, resources.GetString("ContextMenuStrip_ConfigurationsMenu.ToolTip"));
            // 
            // newConfigurationToolStripMenuItem
            // 
            this.newConfigurationToolStripMenuItem.AccessibleDescription = null;
            this.newConfigurationToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.newConfigurationToolStripMenuItem, "newConfigurationToolStripMenuItem");
            this.newConfigurationToolStripMenuItem.BackgroundImage = null;
            this.newConfigurationToolStripMenuItem.Name = "newConfigurationToolStripMenuItem";
            this.newConfigurationToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // ImageList_PetFamilies
            // 
            this.ImageList_PetFamilies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_PetFamilies.ImageStream")));
            this.ImageList_PetFamilies.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_PetFamilies.Images.SetKeyName(0, "INV_Misc_QuestionMark.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(1, "Ability_Hunter_Pet_Bat.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(2, "Ability_Hunter_Pet_Bear.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(3, "Ability_Hunter_Pet_Boar.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(4, "Ability_Hunter_Pet_Cat.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(5, "Ability_Hunter_Pet_Chimera.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(6, "Ability_Hunter_Pet_CoreHound.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(7, "Ability_Hunter_Pet_Crab.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(8, "Ability_Hunter_Pet_Crocolisk.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(9, "Ability_Hunter_Pet_Devilsaur.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(10, "Ability_Hunter_Pet_DragonHawk.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(11, "Ability_Hunter_Pet_Gorilla.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(12, "Ability_Hunter_Pet_Hyena.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(13, "Ability_Hunter_Pet_Moth.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(14, "Ability_Hunter_Pet_NetherRay.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(15, "Ability_Hunter_Pet_Owl.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(16, "Ability_Hunter_Pet_Raptor.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(17, "Ability_Hunter_Pet_Ravager.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(18, "Ability_Hunter_Pet_Rhino.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(19, "Ability_Hunter_Pet_Scorpid.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(20, "Ability_Hunter_Pet_Silithid.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(21, "Ability_Hunter_Pet_Spider.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(22, "Ability_Hunter_Pet_Sporebat.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(23, "Ability_Hunter_Pet_TallStrider.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(24, "Ability_Hunter_Pet_Turtle.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(25, "Ability_Hunter_Pet_Vulture.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(26, "Ability_Hunter_Pet_WarpStalker.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(27, "Ability_Hunter_Pet_Wasp.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(28, "Ability_Hunter_Pet_WindSerpent.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(29, "Ability_Hunter_Pet_Wolf.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(30, "Ability_Hunter_Pet_Worm.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(31, "Spell_Nature_GuardianWard.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(32, "Ability_Druid_PrimalPrecision.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(33, "Spell_Shadow_SummonFelGuard.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(34, "Spell_Shadow_SummonFelHunter.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(35, "Spell_Shadow_SummonImp.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(36, "Spell_Shadow_SummonInfernal.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(37, "Spell_Shadow_SummonSuccubus.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(38, "Spell_Shadow_SummonVoidWalker.jpg");
            this.ImageList_PetFamilies.Images.SetKeyName(39, "Spell_DeathKnight_Gnaw_Ghoul.jpg");
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
            this.SplitContainer_TopBottom.Panel1.Controls.Add(this.TabControl_EmoteConfigurations);
            this.SplitContainer_TopBottom.Panel1.Controls.Add(this.Panel_Keywords);
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
            this.NumericUpDown_KeywordsMinLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PetEmote.Editor.Properties.Settings.Default, "KeywordsMinLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.NumericUpDown_KeywordsMinLength.Value = global::PetEmote.Editor.Properties.Settings.Default.KeywordsMinLength;
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
            this.CheckBox_KeywordsAutoFill.Checked = global::PetEmote.Editor.Properties.Settings.Default.KeywordsAutoFill;
            this.CheckBox_KeywordsAutoFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_KeywordsAutoFill.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PetEmote.Editor.Properties.Settings.Default, "KeywordsAutoFill", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CheckBox_KeywordsAutoFill.Font = null;
            this.CheckBox_KeywordsAutoFill.Name = "CheckBox_KeywordsAutoFill";
            this.ToolTip_Help.SetToolTip(this.CheckBox_KeywordsAutoFill, resources.GetString("CheckBox_KeywordsAutoFill.ToolTip"));
            this.CheckBox_KeywordsAutoFill.UseVisualStyleBackColor = true;
            this.CheckBox_KeywordsAutoFill.CheckedChanged += new System.EventHandler(this.CheckBox_KeywordsAutoFill_CheckedChanged);
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
            // ToolStrip_Main
            // 
            this.ToolStrip_Main.AccessibleDescription = null;
            this.ToolStrip_Main.AccessibleName = null;
            resources.ApplyResources(this.ToolStrip_Main, "ToolStrip_Main");
            this.ToolStrip_Main.BackgroundImage = null;
            this.ToolStrip_Main.Font = null;
            this.ToolStrip_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStipButton_Save,
            this.ToolStripButton_Revert,
            this.ToolStripSeparator1,
            this.ToolStripDropDownButton_AddConfiguration,
            this.ToolStripButton_RemoveConfiguration,
            this.ToolStripSeparator2,
            this.ToolStripDropDownButton_Import,
            this.toolStripSeparator14,
            this.ToolStripButton_AddNode,
            this.ToolStripButton_AddChildNode,
            this.ToolStripButton_RemoveNode,
            this.ToolStripSeparator3,
            this.ToolStripMenuItem_Conditions,
            this.ToolStripMenuItem_Options,
            this.ToolStripSeparator7,
            this.ToolStripLabel_Chance,
            this.ToolStripComboBox_Chance});
            this.ToolStrip_Main.Name = "ToolStrip_Main";
            this.ToolTip_Help.SetToolTip(this.ToolStrip_Main, resources.GetString("ToolStrip_Main.ToolTip"));
            // 
            // ToolStipButton_Save
            // 
            this.ToolStipButton_Save.AccessibleDescription = null;
            this.ToolStipButton_Save.AccessibleName = null;
            resources.ApplyResources(this.ToolStipButton_Save, "ToolStipButton_Save");
            this.ToolStipButton_Save.BackgroundImage = null;
            this.ToolStipButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStipButton_Save.Name = "ToolStipButton_Save";
            this.ToolStipButton_Save.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // ToolStripButton_Revert
            // 
            this.ToolStripButton_Revert.AccessibleDescription = null;
            this.ToolStripButton_Revert.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_Revert, "ToolStripButton_Revert");
            this.ToolStripButton_Revert.BackgroundImage = null;
            this.ToolStripButton_Revert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_Revert.Name = "ToolStripButton_Revert";
            this.ToolStripButton_Revert.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.AccessibleDescription = null;
            this.ToolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // ToolStripDropDownButton_AddConfiguration
            // 
            this.ToolStripDropDownButton_AddConfiguration.AccessibleDescription = null;
            this.ToolStripDropDownButton_AddConfiguration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripDropDownButton_AddConfiguration, "ToolStripDropDownButton_AddConfiguration");
            this.ToolStripDropDownButton_AddConfiguration.BackgroundImage = null;
            this.ToolStripDropDownButton_AddConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox_Independent,
            this.toolStripSeparator11});
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
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.AccessibleDescription = null;
            this.toolStripSeparator11.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            // 
            // ToolStripButton_RemoveConfiguration
            // 
            this.ToolStripButton_RemoveConfiguration.AccessibleDescription = null;
            this.ToolStripButton_RemoveConfiguration.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_RemoveConfiguration, "ToolStripButton_RemoveConfiguration");
            this.ToolStripButton_RemoveConfiguration.BackgroundImage = null;
            this.ToolStripButton_RemoveConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.ToolStripDropDownButton_Import.Name = "ToolStripDropDownButton_Import";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.AccessibleDescription = null;
            this.toolStripSeparator14.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            // 
            // ToolStripButton_AddNode
            // 
            this.ToolStripButton_AddNode.AccessibleDescription = null;
            this.ToolStripButton_AddNode.AccessibleName = null;
            resources.ApplyResources(this.ToolStripButton_AddNode, "ToolStripButton_AddNode");
            this.ToolStripButton_AddNode.BackgroundImage = null;
            this.ToolStripButton_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.ToolStripMenuItem_FoodAccepted,
            this.ToolStripMenuItem_FoodRefused,
            this.ToolStripSeparator9,
            this.ToolStripMenuItem_IsFirstCall,
            this.ToolStripMenuItem_IsSecondCall,
            this.ToolStripMenuItem_IsThirdCall,
            this.ToolStripSeparator6,
            this.ToolStripMenuItem_Condition_None});
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
            // ToolStripMenuItem_FoodAccepted
            // 
            this.ToolStripMenuItem_FoodAccepted.AccessibleDescription = null;
            this.ToolStripMenuItem_FoodAccepted.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_FoodAccepted, "ToolStripMenuItem_FoodAccepted");
            this.ToolStripMenuItem_FoodAccepted.BackgroundImage = null;
            this.ToolStripMenuItem_FoodAccepted.CheckOnClick = true;
            this.ToolStripMenuItem_FoodAccepted.Name = "ToolStripMenuItem_FoodAccepted";
            this.ToolStripMenuItem_FoodAccepted.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_FoodAccepted.Tag = "FoodAccepted";
            this.ToolStripMenuItem_FoodAccepted.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_FoodRefused
            // 
            this.ToolStripMenuItem_FoodRefused.AccessibleDescription = null;
            this.ToolStripMenuItem_FoodRefused.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_FoodRefused, "ToolStripMenuItem_FoodRefused");
            this.ToolStripMenuItem_FoodRefused.BackgroundImage = null;
            this.ToolStripMenuItem_FoodRefused.CheckOnClick = true;
            this.ToolStripMenuItem_FoodRefused.Name = "ToolStripMenuItem_FoodRefused";
            this.ToolStripMenuItem_FoodRefused.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_FoodRefused.Tag = "FoodRefused";
            this.ToolStripMenuItem_FoodRefused.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.AccessibleDescription = null;
            this.ToolStripSeparator9.AccessibleName = null;
            resources.ApplyResources(this.ToolStripSeparator9, "ToolStripSeparator9");
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            // 
            // ToolStripMenuItem_IsFirstCall
            // 
            this.ToolStripMenuItem_IsFirstCall.AccessibleDescription = null;
            this.ToolStripMenuItem_IsFirstCall.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_IsFirstCall, "ToolStripMenuItem_IsFirstCall");
            this.ToolStripMenuItem_IsFirstCall.BackgroundImage = null;
            this.ToolStripMenuItem_IsFirstCall.CheckOnClick = true;
            this.ToolStripMenuItem_IsFirstCall.Name = "ToolStripMenuItem_IsFirstCall";
            this.ToolStripMenuItem_IsFirstCall.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_IsFirstCall.Tag = "IsFirstCall";
            this.ToolStripMenuItem_IsFirstCall.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_IsSecondCall
            // 
            this.ToolStripMenuItem_IsSecondCall.AccessibleDescription = null;
            this.ToolStripMenuItem_IsSecondCall.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_IsSecondCall, "ToolStripMenuItem_IsSecondCall");
            this.ToolStripMenuItem_IsSecondCall.BackgroundImage = null;
            this.ToolStripMenuItem_IsSecondCall.CheckOnClick = true;
            this.ToolStripMenuItem_IsSecondCall.Name = "ToolStripMenuItem_IsSecondCall";
            this.ToolStripMenuItem_IsSecondCall.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_IsSecondCall.Tag = "IsSecondCall";
            this.ToolStripMenuItem_IsSecondCall.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
            // 
            // ToolStripMenuItem_IsThirdCall
            // 
            this.ToolStripMenuItem_IsThirdCall.AccessibleDescription = null;
            this.ToolStripMenuItem_IsThirdCall.AccessibleName = null;
            resources.ApplyResources(this.ToolStripMenuItem_IsThirdCall, "ToolStripMenuItem_IsThirdCall");
            this.ToolStripMenuItem_IsThirdCall.BackgroundImage = null;
            this.ToolStripMenuItem_IsThirdCall.CheckOnClick = true;
            this.ToolStripMenuItem_IsThirdCall.Name = "ToolStripMenuItem_IsThirdCall";
            this.ToolStripMenuItem_IsThirdCall.ShortcutKeyDisplayString = null;
            this.ToolStripMenuItem_IsThirdCall.Tag = "IsThirdCall";
            this.ToolStripMenuItem_IsThirdCall.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_Condition_CheckedChanged);
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
            // ContextMenuStrip_EmoteTree
            // 
            this.ContextMenuStrip_EmoteTree.AccessibleDescription = null;
            this.ContextMenuStrip_EmoteTree.AccessibleName = null;
            resources.ApplyResources(this.ContextMenuStrip_EmoteTree, "ContextMenuStrip_EmoteTree");
            this.ContextMenuStrip_EmoteTree.BackgroundImage = null;
            this.ContextMenuStrip_EmoteTree.Font = null;
            this.ContextMenuStrip_EmoteTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.ContextMenuStrip_EmoteTree.Name = "ContextMenuStrip_EmoteTree";
            this.ToolTip_Help.SetToolTip(this.ContextMenuStrip_EmoteTree, resources.GetString("ContextMenuStrip_EmoteTree.ToolTip"));
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.AccessibleDescription = null;
            this.importToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            this.importToolStripMenuItem.BackgroundImage = null;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // ImageList_TreeView
            // 
            this.ImageList_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_TreeView.ImageStream")));
            this.ImageList_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_TreeView.Images.SetKeyName(0, "AddNode.gif");
            this.ImageList_TreeView.Images.SetKeyName(1, "AddChildNode.gif");
            this.ImageList_TreeView.Images.SetKeyName(2, "RemoveNode.gif");
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
            // MenuStrip
            // 
            this.MenuStrip.AccessibleDescription = null;
            this.MenuStrip.AccessibleName = null;
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.BackgroundImage = null;
            this.MenuStrip.Font = null;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.emoteToolStripMenuItem,
            this.conditionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.ToolTip_Help.SetToolTip(this.MenuStrip, resources.GetString("MenuStrip.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator10,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.AccessibleDescription = null;
            this.revertToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.revertToolStripMenuItem, "revertToolStripMenuItem");
            this.revertToolStripMenuItem.BackgroundImage = null;
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleDescription = null;
            this.saveToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.BackgroundImage = null;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.AccessibleDescription = null;
            this.toolStripSeparator10.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleDescription = null;
            this.editToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.BackgroundImage = null;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.AccessibleDescription = null;
            this.configurationToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.configurationToolStripMenuItem, "configurationToolStripMenuItem");
            this.configurationToolStripMenuItem.BackgroundImage = null;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // emoteToolStripMenuItem
            // 
            this.emoteToolStripMenuItem.AccessibleDescription = null;
            this.emoteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.emoteToolStripMenuItem, "emoteToolStripMenuItem");
            this.emoteToolStripMenuItem.BackgroundImage = null;
            this.emoteToolStripMenuItem.Name = "emoteToolStripMenuItem";
            this.emoteToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // conditionsToolStripMenuItem
            // 
            this.conditionsToolStripMenuItem.AccessibleDescription = null;
            this.conditionsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.conditionsToolStripMenuItem, "conditionsToolStripMenuItem");
            this.conditionsToolStripMenuItem.BackgroundImage = null;
            this.conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            this.conditionsToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.AccessibleDescription = null;
            this.toolsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.BackgroundImage = null;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = null;
            this.helpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.BackgroundImage = null;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // ContextMenuStrip_Configuration
            // 
            this.ContextMenuStrip_Configuration.AccessibleDescription = null;
            this.ContextMenuStrip_Configuration.AccessibleName = null;
            resources.ApplyResources(this.ContextMenuStrip_Configuration, "ContextMenuStrip_Configuration");
            this.ContextMenuStrip_Configuration.BackgroundImage = null;
            this.ContextMenuStrip_Configuration.Font = null;
            this.ContextMenuStrip_Configuration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petFamilyToolStripMenuItem,
            this.toolStripSeparator12,
            this.renameToolStripMenuItem,
            this.renameToFamilyToolStripMenuItem,
            this.toolStripSeparator13,
            this.deleteToolStripMenuItem});
            this.ContextMenuStrip_Configuration.Name = "ContextMenuStrip_Configuration";
            this.ToolTip_Help.SetToolTip(this.ContextMenuStrip_Configuration, resources.GetString("ContextMenuStrip_Configuration.ToolTip"));
            this.ContextMenuStrip_Configuration.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Configuration_Opening);
            // 
            // petFamilyToolStripMenuItem
            // 
            this.petFamilyToolStripMenuItem.AccessibleDescription = null;
            this.petFamilyToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.petFamilyToolStripMenuItem, "petFamilyToolStripMenuItem");
            this.petFamilyToolStripMenuItem.BackgroundImage = null;
            this.petFamilyToolStripMenuItem.Name = "petFamilyToolStripMenuItem";
            this.petFamilyToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.AccessibleDescription = null;
            this.toolStripSeparator12.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.AccessibleDescription = null;
            this.renameToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.BackgroundImage = null;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // renameToFamilyToolStripMenuItem
            // 
            this.renameToFamilyToolStripMenuItem.AccessibleDescription = null;
            this.renameToFamilyToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.renameToFamilyToolStripMenuItem, "renameToFamilyToolStripMenuItem");
            this.renameToFamilyToolStripMenuItem.BackgroundImage = null;
            this.renameToFamilyToolStripMenuItem.Name = "renameToFamilyToolStripMenuItem";
            this.renameToFamilyToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.renameToFamilyToolStripMenuItem.Click += new System.EventHandler(this.renameToFamilyToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.AccessibleDescription = null;
            this.toolStripSeparator13.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AccessibleDescription = null;
            this.deleteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.BackgroundImage = null;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButton_RemoveConfiguration_Click);
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.ToolStripContainer_EmoteEditing);
            this.Controls.Add(this.MenuStrip);
            this.Font = null;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.ToolTip_Help.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ToolStripContainer_EmoteEditing.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer_EmoteEditing.ResumeLayout(false);
            this.ToolStripContainer_EmoteEditing.PerformLayout();
            this.SplitContainer_LeftRight.Panel1.ResumeLayout(false);
            this.SplitContainer_LeftRight.Panel2.ResumeLayout(false);
            this.SplitContainer_LeftRight.ResumeLayout(false);
            this.ContextMenuStrip_ConfigurationsMenu.ResumeLayout(false);
            this.SplitContainer_TopBottom.Panel1.ResumeLayout(false);
            this.SplitContainer_TopBottom.Panel2.ResumeLayout(false);
            this.SplitContainer_TopBottom.ResumeLayout(false);
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
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.ContextMenuStrip_EmoteTree.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ContextMenuStrip_Configuration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView_DefaultEmotes;
        private System.Windows.Forms.ToolStrip ToolStrip_Main;
        private System.Windows.Forms.ToolStripButton ToolStipButton_Save;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.SplitContainer SplitContainer_TopBottom;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripButton ToolStripButton_RemoveConfiguration;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton_AddConfiguration;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_Independent;
        private System.Windows.Forms.ListView ListView_Output;
        private System.Windows.Forms.ColumnHeader ColumnHeader_EmoteText;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Condition;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton_Import;
        private System.Windows.Forms.ToolStripContainer ToolStripContainer_EmoteEditing;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AddNode;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AddChildNode;
        private System.Windows.Forms.ToolStripButton ToolStripButton_RemoveNode;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FoodAccepted;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FoodRefused;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_IsFirstCall;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_IsSecondCall;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_IsThirdCall;
        private System.Windows.Forms.NumericUpDown NumericUpDown_KeywordsMinLength;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.SplitContainer SplitContainer_LeftRight;
        private System.Windows.Forms.ListView ListView_Configurations;
        private System.Windows.Forms.ImageList ImageList_PetFamilies;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_EmoteTree;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_ConfigurationsMenu;
        private System.Windows.Forms.ToolStripMenuItem newConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Configuration;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem renameToFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton ToolStripButton_Revert;
    }
}

