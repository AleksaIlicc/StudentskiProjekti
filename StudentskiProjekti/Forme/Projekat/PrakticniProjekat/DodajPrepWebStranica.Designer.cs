namespace StudentskiProjekti.Forme.Projekat.PrakticniProjekat
{
    partial class DodajPrepWebStranica
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
            Dodaj_Btn = new Button();
            Naziv_TB = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Dodaj_Btn
            // 
            Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Dodaj_Btn.Location = new System.Drawing.Point(208, 97);
            Dodaj_Btn.Name = "Dodaj_Btn";
            Dodaj_Btn.Size = new System.Drawing.Size(140, 39);
            Dodaj_Btn.TabIndex = 1;
            Dodaj_Btn.Text = "Dodaj";
            Dodaj_Btn.UseVisualStyleBackColor = false;
            Dodaj_Btn.Click += Dodaj_Btn_Click;
            // 
            // Naziv_TB
            // 
            Naziv_TB.Location = new System.Drawing.Point(92, 44);
            Naziv_TB.Name = "Naziv_TB";
            Naziv_TB.Size = new System.Drawing.Size(256, 27);
            Naziv_TB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(12, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 18);
            label1.TabIndex = 7;
            label1.Text = "Naziv:";
            // 
            // DodajPrepWebStranica
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(360, 148);
            Controls.Add(label1);
            Controls.Add(Naziv_TB);
            Controls.Add(Dodaj_Btn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajPrepWebStranica";
            Text = "Dodaj preporucenu web stranicu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Dodaj_Btn;
        private TextBox Naziv_TB;
        private Label label1;
    }
}