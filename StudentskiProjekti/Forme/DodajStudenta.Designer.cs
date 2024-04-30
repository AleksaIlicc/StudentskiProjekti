namespace StudentskiProjekti.Forme
{
	partial class DodajStudenta
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
			OsnovnipodaciopredmetuGB = new GroupBox();
			Smer_TB = new TextBox();
			label5 = new Label();
			Dodaj_Btn = new Button();
			Prezime_TB = new TextBox();
			Ime_TB = new TextBox();
			BrIndeksa_TB = new TextBox();
			ImeRoditelja_TB = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			OsnovnipodaciopredmetuGB.SuspendLayout();
			SuspendLayout();
			// 
			// OsnovnipodaciopredmetuGB
			// 
			OsnovnipodaciopredmetuGB.Controls.Add(Smer_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label5);
			OsnovnipodaciopredmetuGB.Controls.Add(Dodaj_Btn);
			OsnovnipodaciopredmetuGB.Controls.Add(Prezime_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(Ime_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(BrIndeksa_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(ImeRoditelja_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label4);
			OsnovnipodaciopredmetuGB.Controls.Add(label3);
			OsnovnipodaciopredmetuGB.Controls.Add(label2);
			OsnovnipodaciopredmetuGB.Controls.Add(label1);
			OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
			OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
			OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
			OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(325, 241);
			OsnovnipodaciopredmetuGB.TabIndex = 0;
			OsnovnipodaciopredmetuGB.TabStop = false;
			OsnovnipodaciopredmetuGB.Text = "Podaci o studentu";
			// 
			// Smer_TB
			// 
			Smer_TB.Location = new System.Drawing.Point(96, 165);
			Smer_TB.Name = "Smer_TB";
			Smer_TB.Size = new System.Drawing.Size(209, 21);
			Smer_TB.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Georgia", 9F);
			label5.Location = new System.Drawing.Point(8, 168);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(42, 15);
			label5.TabIndex = 9;
			label5.Text = "Smer:";
			// 
			// Dodaj_Btn
			// 
			Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Dodaj_Btn.Location = new System.Drawing.Point(184, 198);
			Dodaj_Btn.Name = "Dodaj_Btn";
			Dodaj_Btn.Size = new System.Drawing.Size(121, 29);
			Dodaj_Btn.TabIndex = 5;
			Dodaj_Btn.Text = "Dodaj";
			Dodaj_Btn.UseVisualStyleBackColor = false;
			Dodaj_Btn.Click += Dodaj_Btn_Click;
			// 
			// Prezime_TB
			// 
			Prezime_TB.Location = new System.Drawing.Point(96, 134);
			Prezime_TB.Name = "Prezime_TB";
			Prezime_TB.Size = new System.Drawing.Size(209, 21);
			Prezime_TB.TabIndex = 3;
			Prezime_TB.KeyPress += Prezime_TB_KeyPress;
			// 
			// Ime_TB
			// 
			Ime_TB.Location = new System.Drawing.Point(96, 68);
			Ime_TB.Name = "Ime_TB";
			Ime_TB.Size = new System.Drawing.Size(209, 21);
			Ime_TB.TabIndex = 1;
			Ime_TB.KeyPress += Ime_TB_KeyPress;
			// 
			// BrIndeksa_TB
			// 
			BrIndeksa_TB.Location = new System.Drawing.Point(96, 37);
			BrIndeksa_TB.Name = "BrIndeksa_TB";
			BrIndeksa_TB.Size = new System.Drawing.Size(209, 21);
			BrIndeksa_TB.TabIndex = 0;
			// 
			// ImeRoditelja_TB
			// 
			ImeRoditelja_TB.Location = new System.Drawing.Point(96, 99);
			ImeRoditelja_TB.Name = "ImeRoditelja_TB";
			ImeRoditelja_TB.Size = new System.Drawing.Size(209, 21);
			ImeRoditelja_TB.TabIndex = 2;
			ImeRoditelja_TB.KeyPress += ImeRoditelja_TB_KeyPress;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Georgia", 9F);
			label4.Location = new System.Drawing.Point(8, 137);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(57, 15);
			label4.TabIndex = 3;
			label4.Text = "Prezime:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Georgia", 9F);
			label3.Location = new System.Drawing.Point(8, 102);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(85, 15);
			label3.TabIndex = 2;
			label3.Text = "Ime roditelja:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Georgia", 9F);
			label2.Location = new System.Drawing.Point(8, 71);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(33, 15);
			label2.TabIndex = 1;
			label2.Text = "Ime:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Georgia", 9F);
			label1.Location = new System.Drawing.Point(8, 40);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(82, 15);
			label1.TabIndex = 0;
			label1.Text = "Broj indeksa:";
			// 
			// DodajStudenta
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.AntiqueWhite;
			ClientSize = new System.Drawing.Size(348, 266);
			Controls.Add(OsnovnipodaciopredmetuGB);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(364, 305);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(364, 305);
			Name = "DodajStudenta";
			Text = "Dodaj studenta";
			OsnovnipodaciopredmetuGB.ResumeLayout(false);
			OsnovnipodaciopredmetuGB.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox OsnovnipodaciopredmetuGB;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox Prezime_TB;
		private TextBox Ime_TB;
		private TextBox BrIndeksa_TB;
		private TextBox ImeRoditelja_TB;
		private Button Dodaj_Btn;
		private TextBox Smer_TB;
		private Label label5;
	}
}