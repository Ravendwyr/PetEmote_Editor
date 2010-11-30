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
	/// <summary>
	/// Das Hauptformular des PetEmote-Editors.
	/// </summary>
	public partial class MainForm : Form
	{
		private DefaultEmotes defaultEmotes;
		private CustomEmotes customEmotes;
		private Emotes currentEmotes;
		private EmoteConfiguration currentEmoteConfiguration;
		private TreeView currentTreeView;

		/// <summary>
		/// Erzeugt eine neue Instanz des Hauptformulars.
		/// </summary>
		/// <param name="arguments">Die Startparameter der Anwendung.</param>
		public MainForm(params string[] arguments) : base()
		{
			this.Arguments = arguments;
			this.InitializeComponent();
		}

		/// <summary>
		/// Bietet Zugriff auf die Startparameter der Anwendung.
		/// </summary>
		public string[] Arguments { get; private set; }

		/// <summary>
		/// Gibt an, ob der Editor statt den benutzerspezifischen Emotes die Standard-Emotes laden soll.
		/// </summary>
		public bool EditsDefaultEmotes
		{
			get { return this.Arguments.Select(a => a.TrimStart(new char[] { '/', '-' })).Contains("default"); }
		}

		/// <summary>
		/// Gibt eine Auflistung der ToolStripItems zurück, die zur
		/// Ausführung keine aktive Emote-Konfiguration benötigen.
		/// </summary>
		private IEnumerable<ToolStripItem> ToolStripItemsThatNeedNoActiveConfiguration
		{
			get
			{
				yield return this.ToolStripButton_Save;
				yield return this.ToolStripButton_Revert;
				yield return this.ToolStripDropDownButton_AddConfiguration;
			}
		}

		/// <summary>
		/// Gibt eine Auflistung der ToolStripItems zurück,
		/// die zur Ausführung kein aktives Emote benötigen.
		/// </summary>
		private IEnumerable<ToolStripItem> ToolStripItemsThatNeedNoActiveEmote
		{
			get
			{
				foreach (var item in this.ToolStripItemsThatNeedNoActiveConfiguration)
					yield return item;

				yield return this.ToolStripButton_RemoveConfiguration;
				yield return this.ToolStripDropDownButton_Import;
				yield return this.ToolStripButton_AddNode;
			}
		}

		/// <summary>
		/// Aktiviert oder deaktiviert beliebige ToolStripItems.
		/// </summary>
		/// <param name="enabled">Ein Wert, der angibt, ob die ToolStripItems aktiviert oder deaktiviert werden sollen.</param>
		/// <param name="items">Eine Auflistung beliebig vieler ToolStripItems, die aktiviert oder deaktiviert werden sollen.</param>
		private void EnableToolStripItems (bool enabled, params ToolStripItem[] items)
		{
			foreach (ToolStripItem item in items)
				item.Enabled = enabled;
		}

		/// <summary>
		/// Aktiviert oder deaktiviert alle ToolStripItems eines ToolStrips.
		/// </summary>
		/// <param name="enabled">Ein Wert, der angibt, ob die ToolStripItems aktiviert oder deaktiviert werden sollen.</param>
		/// <param name="toolStrip">Der ToolStrip, dessen Items aktiviert oder deaktiviert werden sollen.</param>
		private void EnableToolStripItems (bool enabled, ToolStrip toolStrip)
		{
			this.EnableToolStripItems(enabled, toolStrip.Items.OfType<ToolStripItem>().ToArray());
		}

		/// <summary>
		/// Aktiviert alle ToolStripItems eines ToolStrips mit Ausnahme bestimmter Items.
		/// </summary>
		/// <param name="toolStrip">Der ToolStrip, dessen Items alle aktiviert werden sollen.</param>
		/// <param name="exceptItems">Die Items des ToolStrips, die deaktiviert werden sollen.</param>
		private void EnableItemsOfToolStripExcept (ToolStrip toolStrip, params ToolStripItem[] exceptItems)
		{
			this.EnableToolStripItems(true, toolStrip);
			this.EnableToolStripItems(false, exceptItems);
		}

		/// <summary>
		/// Deaktiviert alle ToolStripItems eines ToolStrips mit Ausnahme bestimmter Items.
		/// </summary>
		/// <param name="toolStrip">Der ToolStrip, dessen Items alle deaktiviert werden sollen.</param>
		/// <param name="exceptItems">Die Items des ToolStrips, die aktiviert werden sollen.</param>
		private void DisableItemsOfToolStripExcept (ToolStrip toolStrip, params ToolStripItem[] exceptItems)
		{
			this.EnableToolStripItems(false, toolStrip);
			this.EnableToolStripItems(true, exceptItems);
		}

		private void Save ()
		{
			if (this.currentEmoteConfiguration != null)
			{
				this.currentEmoteConfiguration.DefaultEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_DefaultEmotes.Nodes).ToList();
				this.currentEmoteConfiguration.CombatEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_CombatEmotes.Nodes).ToList();
				this.currentEmoteConfiguration.FeedingEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_FeedingEmotes.Nodes).ToList();
			}

			this.currentEmotes.EmoteConfigurations.Clear();

			foreach (ListViewItem item in this.ListView_Configurations.Items) {
				this.currentEmotes.EmoteConfigurations.Add((EmoteConfiguration)item.Tag);
			}

			// Speichern (xml)
			while (!this.currentEmotes.Save()) {
				if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) != DialogResult.Retry)
					break;
			}

			// Exportieren (lua)
			while (!this.currentEmotes.Export(this.currentEmotes.GetType() == typeof(DefaultEmotes))) {
				if (MessageBox.Show(Resources.Message_SavingFailed, Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation) != DialogResult.Retry)
					break;
			}
		}

		/// <summary>
		/// Lädt die Emote-Konfigurationen zur Bearbeitung neu.
		/// </summary>
		private void Revert ()
		{
			this.UnloadConfigurations();

			DirectoryInfo directory = this.GetPetEmoteDirectory();

			if (directory == null)
			{
				Application.Exit();
				return;
			}

			this.defaultEmotes = new DefaultEmotes(directory);
			this.customEmotes = new CustomEmotes(directory);

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

			this.currentEmotes = this.EditsDefaultEmotes ? (Emotes)this.defaultEmotes : (Emotes)this.customEmotes;

			this.FillConfigurationsMenu();
			this.FillImportMenu();
		}

		private void SelectFirstConfiguration ()
		{
			if (this.ListView_Configurations.Items.Count == 0) return;

			foreach (ListViewGroup group in this.ListView_Configurations.Groups)
			{
				var configurations = this.ListView_Configurations.Items.OfType<ListViewItem>().Where(i => i.Group == group);

				if (configurations.Count() > 0)
				{
					configurations.First().Selected = true;
					break;
				}
			}
		}

		/// <summary>
		/// Ermittelt das Verzeichnis, in dem PetEmote installiert ist.
		/// </summary>
		/// <returns>
		/// Ein Verweis auf das Verzeichnis, in dem PetEmote installiert
		/// ist, oder null, wenn es nicht ermittelt werden konnte.
		/// </returns>
		private DirectoryInfo GetPetEmoteDirectory ()
		{
			string path = this.GetPathFromRegistry();

			if (path == null || !Directory.Exists(path))
			{
				path = this.GetPathFromSettings();

				if (path == null || !Directory.Exists(path))
				{
					path = this.GetPathFromSearchDialog();

					if (path == null || !Directory.Exists(path))
					{
						return null;
					}
				}
			}

			Properties.Settings.Default.WorldOfWarcraftDirectory = path;

			DirectoryInfo directory = new DirectoryInfo(Path.Combine(path, @"Interface\AddOns\PetEmote"));

			if (!directory.Exists)
			{
				MessageBox.Show(Resources.Message_PetEmoteNotFound, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return null;
			}

			return directory;
		}

		/// <summary>
		/// Fragt den Pfad zum World-of-Warcraft-Verzeichnis über einen Verzeichnis-Dialog vom Benutzer ab.
		/// </summary>
		/// <returns>Der Pfad zum World-of-Warcraft-Verzeichnis oder null, wenn er nicht angegeben wurde.</returns>
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

		/// <summary>
		/// List den Pfad zum World-of-Warcraft-Verzeichnis aus der Registry aus.
		/// </summary>
		/// <returns>Der Pfad zum World-of-Warcraft-Verzeichnis oder null, wenn er nicht ermittelt werden konnte.</returns>
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

		/// <summary>
		/// List den Pfad zum World-of-Warcraft-Verzeichnis aus den Einstellungen aus.
		/// </summary>
		/// <returns>Der Pfad zum World-of-Warcraft-Verzeichnis oder null, wenn er nicht ermittelt werden konnte.</returns>
		private string GetPathFromSettings ()
		{
			try
			{
				string path = Properties.Settings.Default.WorldOfWarcraftDirectory;
				if (path.Trim().Length == 0) return null;
				DirectoryInfo directory = new DirectoryInfo(path);
				return directory.FullName;
			}
			catch (Exception)
			{
				return null;
			}
		}

		private void FillConfigurationsMenu ()
		{
			foreach (EmoteConfiguration config in this.currentEmotes.EmoteConfigurations.OrderBy(c => c.Name))
			{
				ListViewItem item = new ListViewItem(config.Name);
				item.ImageIndex = IconFactory.GetPetFamilyIconIndex(config.PetFamily.FamilyType);
				item.Group = this.ListView_Configurations.Groups[String.Format("ListViewGroup_{0}_{1}", config.PetFamily.ClassType, config.PetFamily.Language)];
				item.Tag = config;
				this.ListView_Configurations.Items.Add(item);
			}

			this.SelectFirstConfiguration();
		}

		private void FillAddConfigurationMenu (ToolStripItemCollection containerItem, EventHandler eventHandler)
		{
			var families =
				from family in this.defaultEmotes.PetFamilies
				where family.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName
				group family by family.ClassType into classGroup
				select classGroup;

			foreach (var classGroup in families)
			{
				ToolStripMenuItem menuItem = new ToolStripMenuItem(Resources.ResourceManager.GetString("ClassName_" + classGroup.Key.ToString()));
				menuItem.Name = "ToolStripMenuItem_AddConfiguration_" + classGroup.Key.ToString();
				menuItem.Image = IconFactory.GetClassIcon(classGroup.Key);
				containerItem.Add(menuItem);

				foreach (PetFamily family in classGroup)
				{
					ToolStripMenuItem familyItem = new ToolStripMenuItem(family.Name);

					familyItem.Name = "ToolStripMenuItem_AddConfiguration_" + family.Name.GetHashCode().ToString();
					familyItem.Image = IconFactory.GetPetFamilyIcon(family.FamilyType);
					familyItem.Tag = family;
					familyItem.Click += eventHandler;

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

			foreach (var classGroup in configurations)
			{
				ToolStripMenuItem menuItem = new ToolStripMenuItem(Resources.ResourceManager.GetString("ClassName_" + classGroup.Key.ToString()));
				menuItem.Name = "ToolStripMenuItem_Import_" + classGroup.Key.ToString();
				menuItem.Image = IconFactory.GetClassIcon(classGroup.Key);
				this.ToolStripDropDownButton_Import.DropDownItems.Add(menuItem);

				foreach (EmoteConfiguration config in classGroup)
				{
					ToolStripMenuItem familyItem = new ToolStripMenuItem(config.Name);

					familyItem.Name = "ToolStripMenuItem_Import_" + config.Name.GetHashCode().ToString();
					familyItem.Image = IconFactory.GetPetFamilyIcon(config.PetFamily.FamilyType);
					familyItem.Tag = config;
					familyItem.Click += new EventHandler(this.ToolStripMenuItem_Import_Click);

					menuItem.DropDownItems.Add(familyItem);
				}
			}
		}

		private void HandleConfigurationSelection (string text, PetFamily family)
		{
			if (text == String.Empty) return;

			ListViewItem foundItem = null;
			if (this.ListView_Configurations.Items.Count > 0)
				foundItem = this.ListView_Configurations.FindItemWithText(text, false, 0);

			if (foundItem != null) {
				foundItem.Selected = true;
			}
			else
			{
				ListViewItem newItem = new ListViewItem()
				{
					Text = text,
					ImageIndex = IconFactory.GetPetFamilyIconIndex(family.FamilyType),
					Group = this.ListView_Configurations.Groups[String.Format("ListViewGroup_{0}_{1}", family.ClassType, family.Language)],
					Tag = new EmoteConfiguration(text, family)
				};

				this.ListView_Configurations.Items.Add(newItem);

				newItem.Selected = true;

				if (this.defaultEmotes.HasConfigurationForPetFamily(family.FamilyType, family.Language)) {
					this.ToolStripDropDownButton_Import.Select();
				} else {
					this.ToolStripButton_AddNode.Select();
				}
			}
		}

		private void UnloadConfigurations ()
		{
			this.ListView_Configurations.Items.Clear();
			this.ClearTreeViews();
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
			node.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(emoteNode.ChildNodes).ToArray());

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
			node.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(emoteNode.ChildNodes).ToArray());

			parentNode.Nodes.Add(node);

			return node;
		}

		private void AddTreeNodeRange (ref TreeView treeView, List<EmoteNode> emoteNodeSet)
		{
			treeView.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(emoteNodeSet).ToArray());
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

		/// <summary>
		/// Gibt einen Emote-TreeNode im EmoteOutput-Control aus.
		/// </summary>
		/// <param name="treeNode">Der TreeNode, der ausgegeben werden soll.</param>
		private void ShowEmoteOutputByTreeNode (TreeNode treeNode)
		{
			EmoteNode emoteNode = TreeNodeConverter.TreeNodeToEmoteNode(treeNode);

			// Das hier ist nur eine Notlösung, um beim Markieren eines untergeordneten Emotes
			// trotzdem den kompletten Emote-Text zu sehen. Besser wäre es, wenn beim Flachklopfen
			// des EmoteNodes die übergeordneten Emotes berücksichtigt werden könnten (nur fraglich,
			// ob das dann dort sinnvoll wäre). Wichtig wäre dann auch, die Properties der
			// übergeordneten Emotes zu bekommen, weil die im Moment gar nicht übergeben werden
			// können. Deshalb werden die Bedingungen erst ab dem markierten Emote angezeigt.
			if (treeNode.Parent != null) {
				emoteNode.Text = treeNode.Parent.FullPath + " " + emoteNode.Text;
			}

			this.EmoteOutput.PetName = this.currentEmoteConfiguration.Name;
			this.EmoteOutput.Clear();
			this.EmoteOutput.AddEmoteNode(emoteNode);
		}

		private void MainForm_Load (object sender, EventArgs e)
		{
			this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];

			this.Revert();

			this.FillAddConfigurationMenu(this.ToolStripDropDownButton_AddConfiguration.DropDownItems, new EventHandler(this.ToolStripMenuItem_AddConfiguration_Click));
			this.FillAddConfigurationMenu(this.newConfigurationToolStripMenuItem.DropDownItems, new EventHandler(this.ToolStripMenuItem_AddConfiguration_Click));
			this.FillAddConfigurationMenu(this.petFamilyToolStripMenuItem.DropDownItems, new EventHandler(this.ToolStripMenuItem_SetPetFamily_Click));

			this.DisableItemsOfToolStripExcept(
				this.ToolStrip_Main,
				this.ToolStripItemsThatNeedNoActiveConfiguration.ToArray()
			);

			if (this.ListView_Configurations.Items.Count == 0) {
				this.ToolStripDropDownButton_AddConfiguration.Select();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}

		private void TabControl_EmoteConfigurations_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.currentTreeView = (TreeView)this.TabControl_EmoteConfigurations.SelectedTab.Controls[0];

			if (this.currentTreeView.Nodes.Count > 0) {
				this.EnableToolStripItems(true, this.ToolStrip_Main);
			}
			else {
				this.DisableItemsOfToolStripExcept(
					this.ToolStrip_Main,
					this.ToolStripItemsThatNeedNoActiveEmote.ToArray()
				);
			}
		}

		private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			EmoteNodeProperties properties = (EmoteNodeProperties)e.Node.Tag;

			this.ToolStripMenuItem_MustContinue.Checked = properties.MustContinue;
			this.ToolStripMenuItem_MustContinue.Enabled = e.Node.Nodes.Count > 0;

			this.ToolStripComboBox_Chance.Text = properties.Chance.ToString();
			this.TextBox_Keywords.Text = String.Join(" ", properties.Keywords);

			this.EnableToolStripItems(true, this.ToolStrip_Main);
			this.SetSelectedMenuItem(this.ToolStripMenuItem_Conditions.DropDownItems, properties.Condition.ToString());

			this.ShowEmoteOutputByTreeNode(e.Node);
		}

		private void TreeView_AfterLabelEdit (object sender, NodeLabelEditEventArgs e)
		{
			if (e.Label != null && (this.CheckBox_KeywordsAutoFill.Checked || this.TextBox_Keywords.Text.Length == 0))
			{
				EmoteNodeProperties properties = new EmoteNodeProperties();
				properties.ImportKeywords(e.Label, (int)this.NumericUpDown_KeywordsMinLength.Value);
				this.TextBox_Keywords.Text = String.Join(" ", properties.Keywords);
			}
		}

		private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
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

		private void TreeView_DragOver(object sender, DragEventArgs e)
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

		private void TreeView_DragDrop(object sender, DragEventArgs e)
		{
			TreeView tree = (TreeView)sender;

			Point pt = tree.PointToClient(new Point(e.X, e.Y));

			TreeNode node = tree.GetNodeAt(pt);

			if (node != null) {
				node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
				node.Expand();
			}
			else {
				tree.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
			}

			if (e.Effect == DragDropEffects.Move)
				tree.SelectedNode.Remove();

			tree.SelectedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
		}

		private void CheckBox_KeywordsAutoFill_CheckedChanged(object sender, EventArgs e)
		{
			this.TextBox_Keywords.Enabled = !this.CheckBox_KeywordsAutoFill.Checked;
		}

		private void TextBox_Keywords_TextChanged(object sender, EventArgs e)
		{
			if (this.currentTreeView.SelectedNode == null) return;
			EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
			config.ImportKeywords(this.TextBox_Keywords.Text);
		}

		private void ToolStripButton_Save_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		private void ToolStripMenuItem_Revert_Click (object sender, EventArgs e)
		{
			this.Revert();
		}

		private void ListView_Configurations_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count != 1)
			{
				this.ListView_Configurations.ContextMenuStrip = this.ContextMenuStrip_ConfigurationsMenu;

				if (this.currentEmoteConfiguration != null)
				{
					this.currentEmoteConfiguration.DefaultEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_DefaultEmotes.Nodes).ToList();
					this.currentEmoteConfiguration.CombatEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_CombatEmotes.Nodes).ToList();
					this.currentEmoteConfiguration.FeedingEmotes = TreeNodeConverter.TreeNodeCollectionToEmoteNodes(this.TreeView_FeedingEmotes.Nodes).ToList();
				}

				this.currentEmoteConfiguration = null;
				this.ClearTreeViews();
				this.DisableItemsOfToolStripExcept(
					this.ToolStrip_Main,
					this.ToolStripItemsThatNeedNoActiveConfiguration.ToArray()
				);
			}
			else
			{
				this.ListView_Configurations.ContextMenuStrip = this.ContextMenuStrip_Configuration;
				this.currentEmoteConfiguration = (EmoteConfiguration)this.ListView_Configurations.SelectedItems[0].Tag;
				this.ClearTreeViews();
				this.DisableItemsOfToolStripExcept(
					this.ToolStrip_Main,
					this.ToolStripItemsThatNeedNoActiveEmote.ToArray()
				);

				this.TreeView_DefaultEmotes.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(this.currentEmoteConfiguration.DefaultEmotes).ToArray());
				this.TreeView_CombatEmotes.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(this.currentEmoteConfiguration.CombatEmotes).ToArray());
				this.TreeView_FeedingEmotes.Nodes.AddRange(TreeNodeConverter.EmoteNodesToTreeNodes(this.currentEmoteConfiguration.FeedingEmotes).ToArray());
			}
		}

		private void ToolStripButton_RemoveConfiguration_Click(object sender, EventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count == 1)
			{
				if (MessageBox.Show(Resources.Message_ConfirmDeleteConfiguration, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
				this.ListView_Configurations.SelectedItems[0].Remove();
				this.ClearTreeViews();
				this.SelectFirstConfiguration();
			}
		}

		private void ToolStripTextBox_Independent_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.HandleConfigurationSelection(this.ToolStripTextBox_Independent.Text, new PetFamily());
				this.ToolStripDropDownButton_AddConfiguration.HideDropDown();
			}
		}

		private void ToolStripMenuItem_AddConfiguration_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
			this.HandleConfigurationSelection(menuItem.Text, (PetFamily)menuItem.Tag);
		}

		private void ToolStripMenuItem_SetPetFamily_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

			if (this.ListView_Configurations.SelectedItems.Count == 1)
			{
				ListViewItem listViewItem = this.ListView_Configurations.SelectedItems[0];
				EmoteConfiguration config = (EmoteConfiguration)listViewItem.Tag;
				config.PetFamily = (PetFamily)menuItem.Tag;
				listViewItem.ImageIndex = IconFactory.GetPetFamilyIconIndex(config.PetFamily.FamilyType);
				listViewItem.Group = this.ListView_Configurations.Groups[String.Format("ListViewGroup_{0}_{1}", config.PetFamily.ClassType, config.PetFamily.Language)];
			}
		}

		private void ToolStripMenuItem_Import_Click(object sender, EventArgs e)
		{
			if (this.currentEmoteConfiguration == null) return;

			ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
			EmoteConfiguration config = (EmoteConfiguration)menuItem.Tag;

			this.AddTreeNodeRange(ref this.TreeView_DefaultEmotes, config.DefaultEmotes);
			this.AddTreeNodeRange(ref this.TreeView_CombatEmotes, config.CombatEmotes);
			this.AddTreeNodeRange(ref this.TreeView_FeedingEmotes, config.FeedingEmotes);
		}

		private void ToolStripButton_AddNode_Click(object sender, EventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count != 1) return;
			this.currentTreeView.SelectedNode = this.AddTreeNode(Resources.Other_NewEmote);
			this.currentTreeView.SelectedNode.BeginEdit();
		}

		private void ToolStripButton_AddChildNode_Click(object sender, EventArgs e)
		{
			if (this.currentTreeView.SelectedNode == null) return;
			this.currentTreeView.SelectedNode = this.AddTreeNode(Resources.Other_NewSubordinaryEmote, this.currentTreeView.SelectedNode);
			this.currentTreeView.SelectedNode.BeginEdit();
		}

		private void ToolStripButton_RemoveNode_Click(object sender, EventArgs e)
		{
			if (this.currentTreeView.SelectedNode == null) return;

			this.currentTreeView.SelectedNode.Remove();

			if (this.currentTreeView.Nodes.Count == 0) {
				this.DisableItemsOfToolStripExcept(
					this.ToolStrip_Main,
					this.ToolStripItemsThatNeedNoActiveEmote.ToArray()
				);
			}
		}

		private void ToolStripMenuItem_MustContinue_CheckedChanged(object sender, EventArgs e)
		{
			if (this.currentTreeView.SelectedNode == null) return;
			EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;
			config.MustContinue = this.ToolStripMenuItem_MustContinue.Checked;
		}

		private void ToolStripMenuItem_Condition_CheckedChanged(object sender, EventArgs e)
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

		private void ToolStripComboBox_Chance_TextChanged(object sender, EventArgs e)
		{
			if (this.currentTreeView.SelectedNode == null) return;
			EmoteNodeProperties config = (EmoteNodeProperties)this.currentTreeView.SelectedNode.Tag;

			try {
				config.Chance = int.Parse(this.ToolStripComboBox_Chance.Text);
			}
			catch (FormatException) { }
		}

		private void ToolStripMenuItem_Rename_Click (object sender, EventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count == 1)
				this.ListView_Configurations.SelectedItems[0].BeginEdit();
		}

		private void ListView_Configurations_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			ListView control = (ListView)sender;
			EmoteConfiguration config = (EmoteConfiguration)control.Items[e.Item].Tag;
			config.Name = e.Label;
		}

		private void ToolStripMenuItem_RenameToFamily_Click (object sender, EventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count == 1)
			{
				ListViewItem item = this.ListView_Configurations.SelectedItems[0];
				EmoteConfiguration config = (EmoteConfiguration)item.Tag;
				config.Name = item.Text = config.PetFamily.Name;
			}
		}

		private void ContextMenuStrip_Configuration_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.ListView_Configurations.SelectedItems.Count == 1)
			{
				ListViewItem item = this.ListView_Configurations.SelectedItems[0];
				EmoteConfiguration config = (EmoteConfiguration)item.Tag;
				this.petFamilyToolStripMenuItem.Image = IconFactory.GetPetFamilyIcon(config.PetFamily.FamilyType);
			}
		}
	}
}