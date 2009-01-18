using System;
using System.Globalization;
using System.Windows.Forms;
using PetEmote.Emotes;

namespace PetEmote.Forms
{
    partial class MainForm
    {
        private void FillConfigurationsMenu ()
        {
            foreach (EmoteConfiguration config in this.currentEmotes.EmoteConfigurations)
                this.ToolStripComboBox_Configuration.Items.Add(config);

            if (this.ToolStripComboBox_Configuration.Items.Count > 0)
                this.ToolStripComboBox_Configuration.SelectedIndex = 0;
        }

        private void FillAddConfigurationMenu ()
        {
            ToolStripMenuItem hunter = new ToolStripMenuItem("Jäger");
            hunter.Name = "ToolStripMenuItem_AddConfiguration_Hunter";
            hunter.Image = Icons.INV_Weapon_Bow_07;

            ToolStripMenuItem warlock = new ToolStripMenuItem("Hexenmeister");
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
            ToolStripMenuItem hunter = new ToolStripMenuItem("Jäger");
            hunter.Name = "ToolStripMenuItem_Import_Hunter";
            hunter.Image = Icons.INV_Weapon_Bow_07;

            ToolStripMenuItem warlock = new ToolStripMenuItem("Hexenmeister");
            warlock.Name = "ToolStripMenuItem_Import_Warlock";
            warlock.Image = Icons.Spell_Nature_Drowsy;

            this.ToolStripDropDownButton_Import.DropDownItems.Add(hunter);
            this.ToolStripDropDownButton_Import.DropDownItems.Add(warlock);

            foreach (EmoteConfiguration config in this.defaultEmotes.EmoteConfigurations)
            {
                if (config.IsCurrentLanguage)
                {
                    //config.PetFamily = new PetFamily(config.PetFamily.Name, config.PetFamily.FamilyType, config.PetFamily.ClassType, config.PetFamily.Language);

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
                this.AddTreeNode("Neues Emote").BeginEdit();
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
                    {
                        itemTypeChecked.Checked = true;
                        found = true;
                    }
                    else
                    {
                        itemTypeChecked.Checked = false;
                    }

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
    }
}
