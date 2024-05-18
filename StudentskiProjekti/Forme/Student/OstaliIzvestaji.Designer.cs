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
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
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
            OstaliStudenti_GB.Size = new System.Drawing.Size(713, 273);
            OstaliStudenti_GB.TabIndex = 0;
            OstaliStudenti_GB.TabStop = false;
            OstaliStudenti_GB.Text = "Izvestaji ostalih studenata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 43);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(342, 18);
            label5.TabIndex = 11;
            label5.Text = "Duplim klikom na red mozete videti opis izvestaja:";
            // 
            // Izvestaji_ListV
            // 
            Izvestaji_ListV.AccessibleRole = AccessibleRole.None;
            Izvestaji_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7, columnHeader4, columnHeader5, columnHeader9 });
            Izvestaji_ListV.FullRowSelect = true;
            Izvestaji_ListV.GridLines = true;
            Izvestaji_ListV.Location = new System.Drawing.Point(6, 64);
            Izvestaji_ListV.MultiSelect = false;
            Izvestaji_ListV.Name = "Izvestaji_ListV";
            Izvestaji_ListV.Size = new System.Drawing.Size(697, 203);
            Izvestaji_ListV.TabIndex = 1;
            Izvestaji_ListV.UseCompatibleStateImageBehavior = false;
            Izvestaji_ListV.View = View.Details;
            Izvestaji_ListV.DoubleClick += Izvestaji_ListV_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Br. indeksa";
            columnHeader1.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ime";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Prezime";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum poc. izrade";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Datum zavr. izrade";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Rok za zavrsetak izrade";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 170;
            // 
            // OstaliIzvestaji
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(737, 297);
            Controls.Add(OstaliStudenti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private Label label5;
    }
}