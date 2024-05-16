namespace StudentskiProjekti.Forme
{
    partial class IzmeniKnjigu
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
            OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(340, 217);
            OsnovnipodaciopredmetuGB.TabIndex = 0;
            OsnovnipodaciopredmetuGB.TabStop = false;
            OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o predmetu";
            // 
            // Dodaj_Btn
            // 
            Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Dodaj_Btn.Location = new System.Drawing.Point(202, 170);
            Dodaj_Btn.Name = "Dodaj_Btn";
            Dodaj_Btn.Size = new System.Drawing.Size(124, 29);
            Dodaj_Btn.TabIndex = 4;
            Dodaj_Btn.Text = "Dodaj";
            Dodaj_Btn.UseVisualStyleBackColor = false;
            // 
            // GodinaIzdanja_TB
            // 
            GodinaIzdanja_TB.Location = new System.Drawing.Point(109, 131);
            GodinaIzdanja_TB.Name = "GodinaIzdanja_TB";
            GodinaIzdanja_TB.Size = new System.Drawing.Size(217, 21);
            GodinaIzdanja_TB.TabIndex = 3;
            // 
            // Naziv_TB
            // 
            Naziv_TB.Location = new System.Drawing.Point(109, 68);
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
            // 
            // Izdavac_TB
            // 
            Izdavac_TB.Location = new System.Drawing.Point(109, 99);
            Izdavac_TB.Name = "Izdavac_TB";
            Izdavac_TB.Size = new System.Drawing.Size(217, 21);
            Izdavac_TB.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 9F);
            label4.Location = new System.Drawing.Point(6, 137);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Godina izdanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 9F);
            label3.Location = new System.Drawing.Point(8, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Izdavac:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 9F);
            label2.Location = new System.Drawing.Point(8, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(8, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // IzmeniKnjigu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(359, 235);
            Controls.Add(OsnovnipodaciopredmetuGB);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(375, 274);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(375, 274);
            Name = "IzmeniKnjigu";
            Text = "Izmeni knjigu";
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
        private TextBox ISBN_TB;
        private TextBox Izdavac_TB;
        private Button Dodaj_Btn;
        private TextBox GodinaIzdanja_TB;
        private Label label4;
    }
}