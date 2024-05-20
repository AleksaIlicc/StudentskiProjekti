namespace StudentskiProjekti.Forme
{
    partial class TeorijskiProjekti
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
			TeorijskiProjekti_GB = new GroupBox();
			Literatura_Btn = new Button();
			TeorijskiProjekti_ListV = new ListView();
			columnHeader3 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			IzmeniTeorijski_GB = new GroupBox();
			IzmeniProjekatT_Btn = new Button();
			DodajProjekatT_Btn = new Button();
			ObrisiProjekatT_Btn = new Button();
			PrikazProjekta_GB = new GroupBox();
			Tip_GB = new GroupBox();
			Pojedinacni_RB = new RadioButton();
			Grupni_RB = new RadioButton();
			label7 = new Label();
			Ocisti_Btn = new Button();
			Sortiraj_Btn = new Button();
			label6 = new Label();
			SkoslkaGodZad_TB = new TextBox();
			button1 = new Button();
			TeorijskiProjekti_GB.SuspendLayout();
			IzmeniTeorijski_GB.SuspendLayout();
			PrikazProjekta_GB.SuspendLayout();
			Tip_GB.SuspendLayout();
			SuspendLayout();
			// 
			// TeorijskiProjekti_GB
			// 
			TeorijskiProjekti_GB.Controls.Add(Literatura_Btn);
			TeorijskiProjekti_GB.Controls.Add(TeorijskiProjekti_ListV);
			TeorijskiProjekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			TeorijskiProjekti_GB.Location = new System.Drawing.Point(8, 12);
			TeorijskiProjekti_GB.Name = "TeorijskiProjekti_GB";
			TeorijskiProjekti_GB.Size = new System.Drawing.Size(785, 366);
			TeorijskiProjekti_GB.TabIndex = 3;
			TeorijskiProjekti_GB.TabStop = false;
			TeorijskiProjekti_GB.Text = "Teorijski Projekti";
			// 
			// Literatura_Btn
			// 
			Literatura_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Literatura_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Literatura_Btn.Location = new System.Drawing.Point(632, 312);
			Literatura_Btn.Name = "Literatura_Btn";
			Literatura_Btn.Size = new System.Drawing.Size(147, 48);
			Literatura_Btn.TabIndex = 1;
			Literatura_Btn.Text = "Prikazi literaturu na projektu";
			Literatura_Btn.UseVisualStyleBackColor = false;
			Literatura_Btn.Click += Literatura_Btn_Click;
			// 
			// TeorijskiProjekti_ListV
			// 
			TeorijskiProjekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader7, columnHeader8 });
			TeorijskiProjekti_ListV.FullRowSelect = true;
			TeorijskiProjekti_ListV.GridLines = true;
			TeorijskiProjekti_ListV.Location = new System.Drawing.Point(6, 37);
			TeorijskiProjekti_ListV.MultiSelect = false;
			TeorijskiProjekti_ListV.Name = "TeorijskiProjekti_ListV";
			TeorijskiProjekti_ListV.Size = new System.Drawing.Size(773, 269);
			TeorijskiProjekti_ListV.TabIndex = 0;
			TeorijskiProjekti_ListV.UseCompatibleStateImageBehavior = false;
			TeorijskiProjekti_ListV.View = View.Details;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Naziv";
			columnHeader3.Width = 430;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Skolska god. zadavanja";
			columnHeader6.TextAlign = HorizontalAlignment.Center;
			columnHeader6.Width = 145;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Tip";
			columnHeader7.TextAlign = HorizontalAlignment.Center;
			columnHeader7.Width = 100;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Maksimlani br. strana";
			columnHeader8.TextAlign = HorizontalAlignment.Center;
			columnHeader8.Width = 120;
			// 
			// IzmeniTeorijski_GB
			// 
			IzmeniTeorijski_GB.Controls.Add(IzmeniProjekatT_Btn);
			IzmeniTeorijski_GB.Controls.Add(DodajProjekatT_Btn);
			IzmeniTeorijski_GB.Controls.Add(ObrisiProjekatT_Btn);
			IzmeniTeorijski_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniTeorijski_GB.Location = new System.Drawing.Point(8, 395);
			IzmeniTeorijski_GB.Name = "IzmeniTeorijski_GB";
			IzmeniTeorijski_GB.Size = new System.Drawing.Size(202, 164);
			IzmeniTeorijski_GB.TabIndex = 4;
			IzmeniTeorijski_GB.TabStop = false;
			IzmeniTeorijski_GB.Text = "Izmeni";
			// 
			// IzmeniProjekatT_Btn
			// 
			IzmeniProjekatT_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniProjekatT_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniProjekatT_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniProjekatT_Btn.Name = "IzmeniProjekatT_Btn";
			IzmeniProjekatT_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniProjekatT_Btn.TabIndex = 3;
			IzmeniProjekatT_Btn.Text = "Izmeni projekat";
			IzmeniProjekatT_Btn.UseVisualStyleBackColor = false;
			IzmeniProjekatT_Btn.Click += IzmeniProjekatT_Btn_Click;
			// 
			// DodajProjekatT_Btn
			// 
			DodajProjekatT_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajProjekatT_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajProjekatT_Btn.Location = new System.Drawing.Point(34, 26);
			DodajProjekatT_Btn.Name = "DodajProjekatT_Btn";
			DodajProjekatT_Btn.Size = new System.Drawing.Size(132, 33);
			DodajProjekatT_Btn.TabIndex = 2;
			DodajProjekatT_Btn.Text = "Dodaj projekat";
			DodajProjekatT_Btn.UseVisualStyleBackColor = false;
			DodajProjekatT_Btn.Click += DodajProjekatT_Btn_Click;
			// 
			// ObrisiProjekatT_Btn
			// 
			ObrisiProjekatT_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiProjekatT_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiProjekatT_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiProjekatT_Btn.Name = "ObrisiProjekatT_Btn";
			ObrisiProjekatT_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiProjekatT_Btn.TabIndex = 4;
			ObrisiProjekatT_Btn.Text = "Obrisi projekat";
			ObrisiProjekatT_Btn.UseVisualStyleBackColor = false;
			ObrisiProjekatT_Btn.Click += ObrisiProjekatT_Btn_Click;
			// 
			// PrikazProjekta_GB
			// 
			PrikazProjekta_GB.Controls.Add(Tip_GB);
			PrikazProjekta_GB.Controls.Add(label7);
			PrikazProjekta_GB.Controls.Add(Ocisti_Btn);
			PrikazProjekta_GB.Controls.Add(Sortiraj_Btn);
			PrikazProjekta_GB.Controls.Add(label6);
			PrikazProjekta_GB.Controls.Add(SkoslkaGodZad_TB);
			PrikazProjekta_GB.Location = new System.Drawing.Point(229, 395);
			PrikazProjekta_GB.Name = "PrikazProjekta_GB";
			PrikazProjekta_GB.Size = new System.Drawing.Size(391, 164);
			PrikazProjekta_GB.TabIndex = 8;
			PrikazProjekta_GB.TabStop = false;
			PrikazProjekta_GB.Text = "Prikaz";
			// 
			// Tip_GB
			// 
			Tip_GB.Controls.Add(Pojedinacni_RB);
			Tip_GB.Controls.Add(Grupni_RB);
			Tip_GB.Location = new System.Drawing.Point(198, 29);
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
			label7.Location = new System.Drawing.Point(6, 40);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(124, 15);
			label7.TabIndex = 6;
			label7.Text = "Unesite tip projekta:";
			// 
			// Ocisti_Btn
			// 
			Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Ocisti_Btn.Location = new System.Drawing.Point(223, 120);
			Ocisti_Btn.Name = "Ocisti_Btn";
			Ocisti_Btn.Size = new System.Drawing.Size(75, 25);
			Ocisti_Btn.TabIndex = 7;
			Ocisti_Btn.Text = "Ocisti";
			Ocisti_Btn.UseVisualStyleBackColor = false;
			// 
			// Sortiraj_Btn
			// 
			Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Sortiraj_Btn.Location = new System.Drawing.Point(304, 120);
			Sortiraj_Btn.Name = "Sortiraj_Btn";
			Sortiraj_Btn.Size = new System.Drawing.Size(75, 25);
			Sortiraj_Btn.TabIndex = 8;
			Sortiraj_Btn.Text = "Sortiraj";
			Sortiraj_Btn.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(6, 78);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(189, 15);
			label6.TabIndex = 4;
			label6.Text = "Unesite skolsku god. zadavanja:";
			// 
			// SkoslkaGodZad_TB
			// 
			SkoslkaGodZad_TB.Location = new System.Drawing.Point(198, 75);
			SkoslkaGodZad_TB.Name = "SkoslkaGodZad_TB";
			SkoslkaGodZad_TB.Size = new System.Drawing.Size(181, 21);
			SkoslkaGodZad_TB.TabIndex = 6;
			// 
			// button1
			// 
			button1.BackColor = System.Drawing.Color.AntiqueWhite;
			button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Location = new System.Drawing.Point(626, 504);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(167, 55);
			button1.TabIndex = 9;
			button1.Text = "Prikazi studente koji rade na projektu";
			button1.UseVisualStyleBackColor = false;
			// 
			// TeorijskiProjekti
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(801, 571);
			Controls.Add(button1);
			Controls.Add(PrikazProjekta_GB);
			Controls.Add(IzmeniTeorijski_GB);
			Controls.Add(TeorijskiProjekti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(817, 610);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(817, 610);
			Name = "TeorijskiProjekti";
			Text = "Teorijski projekti";
			Load += TeorijskiProjekti_Load;
			TeorijskiProjekti_GB.ResumeLayout(false);
			IzmeniTeorijski_GB.ResumeLayout(false);
			PrikazProjekta_GB.ResumeLayout(false);
			PrikazProjekta_GB.PerformLayout();
			Tip_GB.ResumeLayout(false);
			Tip_GB.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox TeorijskiProjekti_GB;
        private ListView TeorijskiProjekti_ListV;
        private GroupBox IzmeniTeorijski_GB;
        private Button IzmeniProjekatT_Btn;
        private Button DodajProjekatT_Btn;
        private Button ObrisiProjekatT_Btn;
        private Button Literatura_Btn;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
		private GroupBox PrikazProjekta_GB;
		private GroupBox Tip_GB;
		private RadioButton Pojedinacni_RB;
		private RadioButton Grupni_RB;
		private Label label7;
		private Button Ocisti_Btn;
		private Button Sortiraj_Btn;
		private Label label6;
		private TextBox SkoslkaGodZad_TB;
		private Button button1;
	}
}