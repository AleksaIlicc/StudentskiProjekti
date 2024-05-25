namespace StudentskiProjekti.Forme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPrepWebStranica));
            Dodaj_Btn = new Button();
            Naziv_TB = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Dodaj_Btn
            // 
            Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            Dodaj_Btn.Location = new System.Drawing.Point(182, 73);
            Dodaj_Btn.Margin = new Padding(3, 2, 3, 2);
            Dodaj_Btn.Name = "Dodaj_Btn";
            Dodaj_Btn.Size = new System.Drawing.Size(122, 29);
            Dodaj_Btn.TabIndex = 1;
            Dodaj_Btn.Text = "Dodaj";
            Dodaj_Btn.UseVisualStyleBackColor = false;
            Dodaj_Btn.Click += Dodaj_Btn_Click;
            // 
            // Naziv_TB
            // 
            Naziv_TB.Location = new System.Drawing.Point(80, 33);
            Naziv_TB.Margin = new Padding(3, 2, 3, 2);
            Naziv_TB.Name = "Naziv_TB";
            Naziv_TB.Size = new System.Drawing.Size(224, 23);
            Naziv_TB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 9F);
            label1.Location = new System.Drawing.Point(10, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Naziv:";
            // 
            // DodajPrepWebStranica
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(315, 111);
            Controls.Add(label1);
            Controls.Add(Naziv_TB);
            Controls.Add(Dodaj_Btn);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(331, 150);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(331, 150);
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