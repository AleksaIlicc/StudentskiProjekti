namespace StudentskiProjekti
{
    partial class Form1
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
			button_1 = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// button_1
			// 
			button_1.Location = new System.Drawing.Point(308, 110);
			button_1.Name = "button_1";
			button_1.Size = new System.Drawing.Size(105, 23);
			button_1.TabIndex = 0;
			button_1.Text = "Duvaj ga Emina";
			button_1.UseVisualStyleBackColor = true;
			button_1.Click += button_1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(button_1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button button_1;
	}
}

