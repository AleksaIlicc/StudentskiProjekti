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
            button_1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_1
            // 
            button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_1.AutoSize = true;
            button_1.Font = new System.Drawing.Font("Segoe UI", 13F);
            button_1.Location = new System.Drawing.Point(59, 233);
            button_1.Margin = new Padding(3, 4, 3, 4);
            button_1.Name = "button_1";
            button_1.Size = new System.Drawing.Size(206, 57);
            button_1.TabIndex = 0;
            button_1.Text = "Predmeti";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(110, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 15.2F);
            label1.Location = new System.Drawing.Point(72, 148);
            label1.MinimumSize = new System.Drawing.Size(179, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 60);
            label1.TabIndex = 2;
            label1.Text = "STUDENTSKI\r\nPROJEKTI";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentskiProjekti
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(332, 353);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button_1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(350, 400);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(350, 400);
            Name = "StudentskiProjekti";
            Text = "Studentski Projekti";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}

