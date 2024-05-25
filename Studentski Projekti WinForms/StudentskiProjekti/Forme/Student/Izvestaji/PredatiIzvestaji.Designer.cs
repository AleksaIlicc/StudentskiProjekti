namespace StudentskiProjekti.Forme
{
    partial class PredatiIzvestaji
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
			Izvestaji_GB = new GroupBox();
			Izvestaji_ListV = new ListView();
			columnHeader0 = new ColumnHeader();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			label5 = new Label();
			OstaliClanovi_Btn = new Button();
			Podaci_o_predmetimaGB = new GroupBox();
			IzmeniIzvestaj_Btn = new Button();
			DodajIzvestaj_Btn = new Button();
			ObrisiIzvestaj_Btn = new Button();
			NazivProj_LB = new Label();
			label7 = new Label();
			DatumPocIzrade_LB = new Label();
			label11 = new Label();
			DatumZavrIzrade_LB = new Label();
			label12 = new Label();
			UkupanBrIzvest_LB = new Label();
			UkupanBrIzPrikaz_LB = new Label();
			groupBox1 = new GroupBox();
			label6 = new Label();
			Smer_LB = new Label();
			Ime_LB = new Label();
			label10 = new Label();
			label13 = new Label();
			Prezime_LB = new Label();
			label15 = new Label();
			BrIndeksa_LB = new Label();
			Izvestaji_GB.SuspendLayout();
			Podaci_o_predmetimaGB.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// Izvestaji_GB
			// 
			Izvestaji_GB.Controls.Add(Izvestaji_ListV);
			Izvestaji_GB.Controls.Add(label5);
			Izvestaji_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Izvestaji_GB.Location = new System.Drawing.Point(6, 121);
			Izvestaji_GB.Name = "Izvestaji_GB";
			Izvestaji_GB.Size = new System.Drawing.Size(845, 278);
			Izvestaji_GB.TabIndex = 3;
			Izvestaji_GB.TabStop = false;
			Izvestaji_GB.Text = "Izvestaji";
			// 
			// Izvestaji_ListV
			// 
			Izvestaji_ListV.AccessibleRole = AccessibleRole.None;
			Izvestaji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2 });
			Izvestaji_ListV.FullRowSelect = true;
			Izvestaji_ListV.GridLines = true;
			Izvestaji_ListV.Location = new System.Drawing.Point(6, 45);
			Izvestaji_ListV.MultiSelect = false;
			Izvestaji_ListV.Name = "Izvestaji_ListV";
			Izvestaji_ListV.Size = new System.Drawing.Size(828, 226);
			Izvestaji_ListV.TabIndex = 0;
			Izvestaji_ListV.UseCompatibleStateImageBehavior = false;
			Izvestaji_ListV.View = View.Details;
			Izvestaji_ListV.DoubleClick += Izvestaji_ListV_DoubleClick;
			// 
			// columnHeader0
			// 
			columnHeader0.Text = "Opis";
			columnHeader0.Width = 390;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Datum predaje izvestaja";
			columnHeader1.TextAlign = HorizontalAlignment.Center;
			columnHeader1.Width = 160;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Vreme predaje u odnosu na pocetak projekta";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 270;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(6, 27);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(318, 15);
			label5.TabIndex = 10;
			label5.Text = "Duplim klikom na red mozete videti ceo opis izvestaja:";
			// 
			// OstaliClanovi_Btn
			// 
			OstaliClanovi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			OstaliClanovi_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			OstaliClanovi_Btn.Location = new System.Drawing.Point(660, 518);
			OstaliClanovi_Btn.Name = "OstaliClanovi_Btn";
			OstaliClanovi_Btn.Size = new System.Drawing.Size(180, 69);
			OstaliClanovi_Btn.TabIndex = 1;
			OstaliClanovi_Btn.Text = "Prikazi izvestaje koji su predali ostali clanovi grupe";
			OstaliClanovi_Btn.UseVisualStyleBackColor = false;
			OstaliClanovi_Btn.Click += OstaliClanovi_Btn_Click;
			// 
			// Podaci_o_predmetimaGB
			// 
			Podaci_o_predmetimaGB.Controls.Add(IzmeniIzvestaj_Btn);
			Podaci_o_predmetimaGB.Controls.Add(DodajIzvestaj_Btn);
			Podaci_o_predmetimaGB.Controls.Add(ObrisiIzvestaj_Btn);
			Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Podaci_o_predmetimaGB.Location = new System.Drawing.Point(12, 406);
			Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
			Podaci_o_predmetimaGB.Size = new System.Drawing.Size(167, 183);
			Podaci_o_predmetimaGB.TabIndex = 18;
			Podaci_o_predmetimaGB.TabStop = false;
			Podaci_o_predmetimaGB.Text = "Izmeni";
			// 
			// IzmeniIzvestaj_Btn
			// 
			IzmeniIzvestaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniIzvestaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniIzvestaj_Btn.Location = new System.Drawing.Point(19, 79);
			IzmeniIzvestaj_Btn.Name = "IzmeniIzvestaj_Btn";
			IzmeniIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
			IzmeniIzvestaj_Btn.TabIndex = 2;
			IzmeniIzvestaj_Btn.Text = "Izmeni izvestaj";
			IzmeniIzvestaj_Btn.UseVisualStyleBackColor = false;
			IzmeniIzvestaj_Btn.Click += IzmeniIzvestaj_Btn_Click;
			// 
			// DodajIzvestaj_Btn
			// 
			DodajIzvestaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajIzvestaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajIzvestaj_Btn.Location = new System.Drawing.Point(19, 32);
			DodajIzvestaj_Btn.Name = "DodajIzvestaj_Btn";
			DodajIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
			DodajIzvestaj_Btn.TabIndex = 1;
			DodajIzvestaj_Btn.Text = "Dodaj izvestaj";
			DodajIzvestaj_Btn.UseVisualStyleBackColor = false;
			DodajIzvestaj_Btn.Click += DodajIzvestaj_Btn_Click;
			// 
			// ObrisiIzvestaj_Btn
			// 
			ObrisiIzvestaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiIzvestaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiIzvestaj_Btn.Location = new System.Drawing.Point(19, 127);
			ObrisiIzvestaj_Btn.Name = "ObrisiIzvestaj_Btn";
			ObrisiIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
			ObrisiIzvestaj_Btn.TabIndex = 0;
			ObrisiIzvestaj_Btn.Text = "Obrisi izvestaj";
			ObrisiIzvestaj_Btn.UseVisualStyleBackColor = false;
			ObrisiIzvestaj_Btn.Click += ObrisiIzvestaj_Btn_Click;
			// 
			// NazivProj_LB
			// 
			NazivProj_LB.AutoSize = true;
			NazivProj_LB.Location = new System.Drawing.Point(122, 18);
			NazivProj_LB.Name = "NazivProj_LB";
			NazivProj_LB.Size = new System.Drawing.Size(0, 15);
			NazivProj_LB.TabIndex = 20;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(20, 18);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(96, 15);
			label7.TabIndex = 19;
			label7.Text = "Naziv projekta:";
			// 
			// DatumPocIzrade_LB
			// 
			DatumPocIzrade_LB.AutoSize = true;
			DatumPocIzrade_LB.Location = new System.Drawing.Point(193, 51);
			DatumPocIzrade_LB.Name = "DatumPocIzrade_LB";
			DatumPocIzrade_LB.Size = new System.Drawing.Size(0, 15);
			DatumPocIzrade_LB.TabIndex = 24;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(20, 51);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(167, 15);
			label11.TabIndex = 23;
			label11.Text = "Datum poc. izrade projekta:";
			// 
			// DatumZavrIzrade_LB
			// 
			DatumZavrIzrade_LB.AutoSize = true;
			DatumZavrIzrade_LB.Location = new System.Drawing.Point(517, 51);
			DatumZavrIzrade_LB.Name = "DatumZavrIzrade_LB";
			DatumZavrIzrade_LB.Size = new System.Drawing.Size(0, 15);
			DatumZavrIzrade_LB.TabIndex = 26;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(287, 51);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(179, 15);
			label12.TabIndex = 25;
			label12.Text = "Datum zavrs. izrade projekta:";
			// 
			// UkupanBrIzvest_LB
			// 
			UkupanBrIzvest_LB.AutoSize = true;
			UkupanBrIzvest_LB.Location = new System.Drawing.Point(287, 92);
			UkupanBrIzvest_LB.Name = "UkupanBrIzvest_LB";
			UkupanBrIzvest_LB.Size = new System.Drawing.Size(0, 15);
			UkupanBrIzvest_LB.TabIndex = 28;
			UkupanBrIzvest_LB.Visible = false;
			// 
			// UkupanBrIzPrikaz_LB
			// 
			UkupanBrIzPrikaz_LB.AutoSize = true;
			UkupanBrIzPrikaz_LB.Location = new System.Drawing.Point(20, 92);
			UkupanBrIzPrikaz_LB.Name = "UkupanBrIzPrikaz_LB";
			UkupanBrIzPrikaz_LB.Size = new System.Drawing.Size(261, 15);
			UkupanBrIzPrikaz_LB.TabIndex = 27;
			UkupanBrIzPrikaz_LB.Text = "Ukupan broj izvestaja koje je grupa predala:";
			UkupanBrIzPrikaz_LB.Visible = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(Smer_LB);
			groupBox1.Controls.Add(Ime_LB);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(Prezime_LB);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(BrIndeksa_LB);
			groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.Location = new System.Drawing.Point(287, 406);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(308, 183);
			groupBox1.TabIndex = 29;
			groupBox1.TabStop = false;
			groupBox1.Text = "Podaci o studentu";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(26, 107);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(57, 15);
			label6.TabIndex = 12;
			label6.Text = "Prezime:";
			// 
			// Smer_LB
			// 
			Smer_LB.AutoSize = true;
			Smer_LB.Location = new System.Drawing.Point(133, 138);
			Smer_LB.Name = "Smer_LB";
			Smer_LB.Size = new System.Drawing.Size(0, 15);
			Smer_LB.TabIndex = 15;
			// 
			// Ime_LB
			// 
			Ime_LB.AutoSize = true;
			Ime_LB.Location = new System.Drawing.Point(133, 78);
			Ime_LB.Name = "Ime_LB";
			Ime_LB.Size = new System.Drawing.Size(0, 15);
			Ime_LB.TabIndex = 17;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(26, 138);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(42, 15);
			label10.TabIndex = 11;
			label10.Text = "Smer:";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(26, 43);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(76, 15);
			label13.TabIndex = 9;
			label13.Text = "Br. indeksa:";
			// 
			// Prezime_LB
			// 
			Prezime_LB.AutoSize = true;
			Prezime_LB.Location = new System.Drawing.Point(133, 107);
			Prezime_LB.Name = "Prezime_LB";
			Prezime_LB.Size = new System.Drawing.Size(0, 15);
			Prezime_LB.TabIndex = 16;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(26, 78);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(33, 15);
			label15.TabIndex = 10;
			label15.Text = "Ime:";
			// 
			// BrIndeksa_LB
			// 
			BrIndeksa_LB.AutoSize = true;
			BrIndeksa_LB.Location = new System.Drawing.Point(133, 43);
			BrIndeksa_LB.Name = "BrIndeksa_LB";
			BrIndeksa_LB.Size = new System.Drawing.Size(0, 15);
			BrIndeksa_LB.TabIndex = 14;
			// 
			// PredatiIzvestaji
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(858, 595);
			Controls.Add(groupBox1);
			Controls.Add(Izvestaji_GB);
			Controls.Add(UkupanBrIzvest_LB);
			Controls.Add(UkupanBrIzPrikaz_LB);
			Controls.Add(DatumZavrIzrade_LB);
			Controls.Add(label12);
			Controls.Add(DatumPocIzrade_LB);
			Controls.Add(label11);
			Controls.Add(NazivProj_LB);
			Controls.Add(label7);
			Controls.Add(Podaci_o_predmetimaGB);
			Controls.Add(OstaliClanovi_Btn);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(874, 634);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(874, 634);
			Name = "PredatiIzvestaji";
			Text = "Izvestaji";
			Load += PredatiIzvestaji_Load;
			Izvestaji_GB.ResumeLayout(false);
			Izvestaji_GB.PerformLayout();
			Podaci_o_predmetimaGB.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox Izvestaji_GB;
        private ListView Izvestaji_ListV;
        private Button OstaliClanovi_Btn;
        private Label label5;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniIzvestaj_Btn;
        private Button DodajIzvestaj_Btn;
        private Button ObrisiIzvestaj_Btn;
        private ColumnHeader columnHeader1;
        private Label NazivProj_LB;
        private Label label7;
        private Label DatumPocIzrade_LB;
        private Label label11;
        private Label DatumZavrIzrade_LB;
        private Label label12;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader2;
        private Label UkupanBrIzvest_LB;
        private Label UkupanBrIzPrikaz_LB;
        private GroupBox groupBox1;
        private Label label6;
        private Label Smer_LB;
        private Label Ime_LB;
        private Label label10;
        private Label label13;
        private Label Prezime_LB;
        private Label label15;
        private Label BrIndeksa_LB;
    }
}