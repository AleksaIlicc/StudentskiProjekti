namespace StudentskiProjekti.Forme
{
    partial class PrakticniProjekti
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
			ColumnHeader columnHeader1;
			PrakticniProjekti_GB = new GroupBox();
			KratakOpis_Btn = new Button();
			PreporuceneWebStrane_Btn = new Button();
			PrakticniProjekti_ListV = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			IzmeniProjekte_GB = new GroupBox();
			IzmeniProjekatP_Btn = new Button();
			DodajProjekatP_Btn = new Button();
			ObrisiProjekatP_Btn = new Button();
			button1 = new Button();
			PrikazProjekta_GB = new GroupBox();
			label1 = new Label();
			textBox1 = new TextBox();
			Tip_GB = new GroupBox();
			Pojedinacni_RB = new RadioButton();
			Grupni_RB = new RadioButton();
			label7 = new Label();
			Ocisti_Btn = new Button();
			Sortiraj_Btn = new Button();
			label6 = new Label();
			SkoslkaGodZad_TB = new TextBox();
			columnHeader1 = new ColumnHeader();
			PrakticniProjekti_GB.SuspendLayout();
			IzmeniProjekte_GB.SuspendLayout();
			PrikazProjekta_GB.SuspendLayout();
			Tip_GB.SuspendLayout();
			SuspendLayout();
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Naziv";
			columnHeader1.Width = 430;
			// 
			// PrakticniProjekti_GB
			// 
			PrakticniProjekti_GB.Controls.Add(KratakOpis_Btn);
			PrakticniProjekti_GB.Controls.Add(PreporuceneWebStrane_Btn);
			PrakticniProjekti_GB.Controls.Add(PrakticniProjekti_ListV);
			PrakticniProjekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			PrakticniProjekti_GB.Location = new System.Drawing.Point(8, 12);
			PrakticniProjekti_GB.Name = "PrakticniProjekti_GB";
			PrakticniProjekti_GB.Size = new System.Drawing.Size(785, 378);
			PrakticniProjekti_GB.TabIndex = 0;
			PrakticniProjekti_GB.TabStop = false;
			PrakticniProjekti_GB.Text = "Prakticni Projekti";
			// 
			// KratakOpis_Btn
			// 
			KratakOpis_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			KratakOpis_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			KratakOpis_Btn.Location = new System.Drawing.Point(613, 323);
			KratakOpis_Btn.Name = "KratakOpis_Btn";
			KratakOpis_Btn.Size = new System.Drawing.Size(167, 48);
			KratakOpis_Btn.TabIndex = 2;
			KratakOpis_Btn.Text = "Prikazi kratak opis projekta";
			KratakOpis_Btn.UseVisualStyleBackColor = false;
			KratakOpis_Btn.Click += KratakOpis_Btn_Click;
			// 
			// PreporuceneWebStrane_Btn
			// 
			PreporuceneWebStrane_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			PreporuceneWebStrane_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			PreporuceneWebStrane_Btn.Location = new System.Drawing.Point(440, 323);
			PreporuceneWebStrane_Btn.Name = "PreporuceneWebStrane_Btn";
			PreporuceneWebStrane_Btn.Size = new System.Drawing.Size(167, 48);
			PreporuceneWebStrane_Btn.TabIndex = 1;
			PreporuceneWebStrane_Btn.Text = "Prikazi preporucene web stranice projekta";
			PreporuceneWebStrane_Btn.UseVisualStyleBackColor = false;
			PreporuceneWebStrane_Btn.Click += PreporuceneWebStrane_Btn_Click;
			// 
			// PrakticniProjekti_ListV
			// 
			PrakticniProjekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5 });
			PrakticniProjekti_ListV.FullRowSelect = true;
			PrakticniProjekti_ListV.GridLines = true;
			PrakticniProjekti_ListV.Location = new System.Drawing.Point(7, 48);
			PrakticniProjekti_ListV.MultiSelect = false;
			PrakticniProjekti_ListV.Name = "PrakticniProjekti_ListV";
			PrakticniProjekti_ListV.Size = new System.Drawing.Size(772, 269);
			PrakticniProjekti_ListV.TabIndex = 0;
			PrakticniProjekti_ListV.UseCompatibleStateImageBehavior = false;
			PrakticniProjekti_ListV.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Skolska god. zadavanja";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 145;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Tip projekta";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Preporuceni prog. jezik";
			columnHeader5.TextAlign = HorizontalAlignment.Center;
			columnHeader5.Width = 150;
			// 
			// IzmeniProjekte_GB
			// 
			IzmeniProjekte_GB.Controls.Add(IzmeniProjekatP_Btn);
			IzmeniProjekte_GB.Controls.Add(DodajProjekatP_Btn);
			IzmeniProjekte_GB.Controls.Add(ObrisiProjekatP_Btn);
			IzmeniProjekte_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniProjekte_GB.Location = new System.Drawing.Point(8, 408);
			IzmeniProjekte_GB.Name = "IzmeniProjekte_GB";
			IzmeniProjekte_GB.Size = new System.Drawing.Size(185, 164);
			IzmeniProjekte_GB.TabIndex = 1;
			IzmeniProjekte_GB.TabStop = false;
			IzmeniProjekte_GB.Text = "Izmeni";
			// 
			// IzmeniProjekatP_Btn
			// 
			IzmeniProjekatP_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniProjekatP_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniProjekatP_Btn.Location = new System.Drawing.Point(23, 73);
			IzmeniProjekatP_Btn.Name = "IzmeniProjekatP_Btn";
			IzmeniProjekatP_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniProjekatP_Btn.TabIndex = 1;
			IzmeniProjekatP_Btn.Text = "Izmeni projekat";
			IzmeniProjekatP_Btn.UseVisualStyleBackColor = false;
			IzmeniProjekatP_Btn.Click += IzmeniProjekatP_Btn_Click;
			// 
			// DodajProjekatP_Btn
			// 
			DodajProjekatP_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajProjekatP_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajProjekatP_Btn.Location = new System.Drawing.Point(23, 28);
			DodajProjekatP_Btn.Name = "DodajProjekatP_Btn";
			DodajProjekatP_Btn.Size = new System.Drawing.Size(132, 33);
			DodajProjekatP_Btn.TabIndex = 0;
			DodajProjekatP_Btn.Text = "Dodaj projekat";
			DodajProjekatP_Btn.UseVisualStyleBackColor = false;
			DodajProjekatP_Btn.Click += DodajProjekatP_Btn_Click;
			// 
			// ObrisiProjekatP_Btn
			// 
			ObrisiProjekatP_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiProjekatP_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiProjekatP_Btn.Location = new System.Drawing.Point(23, 116);
			ObrisiProjekatP_Btn.Name = "ObrisiProjekatP_Btn";
			ObrisiProjekatP_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiProjekatP_Btn.TabIndex = 2;
			ObrisiProjekatP_Btn.Text = "Obrisi projekat";
			ObrisiProjekatP_Btn.UseVisualStyleBackColor = false;
			ObrisiProjekatP_Btn.Click += ObrisiProjekatP_Btn_Click;
			// 
			// button1
			// 
			button1.BackColor = System.Drawing.Color.AntiqueWhite;
			button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Location = new System.Drawing.Point(621, 517);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(167, 55);
			button1.TabIndex = 3;
			button1.Text = "Prikazi studente koji rade na projektu";
			button1.UseVisualStyleBackColor = false;
			// 
			// PrikazProjekta_GB
			// 
			PrikazProjekta_GB.Controls.Add(label1);
			PrikazProjekta_GB.Controls.Add(textBox1);
			PrikazProjekta_GB.Controls.Add(Tip_GB);
			PrikazProjekta_GB.Controls.Add(label7);
			PrikazProjekta_GB.Controls.Add(Ocisti_Btn);
			PrikazProjekta_GB.Controls.Add(Sortiraj_Btn);
			PrikazProjekta_GB.Controls.Add(label6);
			PrikazProjekta_GB.Controls.Add(SkoslkaGodZad_TB);
			PrikazProjekta_GB.Location = new System.Drawing.Point(212, 408);
			PrikazProjekta_GB.Name = "PrikazProjekta_GB";
			PrikazProjekta_GB.Size = new System.Drawing.Size(391, 164);
			PrikazProjekta_GB.TabIndex = 2;
			PrikazProjekta_GB.TabStop = false;
			PrikazProjekta_GB.Text = "Prikaz";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 95);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(186, 15);
			label1.TabIndex = 9;
			label1.Text = "Unesite prep. programski jezik:";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(198, 92);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(181, 21);
			textBox1.TabIndex = 2;
			// 
			// Tip_GB
			// 
			Tip_GB.Controls.Add(Pojedinacni_RB);
			Tip_GB.Controls.Add(Grupni_RB);
			Tip_GB.Location = new System.Drawing.Point(198, 13);
			Tip_GB.Name = "Tip_GB";
			Tip_GB.Size = new System.Drawing.Size(181, 30);
			Tip_GB.TabIndex = 0;
			Tip_GB.TabStop = false;
			// 
			// Pojedinacni_RB
			// 
			Pojedinacni_RB.AutoSize = true;
			Pojedinacni_RB.Location = new System.Drawing.Point(86, 9);
			Pojedinacni_RB.Name = "Pojedinacni_RB";
			Pojedinacni_RB.Size = new System.Drawing.Size(92, 19);
			Pojedinacni_RB.TabIndex = 3;
			Pojedinacni_RB.Text = "Pojedinacni";
			Pojedinacni_RB.UseVisualStyleBackColor = true;
			// 
			// Grupni_RB
			// 
			Grupni_RB.AutoSize = true;
			Grupni_RB.Location = new System.Drawing.Point(4, 9);
			Grupni_RB.Name = "Grupni_RB";
			Grupni_RB.Size = new System.Drawing.Size(67, 19);
			Grupni_RB.TabIndex = 2;
			Grupni_RB.Text = "Grupni";
			Grupni_RB.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(6, 24);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(124, 15);
			label7.TabIndex = 6;
			label7.Text = "Unesite tip projekta:";
			// 
			// Ocisti_Btn
			// 
			Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Ocisti_Btn.Location = new System.Drawing.Point(253, 124);
			Ocisti_Btn.Name = "Ocisti_Btn";
			Ocisti_Btn.Size = new System.Drawing.Size(60, 25);
			Ocisti_Btn.TabIndex = 3;
			Ocisti_Btn.Text = "Ocisti";
			Ocisti_Btn.UseVisualStyleBackColor = false;
			// 
			// Sortiraj_Btn
			// 
			Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Sortiraj_Btn.Location = new System.Drawing.Point(319, 124);
			Sortiraj_Btn.Name = "Sortiraj_Btn";
			Sortiraj_Btn.Size = new System.Drawing.Size(60, 25);
			Sortiraj_Btn.TabIndex = 4;
			Sortiraj_Btn.Text = "Sortiraj";
			Sortiraj_Btn.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(6, 61);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(189, 15);
			label6.TabIndex = 4;
			label6.Text = "Unesite skolsku god. zadavanja:";
			// 
			// SkoslkaGodZad_TB
			// 
			SkoslkaGodZad_TB.Location = new System.Drawing.Point(198, 58);
			SkoslkaGodZad_TB.Name = "SkoslkaGodZad_TB";
			SkoslkaGodZad_TB.Size = new System.Drawing.Size(181, 21);
			SkoslkaGodZad_TB.TabIndex = 1;
			// 
			// PrakticniProjekti
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(799, 582);
			Controls.Add(PrikazProjekta_GB);
			Controls.Add(button1);
			Controls.Add(IzmeniProjekte_GB);
			Controls.Add(PrakticniProjekti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(817, 621);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(815, 621);
			Name = "PrakticniProjekti";
			Text = "Prakticni projekti";
			Load += PrakticniProjekti_Load;
			PrakticniProjekti_GB.ResumeLayout(false);
			IzmeniProjekte_GB.ResumeLayout(false);
			PrikazProjekta_GB.ResumeLayout(false);
			PrikazProjekta_GB.PerformLayout();
			Tip_GB.ResumeLayout(false);
			Tip_GB.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox PrakticniProjekti_GB;
        private ListView PrakticniProjekti_ListV;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox IzmeniProjekte_GB;
        private Button IzmeniProjekatP_Btn;
        private Button DodajProjekatP_Btn;
        private Button ObrisiProjekatP_Btn;
        private Button KratakOpis_Btn;
        private Button PreporuceneWebStrane_Btn;
		private Button button1;
		private GroupBox PrikazProjekta_GB;
		private Label label1;
		private TextBox textBox1;
		private GroupBox Tip_GB;
		private RadioButton Pojedinacni_RB;
		private RadioButton Grupni_RB;
		private Label label7;
		private Button Ocisti_Btn;
		private Button Sortiraj_Btn;
		private Label label6;
		private TextBox SkoslkaGodZad_TB;
	}
}