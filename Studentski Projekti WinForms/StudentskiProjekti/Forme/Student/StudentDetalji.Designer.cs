namespace StudentskiProjekti.Forme
{
	partial class StudentDetalji
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
            StudentDetalji_GB = new GroupBox();
            StudentDetalji_ListV = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Ucesce_Btn = new Button();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniUcesce_Btn = new Button();
            DodajUcesce_Btn = new Button();
            ObrisiUcesce_Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BrIndeksa_LB = new Label();
            Smer_LB = new Label();
            Prezime_LB = new Label();
            Ime_LB = new Label();
            groupBox1 = new GroupBox();
            StudentDetalji_GB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDetalji_GB
            // 
            StudentDetalji_GB.Controls.Add(StudentDetalji_ListV);
            StudentDetalji_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StudentDetalji_GB.Location = new System.Drawing.Point(8, 12);
            StudentDetalji_GB.Name = "StudentDetalji_GB";
            StudentDetalji_GB.Size = new System.Drawing.Size(777, 385);
            StudentDetalji_GB.TabIndex = 0;
            StudentDetalji_GB.TabStop = false;
            StudentDetalji_GB.Text = "Projekti na kojima radi:";
            // 
            // StudentDetalji_ListV
            // 
            StudentDetalji_ListV.AccessibleRole = AccessibleRole.None;
            StudentDetalji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader3, columnHeader6, columnHeader7, columnHeader8, columnHeader1, columnHeader2 });
            StudentDetalji_ListV.FullRowSelect = true;
            StudentDetalji_ListV.GridLines = true;
            StudentDetalji_ListV.Location = new System.Drawing.Point(6, 44);
            StudentDetalji_ListV.MultiSelect = false;
            StudentDetalji_ListV.Name = "StudentDetalji_ListV";
            StudentDetalji_ListV.Size = new System.Drawing.Size(760, 335);
            StudentDetalji_ListV.TabIndex = 0;
            StudentDetalji_ListV.UseCompatibleStateImageBehavior = false;
            StudentDetalji_ListV.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Predmet";
            columnHeader4.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 240;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Datum poc. izrade";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum zavr. izrade";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Rok za zavrsetak";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Projekat zavrsen";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Vrsta projekta";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // Ucesce_Btn
            // 
            Ucesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Ucesce_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Ucesce_Btn.Location = new System.Drawing.Point(604, 517);
            Ucesce_Btn.Name = "Ucesce_Btn";
            Ucesce_Btn.Size = new System.Drawing.Size(170, 69);
            Ucesce_Btn.TabIndex = 2;
            Ucesce_Btn.Text = "Prikazi vise\r\ninformacija o ucescu";
            Ucesce_Btn.UseVisualStyleBackColor = false;
            Ucesce_Btn.Click += Ucesce_Btn_Click;
            // 
            // Podaci_o_predmetimaGB
            // 
            Podaci_o_predmetimaGB.Controls.Add(IzmeniUcesce_Btn);
            Podaci_o_predmetimaGB.Controls.Add(DodajUcesce_Btn);
            Podaci_o_predmetimaGB.Controls.Add(ObrisiUcesce_Btn);
            Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(8, 403);
            Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
            Podaci_o_predmetimaGB.Size = new System.Drawing.Size(177, 182);
            Podaci_o_predmetimaGB.TabIndex = 1;
            Podaci_o_predmetimaGB.TabStop = false;
            Podaci_o_predmetimaGB.Text = "Izmeni ucesce";
            // 
            // IzmeniUcesce_Btn
            // 
            IzmeniUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            IzmeniUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            IzmeniUcesce_Btn.Location = new System.Drawing.Point(15, 85);
            IzmeniUcesce_Btn.Name = "IzmeniUcesce_Btn";
            IzmeniUcesce_Btn.Size = new System.Drawing.Size(146, 38);
            IzmeniUcesce_Btn.TabIndex = 1;
            IzmeniUcesce_Btn.Text = "Izmeni ucesce";
            IzmeniUcesce_Btn.UseVisualStyleBackColor = false;
            IzmeniUcesce_Btn.Click += IzmeniUcesce_Btn_Click;
            // 
            // DodajUcesce_Btn
            // 
            DodajUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodajUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            DodajUcesce_Btn.Location = new System.Drawing.Point(15, 41);
            DodajUcesce_Btn.Name = "DodajUcesce_Btn";
            DodajUcesce_Btn.Size = new System.Drawing.Size(146, 38);
            DodajUcesce_Btn.TabIndex = 0;
            DodajUcesce_Btn.Text = "Dodaj novo ucesce";
            DodajUcesce_Btn.UseVisualStyleBackColor = false;
            DodajUcesce_Btn.Click += DodajUcesce_Btn_Click;
            // 
            // ObrisiUcesce_Btn
            // 
            ObrisiUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiUcesce_Btn.Location = new System.Drawing.Point(15, 129);
            ObrisiUcesce_Btn.Name = "ObrisiUcesce_Btn";
            ObrisiUcesce_Btn.Size = new System.Drawing.Size(146, 38);
            ObrisiUcesce_Btn.TabIndex = 2;
            ObrisiUcesce_Btn.Text = "Obrisi ucesce";
            ObrisiUcesce_Btn.UseVisualStyleBackColor = false;
            ObrisiUcesce_Btn.Click += ObrisiUcesce_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Br. indeksa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Smer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Prezime:";
            // 
            // BrIndeksa_LB
            // 
            BrIndeksa_LB.AutoSize = true;
            BrIndeksa_LB.Location = new System.Drawing.Point(133, 43);
            BrIndeksa_LB.Name = "BrIndeksa_LB";
            BrIndeksa_LB.Size = new System.Drawing.Size(0, 15);
            BrIndeksa_LB.TabIndex = 14;
            // 
            // Smer_LB
            // 
            Smer_LB.AutoSize = true;
            Smer_LB.Location = new System.Drawing.Point(133, 138);
            Smer_LB.Name = "Smer_LB";
            Smer_LB.Size = new System.Drawing.Size(0, 15);
            Smer_LB.TabIndex = 15;
            // 
            // Prezime_LB
            // 
            Prezime_LB.AutoSize = true;
            Prezime_LB.Location = new System.Drawing.Point(133, 107);
            Prezime_LB.Name = "Prezime_LB";
            Prezime_LB.Size = new System.Drawing.Size(0, 15);
            Prezime_LB.TabIndex = 16;
            // 
            // Ime_LB
            // 
            Ime_LB.AutoSize = true;
            Ime_LB.Location = new System.Drawing.Point(133, 78);
            Ime_LB.Name = "Ime_LB";
            Ime_LB.Size = new System.Drawing.Size(0, 15);
            Ime_LB.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Smer_LB);
            groupBox1.Controls.Add(Ime_LB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Prezime_LB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BrIndeksa_LB);
            groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(251, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(308, 182);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o studentu";
            // 
            // StudentDetalji
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(795, 598);
            Controls.Add(groupBox1);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Ucesce_Btn);
            Controls.Add(StudentDetalji_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(811, 637);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(811, 637);
            Name = "StudentDetalji";
            Text = "Student detalji";
            Load += StudentDetalji_Load;
            StudentDetalji_GB.ResumeLayout(false);
            Podaci_o_predmetimaGB.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentDetalji_GB;
		private ListView StudentDetalji_ListV;
		private Button Ucesce_Btn;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniUcesce_Btn;
        private Button DodajUcesce_Btn;
        private Button ObrisiUcesce_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label BrIndeksa_LB;
        private Label Smer_LB;
        private Label Prezime_LB;
        private Label Ime_LB;
        private ColumnHeader columnHeader2;
		private GroupBox groupBox1;
        private ColumnHeader columnHeader4;
    }
}