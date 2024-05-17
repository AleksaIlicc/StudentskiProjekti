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
			OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
			OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
			OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(383, 204);
			OsnovnipodaciopredmetuGB.TabIndex = 0;
			OsnovnipodaciopredmetuGB.TabStop = false;
			OsnovnipodaciopredmetuGB.Text = "Podaci o radu";
			// 
			// Format_CB
			// 
			Format_CB.BackColor = System.Drawing.Color.White;
			Format_CB.DropDownStyle = ComboBoxStyle.DropDownList;
			Format_CB.ForeColor = System.Drawing.SystemColors.WindowText;
			Format_CB.FormattingEnabled = true;
			Format_CB.Location = new System.Drawing.Point(148, 100);
			Format_CB.Name = "Format_CB";
			Format_CB.Size = new System.Drawing.Size(217, 23);
			Format_CB.TabIndex = 5;
			// 
			// Izmeni_Btn
			// 
			Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Izmeni_Btn.Location = new System.Drawing.Point(241, 164);
			Izmeni_Btn.Name = "Izmeni_Btn";
			Izmeni_Btn.Size = new System.Drawing.Size(124, 29);
			Izmeni_Btn.TabIndex = 4;
			Izmeni_Btn.Text = "Izmeni";
			Izmeni_Btn.UseVisualStyleBackColor = false;
			Izmeni_Btn.Click += Izmeni_Btn_Click;
			// 
			// KonfObjavljivanja_TB
			// 
			KonfObjavljivanja_TB.Location = new System.Drawing.Point(148, 127);
			KonfObjavljivanja_TB.Name = "KonfObjavljivanja_TB";
			KonfObjavljivanja_TB.Size = new System.Drawing.Size(217, 21);
			KonfObjavljivanja_TB.TabIndex = 3;
			// 
			// Naziv_TB
			// 
			Naziv_TB.Location = new System.Drawing.Point(148, 45);
			Naziv_TB.Name = "Naziv_TB";
			Naziv_TB.Size = new System.Drawing.Size(217, 21);
			Naziv_TB.TabIndex = 1;
			// 
			// URL_TB
			// 
			URL_TB.Location = new System.Drawing.Point(148, 73);
			URL_TB.Name = "URL_TB";
			URL_TB.Size = new System.Drawing.Size(217, 21);
			URL_TB.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Georgia", 9F);
			label4.Location = new System.Drawing.Point(20, 130);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(122, 15);
			label4.TabIndex = 3;
			label4.Text = "Konf. objavljivanja:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Georgia", 9F);
			label3.Location = new System.Drawing.Point(20, 103);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(54, 15);
			label3.TabIndex = 2;
			label3.Text = "Format:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Georgia", 9F);
			label2.Location = new System.Drawing.Point(20, 48);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(45, 15);
			label2.TabIndex = 1;
			label2.Text = "Naziv:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Georgia", 9F);
			label1.Location = new System.Drawing.Point(20, 76);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 15);
			label1.TabIndex = 0;
			label1.Text = "URL:";
			// 
			// IzmeniRad
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.AntiqueWhite;
			ClientSize = new System.Drawing.Size(403, 223);
			Controls.Add(OsnovnipodaciopredmetuGB);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(419, 262);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(419, 262);
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
        private TextBox Katedra_TB;
        private TextBox Naziv_TB;
        private TextBox URL_TB;
        private Button Izmeni_Btn;
        private TextBox KonfObjavljivanja_TB;
        private Label label4;
		private ComboBox Format_CB;
	}
}