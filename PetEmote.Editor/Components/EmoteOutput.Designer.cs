namespace PetEmote.Editor.Components
{
	partial class EmoteOutput
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmoteOutput));
			this.ListView = new System.Windows.Forms.ListView();
			this.ColumnHeader_EmoteText = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader_Condition = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// ListView
			// 
			this.ListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_EmoteText,
            this.ColumnHeader_Condition});
			resources.ApplyResources(this.ListView, "ListView");
			this.ListView.FullRowSelect = true;
			this.ListView.GridLines = true;
			this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView.Name = "ListView";
			this.ListView.ShowItemToolTips = true;
			this.ListView.UseCompatibleStateImageBehavior = false;
			this.ListView.View = System.Windows.Forms.View.Details;
			// 
			// ColumnHeader_EmoteText
			// 
			resources.ApplyResources(this.ColumnHeader_EmoteText, "ColumnHeader_EmoteText");
			// 
			// ColumnHeader_Condition
			// 
			resources.ApplyResources(this.ColumnHeader_Condition, "ColumnHeader_Condition");
			// 
			// EmoteOutput
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ListView);
			this.Name = "EmoteOutput";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView ListView;
		private System.Windows.Forms.ColumnHeader ColumnHeader_EmoteText;
		private System.Windows.Forms.ColumnHeader ColumnHeader_Condition;
	}
}
