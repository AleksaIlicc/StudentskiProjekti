namespace StudentskiProjekti.Forme
{
    partial class IzmeniRad
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
			Autori_TB = new TextBox();
			label6 = new Label();
			Format_CB = new ComboBox();
			Izmeni_Btn = new Button();
			KonfObjavljivanja_TB = new TextBox();
			Naziv_TB = new TextBox();
			URL_TB = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			OsnovnipodaciopredmetuGB.SuspendLayout();
			SuspendLayout();
			// 
			// OsnovnipodaciopredmetuGB
			// 
			OsnovnipodaciopredmetuGB.Controls.Add(Autori_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label6);
			OsnovnipodaciopredmetuGB.Controls.Add(Format_CB);
			OsnovnipodaciopredmetuGB.Controls.Add(Izmeni_Btn);
			OsnovnipodaciopredmetuGB.Controls.Add(KonfObjavljivanja_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(URL_TB);
			OsnovnipodaciopredmetuGB.Controls.Add(label4);
			OsnovnipodaciopredmetuGB.Controls.Add(label3);
			OsnovnipodaciopredmetuGB.Controls.Add(label2);
			OsnovnipodaciopredmetuGB.Controls.Add(label1);
			OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
			OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(3, 12);
			OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
			OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(363, 250);
			OsnovnipodaciopredmetuGB.TabIndex = 0;
			OsnovnipodaciopredmetuGB.TabStop = false;
			OsnovnipodaciopredmetuGB.Text = "Podaci o radu";
			// 
			// Autori_TB
			// 
			Autori_TB.Location = new System.Drawing.Point(135, 77);
			Autori_TB.Multiline = true;
			Autori_TB.Name = "Autori_TB";
			Autori_TB.Size = new System.Drawing.Size(217, 42);
			Autori_TB.TabIndex = 1;
			Autori_TB.KeyPress += Autori_TB_KeyPress;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Georgia", 9F);
			label6.Location = new System.Drawing.Point(9, 80);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(55, 15);
			label6.TabIndex = 14;
			label6.Text = "Autor/i:";
			// 
			// Format_CB
			// 
			Format_CB.BackColor = System.Drawing.Color.White;
			Format_CB.DropDownStyle = ComboBoxStyle.DropDownList;
			Format_CB.ForeColor = System.Drawing.SystemColors.WindowText;
			Format_CB.FormattingEnabled = true;
			Format_CB.Location = new System.Drawing.Point(135, 154);
			Format_CB.Name = "Format_CB";
			Format_CB.Size = new System.Drawing.Size(217, 23);
			Format_CB.TabIndex = 3;
			// 
			// Izmeni_Btn
			// 
			Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Izmeni_Btn.Location = new System.Drawing.Point(228, 210);
			Izmeni_Btn.Name = "Izmeni_Btn";
			Izmeni_Btn.Size = new System.Drawing.Size(124, 29);
			Izmeni_Btn.TabIndex = 5;
			Izmeni_Btn.Text = "Izmeni";
			Izmeni_Btn.UseVisualStyleBackColor = false;
			Izmeni_Btn.Click += Izmeni_Btn_Click;
			// 
			// KonfObjavljivanja_TB
			// 
			KonfObjavljivanja_TB.Location = new System.Drawing.Point(135, 181);
			KonfObjavljivanja_TB.Name = "KonfObjavljivanja_TB";
			KonfObjavljivanja_TB.Size = new System.Drawing.Size(217, 21);
			KonfObjavljivanja_TB.TabIndex = 4;
			// 
			// Naziv_TB
			// 
			Naziv_TB.Location = new System.Drawing.Point(135, 45);
			Naziv_TB.Name = "Naziv_TB";
			Naziv_TB.Size = new System.Drawing.Size(217, 21);
			Naziv_TB.TabIndex = 0;
			// 
			// URL_TB
			// 
			URL_TB.Location = new System.Drawing.Point(135, 127);
			URL_TB.Name = "URL_TB";
			URL_TB.Size = new System.Drawing.Size(217, 21);
			URL_TB.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Georgia", 9F);
			label4.Location = new System.Drawing.Point(9, 184);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(122, 15);
			label4.TabIndex = 3;
			label4.Text = "Konf. objavljivanja:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Georgia", 9F);
			label3.Location = new System.Drawing.Point(9, 157);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(54, 15);
			label3.TabIndex = 2;
			label3.Text = "Format:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Georgia", 9F);
			label2.Location = new System.Drawing.Point(9, 48);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(45, 15);
			label2.TabIndex = 1;
			label2.Text = "Naziv:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Georgia", 9F);
			label1.Location = new System.Drawing.Point(9, 130);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 15);
			label1.TabIndex = 0;
			label1.Text = "URL:";
			// 
			// IzmeniRad
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.AntiqueWhite;
			ClientSize = new System.Drawing.Size(374, 273);
			Controls.Add(OsnovnipodaciopredmetuGB);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(390, 312);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(390, 312);
			Name = "IzmeniRad";
			Text = "Izmeni rad";
			Load += IzmeniRad_Load;
			OsnovnipodaciopredmetuGB.ResumeLayout(false);
			OsnovnipodaciopredmetuGB.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox OsnovnipodaciopredmetuGB;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Naziv_TB;
        private TextBox URL_TB;
        private Button Izmeni_Btn;
        private TextBox KonfObjavljivanja_TB;
        private Label label4;
		private ComboBox Format_CB;
		private TextBox Autori_TB;
		private Label label6;
	}
}