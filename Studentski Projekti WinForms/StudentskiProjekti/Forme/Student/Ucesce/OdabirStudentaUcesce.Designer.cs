namespace StudentskiProjekti.Forme;

partial class OdabirStudentaUcesce
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
        Studenti_GB = new GroupBox();
        Studenti_ListV = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        Prikaz_GB = new GroupBox();
        Smer_TB = new TextBox();
        label4 = new Label();
        Prezime_TB = new TextBox();
        label3 = new Label();
        Ocisti_Btn = new Button();
        Sortiraj_Btn = new Button();
        label2 = new Label();
        label1 = new Label();
        BrojIndeksa_TB = new TextBox();
        Ime_TB = new TextBox();
        Izaberi_Btn = new Button();
        Studenti_GB.SuspendLayout();
        Prikaz_GB.SuspendLayout();
        SuspendLayout();
        // 
        // Studenti_GB
        // 
        Studenti_GB.Controls.Add(Studenti_ListV);
        Studenti_GB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        Studenti_GB.Location = new System.Drawing.Point(8, 12);
        Studenti_GB.Name = "Studenti_GB";
        Studenti_GB.Size = new System.Drawing.Size(736, 323);
        Studenti_GB.TabIndex = 0;
        Studenti_GB.TabStop = false;
        Studenti_GB.Text = "Studenti";
        // 
        // Studenti_ListV
        // 
        Studenti_ListV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
        Studenti_ListV.FullRowSelect = true;
        Studenti_ListV.GridLines = true;
        Studenti_ListV.Location = new System.Drawing.Point(7, 48);
        Studenti_ListV.MultiSelect = false;
        Studenti_ListV.Name = "Studenti_ListV";
        Studenti_ListV.Size = new System.Drawing.Size(723, 269);
        Studenti_ListV.TabIndex = 0;
        Studenti_ListV.UseCompatibleStateImageBehavior = false;
        Studenti_ListV.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Broj indeksa";
        columnHeader1.Width = 90;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Ime";
        columnHeader2.TextAlign = HorizontalAlignment.Center;
        columnHeader2.Width = 130;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Ime roditelja";
        columnHeader3.TextAlign = HorizontalAlignment.Center;
        columnHeader3.Width = 130;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Prezime";
        columnHeader4.TextAlign = HorizontalAlignment.Center;
        columnHeader4.Width = 130;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Smer";
        columnHeader5.TextAlign = HorizontalAlignment.Center;
        columnHeader5.Width = 215;
        // 
        // Prikaz_GB
        // 
        Prikaz_GB.Controls.Add(Smer_TB);
        Prikaz_GB.Controls.Add(label4);
        Prikaz_GB.Controls.Add(Prezime_TB);
        Prikaz_GB.Controls.Add(label3);
        Prikaz_GB.Controls.Add(Ocisti_Btn);
        Prikaz_GB.Controls.Add(Sortiraj_Btn);
        Prikaz_GB.Controls.Add(label2);
        Prikaz_GB.Controls.Add(label1);
        Prikaz_GB.Controls.Add(BrojIndeksa_TB);
        Prikaz_GB.Controls.Add(Ime_TB);
        Prikaz_GB.Location = new System.Drawing.Point(15, 365);
        Prikaz_GB.Name = "Prikaz_GB";
        Prikaz_GB.Size = new System.Drawing.Size(296, 204);
        Prikaz_GB.TabIndex = 2;
        Prikaz_GB.TabStop = false;
        Prikaz_GB.Text = "Prikaz";
        // 
        // Smer_TB
        // 
        Smer_TB.Location = new System.Drawing.Point(164, 136);
        Smer_TB.Name = "Smer_TB";
        Smer_TB.Size = new System.Drawing.Size(108, 21);
        Smer_TB.TabIndex = 3;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(16, 139);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(86, 15);
        label4.TabIndex = 13;
        label4.Text = "Unesite smer:";
        // 
        // Prezime_TB
        // 
        Prezime_TB.Location = new System.Drawing.Point(164, 99);
        Prezime_TB.Name = "Prezime_TB";
        Prezime_TB.Size = new System.Drawing.Size(108, 21);
        Prezime_TB.TabIndex = 2;
        Prezime_TB.KeyPress += Prezime_TB_KeyPress;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(16, 102);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(103, 15);
        label3.TabIndex = 11;
        label3.Text = "Unesite prezime:";
        // 
        // Ocisti_Btn
        // 
        Ocisti_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
        Ocisti_Btn.Font = new System.Drawing.Font("Georgia", 9F);
        Ocisti_Btn.Location = new System.Drawing.Point(145, 170);
        Ocisti_Btn.Name = "Ocisti_Btn";
        Ocisti_Btn.Size = new System.Drawing.Size(61, 23);
        Ocisti_Btn.TabIndex = 4;
        Ocisti_Btn.Text = "Ocisti";
        Ocisti_Btn.UseVisualStyleBackColor = false;
        Ocisti_Btn.Click += Ocisti_Btn_Click;
        // 
        // Sortiraj_Btn
        // 
        Sortiraj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
        Sortiraj_Btn.Font = new System.Drawing.Font("Georgia", 9F);
        Sortiraj_Btn.Location = new System.Drawing.Point(211, 170);
        Sortiraj_Btn.Name = "Sortiraj_Btn";
        Sortiraj_Btn.Size = new System.Drawing.Size(61, 23);
        Sortiraj_Btn.TabIndex = 5;
        Sortiraj_Btn.Text = "Sortiraj";
        Sortiraj_Btn.UseVisualStyleBackColor = false;
        Sortiraj_Btn.Click += Sortiraj_Btn_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(16, 65);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(79, 15);
        label2.TabIndex = 8;
        label2.Text = "Unesite ime:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(16, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(127, 15);
        label1.TabIndex = 10;
        label1.Text = "Unesite broj indeksa:";
        // 
        // BrojIndeksa_TB
        // 
        BrojIndeksa_TB.Location = new System.Drawing.Point(164, 24);
        BrojIndeksa_TB.Name = "BrojIndeksa_TB";
        BrojIndeksa_TB.Size = new System.Drawing.Size(108, 21);
        BrojIndeksa_TB.TabIndex = 1;
        // 
        // Ime_TB
        // 
        Ime_TB.Location = new System.Drawing.Point(164, 62);
        Ime_TB.Name = "Ime_TB";
        Ime_TB.Size = new System.Drawing.Size(108, 21);
        Ime_TB.TabIndex = 1;
        Ime_TB.KeyPress += Ime_TB_KeyPress;
        // 
        // Izaberi_Btn
        // 
        Izaberi_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
        Izaberi_Btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
        Izaberi_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
        Izaberi_Btn.Location = new System.Drawing.Point(571, 501);
        Izaberi_Btn.Name = "Izaberi_Btn";
        Izaberi_Btn.Size = new System.Drawing.Size(167, 68);
        Izaberi_Btn.TabIndex = 3;
        Izaberi_Btn.Text = "Izaberite studenta";
        Izaberi_Btn.UseVisualStyleBackColor = false;
        Izaberi_Btn.Click += Izaberi_Btn_Click;
        // 
        // OdabirStudentaUcesce
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = System.Drawing.Color.Linen;
        ClientSize = new System.Drawing.Size(756, 581);
        Controls.Add(Izaberi_Btn);
        Controls.Add(Prikaz_GB);
        Controls.Add(Studenti_GB);
        Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(772, 620);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(772, 620);
        Name = "OdabirStudentaUcesce";
        Text = "Studenti";
        Load += OdabirStudentaUcesce_Load;
        Studenti_GB.ResumeLayout(false);
        Prikaz_GB.ResumeLayout(false);
        Prikaz_GB.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox Studenti_GB;
    private ListView Studenti_ListV;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private GroupBox Prikaz_GB;
    private Button Ocisti_Btn;
    private Button Sortiraj_Btn;
    private Label label2;
    private Label label1;
    private TextBox BrojIndeksa_TB;
    private TextBox Ime_TB;
    private TextBox Smer_TB;
    private Label label4;
    private TextBox Prezime_TB;
    private Label label3;
    private Button Izaberi_Btn;
}