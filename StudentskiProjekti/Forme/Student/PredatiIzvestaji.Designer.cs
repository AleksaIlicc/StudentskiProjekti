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
            label5 = new Label();
            Izvestaji_ListV = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            OstaliClanovi_Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BrIndeksa_LB = new Label();
            Smer_LB = new Label();
            Prezime_LB = new Label();
            Ime_LB = new Label();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniIzvestaj_Btn = new Button();
            DodajIzvestaj_Btn = new Button();
            ObrisiIzvestaj_Btn = new Button();
            columnHeader1 = new ColumnHeader();
            Izvestaji_GB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            SuspendLayout();
            // 
            // Izvestaji_GB
            // 
            Izvestaji_GB.Controls.Add(label5);
            Izvestaji_GB.Controls.Add(Izvestaji_ListV);
            Izvestaji_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Izvestaji_GB.Location = new System.Drawing.Point(8, 12);
            Izvestaji_GB.Name = "Izvestaji_GB";
            Izvestaji_GB.Size = new System.Drawing.Size(709, 289);
            Izvestaji_GB.TabIndex = 3;
            Izvestaji_GB.TabStop = false;
            Izvestaji_GB.Text = "Izvestaji:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(342, 18);
            label5.TabIndex = 10;
            label5.Text = "Duplim klikom na red mozete videti opis izvestaja:";
            // 
            // Izvestaji_ListV
            // 
            Izvestaji_ListV.AccessibleRole = AccessibleRole.None;
            Izvestaji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader9, columnHeader1 });
            Izvestaji_ListV.FullRowSelect = true;
            Izvestaji_ListV.GridLines = true;
            Izvestaji_ListV.Location = new System.Drawing.Point(6, 57);
            Izvestaji_ListV.MultiSelect = false;
            Izvestaji_ListV.Name = "Izvestaji_ListV";
            Izvestaji_ListV.Size = new System.Drawing.Size(697, 226);
            Izvestaji_ListV.TabIndex = 0;
            Izvestaji_ListV.UseCompatibleStateImageBehavior = false;
            Izvestaji_ListV.View = View.Details;
            Izvestaji_ListV.DoubleClick += Izvestaji_ListV_DoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum poc. izrade";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Datum zavr. izrade";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Rok za zavrsetak projekta";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 170;
            // 
            // OstaliClanovi_Btn
            // 
            OstaliClanovi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            OstaliClanovi_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            OstaliClanovi_Btn.Location = new System.Drawing.Point(528, 422);
            OstaliClanovi_Btn.Name = "OstaliClanovi_Btn";
            OstaliClanovi_Btn.Size = new System.Drawing.Size(180, 69);
            OstaliClanovi_Btn.TabIndex = 1;
            OstaliClanovi_Btn.Text = "Prikazi izvestaje koji su predali ostali clanovi grupe";
            OstaliClanovi_Btn.UseVisualStyleBackColor = false;
            OstaliClanovi_Btn.Click += OstaliClanovi_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(212, 375);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 18);
            label1.TabIndex = 9;
            label1.Text = "Br. indeksa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(212, 410);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 18);
            label2.TabIndex = 10;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(212, 473);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 18);
            label3.TabIndex = 11;
            label3.Text = "Smer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(212, 439);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 18);
            label4.TabIndex = 12;
            label4.Text = "Prezime:";
            // 
            // BrIndeksa_LB
            // 
            BrIndeksa_LB.AutoSize = true;
            BrIndeksa_LB.Location = new System.Drawing.Point(319, 375);
            BrIndeksa_LB.Name = "BrIndeksa_LB";
            BrIndeksa_LB.Size = new System.Drawing.Size(0, 18);
            BrIndeksa_LB.TabIndex = 14;
            // 
            // Smer_LB
            // 
            Smer_LB.AutoSize = true;
            Smer_LB.Location = new System.Drawing.Point(319, 473);
            Smer_LB.Name = "Smer_LB";
            Smer_LB.Size = new System.Drawing.Size(0, 18);
            Smer_LB.TabIndex = 15;
            // 
            // Prezime_LB
            // 
            Prezime_LB.AutoSize = true;
            Prezime_LB.Location = new System.Drawing.Point(319, 439);
            Prezime_LB.Name = "Prezime_LB";
            Prezime_LB.Size = new System.Drawing.Size(0, 18);
            Prezime_LB.TabIndex = 16;
            // 
            // Ime_LB
            // 
            Ime_LB.AutoSize = true;
            Ime_LB.Location = new System.Drawing.Point(319, 410);
            Ime_LB.Name = "Ime_LB";
            Ime_LB.Size = new System.Drawing.Size(0, 18);
            Ime_LB.TabIndex = 17;
            // 
            // Podaci_o_predmetimaGB
            // 
            Podaci_o_predmetimaGB.Controls.Add(IzmeniIzvestaj_Btn);
            Podaci_o_predmetimaGB.Controls.Add(DodajIzvestaj_Btn);
            Podaci_o_predmetimaGB.Controls.Add(ObrisiIzvestaj_Btn);
            Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(14, 319);
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
            IzmeniIzvestaj_Btn.Location = new System.Drawing.Point(19, 90);
            IzmeniIzvestaj_Btn.Name = "IzmeniIzvestaj_Btn";
            IzmeniIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
            IzmeniIzvestaj_Btn.TabIndex = 2;
            IzmeniIzvestaj_Btn.Text = "Izmeni izvestaj";
            IzmeniIzvestaj_Btn.UseVisualStyleBackColor = false;
            // 
            // DodajIzvestaj_Btn
            // 
            DodajIzvestaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodajIzvestaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            DodajIzvestaj_Btn.Location = new System.Drawing.Point(19, 46);
            DodajIzvestaj_Btn.Name = "DodajIzvestaj_Btn";
            DodajIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
            DodajIzvestaj_Btn.TabIndex = 1;
            DodajIzvestaj_Btn.Text = "Dodaj izvestaj";
            DodajIzvestaj_Btn.UseVisualStyleBackColor = false;
            // 
            // ObrisiIzvestaj_Btn
            // 
            ObrisiIzvestaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiIzvestaj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiIzvestaj_Btn.Location = new System.Drawing.Point(19, 134);
            ObrisiIzvestaj_Btn.Name = "ObrisiIzvestaj_Btn";
            ObrisiIzvestaj_Btn.Size = new System.Drawing.Size(132, 38);
            ObrisiIzvestaj_Btn.TabIndex = 0;
            ObrisiIzvestaj_Btn.Text = "Obrisi izvestaj";
            ObrisiIzvestaj_Btn.UseVisualStyleBackColor = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Datum predaje izvestaja";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 160;
            // 
            // PredatiIzvestaji
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(724, 511);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Ime_LB);
            Controls.Add(Prezime_LB);
            Controls.Add(Smer_LB);
            Controls.Add(BrIndeksa_LB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OstaliClanovi_Btn);
            Controls.Add(Izvestaji_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "PredatiIzvestaji";
            Text = "Izvestaji";
            Load += PredatiIzvestaji_Load;
            Izvestaji_GB.ResumeLayout(false);
            Izvestaji_GB.PerformLayout();
            Podaci_o_predmetimaGB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Izvestaji_GB;
        private ListView Izvestaji_ListV;
        private Button OstaliClanovi_Btn;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label BrIndeksa_LB;
        private Label Smer_LB;
        private Label Prezime_LB;
        private Label Ime_LB;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private Label label5;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniIzvestaj_Btn;
        private Button DodajIzvestaj_Btn;
        private Button ObrisiIzvestaj_Btn;
        private ColumnHeader columnHeader1;
    }
}