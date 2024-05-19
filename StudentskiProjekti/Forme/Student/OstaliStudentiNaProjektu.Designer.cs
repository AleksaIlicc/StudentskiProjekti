namespace StudentskiProjekti.Forme
{
    partial class OstaliStudentiNaProjektu
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
            OstaliStudenti_GB = new GroupBox();
            OstaliStudenti_ListV = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            OstaliStudenti_GB.SuspendLayout();
            SuspendLayout();
            // 
            // OstaliStudenti_GB
            // 
            OstaliStudenti_GB.Controls.Add(OstaliStudenti_ListV);
            OstaliStudenti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OstaliStudenti_GB.Location = new System.Drawing.Point(12, 12);
            OstaliStudenti_GB.Name = "OstaliStudenti_GB";
            OstaliStudenti_GB.Size = new System.Drawing.Size(319, 335);
            OstaliStudenti_GB.TabIndex = 0;
            OstaliStudenti_GB.TabStop = false;
            OstaliStudenti_GB.Text = "Studenti koji rade na istom projektu";
            // 
            // OstaliStudenti_ListV
            // 
            OstaliStudenti_ListV.AccessibleRole = AccessibleRole.None;
            OstaliStudenti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13 });
            OstaliStudenti_ListV.FullRowSelect = true;
            OstaliStudenti_ListV.GridLines = true;
            OstaliStudenti_ListV.Location = new System.Drawing.Point(8, 32);
            OstaliStudenti_ListV.MultiSelect = false;
            OstaliStudenti_ListV.Name = "OstaliStudenti_ListV";
            OstaliStudenti_ListV.Size = new System.Drawing.Size(305, 297);
            OstaliStudenti_ListV.TabIndex = 1;
            OstaliStudenti_ListV.UseCompatibleStateImageBehavior = false;
            OstaliStudenti_ListV.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Br. Indeksa";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Ime";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Prezime";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 100;
            // 
            // OstaliStudentiNaPProjektu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(339, 354);
            Controls.Add(OstaliStudenti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(355, 393);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(355, 393);
            Name = "OstaliStudentiNaPProjektu";
            Text = "Studenti";
            Load += OstaliStudentiNaPProjektu_Load;
            OstaliStudenti_GB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox OstaliStudenti_GB;
        private ListView OstaliStudenti_ListV;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}