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
            ObrisiPredmetBtn = new Button();
            PredmetiGB = new GroupBox();
            Predmeti_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniPredmetBtn = new Button();
            DodajPredmetBtn = new Button();
            PrikazPredmeta_GB = new GroupBox();
            Sortiraj = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            PredmetiGB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            PrikazPredmeta_GB.SuspendLayout();
            SuspendLayout();
            // 
            // ObrisiPredmetBtn
            // 
            ObrisiPredmetBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiPredmetBtn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiPredmetBtn.Location = new System.Drawing.Point(34, 112);
            ObrisiPredmetBtn.Name = "ObrisiPredmetBtn";
            ObrisiPredmetBtn.Size = new System.Drawing.Size(132, 33);
            ObrisiPredmetBtn.TabIndex = 1;
            ObrisiPredmetBtn.Text = "Obrisi Predmet";
            ObrisiPredmetBtn.UseVisualStyleBackColor = false;
            ObrisiPredmetBtn.Click += ObrisiPredmetBtn_Click;
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
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Katedra";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 225;
            // 
            // Podaci_o_predmetimaGB
            // 
            Podaci_o_predmetimaGB.Controls.Add(IzmeniPredmetBtn);
            Podaci_o_predmetimaGB.Controls.Add(DodajPredmetBtn);
            Podaci_o_predmetimaGB.Controls.Add(ObrisiPredmetBtn);
            Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(30, 356);
            Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
            Podaci_o_predmetimaGB.Size = new System.Drawing.Size(202, 164);
            Podaci_o_predmetimaGB.TabIndex = 3;
            Podaci_o_predmetimaGB.TabStop = false;
            Podaci_o_predmetimaGB.Text = "Izmeni";
            // 
            // IzmeniPredmetBtn
            // 
            IzmeniPredmetBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            IzmeniPredmetBtn.Font = new System.Drawing.Font("Georgia", 9F);
            IzmeniPredmetBtn.Location = new System.Drawing.Point(34, 67);
            IzmeniPredmetBtn.Name = "IzmeniPredmetBtn";
            IzmeniPredmetBtn.Size = new System.Drawing.Size(132, 33);
            IzmeniPredmetBtn.TabIndex = 3;
            IzmeniPredmetBtn.Text = "Izmeni Predmet";
            IzmeniPredmetBtn.UseVisualStyleBackColor = false;
            IzmeniPredmetBtn.Click += IzmeniPredmetBtn_Click;
            // 
            // DodajPredmetBtn
            // 
            DodajPredmetBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodajPredmetBtn.Font = new System.Drawing.Font("Georgia", 9F);
            DodajPredmetBtn.Location = new System.Drawing.Point(34, 26);
            DodajPredmetBtn.Name = "DodajPredmetBtn";
            DodajPredmetBtn.Size = new System.Drawing.Size(132, 33);
            DodajPredmetBtn.TabIndex = 2;
            DodajPredmetBtn.Text = "Dodaj Predmet";
            DodajPredmetBtn.UseVisualStyleBackColor = false;
            DodajPredmetBtn.Click += DodajPredmet_Btn_Click;
            // 
            // PrikazPredmeta_GB
            // 
            PrikazPredmeta_GB.Controls.Add(Sortiraj);
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
            // Sortiraj
            // 
            Sortiraj.BackColor = System.Drawing.Color.AntiqueWhite;
            Sortiraj.Font = new System.Drawing.Font("Georgia", 9F);
            Sortiraj.Location = new System.Drawing.Point(208, 121);
            Sortiraj.Name = "Sortiraj";
            Sortiraj.Size = new System.Drawing.Size(60, 23);
            Sortiraj.TabIndex = 6;
            Sortiraj.Text = "Sortiraj";
            Sortiraj.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 18);
            label2.TabIndex = 3;
            label2.Text = "Unesite naziv katedre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 18);
            label1.TabIndex = 2;
            label1.Text = "Unesite semestar:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(160, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(108, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(160, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(108, 25);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 8F);
            label3.Location = new System.Drawing.Point(576, 449);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 17);
            label3.TabIndex = 5;
            label3.Text = "Vise detalja za predmet:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.AntiqueWhite;
            button1.Font = new System.Drawing.Font("Georgia", 14F);
            button1.ForeColor = System.Drawing.SystemColors.ControlText;
            button1.Location = new System.Drawing.Point(578, 466);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(141, 54);
            button1.TabIndex = 6;
            button1.Text = "Prikazi";
            button1.UseVisualStyleBackColor = false;
            // 
            // Predmeti
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(754, 552);
            Controls.Add(button1);
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
        private Button ObrisiPredmetBtn;
        private GroupBox PredmetiGB;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniPredmetBtn;
        private Button DodajPredmetBtn;
        private ListView Predmeti_ListV;
		private GroupBox PrikazPredmeta_GB;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button Sortiraj;
		private Label label3;
		private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}