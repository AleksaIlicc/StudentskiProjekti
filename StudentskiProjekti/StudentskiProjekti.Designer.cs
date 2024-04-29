namespace StudentskiProjekti
{
    partial class StudentskiProjekti
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentskiProjekti));
			Predmeti_Btn = new Button();
			GlavniLogoPic = new PictureBox();
			StudentskiProjLab = new Label();
			Studenti_Btn = new Button();
			((System.ComponentModel.ISupportInitialize)GlavniLogoPic).BeginInit();
			SuspendLayout();
			// 
			// Predmeti_Btn
			// 
			Predmeti_Btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Predmeti_Btn.AutoSize = true;
			Predmeti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Predmeti_Btn.Font = new System.Drawing.Font("Georgia", 13.2000008F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Predmeti_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			Predmeti_Btn.Location = new System.Drawing.Point(60, 209);
			Predmeti_Btn.Margin = new Padding(3, 4, 3, 4);
			Predmeti_Btn.Name = "Predmeti_Btn";
			Predmeti_Btn.Size = new System.Drawing.Size(206, 57);
			Predmeti_Btn.TabIndex = 0;
			Predmeti_Btn.Text = "Predmeti";
			Predmeti_Btn.UseVisualStyleBackColor = false;
			Predmeti_Btn.Click += Predmeti_Btn_Click;
			// 
			// GlavniLogoPic
			// 
			GlavniLogoPic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			GlavniLogoPic.BackColor = System.Drawing.Color.AntiqueWhite;
			GlavniLogoPic.BackgroundImage = (System.Drawing.Image)resources.GetObject("GlavniLogoPic.BackgroundImage");
			GlavniLogoPic.BackgroundImageLayout = ImageLayout.Center;
			GlavniLogoPic.BorderStyle = BorderStyle.FixedSingle;
			GlavniLogoPic.Location = new System.Drawing.Point(110, 31);
			GlavniLogoPic.Name = "GlavniLogoPic";
			GlavniLogoPic.Size = new System.Drawing.Size(100, 100);
			GlavniLogoPic.SizeMode = PictureBoxSizeMode.AutoSize;
			GlavniLogoPic.TabIndex = 1;
			GlavniLogoPic.TabStop = false;
			// 
			// StudentskiProjLab
			// 
			StudentskiProjLab.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			StudentskiProjLab.AutoSize = true;
			StudentskiProjLab.Font = new System.Drawing.Font("Georgia", 15.2F);
			StudentskiProjLab.Location = new System.Drawing.Point(72, 145);
			StudentskiProjLab.MinimumSize = new System.Drawing.Size(179, 60);
			StudentskiProjLab.Name = "StudentskiProjLab";
			StudentskiProjLab.Size = new System.Drawing.Size(179, 60);
			StudentskiProjLab.TabIndex = 2;
			StudentskiProjLab.Text = "STUDENTSKI\r\nPROJEKTI";
			StudentskiProjLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Studenti_Btn
			// 
			Studenti_Btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Studenti_Btn.AutoSize = true;
			Studenti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
			Studenti_Btn.Font = new System.Drawing.Font("Georgia", 13.2000008F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Studenti_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			Studenti_Btn.Location = new System.Drawing.Point(60, 274);
			Studenti_Btn.Margin = new Padding(3, 4, 3, 4);
			Studenti_Btn.Name = "Studenti_Btn";
			Studenti_Btn.Size = new System.Drawing.Size(206, 57);
			Studenti_Btn.TabIndex = 3;
			Studenti_Btn.Text = "Studenti";
			Studenti_Btn.UseVisualStyleBackColor = false;
			Studenti_Btn.Click += Studenti_Btn_Click;
			// 
			// StudentskiProjekti
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(334, 361);
			Controls.Add(Studenti_Btn);
			Controls.Add(StudentskiProjLab);
			Controls.Add(GlavniLogoPic);
			Controls.Add(Predmeti_Btn);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(350, 400);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(350, 400);
			Name = "StudentskiProjekti";
			Text = "Pocetna stranica";
			((System.ComponentModel.ISupportInitialize)GlavniLogoPic).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button Predmeti_Btn;
        private PictureBox GlavniLogoPic;
        private Label StudentskiProjLab;
		private Button Studenti_Btn;
	}
}

