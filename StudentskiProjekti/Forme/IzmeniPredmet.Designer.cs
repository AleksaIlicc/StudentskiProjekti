namespace StudentskiProjekti.Forme
{
    partial class IzmeniPredmet
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
            Izmeni_Btn = new Button();
            Katedra_TB = new TextBox();
            Naziv_TB = new TextBox();
            Sifra_TB = new TextBox();
            Semestar_TB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            OsnovnipodaciopredmetuGB.SuspendLayout();
            SuspendLayout();
            // 
            // OsnovnipodaciopredmetuGB
            // 
            OsnovnipodaciopredmetuGB.Controls.Add(Izmeni_Btn);
            OsnovnipodaciopredmetuGB.Controls.Add(Katedra_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Sifra_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Semestar_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(label4);
            OsnovnipodaciopredmetuGB.Controls.Add(label3);
            OsnovnipodaciopredmetuGB.Controls.Add(label2);
            OsnovnipodaciopredmetuGB.Controls.Add(label1);
            OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
            OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(11, 10);
            OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
            OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(325, 201);
            OsnovnipodaciopredmetuGB.TabIndex = 1;
            OsnovnipodaciopredmetuGB.TabStop = false;
            OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o predmetu";
            // 
            // Izmeni_Btn
            // 
            Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Izmeni_Btn.Location = new System.Drawing.Point(184, 161);
            Izmeni_Btn.Name = "Izmeni_Btn";
            Izmeni_Btn.Size = new System.Drawing.Size(121, 29);
            Izmeni_Btn.TabIndex = 8;
            Izmeni_Btn.Text = "Izmeni";
            Izmeni_Btn.UseVisualStyleBackColor = false;
            Izmeni_Btn.Click += Izmeni_Btn_Click;
            // 
            // Katedra_TB
            // 
            Katedra_TB.Location = new System.Drawing.Point(88, 130);
            Katedra_TB.Name = "Katedra_TB";
            Katedra_TB.Size = new System.Drawing.Size(217, 25);
            Katedra_TB.TabIndex = 7;
            // 
            // Naziv_TB
            // 
            Naziv_TB.Location = new System.Drawing.Point(88, 68);
            Naziv_TB.Name = "Naziv_TB";
            Naziv_TB.Size = new System.Drawing.Size(217, 25);
            Naziv_TB.TabIndex = 6;
            // 
            // Sifra_TB
            // 
            Sifra_TB.Location = new System.Drawing.Point(88, 37);
            Sifra_TB.Name = "Sifra_TB";
            Sifra_TB.Size = new System.Drawing.Size(217, 25);
            Sifra_TB.TabIndex = 5;
            // 
            // Semestar_TB
            // 
            Semestar_TB.Location = new System.Drawing.Point(88, 99);
            Semestar_TB.Name = "Semestar_TB";
            Semestar_TB.Size = new System.Drawing.Size(217, 25);
            Semestar_TB.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 9F);
            label4.Location = new System.Drawing.Point(8, 137);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 18);
            label4.TabIndex = 3;
            label4.Text = "Katedra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 9F);
            label3.Location = new System.Drawing.Point(8, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 18);
            label3.TabIndex = 2;
            label3.Text = "Semestar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 9F);
            label2.Location = new System.Drawing.Point(8, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 18);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(8, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 18);
            label1.TabIndex = 0;
            label1.Text = "Sifra:";
            // 
            // IzmeniPredmet
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(346, 221);
            Controls.Add(OsnovnipodaciopredmetuGB);
            ForeColor = System.Drawing.SystemColors.ControlText;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(364, 268);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(364, 268);
            Name = "IzmeniPredmet";
            Text = "IzmeniPredmet";
            Load += IzmeniPredmet_Load;
            OsnovnipodaciopredmetuGB.ResumeLayout(false);
            OsnovnipodaciopredmetuGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OsnovnipodaciopredmetuGB;
        private Button Izmeni_Btn;
        private TextBox Katedra_TB;
        private TextBox Naziv_TB;
        private TextBox Sifra_TB;
        private TextBox Semestar_TB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}