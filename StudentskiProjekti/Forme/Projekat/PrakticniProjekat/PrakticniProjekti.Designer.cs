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
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			IzmeniProjekte_GB = new GroupBox();
			IzmeniProjekatP_Btn = new Button();
			DodajProjekatP_Btn = new Button();
			ObrisiProjekatP_Btn = new Button();
			columnHeader1 = new ColumnHeader();
			PrakticniProjekti_GB.SuspendLayout();
			IzmeniProjekte_GB.SuspendLayout();
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
			PrakticniProjekti_GB.TabIndex = 3;
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
			KratakOpis_Btn.TabIndex = 3;
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
			PreporuceneWebStrane_Btn.TabIndex = 2;
			PreporuceneWebStrane_Btn.Text = "Prikazi preporucene web stranice projekta";
			PreporuceneWebStrane_Btn.UseVisualStyleBackColor = false;
			// 
			// PrakticniProjekti_ListV
			// 
			PrakticniProjekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
			PrakticniProjekti_ListV.FullRowSelect = true;
			PrakticniProjekti_ListV.GridLines = true;
			PrakticniProjekti_ListV.Location = new System.Drawing.Point(7, 48);
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
			// columnHeader5
			// 
			columnHeader5.Text = "Preporuceni prog. jezik";
			columnHeader5.Width = 150;
			// 
			// IzmeniProjekte_GB
			// 
			IzmeniProjekte_GB.Controls.Add(IzmeniProjekatP_Btn);
			IzmeniProjekte_GB.Controls.Add(DodajProjekatP_Btn);
			IzmeniProjekte_GB.Controls.Add(ObrisiProjekatP_Btn);
			IzmeniProjekte_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IzmeniProjekte_GB.Location = new System.Drawing.Point(15, 408);
			IzmeniProjekte_GB.Name = "IzmeniProjekte_GB";
			IzmeniProjekte_GB.Size = new System.Drawing.Size(202, 164);
			IzmeniProjekte_GB.TabIndex = 5;
			IzmeniProjekte_GB.TabStop = false;
			IzmeniProjekte_GB.Text = "Izmeni";
			// 
			// IzmeniProjekatP_Btn
			// 
			IzmeniProjekatP_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniProjekatP_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniProjekatP_Btn.Location = new System.Drawing.Point(34, 69);
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
			DodajProjekatP_Btn.Location = new System.Drawing.Point(34, 26);
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
			ObrisiProjekatP_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiProjekatP_Btn.Name = "ObrisiProjekatP_Btn";
			ObrisiProjekatP_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiProjekatP_Btn.TabIndex = 2;
			ObrisiProjekatP_Btn.Text = "Obrisi projekat";
			ObrisiProjekatP_Btn.UseVisualStyleBackColor = false;
			// 
			// PrakticniProjekti
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(805, 624);
			Controls.Add(IzmeniProjekte_GB);
			Controls.Add(PrakticniProjekti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(821, 663);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(821, 663);
			Name = "PrakticniProjekti";
			Text = "Prakticni projekti";
			Load += PrakticniProjekti_Load;
			PrakticniProjekti_GB.ResumeLayout(false);
			IzmeniProjekte_GB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox PrakticniProjekti_GB;
        private ListView PrakticniProjekti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox IzmeniProjekte_GB;
        private Button IzmeniProjekatP_Btn;
        private Button DodajProjekatP_Btn;
        private Button ObrisiProjekatP_Btn;
        private Button KratakOpis_Btn;
        private Button PreporuceneWebStrane_Btn;
	}
}