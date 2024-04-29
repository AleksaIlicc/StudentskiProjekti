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
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniPredmet_Btn = new Button();
            DodajPredmet_Btn = new Button();
            ObrisiPredmet_Btn = new Button();
            Projekti_GB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            SuspendLayout();
            // 
            // Projekti_GB
            // 
            Projekti_GB.Controls.Add(Projekti_ListV);
            Projekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Projekti_GB.Location = new System.Drawing.Point(12, 12);
            Projekti_GB.Name = "Projekti_GB";
            Projekti_GB.Size = new System.Drawing.Size(736, 323);
            Projekti_GB.TabIndex = 3;
            Projekti_GB.TabStop = false;
            Projekti_GB.Text = "Projekti";
            // 
            // Projekti_ListV
            // 
            Projekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Projekti_ListV.FullRowSelect = true;
            Projekti_ListV.GridLines = true;
            Projekti_ListV.Location = new System.Drawing.Point(7, 48);
            Projekti_ListV.Name = "Projekti_ListV";
            Projekti_ListV.Size = new System.Drawing.Size(723, 269);
            Projekti_ListV.TabIndex = 0;
            Projekti_ListV.UseCompatibleStateImageBehavior = false;
            Projekti_ListV.View = View.Details;
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
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(34, 358);
            Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
            Podaci_o_predmetimaGB.Size = new System.Drawing.Size(202, 164);
            Podaci_o_predmetimaGB.TabIndex = 4;
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
            IzmeniPredmet_Btn.Text = "Izmeni projekat";
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
            DodajPredmet_Btn.Text = "Dodaj projekat";
            DodajPredmet_Btn.UseVisualStyleBackColor = false;
            DodajPredmet_Btn.Click += DodajPredmet_Btn_Click;
            // 
            // ObrisiPredmet_Btn
            // 
            ObrisiPredmet_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiPredmet_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiPredmet_Btn.Location = new System.Drawing.Point(34, 112);
            ObrisiPredmet_Btn.Name = "ObrisiPredmet_Btn";
            ObrisiPredmet_Btn.Size = new System.Drawing.Size(132, 33);
            ObrisiPredmet_Btn.TabIndex = 1;
            ObrisiPredmet_Btn.Text = "Obrisi projekat";
            ObrisiPredmet_Btn.UseVisualStyleBackColor = false;
            // 
            // Projekti
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(756, 560);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Projekti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(772, 599);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(772, 599);
            Name = "Projekti";
            Text = "Projekti";
            Projekti_GB.ResumeLayout(false);
            Podaci_o_predmetimaGB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Projekti_GB;
        private ListView Projekti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniPredmet_Btn;
        private Button DodajPredmet_Btn;
        private Button ObrisiPredmet_Btn;
    }
}
