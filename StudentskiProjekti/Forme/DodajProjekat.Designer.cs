namespace StudentskiProjekti.Forme
{
    partial class DodajProjekat
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
            label3 = new Label();
            Semestar_TB = new TextBox();
            Naziv_TB = new TextBox();
            SkoslaGodIzdavanja_TB = new TextBox();
            Dodaj_Btn = new Button();
            Teorijski_RB = new RadioButton();
            OsnovnipodaciopredmetuGB = new GroupBox();
            groupBox2 = new GroupBox();
            Pojedinacni_RB = new RadioButton();
            Grupni_RB = new RadioButton();
            Tip = new GroupBox();
            Prakticni_RB = new RadioButton();
            OsnovnipodaciopredmetuGB.SuspendLayout();
            groupBox2.SuspendLayout();
            Tip.SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 9F);
            label3.Location = new System.Drawing.Point(8, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Semestar:";
            // 
            // Semestar_TB
            // 
            Semestar_TB.Location = new System.Drawing.Point(158, 106);
            Semestar_TB.Name = "Semestar_TB";
            Semestar_TB.Size = new System.Drawing.Size(217, 21);
            Semestar_TB.TabIndex = 2;
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
            // 
            // Dodaj_Btn
            // 
            Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Dodaj_Btn.Location = new System.Drawing.Point(218, 281);
            Dodaj_Btn.Name = "Dodaj_Btn";
            Dodaj_Btn.Size = new System.Drawing.Size(157, 29);
            Dodaj_Btn.TabIndex = 4;
            Dodaj_Btn.Text = "Dodaj";
            Dodaj_Btn.UseVisualStyleBackColor = false;
            // 
            // Teorijski_RB
            // 
            Teorijski_RB.AutoSize = true;
            Teorijski_RB.Location = new System.Drawing.Point(14, 30);
            Teorijski_RB.Name = "Teorijski_RB";
            Teorijski_RB.Size = new System.Drawing.Size(126, 19);
            Teorijski_RB.TabIndex = 7;
            Teorijski_RB.TabStop = true;
            Teorijski_RB.Text = "Teorijski projekat";
            Teorijski_RB.UseVisualStyleBackColor = true;
            // 
            // OsnovnipodaciopredmetuGB
            // 
            OsnovnipodaciopredmetuGB.Controls.Add(groupBox2);
            OsnovnipodaciopredmetuGB.Controls.Add(Tip);
            OsnovnipodaciopredmetuGB.Controls.Add(Dodaj_Btn);
            OsnovnipodaciopredmetuGB.Controls.Add(SkoslaGodIzdavanja_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(Semestar_TB);
            OsnovnipodaciopredmetuGB.Controls.Add(label3);
            OsnovnipodaciopredmetuGB.Controls.Add(label2);
            OsnovnipodaciopredmetuGB.Controls.Add(label1);
            OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
            OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
            OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
            OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(384, 318);
            OsnovnipodaciopredmetuGB.TabIndex = 0;
            OsnovnipodaciopredmetuGB.TabStop = false;
            OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o projektu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Pojedinacni_RB);
            groupBox2.Controls.Add(Grupni_RB);
            groupBox2.Location = new System.Drawing.Point(8, 203);
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
            Pojedinacni_RB.TabIndex = 10;
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
            Grupni_RB.TabIndex = 9;
            Grupni_RB.TabStop = true;
            Grupni_RB.Text = "Grupni projekat";
            Grupni_RB.UseVisualStyleBackColor = true;
            // 
            // Tip
            // 
            Tip.Controls.Add(Prakticni_RB);
            Tip.Controls.Add(Teorijski_RB);
            Tip.Location = new System.Drawing.Point(8, 140);
            Tip.Name = "Tip";
            Tip.Size = new System.Drawing.Size(367, 57);
            Tip.TabIndex = 11;
            Tip.TabStop = false;
            Tip.Text = "Vrsta";
            // 
            // Prakticni_RB
            // 
            Prakticni_RB.AutoSize = true;
            Prakticni_RB.Location = new System.Drawing.Point(210, 30);
            Prakticni_RB.Name = "Prakticni_RB";
            Prakticni_RB.Size = new System.Drawing.Size(130, 19);
            Prakticni_RB.TabIndex = 8;
            Prakticni_RB.TabStop = true;
            Prakticni_RB.Text = "Prakticni projekat";
            Prakticni_RB.UseVisualStyleBackColor = true;
            // 
            // DodajProjekat
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(406, 339);
            Controls.Add(OsnovnipodaciopredmetuGB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(422, 378);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(422, 378);
            Name = "DodajProjekat";
            Text = "Dodaj projekat";
            OsnovnipodaciopredmetuGB.ResumeLayout(false);
            OsnovnipodaciopredmetuGB.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            Tip.ResumeLayout(false);
            Tip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Semestar_TB;
        private TextBox Naziv_TB;
        private TextBox SkoslaGodIzdavanja_TB;
        private Button Dodaj_Btn;
        private RadioButton Teorijski_RB;
        private GroupBox OsnovnipodaciopredmetuGB;
        private GroupBox groupBox2;
        private RadioButton Pojedinacni_RB;
        private RadioButton Grupni_RB;
        private GroupBox Tip;
        private RadioButton Prakticni_RB;
    }
}