namespace StudentskiProjekti.Forme
{
	partial class AutoriLiterature
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
			Obrisi_Btn = new Button();
			Dodaj_Btn = new Button();
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
			// Obrisi_Btn
			// 
			Obrisi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Obrisi_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Obrisi_Btn.Location = new System.Drawing.Point(210, 282);
			Obrisi_Btn.Name = "Obrisi_Btn";
			Obrisi_Btn.Size = new System.Drawing.Size(114, 33);
			Obrisi_Btn.TabIndex = 1;
			Obrisi_Btn.Text = "Obrisi autora";
			Obrisi_Btn.UseVisualStyleBackColor = false;
			Obrisi_Btn.Click += Obrisi_Btn_Click;
			// 
			// Dodaj_Btn
			// 
			Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Dodaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Dodaj_Btn.Location = new System.Drawing.Point(90, 282);
			Dodaj_Btn.Name = "Dodaj_Btn";
			Dodaj_Btn.Size = new System.Drawing.Size(114, 33);
			Dodaj_Btn.TabIndex = 2;
			Dodaj_Btn.Text = "Dodaj autora";
			Dodaj_Btn.UseVisualStyleBackColor = false;
			Dodaj_Btn.Click += Dodaj_Btn_Click;
			// 
			// AutoriLiterature
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(339, 326);
			Controls.Add(Dodaj_Btn);
			Controls.Add(Obrisi_Btn);
			Controls.Add(Predmeti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(355, 365);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(355, 365);
			Name = "AutoriLiterature";
			Text = "Autori literature";
			Load += AutoriLiterature_Load;
			Predmeti_GB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private GroupBox Predmeti_GB;
		private ListView Nazivi_ListV;
		private ColumnHeader columnHeader4;
		private Button Obrisi_Btn;
		private Button Dodaj_Btn;
	}
}