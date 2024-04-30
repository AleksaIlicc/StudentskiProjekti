namespace StudentskiProjekti.Forme
{
    partial class TeorijskiProjekti
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
            TeorijskiProjekti_GB = new GroupBox();
            TeorijskiProjekti_ListV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            TeorijskiProjekti_GB.SuspendLayout();
            SuspendLayout();
            // 
            // TeorijskiProjekti_GB
            // 
            TeorijskiProjekti_GB.Controls.Add(TeorijskiProjekti_ListV);
            TeorijskiProjekti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TeorijskiProjekti_GB.Location = new System.Drawing.Point(8, 12);
            TeorijskiProjekti_GB.Name = "TeorijskiProjekti_GB";
            TeorijskiProjekti_GB.Size = new System.Drawing.Size(785, 323);
            TeorijskiProjekti_GB.TabIndex = 3;
            TeorijskiProjekti_GB.TabStop = false;
            TeorijskiProjekti_GB.Text = "Teorijski Projekti";
            // 
            // TeorijskiProjekti_ListV
            // 
            TeorijskiProjekti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            TeorijskiProjekti_ListV.FullRowSelect = true;
            TeorijskiProjekti_ListV.GridLines = true;
            TeorijskiProjekti_ListV.Location = new System.Drawing.Point(6, 48);
            TeorijskiProjekti_ListV.Name = "TeorijskiProjekti_ListV";
            TeorijskiProjekti_ListV.Size = new System.Drawing.Size(773, 269);
            TeorijskiProjekti_ListV.TabIndex = 0;
            TeorijskiProjekti_ListV.UseCompatibleStateImageBehavior = false;
            TeorijskiProjekti_ListV.View = View.Details;
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
            // columnHeader5
            // 
            columnHeader5.Text = "Maksimalni br. strana";
            columnHeader5.Width = 120;
            // 
            // TeorijskiProjekti
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(805, 624);
            Controls.Add(TeorijskiProjekti_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(821, 663);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(821, 663);
            Name = "TeorijskiProjekti";
            Text = "Teorijski projekti";
            TeorijskiProjekti_GB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TeorijskiProjekti_GB;
        private ListView TeorijskiProjekti_ListV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}