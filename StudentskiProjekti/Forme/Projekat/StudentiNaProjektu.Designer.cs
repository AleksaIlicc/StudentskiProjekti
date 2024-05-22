namespace StudentskiProjekti.Forme
{
    partial class StudentiNaProjektu
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
            Studenti_GB = new GroupBox();
            SkolskaGodZad_LB = new Label();
            label8 = new Label();
            Naziv_LB = new Label();
            label5 = new Label();
            TipProj_LB = new Label();
            Studenti_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            Prikaz_GB = new GroupBox();
            Smer_TB = new TextBox();
            label4 = new Label();
            Prezime_TB = new TextBox();
            label3 = new Label();
            Ocisti_Btn = new Button();
            Sortiraj_Btn = new Button();
            label2 = new Label();
            label1 = new Label();
            BrojIndeksa_TB = new TextBox();
            Ime_TB = new TextBox();
            Excel_Btn = new Button();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniUcesce_Btn = new Button();
            DodajUcesce_Btn = new Button();
            ObrisiUcesce_Btn = new Button();
            DodatnaLit_Izvestaji_Btn = new Button();
            Studenti_GB.SuspendLayout();
            Prikaz_GB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            SuspendLayout();
            // 
            // Studenti_GB
            // 
            Studenti_GB.Controls.Add(SkolskaGodZad_LB);
            Studenti_GB.Controls.Add(label8);
            Studenti_GB.Controls.Add(Naziv_LB);
            Studenti_GB.Controls.Add(label5);
            Studenti_GB.Controls.Add(TipProj_LB);
            Studenti_GB.Controls.Add(Studenti_ListV);
            Studenti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Studenti_GB.Location = new System.Drawing.Point(8, 12);
            Studenti_GB.Name = "Studenti_GB";
            Studenti_GB.Size = new System.Drawing.Size(732, 416);
            Studenti_GB.TabIndex = 4;
            Studenti_GB.TabStop = false;
            Studenti_GB.Text = "Studenti";
            // 
            // SkolskaGodZad_LB
            // 
            SkolskaGodZad_LB.AutoSize = true;
            SkolskaGodZad_LB.Location = new System.Drawing.Point(157, 61);
            SkolskaGodZad_LB.Name = "SkolskaGodZad_LB";
            SkolskaGodZad_LB.Size = new System.Drawing.Size(0, 15);
            SkolskaGodZad_LB.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 61);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(144, 15);
            label8.TabIndex = 14;
            label8.Text = "Skolska god. zadavanja:";
            // 
            // Naziv_LB
            // 
            Naziv_LB.AutoSize = true;
            Naziv_LB.Location = new System.Drawing.Point(157, 28);
            Naziv_LB.Name = "Naziv_LB";
            Naziv_LB.Size = new System.Drawing.Size(0, 15);
            Naziv_LB.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 15);
            label5.TabIndex = 12;
            label5.Text = "Naziv projekta:";
            // 
            // TipProj_LB
            // 
            TipProj_LB.AutoSize = true;
            TipProj_LB.Location = new System.Drawing.Point(4, 98);
            TipProj_LB.Name = "TipProj_LB";
            TipProj_LB.Size = new System.Drawing.Size(0, 15);
            TipProj_LB.TabIndex = 11;
            // 
            // Studenti_ListV
            // 
            Studenti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            Studenti_ListV.FullRowSelect = true;
            Studenti_ListV.GridLines = true;
            Studenti_ListV.Location = new System.Drawing.Point(7, 125);
            Studenti_ListV.MultiSelect = false;
            Studenti_ListV.Name = "Studenti_ListV";
            Studenti_ListV.Size = new System.Drawing.Size(719, 285);
            Studenti_ListV.TabIndex = 0;
            Studenti_ListV.UseCompatibleStateImageBehavior = false;
            Studenti_ListV.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Broj indeksa";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ime roditelja";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prezime";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Smer";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 215;
            // 
            // Prikaz_GB
            // 
            Prikaz_GB.Controls.Add(Smer_TB);
            Prikaz_GB.Controls.Add(label4);
            Prikaz_GB.Controls.Add(Prezime_TB);
            Prikaz_GB.Controls.Add(label3);
            Prikaz_GB.Controls.Add(Ocisti_Btn);
            Prikaz_GB.Controls.Add(Sortiraj_Btn);
            Prikaz_GB.Controls.Add(label2);
            Prikaz_GB.Controls.Add(label1);
            Prikaz_GB.Controls.Add(BrojIndeksa_TB);
            Prikaz_GB.Controls.Add(Ime_TB);
            Prikaz_GB.Location = new System.Drawing.Point(244, 434);
            Prikaz_GB.Name = "Prikaz_GB";
            Prikaz_GB.Size = new System.Drawing.Size(283, 175);
            Prikaz_GB.TabIndex = 1;
            Prikaz_GB.TabStop = false;
            Prikaz_GB.Text = "Prikaz";
            // 
            // Smer_TB
            // 
            Smer_TB.Location = new System.Drawing.Point(164, 102);
            Smer_TB.Name = "Smer_TB";
            Smer_TB.Size = new System.Drawing.Size(108, 21);
            Smer_TB.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 15);
            label4.TabIndex = 13;
            label4.Text = "Unesite smer:";
            // 
            // Prezime_TB
            // 
            Prezime_TB.Location = new System.Drawing.Point(164, 77);
            Prezime_TB.Name = "Prezime_TB";
            Prezime_TB.Size = new System.Drawing.Size(108, 21);
            Prezime_TB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 15);
            label3.TabIndex = 11;
            label3.Text = "Unesite prezime:";
            // 
            // Ocisti_Btn
            // 
            Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Ocisti_Btn.Location = new System.Drawing.Point(145, 140);
            Ocisti_Btn.Name = "Ocisti_Btn";
            Ocisti_Btn.Size = new System.Drawing.Size(61, 23);
            Ocisti_Btn.TabIndex = 4;
            Ocisti_Btn.Text = "Ocisti";
            Ocisti_Btn.UseVisualStyleBackColor = false;
            Ocisti_Btn.Click += Ocisti_Btn_Click;
            // 
            // Sortiraj_Btn
            // 
            Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Sortiraj_Btn.Location = new System.Drawing.Point(211, 140);
            Sortiraj_Btn.Name = "Sortiraj_Btn";
            Sortiraj_Btn.Size = new System.Drawing.Size(61, 23);
            Sortiraj_Btn.TabIndex = 5;
            Sortiraj_Btn.Text = "Sortiraj";
            Sortiraj_Btn.UseVisualStyleBackColor = false;
            Sortiraj_Btn.Click += Sortiraj_Btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Unesite ime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 15);
            label1.TabIndex = 10;
            label1.Text = "Unesite broj indeksa:";
            // 
            // BrojIndeksa_TB
            // 
            BrojIndeksa_TB.Location = new System.Drawing.Point(164, 26);
            BrojIndeksa_TB.Name = "BrojIndeksa_TB";
            BrojIndeksa_TB.Size = new System.Drawing.Size(108, 21);
            BrojIndeksa_TB.TabIndex = 1;
            // 
            // Ime_TB
            // 
            Ime_TB.Location = new System.Drawing.Point(164, 52);
            Ime_TB.Name = "Ime_TB";
            Ime_TB.Size = new System.Drawing.Size(108, 21);
            Ime_TB.TabIndex = 1;
            // 
            // Excel_Btn
            // 
            Excel_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Excel_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Excel_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            Excel_Btn.Location = new System.Drawing.Point(578, 549);
            Excel_Btn.Name = "Excel_Btn";
            Excel_Btn.Size = new System.Drawing.Size(156, 59);
            Excel_Btn.TabIndex = 3;
            Excel_Btn.Text = "Snimi studente u \r\nExcel tabelu";
            Excel_Btn.UseVisualStyleBackColor = false;
            Excel_Btn.Click += Excel_Btn_Click;
            // 
            // Podaci_o_predmetimaGB
            // 
            Podaci_o_predmetimaGB.Controls.Add(IzmeniUcesce_Btn);
            Podaci_o_predmetimaGB.Controls.Add(DodajUcesce_Btn);
            Podaci_o_predmetimaGB.Controls.Add(ObrisiUcesce_Btn);
            Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(15, 434);
            Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
            Podaci_o_predmetimaGB.Size = new System.Drawing.Size(177, 175);
            Podaci_o_predmetimaGB.TabIndex = 9;
            Podaci_o_predmetimaGB.TabStop = false;
            Podaci_o_predmetimaGB.Text = "Izmeni ucesce";
            // 
            // IzmeniUcesce_Btn
            // 
            IzmeniUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            IzmeniUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            IzmeniUcesce_Btn.Location = new System.Drawing.Point(15, 74);
            IzmeniUcesce_Btn.Name = "IzmeniUcesce_Btn";
            IzmeniUcesce_Btn.Size = new System.Drawing.Size(146, 44);
            IzmeniUcesce_Btn.TabIndex = 2;
            IzmeniUcesce_Btn.Text = "Izmeni ucesce";
            IzmeniUcesce_Btn.UseVisualStyleBackColor = false;
            // 
            // DodajUcesce_Btn
            // 
            DodajUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodajUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            DodajUcesce_Btn.Location = new System.Drawing.Point(15, 24);
            DodajUcesce_Btn.Name = "DodajUcesce_Btn";
            DodajUcesce_Btn.Size = new System.Drawing.Size(146, 44);
            DodajUcesce_Btn.TabIndex = 1;
            DodajUcesce_Btn.Text = "Dodaj novo ucesce";
            DodajUcesce_Btn.UseVisualStyleBackColor = false;
            // 
            // ObrisiUcesce_Btn
            // 
            ObrisiUcesce_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiUcesce_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiUcesce_Btn.Location = new System.Drawing.Point(15, 124);
            ObrisiUcesce_Btn.Name = "ObrisiUcesce_Btn";
            ObrisiUcesce_Btn.Size = new System.Drawing.Size(146, 44);
            ObrisiUcesce_Btn.TabIndex = 0;
            ObrisiUcesce_Btn.Text = "Obrisi ucesce";
            ObrisiUcesce_Btn.UseVisualStyleBackColor = false;
            // 
            // DodatnaLit_Izvestaji_Btn
            // 
            DodatnaLit_Izvestaji_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodatnaLit_Izvestaji_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DodatnaLit_Izvestaji_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            DodatnaLit_Izvestaji_Btn.Location = new System.Drawing.Point(578, 484);
            DodatnaLit_Izvestaji_Btn.Name = "DodatnaLit_Izvestaji_Btn";
            DodatnaLit_Izvestaji_Btn.Size = new System.Drawing.Size(156, 59);
            DodatnaLit_Izvestaji_Btn.TabIndex = 10;
            DodatnaLit_Izvestaji_Btn.UseVisualStyleBackColor = false;
            DodatnaLit_Izvestaji_Btn.Click += DodatnaLit_Izvestaji_Btn_Click;
            // 
            // StudentiNaProjektu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(746, 620);
            Controls.Add(DodatnaLit_Izvestaji_Btn);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Excel_Btn);
            Controls.Add(Prikaz_GB);
            Controls.Add(Studenti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentiNaProjektu";
            Text = "Studenti";
            Load += StudentiNaProjektu_Load;
            Studenti_GB.ResumeLayout(false);
            Studenti_GB.PerformLayout();
            Prikaz_GB.ResumeLayout(false);
            Prikaz_GB.PerformLayout();
            Podaci_o_predmetimaGB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Studenti_GB;
        private ListView Studenti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox Prikaz_GB;
        private Button Ocisti_Btn;
        private Button Sortiraj_Btn;
        private Label label2;
        private Label label1;
        private TextBox BrojIndeksa_TB;
        private TextBox Ime_TB;
        private TextBox Smer_TB;
        private Label label4;
        private TextBox Prezime_TB;
        private Label label3;
        private Button Excel_Btn;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniUcesce_Btn;
        private Button DodajUcesce_Btn;
        private Button ObrisiUcesce_Btn;
        private Label TipProj_LB;
        private Label SkolskaGodZad_LB;
        private Label label8;
        private Label Naziv_LB;
        private Label label5;
        private Button DodatnaLit_Izvestaji_Btn;
    }
}