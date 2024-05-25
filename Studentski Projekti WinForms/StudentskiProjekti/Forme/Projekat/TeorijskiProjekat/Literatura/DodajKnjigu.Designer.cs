namespace StudentskiProjekti.Forme
{
    partial class DodajKnjigu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajKnjigu));
            OsnovnipodaciopredmetuGB = new GroupBox();
            Autori_TB = new TextBox();
            label6 = new Label();
            Dodaj_Btn = new Button();
            GodinaIzdanja_TB = new TextBox();
            Naziv_TB = new TextBox();
            ISBN_TB = new TextBox();
            Izdavac_TB = new TextBox();
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
            OsnovnipodaciopredmetuGB.Controls.Add(Dodaj_Btn);
            OsnovnipodaciopredmetuGB.Controls.Add(GodinaIzdanja_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(ISBN_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Izdavac_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(label4);
            OsnovnipodaciopredmetuGB.Controls.Add(label3);
            OsnovnipodaciopredmetuGB.Controls.Add(label2);
            OsnovnipodaciopredmetuGB.Controls.Add(label1);
            OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
            OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
            OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
            OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(340, 267);
            OsnovnipodaciopredmetuGB.TabIndex = 0;
            OsnovnipodaciopredmetuGB.TabStop = false;
            OsnovnipodaciopredmetuGB.Text = "Podaci o knjizi";
            // 
            // Autori_TB
            // 
            Autori_TB.Location = new System.Drawing.Point(109, 101);
            Autori_TB.Multiline = true;
            Autori_TB.Name = "Autori_TB";
            Autori_TB.Size = new System.Drawing.Size(217, 42);
            Autori_TB.TabIndex = 2;
            Autori_TB.KeyPress += Autori_TB_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Georgia", 9F);
            label6.Location = new System.Drawing.Point(6, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Autor/i:";
            // 
            // Dodaj_Btn
            // 
            Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Dodaj_Btn.Location = new System.Drawing.Point(202, 225);
            Dodaj_Btn.Name = "Dodaj_Btn";
            Dodaj_Btn.Size = new System.Drawing.Size(124, 29);
            Dodaj_Btn.TabIndex = 5;
            Dodaj_Btn.Text = "Dodaj";
            Dodaj_Btn.UseVisualStyleBackColor = false;
            Dodaj_Btn.Click += Dodaj_Btn_Click;
            // 
            // GodinaIzdanja_TB
            // 
            GodinaIzdanja_TB.Location = new System.Drawing.Point(109, 186);
            GodinaIzdanja_TB.Name = "GodinaIzdanja_TB";
            GodinaIzdanja_TB.Size = new System.Drawing.Size(217, 21);
            GodinaIzdanja_TB.TabIndex = 4;
            GodinaIzdanja_TB.KeyPress += Godina_TB_KeyPress;
            // 
            // Naziv_TB
            // 
            Naziv_TB.Location = new System.Drawing.Point(109, 70);
            Naziv_TB.Name = "Naziv_TB";
            Naziv_TB.Size = new System.Drawing.Size(217, 21);
            Naziv_TB.TabIndex = 1;
            // 
            // ISBN_TB
            // 
            ISBN_TB.Location = new System.Drawing.Point(109, 40);
            ISBN_TB.Name = "ISBN_TB";
            ISBN_TB.Size = new System.Drawing.Size(217, 21);
            ISBN_TB.TabIndex = 0;
            ISBN_TB.KeyPress += ISSN_TB_KeyPress;
            // 
            // Izdavac_TB
            // 
            Izdavac_TB.Location = new System.Drawing.Point(109, 154);
            Izdavac_TB.Name = "Izdavac_TB";
            Izdavac_TB.Size = new System.Drawing.Size(217, 21);
            Izdavac_TB.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 9F);
            label4.Location = new System.Drawing.Point(6, 189);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Godina izdanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 9F);
            label3.Location = new System.Drawing.Point(6, 157);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Izdavac:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 9F);
            label2.Location = new System.Drawing.Point(6, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(6, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // DodajKnjigu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(359, 291);
            Controls.Add(OsnovnipodaciopredmetuGB);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(375, 330);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(375, 330);
            Name = "DodajKnjigu";
            Text = "Dodaj knjigu";
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
        private TextBox ISBN_TB;
        private TextBox Izdavac_TB;
        private Button Dodaj_Btn;
        private TextBox GodinaIzdanja_TB;
        private Label label4;
		private TextBox Autori_TB;
		private Label label6;
	}
}