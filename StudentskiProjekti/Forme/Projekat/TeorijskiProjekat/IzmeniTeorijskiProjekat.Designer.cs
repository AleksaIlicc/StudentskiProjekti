namespace StudentskiProjekti.Forme
{
    partial class IzmeniTeorijskiProjekat
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
			label1 = new Label();
			label2 = new Label();
			Naziv_TB = new TextBox();
			SkoslaGodIzdavanja_TB = new TextBox();
			Izmeni_Btn = new Button();
			OsnovnipodaciopredmetuGB = new GroupBox();
			MaxBrStrana_TB = new TextBox();
			label4 = new Label();
			groupBox2 = new GroupBox();
			Pojedinacni_RB = new RadioButton();
			Grupni_RB = new RadioButton();
			OsnovnipodaciopredmetuGB.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Georgia", 9F);
			label1.Location = new System.Drawing.Point(8, 42);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(45, 15);
			label1.TabIndex = 0;
			label1.Text = "Naziv:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Georgia", 9F);
			label2.Location = new System.Drawing.Point(8, 74);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(144, 15);
			label2.TabIndex = 1;
			label2.Text = "Skolska god. zadavanja:";
			// 
			// Naziv_TB
			// 
			Naziv_TB.Location = new System.Drawing.Point(158, 39);
			Naziv_TB.Name = "Naziv_TB";
			Naziv_TB.Size = new System.Drawing.Size(217, 21);
			Naziv_TB.TabIndex = 0;
			// 
			// SkoslaGodIzdavanja_TB
			// 
			SkoslaGodIzdavanja_TB.Location = new System.Drawing.Point(158, 71);
			SkoslaGodIzdavanja_TB.Name = "SkoslaGodIzdavanja_TB";
			SkoslaGodIzdavanja_TB.Size = new System.Drawing.Size(217, 21);
			SkoslaGodIzdavanja_TB.TabIndex = 1;
			SkoslaGodIzdavanja_TB.KeyPress += SkoslaGodIzdavanja_TB_KeyPress;
			// 
			// Izmeni_Btn
			// 
			Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Izmeni_Btn.Location = new System.Drawing.Point(218, 204);
			Izmeni_Btn.Name = "Izmeni_Btn";
			Izmeni_Btn.Size = new System.Drawing.Size(157, 29);
			Izmeni_Btn.TabIndex = 5;
			Izmeni_Btn.Text = "Izmeni";
			Izmeni_Btn.UseVisualStyleBackColor = false;
			Izmeni_Btn.Click += Izmeni_Btn_Click;
			// 
			// OsnovnipodaciopredmetuGB
			// 
			OsnovnipodaciopredmetuGB.Controls.Add(MaxBrStrana_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label4);
			OsnovnipodaciopredmetuGB.Controls.Add(groupBox2);
			OsnovnipodaciopredmetuGB.Controls.Add(Izmeni_Btn);
			OsnovnipodaciopredmetuGB.Controls.Add(SkoslaGodIzdavanja_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label2);
			OsnovnipodaciopredmetuGB.Controls.Add(label1);
			OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
			OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
			OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
			OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(384, 239);
			OsnovnipodaciopredmetuGB.TabIndex = 0;
			OsnovnipodaciopredmetuGB.TabStop = false;
			OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o projektu";
			// 
			// MaxBrStrana_TB
			// 
			MaxBrStrana_TB.Location = new System.Drawing.Point(158, 104);
			MaxBrStrana_TB.Name = "MaxBrStrana_TB";
			MaxBrStrana_TB.Size = new System.Drawing.Size(217, 21);
			MaxBrStrana_TB.TabIndex = 2;
			MaxBrStrana_TB.KeyPress += MaxBrStrana_TB_KeyPress;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Georgia", 9F);
			label4.Location = new System.Drawing.Point(8, 107);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(150, 15);
			label4.TabIndex = 14;
			label4.Text = "Maksimalan broj strana:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(Pojedinacni_RB);
			groupBox2.Controls.Add(Grupni_RB);
			groupBox2.Location = new System.Drawing.Point(8, 131);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(367, 57);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Tip";
			// 
			// Pojedinacni_RB
			// 
			Pojedinacni_RB.AutoSize = true;
			Pojedinacni_RB.Location = new System.Drawing.Point(210, 30);
			Pojedinacni_RB.Name = "Pojedinacni_RB";
			Pojedinacni_RB.Size = new System.Drawing.Size(143, 19);
			Pojedinacni_RB.TabIndex = 4;
			Pojedinacni_RB.TabStop = true;
			Pojedinacni_RB.Text = "Pojedinacni projekat";
			Pojedinacni_RB.UseVisualStyleBackColor = true;
			// 
			// Grupni_RB
			// 
			Grupni_RB.AutoSize = true;
			Grupni_RB.Location = new System.Drawing.Point(14, 30);
			Grupni_RB.Name = "Grupni_RB";
			Grupni_RB.Size = new System.Drawing.Size(118, 19);
			Grupni_RB.TabIndex = 3;
			Grupni_RB.TabStop = true;
			Grupni_RB.Text = "Grupni projekat";
			Grupni_RB.UseVisualStyleBackColor = true;
			// 
			// IzmeniTeorijskiProjekat
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.AntiqueWhite;
			ClientSize = new System.Drawing.Size(406, 262);
			Controls.Add(OsnovnipodaciopredmetuGB);
			Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(422, 301);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(422, 301);
			Name = "IzmeniTeorijskiProjekat";
			Text = "Izmeni projekat";
			Load += IzmeniTeorijskiProjekat_Load;
			OsnovnipodaciopredmetuGB.ResumeLayout(false);
			OsnovnipodaciopredmetuGB.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
        private Label label2;
        private TextBox Naziv_TB;
        private TextBox SkoslaGodIzdavanja_TB;
        private Button Izmeni_Btn;
        private GroupBox OsnovnipodaciopredmetuGB;
        private GroupBox groupBox2;
        private RadioButton Pojedinacni_RB;
        private RadioButton Grupni_RB;
        private TextBox MaxBrStrana_TB;
        private Label label4;
    }
}