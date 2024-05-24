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
            Excel_Btn = new Button();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniUcesce_Btn = new Button();
            DodajUcesce_Btn = new Button();
            ObrisiUcesce_Btn = new Button();
            DodatnaLit_Izvestaji_Btn = new Button();
            Studenti_GB.SuspendLayout();
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
            Studenti_GB.Size = new System.Drawing.Size(660, 416);
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
            Studenti_ListV.Size = new System.Drawing.Size(648, 285);
            Studenti_ListV.TabIndex = 0;
            Studenti_ListV.UseCompatibleStateImageBehavior = false;
            Studenti_ListV.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Broj indeksa";
            columnHeader1.Width = 83;
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
            columnHeader5.Width = 170;
            // 
            // Excel_Btn
            // 
            Excel_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Excel_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Excel_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            Excel_Btn.Location = new System.Drawing.Point(507, 543);
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
            DodatnaLit_Izvestaji_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DodatnaLit_Izvestaji_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            DodatnaLit_Izvestaji_Btn.Location = new System.Drawing.Point(507, 478);
            DodatnaLit_Izvestaji_Btn.Name = "DodatnaLit_Izvestaji_Btn";
            DodatnaLit_Izvestaji_Btn.Size = new System.Drawing.Size(156, 59);
            DodatnaLit_Izvestaji_Btn.TabIndex = 10;
            DodatnaLit_Izvestaji_Btn.Text = "Prikazi detalje o ucescu studenta na projektu";
            DodatnaLit_Izvestaji_Btn.UseVisualStyleBackColor = false;
            DodatnaLit_Izvestaji_Btn.Click += DodatnaLit_Izvestaji_Btn_Click;
            // 
            // StudentiNaProjektu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(676, 620);
            Controls.Add(DodatnaLit_Izvestaji_Btn);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Excel_Btn);
            Controls.Add(Studenti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(692, 659);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(692, 659);
            Name = "StudentiNaProjektu";
            Text = "Studenti";
            Load += StudentiNaProjektu_Load;
            Studenti_GB.ResumeLayout(false);
            Studenti_GB.PerformLayout();
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