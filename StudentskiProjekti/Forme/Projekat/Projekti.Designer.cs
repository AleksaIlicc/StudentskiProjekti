namespace StudentskiProjekti.Forme
{
    partial class Projekti
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
			Projekti_GB = new GroupBox();
			Projekti_ListV = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			Sifra_Lbl = new Label();
			Naziv_Lbl = new Label();
			Semestar_Lbl = new Label();
			Katedra_Lbl = new Label();
			PrikazPrakticni_Btn = new Button();
			PrikazTeorijski_Btn = new Button();
			PrikazProjekta_GB = new GroupBox();
			Tip_GB = new GroupBox();
			Pojedinacni_RB = new RadioButton();
			Grupni_RB = new RadioButton();
			label7 = new Label();
			Ocisti_Btn = new Button();
			Vrsta_GB = new GroupBox();
			Prakticni_RB = new RadioButton();
			Teorijski_RB = new RadioButton();
			Sortiraj_Btn = new Button();
			label5 = new Label();
			label6 = new Label();
			SkoslkaGodZad_TB = new TextBox();
			Excel_Btn = new Button();
			Projekti_GB.SuspendLayout();
			PrikazProjekta_GB.SuspendLayout();
			Tip_GB.SuspendLayout();
			Vrsta_GB.SuspendLayout();
			SuspendLayout();
			// 
			// Projekti_GB
			// 
			Projekti_GB.Controls.Add(Projekti_ListV);
			Projekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Projekti_GB.Location = new System.Drawing.Point(8, 77);
			Projekti_GB.Name = "Projekti_GB";
			Projekti_GB.Size = new System.Drawing.Size(785, 323);
			Projekti_GB.TabIndex = 4;
			Projekti_GB.TabStop = false;
			Projekti_GB.Text = "Projekti";
			// 
			// Projekti_ListV
			// 
			Projekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			Projekti_ListV.FullRowSelect = true;
			Projekti_ListV.GridLines = true;
			Projekti_ListV.Location = new System.Drawing.Point(7, 48);
			Projekti_ListV.MultiSelect = false;
			Projekti_ListV.Name = "Projekti_ListV";
			Projekti_ListV.Size = new System.Drawing.Size(772, 269);
			Projekti_ListV.TabIndex = 0;
			Projekti_ListV.UseCompatibleStateImageBehavior = false;
			Projekti_ListV.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Naziv";
			columnHeader1.Width = 423;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Skolska god. zadavanja";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 145;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Vrsta projekta";
			columnHeader3.TextAlign = HorizontalAlignment.Center;
			columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Tip projekta";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 100;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(29, 47);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(104, 15);
			label1.TabIndex = 5;
			label1.Text = "Naziv predmeta:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(29, 23);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(98, 15);
			label2.TabIndex = 6;
			label2.Text = "Sifra predmeta:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(483, 23);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(65, 15);
			label3.TabIndex = 7;
			label3.Text = "Semestar:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(483, 47);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(57, 15);
			label4.TabIndex = 8;
			label4.Text = "Katedra:";
			// 
			// Sifra_Lbl
			// 
			Sifra_Lbl.AutoSize = true;
			Sifra_Lbl.Location = new System.Drawing.Point(143, 23);
			Sifra_Lbl.Name = "Sifra_Lbl";
			Sifra_Lbl.Size = new System.Drawing.Size(0, 15);
			Sifra_Lbl.TabIndex = 9;
			// 
			// Naziv_Lbl
			// 
			Naziv_Lbl.AutoSize = true;
			Naziv_Lbl.Location = new System.Drawing.Point(143, 47);
			Naziv_Lbl.Name = "Naziv_Lbl";
			Naziv_Lbl.Size = new System.Drawing.Size(0, 15);
			Naziv_Lbl.TabIndex = 10;
			// 
			// Semestar_Lbl
			// 
			Semestar_Lbl.AutoSize = true;
			Semestar_Lbl.Location = new System.Drawing.Point(565, 23);
			Semestar_Lbl.Name = "Semestar_Lbl";
			Semestar_Lbl.Size = new System.Drawing.Size(0, 15);
			Semestar_Lbl.TabIndex = 11;
			// 
			// Katedra_Lbl
			// 
			Katedra_Lbl.AutoSize = true;
			Katedra_Lbl.Location = new System.Drawing.Point(565, 47);
			Katedra_Lbl.Name = "Katedra_Lbl";
			Katedra_Lbl.Size = new System.Drawing.Size(0, 15);
			Katedra_Lbl.TabIndex = 12;
			// 
			// PrikazPrakticni_Btn
			// 
			PrikazPrakticni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			PrikazPrakticni_Btn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			PrikazPrakticni_Btn.Location = new System.Drawing.Point(551, 417);
			PrikazPrakticni_Btn.Name = "PrikazPrakticni_Btn";
			PrikazPrakticni_Btn.Size = new System.Drawing.Size(236, 53);
			PrikazPrakticni_Btn.TabIndex = 1;
			PrikazPrakticni_Btn.Text = "Prikazi prakticne projekte";
			PrikazPrakticni_Btn.UseVisualStyleBackColor = false;
			PrikazPrakticni_Btn.Click += PrikazPrakticni_Btn_Click;
			// 
			// PrikazTeorijski_Btn
			// 
			PrikazTeorijski_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			PrikazTeorijski_Btn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			PrikazTeorijski_Btn.Location = new System.Drawing.Point(551, 480);
			PrikazTeorijski_Btn.Name = "PrikazTeorijski_Btn";
			PrikazTeorijski_Btn.Size = new System.Drawing.Size(236, 54);
			PrikazTeorijski_Btn.TabIndex = 2;
			PrikazTeorijski_Btn.Text = "Prikazi teorijske projekte";
			PrikazTeorijski_Btn.UseVisualStyleBackColor = false;
			PrikazTeorijski_Btn.Click += PrikazTeorijski_Btn_Click;
			// 
			// PrikazProjekta_GB
			// 
			PrikazProjekta_GB.Controls.Add(Tip_GB);
			PrikazProjekta_GB.Controls.Add(label7);
			PrikazProjekta_GB.Controls.Add(Ocisti_Btn);
			PrikazProjekta_GB.Controls.Add(Vrsta_GB);
			PrikazProjekta_GB.Controls.Add(Sortiraj_Btn);
			PrikazProjekta_GB.Controls.Add(label5);
			PrikazProjekta_GB.Controls.Add(label6);
			PrikazProjekta_GB.Controls.Add(SkoslkaGodZad_TB);
			PrikazProjekta_GB.Location = new System.Drawing.Point(15, 417);
			PrikazProjekta_GB.Name = "PrikazProjekta_GB";
			PrikazProjekta_GB.Size = new System.Drawing.Size(426, 176);
			PrikazProjekta_GB.TabIndex = 0;
			PrikazProjekta_GB.TabStop = false;
			PrikazProjekta_GB.Text = "Prikaz";
			// 
			// Tip_GB
			// 
			Tip_GB.Controls.Add(Pojedinacni_RB);
			Tip_GB.Controls.Add(Grupni_RB);
			Tip_GB.Location = new System.Drawing.Point(221, 17);
			Tip_GB.Name = "Tip_GB";
			Tip_GB.Size = new System.Drawing.Size(181, 30);
			Tip_GB.TabIndex = 4;
			Tip_GB.TabStop = false;
			// 
			// Pojedinacni_RB
			// 
			Pojedinacni_RB.AutoSize = true;
			Pojedinacni_RB.Location = new System.Drawing.Point(86, 9);
			Pojedinacni_RB.Name = "Pojedinacni_RB";
			Pojedinacni_RB.Size = new System.Drawing.Size(92, 19);
			Pojedinacni_RB.TabIndex = 0;
			Pojedinacni_RB.Text = "Pojedinacni";
			Pojedinacni_RB.UseVisualStyleBackColor = true;
			// 
			// Grupni_RB
			// 
			Grupni_RB.AutoSize = true;
			Grupni_RB.Location = new System.Drawing.Point(4, 9);
			Grupni_RB.Name = "Grupni_RB";
			Grupni_RB.Size = new System.Drawing.Size(67, 19);
			Grupni_RB.TabIndex = 1;
			Grupni_RB.Text = "Grupni";
			Grupni_RB.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(7, 28);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(124, 15);
			label7.TabIndex = 6;
			label7.Text = "Unesite tip projekta:";
			// 
			// Ocisti_Btn
			// 
			Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Ocisti_Btn.Location = new System.Drawing.Point(276, 137);
			Ocisti_Btn.Name = "Ocisti_Btn";
			Ocisti_Btn.Size = new System.Drawing.Size(60, 23);
			Ocisti_Btn.TabIndex = 1;
			Ocisti_Btn.Text = "Ocisti";
			Ocisti_Btn.UseVisualStyleBackColor = false;
			Ocisti_Btn.Click += Ocisti_Btn_Click;
			// 
			// Vrsta_GB
			// 
			Vrsta_GB.Controls.Add(Prakticni_RB);
			Vrsta_GB.Controls.Add(Teorijski_RB);
			Vrsta_GB.Location = new System.Drawing.Point(220, 54);
			Vrsta_GB.Name = "Vrsta_GB";
			Vrsta_GB.Size = new System.Drawing.Size(182, 30);
			Vrsta_GB.TabIndex = 7;
			Vrsta_GB.TabStop = false;
			// 
			// Prakticni_RB
			// 
			Prakticni_RB.AutoSize = true;
			Prakticni_RB.Location = new System.Drawing.Point(87, 9);
			Prakticni_RB.Name = "Prakticni_RB";
			Prakticni_RB.Size = new System.Drawing.Size(79, 19);
			Prakticni_RB.TabIndex = 0;
			Prakticni_RB.Text = "Prakticni";
			Prakticni_RB.UseVisualStyleBackColor = true;
			// 
			// Teorijski_RB
			// 
			Teorijski_RB.AutoSize = true;
			Teorijski_RB.Location = new System.Drawing.Point(5, 9);
			Teorijski_RB.Name = "Teorijski_RB";
			Teorijski_RB.Size = new System.Drawing.Size(75, 19);
			Teorijski_RB.TabIndex = 1;
			Teorijski_RB.Text = "Teorijski";
			Teorijski_RB.UseVisualStyleBackColor = true;
			// 
			// Sortiraj_Btn
			// 
			Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Sortiraj_Btn.Location = new System.Drawing.Point(342, 137);
			Sortiraj_Btn.Name = "Sortiraj_Btn";
			Sortiraj_Btn.Size = new System.Drawing.Size(60, 23);
			Sortiraj_Btn.TabIndex = 8;
			Sortiraj_Btn.Text = "Sortiraj";
			Sortiraj_Btn.UseVisualStyleBackColor = false;
			Sortiraj_Btn.Click += Sortiraj_Btn_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(7, 65);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(140, 15);
			label5.TabIndex = 3;
			label5.Text = "Unesite vrstu projekta:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(7, 108);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(189, 15);
			label6.TabIndex = 4;
			label6.Text = "Unesite skolsku god. zadavanja:";
			// 
			// SkoslkaGodZad_TB
			// 
			SkoslkaGodZad_TB.Location = new System.Drawing.Point(220, 105);
			SkoslkaGodZad_TB.Name = "SkoslkaGodZad_TB";
			SkoslkaGodZad_TB.Size = new System.Drawing.Size(182, 21);
			SkoslkaGodZad_TB.TabIndex = 0;
			SkoslkaGodZad_TB.KeyPress += SkoslkaGodZad_TB_KeyPress;
			// 
			// Excel_Btn
			// 
			Excel_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Excel_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Excel_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			Excel_Btn.Location = new System.Drawing.Point(551, 540);
			Excel_Btn.Name = "Excel_Btn";
			Excel_Btn.Size = new System.Drawing.Size(236, 53);
			Excel_Btn.TabIndex = 3;
			Excel_Btn.Text = "Snimi projekte u \r\nExcel tabelu";
			Excel_Btn.UseVisualStyleBackColor = false;
			Excel_Btn.Click += Excel_Btn_Click;
			// 
			// Projekti
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(805, 624);
			Controls.Add(Excel_Btn);
			Controls.Add(PrikazProjekta_GB);
			Controls.Add(PrikazPrakticni_Btn);
			Controls.Add(PrikazTeorijski_Btn);
			Controls.Add(Katedra_Lbl);
			Controls.Add(Semestar_Lbl);
			Controls.Add(Naziv_Lbl);
			Controls.Add(Sifra_Lbl);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(Projekti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(821, 663);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(821, 663);
			Name = "Projekti";
			Text = "Projekti na predmetu";
			Load += Projekti_Load;
			Projekti_GB.ResumeLayout(false);
			PrikazProjekta_GB.ResumeLayout(false);
			PrikazProjekta_GB.PerformLayout();
			Tip_GB.ResumeLayout(false);
			Tip_GB.PerformLayout();
			Vrsta_GB.ResumeLayout(false);
			Vrsta_GB.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox Projekti_GB;
        private ListView Projekti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Sifra_Lbl;
        private Label Naziv_Lbl;
        private Label Semestar_Lbl;
        private Label Katedra_Lbl;
        private Button PrikazPrakticni_Btn;
        private Button PrikazTeorijski_Btn;
        private GroupBox PrikazProjekta_GB;
        private Label label7;
        private Button Ocisti_Btn;
        private Button Sortiraj_Btn;
        private Label label5;
        private Label label6;
        private TextBox SkoslkaGodZad_TB;
        private GroupBox Vrsta_GB;
        private RadioButton Prakticni_RB;
        private RadioButton Teorijski_RB;
        private RadioButton Pojedinacni_RB;
        private RadioButton Grupni_RB;
        private GroupBox Tip_GB;
        private Button Excel_Btn;
    }
}
