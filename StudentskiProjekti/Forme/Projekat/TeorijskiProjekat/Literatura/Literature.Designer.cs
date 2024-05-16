namespace StudentskiProjekti.Forme
{
	partial class Literature
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
			Literature_GB = new GroupBox();
			label3 = new Label();
			label1 = new Label();
			Radovi_ListV = new ListView();
			columnHeader10 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			columnHeader12 = new ColumnHeader();
			columnHeader15 = new ColumnHeader();
			label2 = new Label();
			Knjige_ListV = new ListView();
			columnHeader13 = new ColumnHeader();
			columnHeader14 = new ColumnHeader();
			columnHeader16 = new ColumnHeader();
			columnHeader17 = new ColumnHeader();
			Clanci_ListV = new ListView();
			columnHeader3 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader18 = new ColumnHeader();
			IzmeniKnjigu_GB = new GroupBox();
			IzmeniKnjigu_Btn = new Button();
			DodajKnjigu_Btn = new Button();
			ObrisiKnjigu_Btn = new Button();
			IzmeniRad_GB = new GroupBox();
			IzmeniRad_Btn = new Button();
			DodajRad_Btn = new Button();
			ObrisiRad_Btn = new Button();
			IzmeniClanak_GB = new GroupBox();
			IzmeniClanak_Btn = new Button();
			DodajClanak_Btn = new Button();
			ObrisiClanak_Btn = new Button();
			button1 = new Button();
			Literature_GB.SuspendLayout();
			IzmeniKnjigu_GB.SuspendLayout();
			IzmeniRad_GB.SuspendLayout();
			IzmeniClanak_GB.SuspendLayout();
			SuspendLayout();
			// 
			// Literature_GB
			// 
			Literature_GB.Controls.Add(button1);
			Literature_GB.Controls.Add(label3);
			Literature_GB.Controls.Add(label1);
			Literature_GB.Controls.Add(Radovi_ListV);
			Literature_GB.Controls.Add(label2);
			Literature_GB.Controls.Add(Knjige_ListV);
			Literature_GB.Controls.Add(Clanci_ListV);
			Literature_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Literature_GB.Location = new System.Drawing.Point(12, 12);
			Literature_GB.Name = "Literature_GB";
			Literature_GB.Size = new System.Drawing.Size(785, 567);
			Literature_GB.TabIndex = 3;
			Literature_GB.TabStop = false;
			Literature_GB.Text = "Literatura:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(12, 27);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(48, 15);
			label3.TabIndex = 5;
			label3.Text = "Knjige:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 197);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(125, 15);
			label1.TabIndex = 3;
			label1.Text = "Clanci u casopisima:";
			// 
			// Radovi_ListV
			// 
			Radovi_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12, columnHeader15 });
			Radovi_ListV.FullRowSelect = true;
			Radovi_ListV.GridLines = true;
			Radovi_ListV.Location = new System.Drawing.Point(6, 382);
			Radovi_ListV.MultiSelect = false;
			Radovi_ListV.Name = "Radovi_ListV";
			Radovi_ListV.Size = new System.Drawing.Size(773, 139);
			Radovi_ListV.TabIndex = 1;
			Radovi_ListV.UseCompatibleStateImageBehavior = false;
			Radovi_ListV.View = View.Details;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Naziv";
			columnHeader10.TextAlign = HorizontalAlignment.Center;
			columnHeader10.Width = 250;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "URL";
			columnHeader11.TextAlign = HorizontalAlignment.Center;
			columnHeader11.Width = 222;
			// 
			// columnHeader12
			// 
			columnHeader12.Text = "Format";
			columnHeader12.TextAlign = HorizontalAlignment.Center;
			columnHeader12.Width = 75;
			// 
			// columnHeader15
			// 
			columnHeader15.Text = "Konferencija objavljivanja";
			columnHeader15.TextAlign = HorizontalAlignment.Center;
			columnHeader15.Width = 220;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(12, 364);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(51, 15);
			label2.TabIndex = 4;
			label2.Text = "Radovi:";
			// 
			// Knjige_ListV
			// 
			Knjige_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader16, columnHeader17 });
			Knjige_ListV.FullRowSelect = true;
			Knjige_ListV.GridLines = true;
			Knjige_ListV.Location = new System.Drawing.Point(6, 45);
			Knjige_ListV.MultiSelect = false;
			Knjige_ListV.Name = "Knjige_ListV";
			Knjige_ListV.Size = new System.Drawing.Size(773, 139);
			Knjige_ListV.TabIndex = 0;
			Knjige_ListV.UseCompatibleStateImageBehavior = false;
			Knjige_ListV.View = View.Details;
			// 
			// columnHeader13
			// 
			columnHeader13.Text = "ISBN";
			columnHeader13.Width = 100;
			// 
			// columnHeader14
			// 
			columnHeader14.Text = "Naziv";
			columnHeader14.TextAlign = HorizontalAlignment.Center;
			columnHeader14.Width = 350;
			// 
			// columnHeader16
			// 
			columnHeader16.Text = "Izdavac";
			columnHeader16.TextAlign = HorizontalAlignment.Center;
			columnHeader16.Width = 200;
			// 
			// columnHeader17
			// 
			columnHeader17.Text = "Godina izdavanja";
			columnHeader17.TextAlign = HorizontalAlignment.Center;
			columnHeader17.Width = 113;
			// 
			// Clanci_ListV
			// 
			Clanci_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader7, columnHeader8, columnHeader18 });
			Clanci_ListV.FullRowSelect = true;
			Clanci_ListV.GridLines = true;
			Clanci_ListV.Location = new System.Drawing.Point(6, 215);
			Clanci_ListV.MultiSelect = false;
			Clanci_ListV.Name = "Clanci_ListV";
			Clanci_ListV.Size = new System.Drawing.Size(773, 139);
			Clanci_ListV.TabIndex = 2;
			Clanci_ListV.UseCompatibleStateImageBehavior = false;
			Clanci_ListV.View = View.Details;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "ISSN";
			columnHeader3.Width = 100;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Naziv clanka";
			columnHeader6.TextAlign = HorizontalAlignment.Center;
			columnHeader6.Width = 270;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Naziv casopisa";
			columnHeader7.TextAlign = HorizontalAlignment.Center;
			columnHeader7.Width = 258;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Broj";
			columnHeader8.TextAlign = HorizontalAlignment.Center;
			columnHeader8.Width = 70;
			// 
			// columnHeader18
			// 
			columnHeader18.Text = "Godina";
			columnHeader18.TextAlign = HorizontalAlignment.Center;
			columnHeader18.Width = 70;
			// 
			// IzmeniKnjigu_GB
			// 
			IzmeniKnjigu_GB.Controls.Add(IzmeniKnjigu_Btn);
			IzmeniKnjigu_GB.Controls.Add(DodajKnjigu_Btn);
			IzmeniKnjigu_GB.Controls.Add(ObrisiKnjigu_Btn);
			IzmeniKnjigu_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniKnjigu_GB.Location = new System.Drawing.Point(91, 585);
			IzmeniKnjigu_GB.Name = "IzmeniKnjigu_GB";
			IzmeniKnjigu_GB.Size = new System.Drawing.Size(202, 164);
			IzmeniKnjigu_GB.TabIndex = 4;
			IzmeniKnjigu_GB.TabStop = false;
			IzmeniKnjigu_GB.Text = "Izmeni - Knjige";
			// 
			// IzmeniKnjigu_Btn
			// 
			IzmeniKnjigu_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniKnjigu_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniKnjigu_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniKnjigu_Btn.Name = "IzmeniKnjigu_Btn";
			IzmeniKnjigu_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniKnjigu_Btn.TabIndex = 3;
			IzmeniKnjigu_Btn.Text = "Izmeni knjigu";
			IzmeniKnjigu_Btn.UseVisualStyleBackColor = false;
			IzmeniKnjigu_Btn.Click += IzmeniKnjigu_Btn_Click;
			// 
			// DodajKnjigu_Btn
			// 
			DodajKnjigu_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajKnjigu_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajKnjigu_Btn.Location = new System.Drawing.Point(34, 26);
			DodajKnjigu_Btn.Name = "DodajKnjigu_Btn";
			DodajKnjigu_Btn.Size = new System.Drawing.Size(132, 33);
			DodajKnjigu_Btn.TabIndex = 2;
			DodajKnjigu_Btn.Text = "Dodaj knjigu";
			DodajKnjigu_Btn.UseVisualStyleBackColor = false;
			DodajKnjigu_Btn.Click += DodajKnjigu_Btn_Click;
			// 
			// ObrisiKnjigu_Btn
			// 
			ObrisiKnjigu_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiKnjigu_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiKnjigu_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiKnjigu_Btn.Name = "ObrisiKnjigu_Btn";
			ObrisiKnjigu_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiKnjigu_Btn.TabIndex = 4;
			ObrisiKnjigu_Btn.Text = "Obrisi knjigu";
			ObrisiKnjigu_Btn.UseVisualStyleBackColor = false;
			ObrisiKnjigu_Btn.Click += ObrisiKnjigu_Btn_Click;
			// 
			// IzmeniRad_GB
			// 
			IzmeniRad_GB.Controls.Add(IzmeniRad_Btn);
			IzmeniRad_GB.Controls.Add(DodajRad_Btn);
			IzmeniRad_GB.Controls.Add(ObrisiRad_Btn);
			IzmeniRad_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniRad_GB.Location = new System.Drawing.Point(507, 585);
			IzmeniRad_GB.Name = "IzmeniRad_GB";
			IzmeniRad_GB.Size = new System.Drawing.Size(202, 164);
			IzmeniRad_GB.TabIndex = 5;
			IzmeniRad_GB.TabStop = false;
			IzmeniRad_GB.Text = "Izmeni - Radovi";
			// 
			// IzmeniRad_Btn
			// 
			IzmeniRad_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniRad_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniRad_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniRad_Btn.Name = "IzmeniRad_Btn";
			IzmeniRad_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniRad_Btn.TabIndex = 3;
			IzmeniRad_Btn.Text = "Izmeni rad";
			IzmeniRad_Btn.UseVisualStyleBackColor = false;
			IzmeniRad_Btn.Click += IzmeniRad_Btn_Click;
			// 
			// DodajRad_Btn
			// 
			DodajRad_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajRad_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajRad_Btn.Location = new System.Drawing.Point(34, 26);
			DodajRad_Btn.Name = "DodajRad_Btn";
			DodajRad_Btn.Size = new System.Drawing.Size(132, 33);
			DodajRad_Btn.TabIndex = 2;
			DodajRad_Btn.Text = "Dodaj rad";
			DodajRad_Btn.UseVisualStyleBackColor = false;
			DodajRad_Btn.Click += DodajRad_Btn_Click;
			// 
			// ObrisiRad_Btn
			// 
			ObrisiRad_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiRad_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiRad_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiRad_Btn.Name = "ObrisiRad_Btn";
			ObrisiRad_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiRad_Btn.TabIndex = 4;
			ObrisiRad_Btn.Text = "Obrisi rad";
			ObrisiRad_Btn.UseVisualStyleBackColor = false;
			ObrisiRad_Btn.Click += ObrisiRad_Btn_Click;
			// 
			// IzmeniClanak_GB
			// 
			IzmeniClanak_GB.Controls.Add(IzmeniClanak_Btn);
			IzmeniClanak_GB.Controls.Add(DodajClanak_Btn);
			IzmeniClanak_GB.Controls.Add(ObrisiClanak_Btn);
			IzmeniClanak_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniClanak_GB.Location = new System.Drawing.Point(299, 585);
			IzmeniClanak_GB.Name = "IzmeniClanak_GB";
			IzmeniClanak_GB.Size = new System.Drawing.Size(202, 164);
			IzmeniClanak_GB.TabIndex = 6;
			IzmeniClanak_GB.TabStop = false;
			IzmeniClanak_GB.Text = "Izmeni - Clanci u casopisu";
			// 
			// IzmeniClanak_Btn
			// 
			IzmeniClanak_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniClanak_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniClanak_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniClanak_Btn.Name = "IzmeniClanak_Btn";
			IzmeniClanak_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniClanak_Btn.TabIndex = 3;
			IzmeniClanak_Btn.Text = "Izmeni clanak";
			IzmeniClanak_Btn.UseVisualStyleBackColor = false;
			IzmeniClanak_Btn.Click += IzmeniClanak_Btn_Click;
			// 
			// DodajClanak_Btn
			// 
			DodajClanak_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajClanak_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajClanak_Btn.Location = new System.Drawing.Point(34, 26);
			DodajClanak_Btn.Name = "DodajClanak_Btn";
			DodajClanak_Btn.Size = new System.Drawing.Size(132, 33);
			DodajClanak_Btn.TabIndex = 2;
			DodajClanak_Btn.Text = "Dodaj clanak";
			DodajClanak_Btn.UseVisualStyleBackColor = false;
			DodajClanak_Btn.Click += DodajClanak_Btn_Click;
			// 
			// ObrisiClanak_Btn
			// 
			ObrisiClanak_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiClanak_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiClanak_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiClanak_Btn.Name = "ObrisiClanak_Btn";
			ObrisiClanak_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiClanak_Btn.TabIndex = 4;
			ObrisiClanak_Btn.Text = "Obrisi clanak";
			ObrisiClanak_Btn.UseVisualStyleBackColor = false;
			ObrisiClanak_Btn.Click += ObrisiClanak_Btn_Click;
			// 
			// button1
			// 
			button1.BackColor = System.Drawing.Color.AntiqueWhite;
			button1.Font = new System.Drawing.Font("Georgia", 9F);
			button1.Location = new System.Drawing.Point(611, 527);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(168, 33);
			button1.TabIndex = 6;
			button1.Text = "Prikazi autore literature";
			button1.UseVisualStyleBackColor = false;
			// 
			// Literature
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(805, 761);
			Controls.Add(IzmeniClanak_GB);
			Controls.Add(IzmeniRad_GB);
			Controls.Add(IzmeniKnjigu_GB);
			Controls.Add(Literature_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(821, 800);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(821, 800);
			Name = "Literature";
			Text = "Preporucena literatura";
			Load += Literature_Load;
			Literature_GB.ResumeLayout(false);
			Literature_GB.PerformLayout();
			IzmeniKnjigu_GB.ResumeLayout(false);
			IzmeniRad_GB.ResumeLayout(false);
			IzmeniClanak_GB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox Literature_GB;
		private ListView Knjige_ListV;
		private GroupBox IzmeniKnjigu_GB;
		private Button IzmeniKnjigu_Btn;
		private Button DodajKnjigu_Btn;
		private Button ObrisiKnjigu_Btn;
        private ListView Radovi_ListV;
        private ListView Clanci_ListV;
        private GroupBox IzmeniRad_GB;
        private Button IzmeniRad_Btn;
        private Button DodajRad_Btn;
        private Button ObrisiRad_Btn;
        private GroupBox IzmeniClanak_GB;
        private Button IzmeniClanak_Btn;
        private Button DodajClanak_Btn;
        private Button ObrisiClanak_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader15;
		private Button button1;
	}
}