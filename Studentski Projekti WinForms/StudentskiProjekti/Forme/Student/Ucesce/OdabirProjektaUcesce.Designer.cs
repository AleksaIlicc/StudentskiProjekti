namespace StudentskiProjekti.Forme
{
    partial class OdabirProjektaUcesce
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
            IzaberiProjekat_Btn = new Button();
            Projekti_GB.SuspendLayout();
            SuspendLayout();
            // 
            // Projekti_GB
            // 
            Projekti_GB.Controls.Add(Projekti_ListV);
            Projekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Projekti_GB.Location = new System.Drawing.Point(8, 77);
            Projekti_GB.Name = "Projekti_GB";
            Projekti_GB.Size = new System.Drawing.Size(785, 244);
            Projekti_GB.TabIndex = 0;
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
            Projekti_ListV.Size = new System.Drawing.Size(772, 186);
            Projekti_ListV.TabIndex = 1;
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
            label1.TabIndex = 2;
            label1.Text = "Naziv predmeta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Sifra predmeta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(483, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Semestar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(483, 47);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Katedra:";
            // 
            // Sifra_Lbl
            // 
            Sifra_Lbl.AutoSize = true;
            Sifra_Lbl.Location = new System.Drawing.Point(143, 23);
            Sifra_Lbl.Name = "Sifra_Lbl";
            Sifra_Lbl.Size = new System.Drawing.Size(0, 15);
            Sifra_Lbl.TabIndex = 3;
            // 
            // Naziv_Lbl
            // 
            Naziv_Lbl.AutoSize = true;
            Naziv_Lbl.Location = new System.Drawing.Point(143, 47);
            Naziv_Lbl.Name = "Naziv_Lbl";
            Naziv_Lbl.Size = new System.Drawing.Size(0, 15);
            Naziv_Lbl.TabIndex = 4;
            // 
            // Semestar_Lbl
            // 
            Semestar_Lbl.AutoSize = true;
            Semestar_Lbl.Location = new System.Drawing.Point(565, 23);
            Semestar_Lbl.Name = "Semestar_Lbl";
            Semestar_Lbl.Size = new System.Drawing.Size(0, 15);
            Semestar_Lbl.TabIndex = 7;
            // 
            // Katedra_Lbl
            // 
            Katedra_Lbl.AutoSize = true;
            Katedra_Lbl.Location = new System.Drawing.Point(565, 47);
            Katedra_Lbl.Name = "Katedra_Lbl";
            Katedra_Lbl.Size = new System.Drawing.Size(0, 15);
            Katedra_Lbl.TabIndex = 8;
            // 
            // IzaberiProjekat_Btn
            // 
            IzaberiProjekat_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            IzaberiProjekat_Btn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            IzaberiProjekat_Btn.Location = new System.Drawing.Point(551, 327);
            IzaberiProjekat_Btn.Name = "IzaberiProjekat_Btn";
            IzaberiProjekat_Btn.Size = new System.Drawing.Size(236, 53);
            IzaberiProjekat_Btn.TabIndex = 9;
            IzaberiProjekat_Btn.Text = "Izaberite projekat";
            IzaberiProjekat_Btn.UseVisualStyleBackColor = false;
            IzaberiProjekat_Btn.Click += IzaberiProjekat_Btn_Click;
            // 
            // OdabirProjektaUcesce
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(801, 388);
            Controls.Add(IzaberiProjekat_Btn);
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
            MaximumSize = new System.Drawing.Size(817, 427);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(817, 427);
            Name = "OdabirProjektaUcesce";
            Text = "Projekti na predmetu";
            Load += OdabirProjektaUcesce_Load;
            Projekti_GB.ResumeLayout(false);
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
        private Button IzaberiProjekat_Btn;
    }
}