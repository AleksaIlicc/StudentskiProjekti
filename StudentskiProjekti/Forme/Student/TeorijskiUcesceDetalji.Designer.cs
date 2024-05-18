namespace StudentskiProjekti.Forme
{
    partial class TeorijskiUcesceDetalji
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
            PrikaziStudenteNaIstom_Btn = new Button();
            OstaliClanovi_GB = new GroupBox();
            OstaliClanovi_ListV = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Naziv_LB = new Label();
            DatumPocetka_LB = new Label();
            DatumZavrsetka_LB = new Label();
            RokZaZavrsetak_LB = new Label();
            ProjekatZavrsen_LB = new Label();
            PodaciOProjektu_GB = new GroupBox();
            DopunskaLit_LB = new Label();
            label16 = new Label();
            MaksimalanBrStranica_LB = new Label();
            SkolskaGodinaZad_LB = new Label();
            label14 = new Label();
            label7 = new Label();
            OstaliClanovi_GB.SuspendLayout();
            PodaciOProjektu_GB.SuspendLayout();
            SuspendLayout();
            // 
            // PrikaziStudenteNaIstom_Btn
            // 
            PrikaziStudenteNaIstom_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            PrikaziStudenteNaIstom_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PrikaziStudenteNaIstom_Btn.Location = new System.Drawing.Point(713, 330);
            PrikaziStudenteNaIstom_Btn.Name = "PrikaziStudenteNaIstom_Btn";
            PrikaziStudenteNaIstom_Btn.Size = new System.Drawing.Size(180, 69);
            PrikaziStudenteNaIstom_Btn.TabIndex = 1;
            PrikaziStudenteNaIstom_Btn.Text = "Prikazi studente koji rade na istom projektu";
            PrikaziStudenteNaIstom_Btn.UseVisualStyleBackColor = false;
            PrikaziStudenteNaIstom_Btn.Click += PrikaziStudente_Btn_Click;
            // 
            // OstaliClanovi_GB
            // 
            OstaliClanovi_GB.Controls.Add(OstaliClanovi_ListV);
            OstaliClanovi_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OstaliClanovi_GB.Location = new System.Drawing.Point(577, 12);
            OstaliClanovi_GB.Name = "OstaliClanovi_GB";
            OstaliClanovi_GB.Size = new System.Drawing.Size(316, 259);
            OstaliClanovi_GB.TabIndex = 4;
            OstaliClanovi_GB.TabStop = false;
            OstaliClanovi_GB.Text = "Ostali clanovi grupe:";
            // 
            // OstaliClanovi_ListV
            // 
            OstaliClanovi_ListV.AccessibleRole = AccessibleRole.None;
            OstaliClanovi_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13 });
            OstaliClanovi_ListV.FullRowSelect = true;
            OstaliClanovi_ListV.GridLines = true;
            OstaliClanovi_ListV.Location = new System.Drawing.Point(6, 33);
            OstaliClanovi_ListV.MultiSelect = false;
            OstaliClanovi_ListV.Name = "OstaliClanovi_ListV";
            OstaliClanovi_ListV.Size = new System.Drawing.Size(304, 215);
            OstaliClanovi_ListV.TabIndex = 0;
            OstaliClanovi_ListV.UseCompatibleStateImageBehavior = false;
            OstaliClanovi_ListV.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Br. Indeksa";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Ime";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Prezime";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 15);
            label1.TabIndex = 5;
            label1.Text = "Naziv projekta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 15);
            label2.TabIndex = 6;
            label2.Text = "Datum pocetka izrade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 15);
            label3.TabIndex = 7;
            label3.Text = "Datum zavrsetka izrade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 162);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "Rok za zavrsetak:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 202);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 15);
            label5.TabIndex = 9;
            label5.Text = "Projekat zavrsen:";
            // 
            // Naziv_LB
            // 
            Naziv_LB.AutoSize = true;
            Naziv_LB.Location = new System.Drawing.Point(174, 33);
            Naziv_LB.MaximumSize = new System.Drawing.Size(350, 0);
            Naziv_LB.Name = "Naziv_LB";
            Naziv_LB.Size = new System.Drawing.Size(0, 15);
            Naziv_LB.TabIndex = 12;
            // 
            // DatumPocetka_LB
            // 
            DatumPocetka_LB.AutoSize = true;
            DatumPocetka_LB.Location = new System.Drawing.Point(174, 76);
            DatumPocetka_LB.MaximumSize = new System.Drawing.Size(350, 0);
            DatumPocetka_LB.Name = "DatumPocetka_LB";
            DatumPocetka_LB.Size = new System.Drawing.Size(0, 15);
            DatumPocetka_LB.TabIndex = 13;
            // 
            // DatumZavrsetka_LB
            // 
            DatumZavrsetka_LB.AutoSize = true;
            DatumZavrsetka_LB.Location = new System.Drawing.Point(174, 117);
            DatumZavrsetka_LB.MaximumSize = new System.Drawing.Size(350, 0);
            DatumZavrsetka_LB.Name = "DatumZavrsetka_LB";
            DatumZavrsetka_LB.Size = new System.Drawing.Size(0, 15);
            DatumZavrsetka_LB.TabIndex = 14;
            // 
            // RokZaZavrsetak_LB
            // 
            RokZaZavrsetak_LB.AutoSize = true;
            RokZaZavrsetak_LB.Location = new System.Drawing.Point(174, 162);
            RokZaZavrsetak_LB.MaximumSize = new System.Drawing.Size(350, 0);
            RokZaZavrsetak_LB.Name = "RokZaZavrsetak_LB";
            RokZaZavrsetak_LB.Size = new System.Drawing.Size(0, 15);
            RokZaZavrsetak_LB.TabIndex = 15;
            // 
            // ProjekatZavrsen_LB
            // 
            ProjekatZavrsen_LB.AutoSize = true;
            ProjekatZavrsen_LB.Location = new System.Drawing.Point(174, 202);
            ProjekatZavrsen_LB.MaximumSize = new System.Drawing.Size(350, 0);
            ProjekatZavrsen_LB.Name = "ProjekatZavrsen_LB";
            ProjekatZavrsen_LB.Size = new System.Drawing.Size(0, 15);
            ProjekatZavrsen_LB.TabIndex = 16;
            // 
            // PodaciOProjektu_GB
            // 
            PodaciOProjektu_GB.Controls.Add(DopunskaLit_LB);
            PodaciOProjektu_GB.Controls.Add(label16);
            PodaciOProjektu_GB.Controls.Add(MaksimalanBrStranica_LB);
            PodaciOProjektu_GB.Controls.Add(SkolskaGodinaZad_LB);
            PodaciOProjektu_GB.Controls.Add(label14);
            PodaciOProjektu_GB.Controls.Add(label7);
            PodaciOProjektu_GB.Controls.Add(ProjekatZavrsen_LB);
            PodaciOProjektu_GB.Controls.Add(RokZaZavrsetak_LB);
            PodaciOProjektu_GB.Controls.Add(DatumZavrsetka_LB);
            PodaciOProjektu_GB.Controls.Add(DatumPocetka_LB);
            PodaciOProjektu_GB.Controls.Add(Naziv_LB);
            PodaciOProjektu_GB.Controls.Add(label5);
            PodaciOProjektu_GB.Controls.Add(label4);
            PodaciOProjektu_GB.Controls.Add(label3);
            PodaciOProjektu_GB.Controls.Add(label2);
            PodaciOProjektu_GB.Controls.Add(label1);
            PodaciOProjektu_GB.Location = new System.Drawing.Point(12, 12);
            PodaciOProjektu_GB.Name = "PodaciOProjektu_GB";
            PodaciOProjektu_GB.Size = new System.Drawing.Size(542, 387);
            PodaciOProjektu_GB.TabIndex = 17;
            PodaciOProjektu_GB.TabStop = false;
            PodaciOProjektu_GB.Text = "Podaci o projektu:";
            // 
            // DopunskaLit_LB
            // 
            DopunskaLit_LB.AutoSize = true;
            DopunskaLit_LB.Location = new System.Drawing.Point(174, 333);
            DopunskaLit_LB.MaximumSize = new System.Drawing.Size(350, 0);
            DopunskaLit_LB.Name = "DopunskaLit_LB";
            DopunskaLit_LB.Size = new System.Drawing.Size(0, 15);
            DopunskaLit_LB.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 333);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(129, 15);
            label16.TabIndex = 21;
            label16.Text = "Dopunska literatura:";
            // 
            // MaksimalanBrStranica_LB
            // 
            MaksimalanBrStranica_LB.AutoSize = true;
            MaksimalanBrStranica_LB.Location = new System.Drawing.Point(175, 284);
            MaksimalanBrStranica_LB.MaximumSize = new System.Drawing.Size(350, 0);
            MaksimalanBrStranica_LB.Name = "MaksimalanBrStranica_LB";
            MaksimalanBrStranica_LB.Size = new System.Drawing.Size(0, 15);
            MaksimalanBrStranica_LB.TabIndex = 20;
            // 
            // SkolskaGodinaZad_LB
            // 
            SkolskaGodinaZad_LB.AutoSize = true;
            SkolskaGodinaZad_LB.Location = new System.Drawing.Point(174, 244);
            SkolskaGodinaZad_LB.MaximumSize = new System.Drawing.Size(350, 0);
            SkolskaGodinaZad_LB.Name = "SkolskaGodinaZad_LB";
            SkolskaGodinaZad_LB.Size = new System.Drawing.Size(0, 15);
            SkolskaGodinaZad_LB.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 284);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(150, 15);
            label14.TabIndex = 19;
            label14.Text = "Maksimalan broj strana:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 244);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(159, 15);
            label7.TabIndex = 17;
            label7.Text = "Skolska godina zadavanja:";
            // 
            // TeorijskiUcesceDetalji
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(905, 424);
            Controls.Add(PodaciOProjektu_GB);
            Controls.Add(OstaliClanovi_GB);
            Controls.Add(PrikaziStudenteNaIstom_Btn);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(921, 463);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(921, 463);
            Name = "TeorijskiUcesceDetalji";
            Text = " Detalji za ucesce";
            Load += TeorijskiUcesceDetalji_Load;
            OstaliClanovi_GB.ResumeLayout(false);
            PodaciOProjektu_GB.ResumeLayout(false);
            PodaciOProjektu_GB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button PrikaziStudenteNaIstom_Btn;
        private GroupBox OstaliClanovi_GB;
        private ListView OstaliClanovi_ListV;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Naziv_LB;
        private Label DatumPocetka_LB;
        private Label DatumZavrsetka_LB;
        private Label RokZaZavrsetak_LB;
        private Label ProjekatZavrsen_LB;
        private GroupBox PodaciOProjektu_GB;
        private Label SkolskaGodinaZad_LB;
        private Label label7;
        private Label MaksimalanBrStranica_LB;
        private Label label14;
        private TextBox DopunskaLit_TB;
        private Label DopunskaLit_LB;
        private Label label16;
    }
}