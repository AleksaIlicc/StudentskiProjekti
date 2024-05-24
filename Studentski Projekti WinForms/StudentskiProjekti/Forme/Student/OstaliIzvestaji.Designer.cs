namespace StudentskiProjekti.Forme
{
    partial class OstaliIzvestaji
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
            label5 = new Label();
            Izvestaji_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            OstaliStudenti_GB.SuspendLayout();
            SuspendLayout();
            // 
            // OstaliStudenti_GB
            // 
            OstaliStudenti_GB.Controls.Add(label5);
            OstaliStudenti_GB.Controls.Add(Izvestaji_ListV);
            OstaliStudenti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OstaliStudenti_GB.Location = new System.Drawing.Point(12, 12);
            OstaliStudenti_GB.Name = "OstaliStudenti_GB";
            OstaliStudenti_GB.Size = new System.Drawing.Size(734, 259);
            OstaliStudenti_GB.TabIndex = 0;
            OstaliStudenti_GB.TabStop = false;
            OstaliStudenti_GB.Text = "Izvestaji ostalih studenata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(318, 15);
            label5.TabIndex = 11;
            label5.Text = "Duplim klikom na red mozete videti ceo opis izvestaja:";
            // 
            // Izvestaji_ListV
            // 
            Izvestaji_ListV.AccessibleRole = AccessibleRole.None;
            Izvestaji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7, columnHeader2, columnHeader3 });
            Izvestaji_ListV.FullRowSelect = true;
            Izvestaji_ListV.GridLines = true;
            Izvestaji_ListV.Location = new System.Drawing.Point(6, 48);
            Izvestaji_ListV.MultiSelect = false;
            Izvestaji_ListV.Name = "Izvestaji_ListV";
            Izvestaji_ListV.Size = new System.Drawing.Size(721, 203);
            Izvestaji_ListV.TabIndex = 1;
            Izvestaji_ListV.UseCompatibleStateImageBehavior = false;
            Izvestaji_ListV.View = View.Details;
            Izvestaji_ListV.DoubleClick += Izvestaji_ListV_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Br. indeksa";
            columnHeader1.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ime";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Prezime";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Opis";
            columnHeader2.Width = 290;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum predaje";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // OstaliIzvestaji
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(758, 281);
            Controls.Add(OstaliStudenti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(774, 320);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(774, 320);
            Name = "OstaliIzvestaji";
            Text = "Izvestaji";
            Load += OstaliIzvestaji_Load;
            OstaliStudenti_GB.ResumeLayout(false);
            OstaliStudenti_GB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox OstaliStudenti_GB;
        private ListView Izvestaji_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}