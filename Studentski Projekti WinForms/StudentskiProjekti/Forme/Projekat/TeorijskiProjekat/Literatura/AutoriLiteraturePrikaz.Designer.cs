namespace StudentskiProjekti.Forme
{
	partial class AutoriLiteraturePrikaz
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Predmeti_GB = new GroupBox();
			Nazivi_ListV = new ListView();
			columnHeader4 = new ColumnHeader();
			Predmeti_GB.SuspendLayout();
			SuspendLayout();
			// 
			// Predmeti_GB
			// 
			Predmeti_GB.Controls.Add(Nazivi_ListV);
			Predmeti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Predmeti_GB.Location = new System.Drawing.Point(12, 12);
			Predmeti_GB.Name = "Predmeti_GB";
			Predmeti_GB.Size = new System.Drawing.Size(318, 264);
			Predmeti_GB.TabIndex = 0;
			Predmeti_GB.TabStop = false;
			Predmeti_GB.Text = "Spisak autora";
			// 
			// Nazivi_ListV
			// 
			Nazivi_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
			Nazivi_ListV.FullRowSelect = true;
			Nazivi_ListV.GridLines = true;
			Nazivi_ListV.Location = new System.Drawing.Point(6, 33);
			Nazivi_ListV.MultiSelect = false;
			Nazivi_ListV.Name = "Nazivi_ListV";
			Nazivi_ListV.Size = new System.Drawing.Size(306, 223);
			Nazivi_ListV.TabIndex = 0;
			Nazivi_ListV.UseCompatibleStateImageBehavior = false;
			Nazivi_ListV.View = View.Details;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Autor";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 300;
			// 
			// AutoriLiteraturePrikaz
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(339, 286);
			Controls.Add(Predmeti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(355, 325);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(355, 325);
			Name = "AutoriLiteraturePrikaz";
			Text = "Autori literature";
			Load += AutoriLiteraturePrikaz_Load;
			Predmeti_GB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private GroupBox Predmeti_GB;
		private ListView Nazivi_ListV;
		private ColumnHeader columnHeader4;
	}
}