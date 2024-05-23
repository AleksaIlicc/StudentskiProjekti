namespace StudentskiProjekti.Forme
{
	partial class DodajPostojecuLiteraturu
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
            Literature_GB = new GroupBox();
            PrikaziAutore_Btn = new Button();
            Literature_ListV = new ListView();
            columnHeader14 = new ColumnHeader();
            ObrisiKnjigu_Btn = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            Literature_GB.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Literature_GB
            // 
            Literature_GB.Controls.Add(PrikaziAutore_Btn);
            Literature_GB.Controls.Add(Literature_ListV);
            Literature_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Literature_GB.Location = new System.Drawing.Point(7, 12);
            Literature_GB.Name = "Literature_GB";
            Literature_GB.Size = new System.Drawing.Size(589, 539);
            Literature_GB.TabIndex = 0;
            Literature_GB.TabStop = false;
            Literature_GB.Text = "Literature:";
            // 
            // PrikaziAutore_Btn
            // 
            PrikaziAutore_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            PrikaziAutore_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            PrikaziAutore_Btn.Location = new System.Drawing.Point(425, 502);
            PrikaziAutore_Btn.Name = "PrikaziAutore_Btn";
            PrikaziAutore_Btn.Size = new System.Drawing.Size(158, 31);
            PrikaziAutore_Btn.TabIndex = 4;
            PrikaziAutore_Btn.Text = "Prikazi autore literature";
            PrikaziAutore_Btn.UseVisualStyleBackColor = false;
            // 
            // Literature_ListV
            // 
            Literature_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader14 });
            Literature_ListV.FullRowSelect = true;
            Literature_ListV.GridLines = true;
            Literature_ListV.Location = new System.Drawing.Point(5, 20);
            Literature_ListV.MultiSelect = false;
            Literature_ListV.Name = "Literature_ListV";
            Literature_ListV.Size = new System.Drawing.Size(578, 476);
            Literature_ListV.TabIndex = 1;
            Literature_ListV.UseCompatibleStateImageBehavior = false;
            Literature_ListV.View = View.Details;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Naziv";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 550;
            // 
            // ObrisiKnjigu_Btn
            // 
            ObrisiKnjigu_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
            ObrisiKnjigu_Btn.Font = new System.Drawing.Font("Georgia", 9F);
            ObrisiKnjigu_Btn.Location = new System.Drawing.Point(12, 607);
            ObrisiKnjigu_Btn.Name = "ObrisiKnjigu_Btn";
            ObrisiKnjigu_Btn.Size = new System.Drawing.Size(127, 59);
            ObrisiKnjigu_Btn.TabIndex = 2;
            ObrisiKnjigu_Btn.Text = "Obrisi sva pojavljivanja literature";
            ObrisiKnjigu_Btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.AntiqueWhite;
            button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(463, 607);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(127, 59);
            button1.TabIndex = 3;
            button1.Text = "Dodaj literature za projekat";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(221, 21);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.AntiqueWhite;
            button2.Font = new System.Drawing.Font("Georgia", 9F);
            button2.Location = new System.Drawing.Point(77, 52);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(77, 30);
            button2.TabIndex = 5;
            button2.Text = "Pretrazi";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new System.Drawing.Point(184, 578);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(233, 88);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // DodajPostojecuLiteraturu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Linen;
            ClientSize = new System.Drawing.Size(601, 672);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(ObrisiKnjigu_Btn);
            Controls.Add(Literature_GB);
            Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "DodajPostojecuLiteraturu";
            Text = " ";
            Load += DodajPostojecuLiteraturu_Load;
            Literature_GB.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Literature_GB;
        private ListView Literature_ListV;
        private Button ObrisiKnjigu_Btn;
        private ColumnHeader columnHeader14;
        private Button PrikaziAutore_Btn;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox1;
    }
}