namespace StudentskiProjekti.Forme
{
    partial class IzmeniIzvestaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniIzvestaj));
            OsnovniPodOIzvestaju = new GroupBox();
            DatumPredaje_DP = new DateTimePicker();
            Izmeni_Btn = new Button();
            Opis_TB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            OsnovniPodOIzvestaju.SuspendLayout();
            SuspendLayout();
            // 
            // OsnovniPodOIzvestaju
            // 
            OsnovniPodOIzvestaju.Controls.Add(DatumPredaje_DP);
            OsnovniPodOIzvestaju.Controls.Add(Izmeni_Btn);
            OsnovniPodOIzvestaju.Controls.Add(Opis_TB);
            OsnovniPodOIzvestaju.Controls.Add(label2);
            OsnovniPodOIzvestaju.Controls.Add(label1);
            OsnovniPodOIzvestaju.Font = new System.Drawing.Font("Georgia", 9F);
            OsnovniPodOIzvestaju.Location = new System.Drawing.Point(6, 12);
            OsnovniPodOIzvestaju.Name = "OsnovniPodOIzvestaju";
            OsnovniPodOIzvestaju.Size = new System.Drawing.Size(347, 155);
            OsnovniPodOIzvestaju.TabIndex = 0;
            OsnovniPodOIzvestaju.TabStop = false;
            OsnovniPodOIzvestaju.Text = "Osnovni podaci o izvestaju";
            // 
            // DatumPredaje_DP
            // 
            DatumPredaje_DP.Location = new System.Drawing.Point(110, 69);
            DatumPredaje_DP.Name = "DatumPredaje_DP";
            DatumPredaje_DP.Size = new System.Drawing.Size(231, 21);
            DatumPredaje_DP.TabIndex = 5;
            // 
            // Izmeni_Btn
            // 
            Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Izmeni_Btn.Location = new System.Drawing.Point(220, 106);
            Izmeni_Btn.Name = "Izmeni_Btn";
            Izmeni_Btn.Size = new System.Drawing.Size(121, 29);
            Izmeni_Btn.TabIndex = 4;
            Izmeni_Btn.Text = "Izmeni";
            Izmeni_Btn.UseVisualStyleBackColor = false;
            Izmeni_Btn.Click += Izmeni_Btn_Click;
            // 
            // Opis_TB
            // 
            Opis_TB.Location = new System.Drawing.Point(110, 30);
            Opis_TB.Name = "Opis_TB";
            Opis_TB.Size = new System.Drawing.Size(231, 21);
            Opis_TB.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 9F);
            label2.Location = new System.Drawing.Point(9, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "DatumPredaje:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(9, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Opis:";
            // 
            // IzmeniIzvestaj
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(358, 172);
            Controls.Add(OsnovniPodOIzvestaju);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(374, 211);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(374, 211);
            Name = "IzmeniIzvestaj";
            Text = "Izmeni izvestaj";
            Load += IzmeniIzvestaj_Load;
            OsnovniPodOIzvestaju.ResumeLayout(false);
            OsnovniPodOIzvestaju.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OsnovniPodOIzvestaju;
        private Label label2;
        private Label label1;
        private TextBox Opis_TB;
        private Button Izmeni_Btn;
        private DateTimePicker DatumPredaje_DP;
    }
}