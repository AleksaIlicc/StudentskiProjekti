namespace StudentskiProjekti.Forme
{
    partial class Predmeti
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Predmeti));
			ObrisiPredmet_Btn = new Button();
			PredmetiGB = new GroupBox();
			Predmeti_ListV = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			Podaci_o_predmetimaGB = new GroupBox();
			IzmeniPredmet_Btn = new Button();
			DodajPredmet_Btn = new Button();
			PrikazPredmeta_GB = new GroupBox();
			Sortiraj_Btn = new Button();
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			Prikazi_Btn = new Button();
			PredmetiGB.SuspendLayout();
			Podaci_o_predmetimaGB.SuspendLayout();
			PrikazPredmeta_GB.SuspendLayout();
			SuspendLayout();
			// 
			// ObrisiPredmet_Btn
			// 
			ObrisiPredmet_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiPredmet_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiPredmet_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiPredmet_Btn.Name = "ObrisiPredmet_Btn";
			ObrisiPredmet_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiPredmet_Btn.TabIndex = 1;
			ObrisiPredmet_Btn.Text = "Obrisi Predmet";
			ObrisiPredmet_Btn.UseVisualStyleBackColor = false;
			ObrisiPredmet_Btn.Click += ObrisiPredmet_Btn_Click;
			// 
			// PredmetiGB
			// 
			PredmetiGB.Controls.Add(Predmeti_ListV);
			PredmetiGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			PredmetiGB.Location = new System.Drawing.Point(6, 4);
			PredmetiGB.Name = "PredmetiGB";
			PredmetiGB.Size = new System.Drawing.Size(736, 323);
			PredmetiGB.TabIndex = 2;
			PredmetiGB.TabStop = false;
			PredmetiGB.Text = "Predmeti";
			// 
			// Predmeti_ListV
			// 
			Predmeti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			Predmeti_ListV.FullRowSelect = true;
			Predmeti_ListV.GridLines = true;
			Predmeti_ListV.Location = new System.Drawing.Point(7, 48);
			Predmeti_ListV.Name = "Predmeti_ListV";
			Predmeti_ListV.Size = new System.Drawing.Size(723, 269);
			Predmeti_ListV.TabIndex = 0;
			Predmeti_ListV.UseCompatibleStateImageBehavior = false;
			Predmeti_ListV.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Sifra";
			columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Naziv";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 320;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Semestar";
			columnHeader3.TextAlign = HorizontalAlignment.Center;
			columnHeader3.Width = 66;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Katedra";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 225;
			// 
			// Podaci_o_predmetimaGB
			// 
			Podaci_o_predmetimaGB.Controls.Add(IzmeniPredmet_Btn);
			Podaci_o_predmetimaGB.Controls.Add(DodajPredmet_Btn);
			Podaci_o_predmetimaGB.Controls.Add(ObrisiPredmet_Btn);
			Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Podaci_o_predmetimaGB.Location = new System.Drawing.Point(30, 356);
			Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
			Podaci_o_predmetimaGB.Size = new System.Drawing.Size(202, 164);
			Podaci_o_predmetimaGB.TabIndex = 3;
			Podaci_o_predmetimaGB.TabStop = false;
			Podaci_o_predmetimaGB.Text = "Izmeni";
			// 
			// IzmeniPredmet_Btn
			// 
			IzmeniPredmet_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniPredmet_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniPredmet_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniPredmet_Btn.Name = "IzmeniPredmet_Btn";
			IzmeniPredmet_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniPredmet_Btn.TabIndex = 3;
			IzmeniPredmet_Btn.Text = "Izmeni Predmet";
			IzmeniPredmet_Btn.UseVisualStyleBackColor = false;
			IzmeniPredmet_Btn.Click += IzmeniPredmet_Btn_Click;
			// 
			// DodajPredmet_Btn
			// 
			DodajPredmet_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajPredmet_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajPredmet_Btn.Location = new System.Drawing.Point(34, 26);
			DodajPredmet_Btn.Name = "DodajPredmet_Btn";
			DodajPredmet_Btn.Size = new System.Drawing.Size(132, 33);
			DodajPredmet_Btn.TabIndex = 2;
			DodajPredmet_Btn.Text = "Dodaj Predmet";
			DodajPredmet_Btn.UseVisualStyleBackColor = false;
			DodajPredmet_Btn.Click += DodajPredmet_Btn_Click;
			// 
			// PrikazPredmeta_GB
			// 
			PrikazPredmeta_GB.Controls.Add(Sortiraj_Btn);
			PrikazPredmeta_GB.Controls.Add(label2);
			PrikazPredmeta_GB.Controls.Add(label1);
			PrikazPredmeta_GB.Controls.Add(textBox2);
			PrikazPredmeta_GB.Controls.Add(textBox1);
			PrikazPredmeta_GB.Location = new System.Drawing.Point(260, 356);
			PrikazPredmeta_GB.Name = "PrikazPredmeta_GB";
			PrikazPredmeta_GB.Size = new System.Drawing.Size(292, 164);
			PrikazPredmeta_GB.TabIndex = 4;
			PrikazPredmeta_GB.TabStop = false;
			PrikazPredmeta_GB.Text = "Prikaz";
			// 
			// Sortiraj_Btn
			// 
			Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			Sortiraj_Btn.Location = new System.Drawing.Point(208, 121);
			Sortiraj_Btn.Name = "Sortiraj_Btn";
			Sortiraj_Btn.Size = new System.Drawing.Size(60, 23);
			Sortiraj_Btn.TabIndex = 6;
			Sortiraj_Btn.Text = "Sortiraj";
			Sortiraj_Btn.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(18, 85);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(136, 15);
			label2.TabIndex = 3;
			label2.Text = "Unesite naziv katedre:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(18, 35);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(109, 15);
			label1.TabIndex = 2;
			label1.Text = "Unesite semestar:";
			// 
			// textBox2
			// 
			textBox2.Location = new System.Drawing.Point(160, 32);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(108, 21);
			textBox2.TabIndex = 1;
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(160, 82);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(108, 21);
			textBox1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Georgia", 8F);
			label3.Location = new System.Drawing.Point(576, 449);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(145, 14);
			label3.TabIndex = 5;
			label3.Text = "Vise detalja za predmet:";
			// 
			// Prikazi_Btn
			// 
			Prikazi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Prikazi_Btn.Font = new System.Drawing.Font("Georgia", 14F);
			Prikazi_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			Prikazi_Btn.Location = new System.Drawing.Point(578, 466);
			Prikazi_Btn.Name = "Prikazi_Btn";
			Prikazi_Btn.Size = new System.Drawing.Size(141, 54);
			Prikazi_Btn.TabIndex = 6;
			Prikazi_Btn.Text = "Prikazi";
			Prikazi_Btn.UseVisualStyleBackColor = false;
			// 
			// Predmeti
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(756, 560);
			Controls.Add(Prikazi_Btn);
			Controls.Add(label3);
			Controls.Add(PrikazPredmeta_GB);
			Controls.Add(Podaci_o_predmetimaGB);
			Controls.Add(PredmetiGB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(772, 599);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(772, 599);
			Name = "Predmeti";
			Text = "Predmeti";
			Load += Predmeti_Load;
			PredmetiGB.ResumeLayout(false);
			Podaci_o_predmetimaGB.ResumeLayout(false);
			PrikazPredmeta_GB.ResumeLayout(false);
			PrikazPredmeta_GB.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button ObrisiPredmet_Btn;
        private GroupBox PredmetiGB;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniPredmet_Btn;
        private Button DodajPredmet_Btn;
        private ListView Predmeti_ListV;
		private GroupBox PrikazPredmeta_GB;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button Sortiraj_Btn;
		private Label label3;
		private Button Prikazi_Btn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}