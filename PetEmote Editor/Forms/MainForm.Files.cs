using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PetEmote.Forms
{
    partial class MainForm
    {
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
                MessageBox.Show("PetEmote wurde in Deinem AddOns-Verzeichnis nicht gefunden.\nDu musst PetEmote zunächst installieren, bevor du fortfahren kannst.", "PetEmote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            return dir;
        }

        private string GetPathFromSearchDialog()
        {
            try
            {
                if (MessageBox.Show("World of Warcraft wurde auf diesem PC nicht gefunden.\nBitte wähle Dein World of Warcraft Installationsverzeichnis manuell aus.", "PetEmote", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return null;
                if (this.folderBrowserDialog.ShowDialog(this) != DialogResult.OK) return null;
                return this.folderBrowserDialog.SelectedPath;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetPathFromRegistry()
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
    }
}
