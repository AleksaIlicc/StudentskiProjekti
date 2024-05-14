﻿namespace StudentskiProjekti.Forme
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
			Literatura_GB = new GroupBox();
			Literatura = new Button();
			TeorijskiProjekti_ListV = new ListView();
			columnHeader3 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			IzmeniTeorijski_GB = new GroupBox();
			IzmeniProjekatT_Btn = new Button();
			DodajProjekatT_Btn = new Button();
			ObrisiProjekatT_Btn = new Button();
			Literatura_GB.SuspendLayout();
			IzmeniTeorijski_GB.SuspendLayout();
			SuspendLayout();
			// 
			// Literatura_GB
			// 
			Literatura_GB.Controls.Add(Literatura);
			Literatura_GB.Controls.Add(TeorijskiProjekti_ListV);
			Literatura_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Literatura_GB.Location = new System.Drawing.Point(8, 12);
			Literatura_GB.Name = "Literatura_GB";
			Literatura_GB.Size = new System.Drawing.Size(785, 366);
			Literatura_GB.TabIndex = 3;
			Literatura_GB.TabStop = false;
			// 
			// Literatura
			// 
			Literatura.BackColor = System.Drawing.Color.AntiqueWhite;
			Literatura.Font = new System.Drawing.Font("Georgia", 9F);
			Literatura.Location = new System.Drawing.Point(632, 312);
			Literatura.Name = "Literatura";
			Literatura.Size = new System.Drawing.Size(147, 48);
			Literatura.TabIndex = 1;
			Literatura.Text = "Prikazi literaturu na projektu";
			Literatura.UseVisualStyleBackColor = false;
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
			IzmeniTeorijski_GB.Location = new System.Drawing.Point(8, 405);
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
			// 
			// StudentDetalji
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(805, 624);
			Controls.Add(IzmeniTeorijski_GB);
			Controls.Add(Literatura_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(5, 3, 5, 3);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(821, 663);
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(821, 663);
			Name = "StudentDetalji";
			Text = "Student detalji";
			Literatura_GB.ResumeLayout(false);
			IzmeniTeorijski_GB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox Literatura_GB;
		private ListView TeorijskiProjekti_ListV;
		private GroupBox IzmeniTeorijski_GB;
		private Button IzmeniProjekatT_Btn;
		private Button DodajProjekatT_Btn;
		private Button ObrisiProjekatT_Btn;
		private Button Literatura;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
	}
}