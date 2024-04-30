using StudentskiProjekti.Properties;

namespace StudentskiProjekti.Forme
{
	partial class Studenti
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
			Studenti_GB = new GroupBox();
			Studenti_ListV = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			Podaci_o_predmetimaGB = new GroupBox();
			IzmeniStudenta_Btn = new Button();
			DodajStudenta_Btn = new Button();
			ObrisiStudenta_Btn = new Button();
			Studenti_GB.SuspendLayout();
			Podaci_o_predmetimaGB.SuspendLayout();
			SuspendLayout();
			// 
			// Studenti_GB
			// 
			Studenti_GB.Controls.Add(Studenti_ListV);
			Studenti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Studenti_GB.Location = new System.Drawing.Point(8, 12);
			Studenti_GB.Name = "Studenti_GB";
			Studenti_GB.Size = new System.Drawing.Size(736, 323);
			Studenti_GB.TabIndex = 3;
			Studenti_GB.TabStop = false;
			Studenti_GB.Text = "Studenti";
			// 
			// Studenti_ListV
			// 
			Studenti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
			Studenti_ListV.FullRowSelect = true;
			Studenti_ListV.GridLines = true;
			Studenti_ListV.Location = new System.Drawing.Point(7, 48);
			Studenti_ListV.Name = "Studenti_ListV";
			Studenti_ListV.Size = new System.Drawing.Size(723, 269);
			Studenti_ListV.TabIndex = 0;
			Studenti_ListV.UseCompatibleStateImageBehavior = false;
			Studenti_ListV.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Broj indeksa";
			columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ime";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Ime roditelja";
			columnHeader3.TextAlign = HorizontalAlignment.Center;
			columnHeader3.Width = 130;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Prezime";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 130;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Smer";
			columnHeader5.TextAlign = HorizontalAlignment.Center;
			columnHeader5.Width = 215;
			// 
			// Podaci_o_predmetimaGB
			// 
			Podaci_o_predmetimaGB.Controls.Add(IzmeniStudenta_Btn);
			Podaci_o_predmetimaGB.Controls.Add(DodajStudenta_Btn);
			Podaci_o_predmetimaGB.Controls.Add(ObrisiStudenta_Btn);
			Podaci_o_predmetimaGB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Podaci_o_predmetimaGB.Location = new System.Drawing.Point(30, 364);
			Podaci_o_predmetimaGB.Name = "Podaci_o_predmetimaGB";
			Podaci_o_predmetimaGB.Size = new System.Drawing.Size(202, 164);
			Podaci_o_predmetimaGB.TabIndex = 4;
			Podaci_o_predmetimaGB.TabStop = false;
			Podaci_o_predmetimaGB.Text = "Izmeni";
			// 
			// IzmeniStudenta_Btn
			// 
			IzmeniStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			IzmeniStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			IzmeniStudenta_Btn.Location = new System.Drawing.Point(34, 69);
			IzmeniStudenta_Btn.Name = "IzmeniStudenta_Btn";
			IzmeniStudenta_Btn.Size = new System.Drawing.Size(132, 33);
			IzmeniStudenta_Btn.TabIndex = 3;
			IzmeniStudenta_Btn.Text = "Izmeni studenta";
			IzmeniStudenta_Btn.UseVisualStyleBackColor = false;
			IzmeniStudenta_Btn.Click += IzmeniStudenta_Btn_Click;
			// 
			// DodajStudenta_Btn
			// 
			DodajStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			DodajStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			DodajStudenta_Btn.Location = new System.Drawing.Point(34, 26);
			DodajStudenta_Btn.Name = "DodajStudenta_Btn";
			DodajStudenta_Btn.Size = new System.Drawing.Size(132, 33);
			DodajStudenta_Btn.TabIndex = 2;
			DodajStudenta_Btn.Text = "Dodaj studenta";
			DodajStudenta_Btn.UseVisualStyleBackColor = false;
			DodajStudenta_Btn.Click += DodajStudenta_Btn_Click;
			// 
			// ObrisiStudenta_Btn
			// 
			ObrisiStudenta_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			ObrisiStudenta_Btn.Font = new System.Drawing.Font("Georgia", 9F);
			ObrisiStudenta_Btn.Location = new System.Drawing.Point(34, 112);
			ObrisiStudenta_Btn.Name = "ObrisiStudenta_Btn";
			ObrisiStudenta_Btn.Size = new System.Drawing.Size(132, 33);
			ObrisiStudenta_Btn.TabIndex = 1;
			ObrisiStudenta_Btn.Text = "Obrisi studenta";
			ObrisiStudenta_Btn.UseVisualStyleBackColor = false;
			ObrisiStudenta_Btn.Click += ObrisiStudenta_Btn_Click_1;
			// 
			// Studenti
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(756, 560);
			Controls.Add(Podaci_o_predmetimaGB);
			Controls.Add(Studenti_GB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(772, 599);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(772, 599);
			Name = "Studenti";
			Text = "Studenti";
			Load += Studenti_Load;
			Studenti_GB.ResumeLayout(false);
			Podaci_o_predmetimaGB.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox Studenti_GB;
		private ListView Studenti_ListV;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private GroupBox Podaci_o_predmetimaGB;
		private Button IzmeniStudenta_Btn;
		private Button DodajStudenta_Btn;
		private Button ObrisiStudenta_Btn;
	}
}