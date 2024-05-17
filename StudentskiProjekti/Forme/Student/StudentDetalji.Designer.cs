namespace StudentskiProjekti.Forme
{
	partial class StudentDetalji
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
            StudentDetalji_GB = new GroupBox();
            StudentDetalji_ListV = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            Literatura = new Button();
            Podaci_o_predmetimaGB = new GroupBox();
            IzmeniStudenta_Btn = new Button();
            DodajStudenta_Btn = new Button();
            ObrisiStudenta_Btn = new Button();
            StudentDetalji_GB.SuspendLayout();
            Podaci_o_predmetimaGB.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDetalji_GB
            // 
            StudentDetalji_GB.Controls.Add(StudentDetalji_ListV);
            StudentDetalji_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StudentDetalji_GB.Location = new System.Drawing.Point(8, 12);
            StudentDetalji_GB.Name = "StudentDetalji_GB";
            StudentDetalji_GB.Size = new System.Drawing.Size(783, 385);
            StudentDetalji_GB.TabIndex = 3;
            StudentDetalji_GB.TabStop = false;
            StudentDetalji_GB.Text = "Projekti na kojima radi:";
            // 
            // StudentDetalji_ListV
            // 
            StudentDetalji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader7, columnHeader8, columnHeader1 });
            StudentDetalji_ListV.FullRowSelect = true;
            StudentDetalji_ListV.GridLines = true;
            StudentDetalji_ListV.Location = new System.Drawing.Point(6, 44);
            StudentDetalji_ListV.MultiSelect = false;
            StudentDetalji_ListV.Name = "StudentDetalji_ListV";
            StudentDetalji_ListV.Size = new System.Drawing.Size(771, 335);
            StudentDetalji_ListV.TabIndex = 0;
            StudentDetalji_ListV.UseCompatibleStateImageBehavior = false;
            StudentDetalji_ListV.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            columnHeader3.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Datum pocetka izrade";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum zavrsetka izrade";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Rok za zavrsetak";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Projekat zavrsen";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 130;
            // 
            // Literatura
            // 
            Literatura.BackColor = System.Drawing.Color.AntiqueWhite;
            Literatura.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Literatura.Location = new System.Drawing.Point(620, 517);
            Literatura.Name = "Literatura";
            Literatura.Size = new System.Drawing.Size(180, 69);
            Literatura.TabIndex = 1;
            Literatura.Text = "Prikazi vise informacija o ucescu";
            Literatura.UseVisualStyleBackColor = false;
            // 
            // Podaci_o_predmetimaGB
            // 
            Podaci_o_predmetimaGB.Controls.Add(IzmeniStudenta_Btn);
            Podaci_o_predmetimaGB.Controls.Add(DodajStudenta_Btn);
            Podaci_o_predmetimaGB.Controls.Add(ObrisiStudenta_Btn);
            Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Podaci_o_predmetimaGB.Location = new System.Drawing.Point(8, 403);
            Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
            Podaci_o_predmetimaGB.Size = new System.Drawing.Size(177, 182);
            Podaci_o_predmetimaGB.TabIndex = 8;
            Podaci_o_predmetimaGB.TabStop = false;
            Podaci_o_predmetimaGB.Text = "Izmeni ucesce";
            // 
            // IzmeniStudenta_Btn
            // 
            IzmeniStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            IzmeniStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            IzmeniStudenta_Btn.Location = new System.Drawing.Point(15, 85);
            IzmeniStudenta_Btn.Name = "IzmeniStudenta_Btn";
            IzmeniStudenta_Btn.Size = new System.Drawing.Size(146, 38);
            IzmeniStudenta_Btn.TabIndex = 2;
            IzmeniStudenta_Btn.Text = "Izmeni ucesce";
            IzmeniStudenta_Btn.UseVisualStyleBackColor = false;
            // 
            // DodajStudenta_Btn
            // 
            DodajStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            DodajStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            DodajStudenta_Btn.Location = new System.Drawing.Point(15, 41);
            DodajStudenta_Btn.Name = "DodajStudenta_Btn";
            DodajStudenta_Btn.Size = new System.Drawing.Size(146, 38);
            DodajStudenta_Btn.TabIndex = 1;
            DodajStudenta_Btn.Text = "Dodaj novo ucesce";
            DodajStudenta_Btn.UseVisualStyleBackColor = false;
            // 
            // ObrisiStudenta_Btn
            // 
            ObrisiStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiStudenta_Btn.Location = new System.Drawing.Point(15, 129);
            ObrisiStudenta_Btn.Name = "ObrisiStudenta_Btn";
            ObrisiStudenta_Btn.Size = new System.Drawing.Size(146, 38);
            ObrisiStudenta_Btn.TabIndex = 0;
            ObrisiStudenta_Btn.Text = "Obrisi ucesce";
            ObrisiStudenta_Btn.UseVisualStyleBackColor = false;
            // 
            // StudentDetalji
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(803, 590);
            Controls.Add(Podaci_o_predmetimaGB);
            Controls.Add(Literatura);
            Controls.Add(StudentDetalji_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(821, 637);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(821, 637);
            Name = "StudentDetalji";
            Text = "Student detalji";
            Load += StudentDetalji_Load;
            StudentDetalji_GB.ResumeLayout(false);
            Podaci_o_predmetimaGB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentDetalji_GB;
		private ListView StudentDetalji_ListV;
		private Button Literatura;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private GroupBox Podaci_o_predmetimaGB;
        private Button IzmeniStudenta_Btn;
        private Button DodajStudenta_Btn;
        private Button ObrisiStudenta_Btn;
    }
}