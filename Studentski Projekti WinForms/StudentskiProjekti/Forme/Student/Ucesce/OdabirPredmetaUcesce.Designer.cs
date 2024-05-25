namespace StudentskiProjekti.Forme
{
    partial class OdabirPredmetaUcesce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdabirPredmetaUcesce));
            Predmeti_GB = new GroupBox();
            label3 = new Label();
            Predmeti_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            PrikazPredmeta_GB = new GroupBox();
            Ocisti_Btn = new Button();
            Sortiraj_Btn = new Button();
            label2 = new Label();
            label1 = new Label();
            Semestar_TB = new TextBox();
            NazivKatedre_TB = new TextBox();
            Prikazi_Btn = new Button();
            Predmeti_GB.SuspendLayout();
            PrikazPredmeta_GB.SuspendLayout();
            SuspendLayout();
            // 
            // Predmeti_GB
            // 
            Predmeti_GB.Controls.Add(label3);
            Predmeti_GB.Controls.Add(Predmeti_ListV);
            Predmeti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Predmeti_GB.Location = new System.Drawing.Point(6, 4);
            Predmeti_GB.Name = "Predmeti_GB";
            Predmeti_GB.Size = new System.Drawing.Size(607, 323);
            Predmeti_GB.TabIndex = 0;
            Predmeti_GB.TabStop = false;
            Predmeti_GB.Text = "Predmeti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 15);
            label3.TabIndex = 5;
            label3.Text = "Izaberite predmet:";
            // 
            // Predmeti_ListV
            // 
            Predmeti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Predmeti_ListV.FullRowSelect = true;
            Predmeti_ListV.GridLines = true;
            Predmeti_ListV.Location = new System.Drawing.Point(7, 48);
            Predmeti_ListV.MultiSelect = false;
            Predmeti_ListV.Name = "Predmeti_ListV";
            Predmeti_ListV.Size = new System.Drawing.Size(592, 269);
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
            columnHeader2.Width = 260;
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
            columnHeader4.Width = 150;
            // 
            // PrikazPredmeta_GB
            // 
            PrikazPredmeta_GB.Controls.Add(Ocisti_Btn);
            PrikazPredmeta_GB.Controls.Add(Sortiraj_Btn);
            PrikazPredmeta_GB.Controls.Add(label2);
            PrikazPredmeta_GB.Controls.Add(label1);
            PrikazPredmeta_GB.Controls.Add(Semestar_TB);
            PrikazPredmeta_GB.Controls.Add(NazivKatedre_TB);
            PrikazPredmeta_GB.Location = new System.Drawing.Point(13, 355);
            PrikazPredmeta_GB.Name = "PrikazPredmeta_GB";
            PrikazPredmeta_GB.Size = new System.Drawing.Size(292, 164);
            PrikazPredmeta_GB.TabIndex = 2;
            PrikazPredmeta_GB.TabStop = false;
            PrikazPredmeta_GB.Text = "Prikaz";
            // 
            // Ocisti_Btn
            // 
            Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Ocisti_Btn.Location = new System.Drawing.Point(143, 122);
            Ocisti_Btn.Name = "Ocisti_Btn";
            Ocisti_Btn.Size = new System.Drawing.Size(60, 23);
            Ocisti_Btn.TabIndex = 3;
            Ocisti_Btn.Text = "Ocisti";
            Ocisti_Btn.UseVisualStyleBackColor = false;
            Ocisti_Btn.Click += Ocisti_Btn_Click;
            // 
            // Sortiraj_Btn
            // 
            Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            Sortiraj_Btn.Location = new System.Drawing.Point(209, 122);
            Sortiraj_Btn.Name = "Sortiraj_Btn";
            Sortiraj_Btn.Size = new System.Drawing.Size(60, 23);
            Sortiraj_Btn.TabIndex = 4;
            Sortiraj_Btn.Text = "Sortiraj";
            Sortiraj_Btn.UseVisualStyleBackColor = false;
            Sortiraj_Btn.Click += Sortiraj_Btn_Click;
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
            label1.TabIndex = 4;
            label1.Text = "Unesite semestar:";
            // 
            // Semestar_TB
            // 
            Semestar_TB.Location = new System.Drawing.Point(160, 32);
            Semestar_TB.Name = "Semestar_TB";
            Semestar_TB.Size = new System.Drawing.Size(108, 21);
            Semestar_TB.TabIndex = 1;
            // 
            // NazivKatedre_TB
            // 
            NazivKatedre_TB.Location = new System.Drawing.Point(160, 82);
            NazivKatedre_TB.Name = "NazivKatedre_TB";
            NazivKatedre_TB.Size = new System.Drawing.Size(108, 21);
            NazivKatedre_TB.TabIndex = 2;
            // 
            // Prikazi_Btn
            // 
            Prikazi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Prikazi_Btn.Font = new System.Drawing.Font("Georgia", 14F);
            Prikazi_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            Prikazi_Btn.Location = new System.Drawing.Point(464, 465);
            Prikazi_Btn.Name = "Prikazi_Btn";
            Prikazi_Btn.Size = new System.Drawing.Size(141, 54);
            Prikazi_Btn.TabIndex = 3;
            Prikazi_Btn.Text = "Izaberi predmet";
            Prikazi_Btn.UseVisualStyleBackColor = false;
            Prikazi_Btn.Click += Prikazi_Btn_Click;
            // 
            // OdabirPredmetaUcesce
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(621, 531);
            Controls.Add(Prikazi_Btn);
            Controls.Add(PrikazPredmeta_GB);
            Controls.Add(Predmeti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(637, 570);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(637, 570);
            Name = "OdabirPredmetaUcesce";
            Text = "Predmeti";
            Load += OdabirPredmetaUcesce_Load;
            Predmeti_GB.ResumeLayout(false);
            Predmeti_GB.PerformLayout();
            PrikazPredmeta_GB.ResumeLayout(false);
            PrikazPredmeta_GB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Predmeti_GB;
        private ListView Predmeti_ListV;
        private GroupBox PrikazPredmeta_GB;
        private Label label2;
        private Label label1;
        private TextBox Semestar_TB;
        private TextBox NazivKatedre_TB;
        private Button Sortiraj_Btn;
        private Button Prikazi_Btn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button Ocisti_Btn;
        private Label label3;
    }
}