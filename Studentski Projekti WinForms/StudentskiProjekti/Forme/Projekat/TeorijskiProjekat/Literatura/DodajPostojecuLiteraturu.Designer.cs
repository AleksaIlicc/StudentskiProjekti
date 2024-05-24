namespace StudentskiProjekti.Forme
{
	partial class DodajPostojecuLiteraturu
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
			PrikaziAutore_Btn = new Button();
			Literature_ListV = new ListView();
			columnHeader14 = new ColumnHeader();
			ObrisiSvaPojavljivanja_Btn = new Button();
			DodajLiteratureZaProjekat_Btn = new Button();
			Pretraga_TB = new TextBox();
			Pretrazi_Btn = new Button();
			groupBox1 = new GroupBox();
			Ocisti_Btn = new Button();
			Literature_GB.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// Literature_GB
			// 
			Literature_GB.Controls.Add(PrikaziAutore_Btn);
			Literature_GB.Controls.Add(Literature_ListV);
			Literature_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Literature_GB.Location = new System.Drawing.Point(7, 12);
			Literature_GB.Name = "Literature_GB";
			Literature_GB.Size = new System.Drawing.Size(589, 539);
			Literature_GB.TabIndex = 0;
			Literature_GB.TabStop = false;
			Literature_GB.Text = "Literature:";
			// 
			// PrikaziAutore_Btn
			// 
			PrikaziAutore_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			PrikaziAutore_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			PrikaziAutore_Btn.Location = new System.Drawing.Point(425, 502);
			PrikaziAutore_Btn.Name = "PrikaziAutore_Btn";
			PrikaziAutore_Btn.Size = new System.Drawing.Size(158, 31);
			PrikaziAutore_Btn.TabIndex = 4;
			PrikaziAutore_Btn.Text = "Prikazi autore literature";
			PrikaziAutore_Btn.UseVisualStyleBackColor = false;
			PrikaziAutore_Btn.Click += PrikaziAutore_Btn_Click;
			// 
			// Literature_ListV
			// 
			Literature_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader14 });
			Literature_ListV.FullRowSelect = true;
			Literature_ListV.GridLines = true;
			Literature_ListV.Location = new System.Drawing.Point(5, 20);
			Literature_ListV.Name = "Literature_ListV";
			Literature_ListV.Size = new System.Drawing.Size(578, 476);
			Literature_ListV.TabIndex = 1;
			Literature_ListV.UseCompatibleStateImageBehavior = false;
			Literature_ListV.View = View.Details;
			// 
			// columnHeader14
			// 
			columnHeader14.Text = "Naziv";
			columnHeader14.TextAlign = HorizontalAlignment.Center;
			columnHeader14.Width = 550;
			// 
			// ObrisiSvaPojavljivanja_Btn
			// 
			ObrisiSvaPojavljivanja_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiSvaPojavljivanja_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiSvaPojavljivanja_Btn.Location = new System.Drawing.Point(12, 601);
			ObrisiSvaPojavljivanja_Btn.Name = "ObrisiSvaPojavljivanja_Btn";
			ObrisiSvaPojavljivanja_Btn.Size = new System.Drawing.Size(140, 59);
			ObrisiSvaPojavljivanja_Btn.TabIndex = 2;
			ObrisiSvaPojavljivanja_Btn.Text = "Obrisi sva pojavljivanja literature";
			ObrisiSvaPojavljivanja_Btn.UseVisualStyleBackColor = false;
			ObrisiSvaPojavljivanja_Btn.Click += ObrisiSvaPojavljivanja_Btn_Click;
			// 
			// DodajLiteratureZaProjekat_Btn
			// 
			DodajLiteratureZaProjekat_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajLiteratureZaProjekat_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			DodajLiteratureZaProjekat_Btn.Location = new System.Drawing.Point(449, 601);
			DodajLiteratureZaProjekat_Btn.Name = "DodajLiteratureZaProjekat_Btn";
			DodajLiteratureZaProjekat_Btn.Size = new System.Drawing.Size(140, 59);
			DodajLiteratureZaProjekat_Btn.TabIndex = 3;
			DodajLiteratureZaProjekat_Btn.Text = "Dodaj literaturu/e za projekat";
			DodajLiteratureZaProjekat_Btn.UseVisualStyleBackColor = false;
			DodajLiteratureZaProjekat_Btn.Click += DodajLiteratureZaProjekat_Btn_Click;
			// 
			// Pretraga_TB
			// 
			Pretraga_TB.Location = new System.Drawing.Point(6, 19);
			Pretraga_TB.Name = "Pretraga_TB";
			Pretraga_TB.Size = new System.Drawing.Size(221, 21);
			Pretraga_TB.TabIndex = 4;
			// 
			// Pretrazi_Btn
			// 
			Pretrazi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Pretrazi_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Pretrazi_Btn.Location = new System.Drawing.Point(119, 52);
			Pretrazi_Btn.Name = "Pretrazi_Btn";
			Pretrazi_Btn.Size = new System.Drawing.Size(77, 30);
			Pretrazi_Btn.TabIndex = 5;
			Pretrazi_Btn.Text = "Pretrazi";
			Pretrazi_Btn.UseVisualStyleBackColor = false;
			Pretrazi_Btn.Click += Pretrazi_Btn_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Ocisti_Btn);
			groupBox1.Controls.Add(Pretrazi_Btn);
			groupBox1.Controls.Add(Pretraga_TB);
			groupBox1.Location = new System.Drawing.Point(184, 578);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(233, 88);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			// 
			// Ocisti_Btn
			// 
			Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Ocisti_Btn.Location = new System.Drawing.Point(36, 52);
			Ocisti_Btn.Name = "Ocisti_Btn";
			Ocisti_Btn.Size = new System.Drawing.Size(77, 30);
			Ocisti_Btn.TabIndex = 6;
			Ocisti_Btn.Text = "Ocisti";
			Ocisti_Btn.UseVisualStyleBackColor = false;
			Ocisti_Btn.Click += Ocisti_Btn_Click;
			// 
			// DodajPostojecuLiteraturu
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(601, 672);
			Controls.Add(groupBox1);
			Controls.Add(DodajLiteratureZaProjekat_Btn);
			Controls.Add(ObrisiSvaPojavljivanja_Btn);
			Controls.Add(Literature_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "DodajPostojecuLiteraturu";
			Text = " ";
			Load += DodajPostojecuLiteraturu_Load;
			Literature_GB.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox Literature_GB;
        private ListView Literature_ListV;
        private Button ObrisiSvaPojavljivanja_Btn;
        private ColumnHeader columnHeader14;
        private Button PrikaziAutore_Btn;
        private Button DodajLiteratureZaProjekat_Btn;
        private TextBox Pretraga_TB;
        private Button Pretrazi_Btn;
        private GroupBox groupBox1;
		private Button Ocisti_Btn;
	}
}