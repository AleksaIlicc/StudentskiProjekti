namespace StudentskiProjekti.Forme
{
    partial class PrakticniProjekti
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
            PrakticniProjekti_GB = new GroupBox();
            PrakticniProjekti_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            PrakticniProjekti_GB.SuspendLayout();
            SuspendLayout();
            // 
            // PrakticniProjekti_GB
            // 
            PrakticniProjekti_GB.Controls.Add(PrakticniProjekti_ListV);
            PrakticniProjekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PrakticniProjekti_GB.Location = new System.Drawing.Point(8, 12);
            PrakticniProjekti_GB.Name = "PrakticniProjekti_GB";
            PrakticniProjekti_GB.Size = new System.Drawing.Size(785, 323);
            PrakticniProjekti_GB.TabIndex = 3;
            PrakticniProjekti_GB.TabStop = false;
            PrakticniProjekti_GB.Text = "Prakticni Projekti";
            // 
            // PrakticniProjekti_ListV
            // 
            PrakticniProjekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            PrakticniProjekti_ListV.FullRowSelect = true;
            PrakticniProjekti_ListV.GridLines = true;
            PrakticniProjekti_ListV.Location = new System.Drawing.Point(7, 48);
            PrakticniProjekti_ListV.Name = "PrakticniProjekti_ListV";
            PrakticniProjekti_ListV.Size = new System.Drawing.Size(772, 269);
            PrakticniProjekti_ListV.TabIndex = 0;
            PrakticniProjekti_ListV.UseCompatibleStateImageBehavior = false;
            PrakticniProjekti_ListV.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Naziv";
            columnHeader1.Width = 430;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Skolska god. zadavanja";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vrsta projekta";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tip projekta";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // PrakticniProjekti
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(805, 624);
            Controls.Add(PrakticniProjekti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(821, 663);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(821, 663);
            Name = "PrakticniProjekti";
            Text = "Prakticni projekti";
            PrakticniProjekti_GB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PrakticniProjekti_GB;
        private ListView PrakticniProjekti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}