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
			PredmetiBtn = new Button();
			GlavniLogoPic = new PictureBox();
			StudentskiProjLab = new Label();
			((System.ComponentModel.ISupportInitialize)GlavniLogoPic).BeginInit();
			SuspendLayout();
			// 
			// PredmetiBtn
			// 
			PredmetiBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PredmetiBtn.AutoSize = true;
			PredmetiBtn.BackColor = System.Drawing.Color.AntiqueWhite;
			PredmetiBtn.Font = new System.Drawing.Font("Georgia", 13.2000008F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			PredmetiBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			PredmetiBtn.Location = new System.Drawing.Point(60, 232);
			PredmetiBtn.Margin = new Padding(3, 4, 3, 4);
			PredmetiBtn.Name = "PredmetiBtn";
			PredmetiBtn.Size = new System.Drawing.Size(206, 57);
			PredmetiBtn.TabIndex = 0;
			PredmetiBtn.Text = "Predmeti";
			PredmetiBtn.UseVisualStyleBackColor = false;
			PredmetiBtn.Click += prodavnica_btn_clk;
			// 
			// GlavniLogoPic
			// 
			GlavniLogoPic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			GlavniLogoPic.BackColor = System.Drawing.Color.AntiqueWhite;
			GlavniLogoPic.BackgroundImage = (System.Drawing.Image)resources.GetObject("GlavniLogoPic.BackgroundImage");
			GlavniLogoPic.BackgroundImageLayout = ImageLayout.Center;
			GlavniLogoPic.BorderStyle = BorderStyle.FixedSingle;
			GlavniLogoPic.Location = new System.Drawing.Point(110, 34);
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
			StudentskiProjLab.Location = new System.Drawing.Point(72, 148);
			StudentskiProjLab.MinimumSize = new System.Drawing.Size(179, 60);
			StudentskiProjLab.Name = "StudentskiProjLab";
			StudentskiProjLab.Size = new System.Drawing.Size(179, 60);
			StudentskiProjLab.TabIndex = 2;
			StudentskiProjLab.Text = "STUDENTSKI\r\nPROJEKTI";
			StudentskiProjLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// StudentskiProjekti
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = System.Drawing.Color.Linen;
			ClientSize = new System.Drawing.Size(334, 361);
			Controls.Add(StudentskiProjLab);
			Controls.Add(GlavniLogoPic);
			Controls.Add(PredmetiBtn);
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

		private System.Windows.Forms.Button PredmetiBtn;
        private PictureBox GlavniLogoPic;
        private Label StudentskiProjLab;
    }
}

