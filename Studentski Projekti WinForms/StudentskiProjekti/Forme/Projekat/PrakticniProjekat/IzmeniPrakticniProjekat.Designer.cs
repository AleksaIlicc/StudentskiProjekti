namespace StudentskiProjekti.Forme;

partial class IzmeniPrakticniProjekat
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniPrakticniProjekat));
        label1 = new Label();
        label2 = new Label();
        Naziv_TB = new TextBox();
        SkolskaGodIzdavanja_TB = new TextBox();
        Izmeni_Btn = new Button();
        OsnovnipodaciopredmetuGB = new GroupBox();
        groupBox1 = new GroupBox();
        Pojedinacni_RB = new RadioButton();
        Grupni_RB = new RadioButton();
        label3 = new Label();
        KratakOpis_TB = new TextBox();
        PreporuceniProgJezik_TB = new TextBox();
        label5 = new Label();
        label4 = new Label();
        PrepWebStranice_TB = new TextBox();
        label6 = new Label();
        OsnovnipodaciopredmetuGB.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Georgia", 9F);
        label1.Location = new System.Drawing.Point(8, 37);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(45, 15);
        label1.TabIndex = 0;
        label1.Text = "Naziv:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Georgia", 9F);
        label2.Location = new System.Drawing.Point(8, 72);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(144, 15);
        label2.TabIndex = 1;
        label2.Text = "Skolska god. zadavanja:";
        // 
        // Naziv_TB
        // 
        Naziv_TB.Location = new System.Drawing.Point(169, 34);
        Naziv_TB.Name = "Naziv_TB";
        Naziv_TB.Size = new System.Drawing.Size(217, 21);
        Naziv_TB.TabIndex = 0;
        // 
        // SkolskaGodIzdavanja_TB
        // 
        SkolskaGodIzdavanja_TB.Location = new System.Drawing.Point(169, 69);
        SkolskaGodIzdavanja_TB.Name = "SkolskaGodIzdavanja_TB";
        SkolskaGodIzdavanja_TB.Size = new System.Drawing.Size(217, 21);
        SkolskaGodIzdavanja_TB.TabIndex = 1;
        SkolskaGodIzdavanja_TB.KeyPress += SkolskaGodIzdavanja_TB_KeyPress;
        // 
        // Izmeni_Btn
        // 
        Izmeni_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
        Izmeni_Btn.Location = new System.Drawing.Point(229, 383);
        Izmeni_Btn.Name = "Izmeni_Btn";
        Izmeni_Btn.Size = new System.Drawing.Size(157, 29);
        Izmeni_Btn.TabIndex = 6;
        Izmeni_Btn.Text = "Izmeni";
        Izmeni_Btn.UseVisualStyleBackColor = false;
        Izmeni_Btn.Click += Izmeni_Btn_Click;
        // 
        // OsnovnipodaciopredmetuGB
        // 
        OsnovnipodaciopredmetuGB.Controls.Add(groupBox1);
        OsnovnipodaciopredmetuGB.Controls.Add(label3);
        OsnovnipodaciopredmetuGB.Controls.Add(KratakOpis_TB);
        OsnovnipodaciopredmetuGB.Controls.Add(PreporuceniProgJezik_TB);
        OsnovnipodaciopredmetuGB.Controls.Add(label5);
        OsnovnipodaciopredmetuGB.Controls.Add(label4);
        OsnovnipodaciopredmetuGB.Controls.Add(PrepWebStranice_TB);
        OsnovnipodaciopredmetuGB.Controls.Add(label6);
        OsnovnipodaciopredmetuGB.Controls.Add(Izmeni_Btn);
        OsnovnipodaciopredmetuGB.Controls.Add(SkolskaGodIzdavanja_TB);
        OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
        OsnovnipodaciopredmetuGB.Controls.Add(label2);
        OsnovnipodaciopredmetuGB.Controls.Add(label1);
        OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
        OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
        OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
        OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(392, 418);
        OsnovnipodaciopredmetuGB.TabIndex = 0;
        OsnovnipodaciopredmetuGB.TabStop = false;
        OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o projektu";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(Pojedinacni_RB);
        groupBox1.Controls.Add(Grupni_RB);
        groupBox1.Location = new System.Drawing.Point(169, 302);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(217, 66);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        // 
        // Pojedinacni_RB
        // 
        Pojedinacni_RB.AutoSize = true;
        Pojedinacni_RB.Location = new System.Drawing.Point(68, 39);
        Pojedinacni_RB.Name = "Pojedinacni_RB";
        Pojedinacni_RB.RightToLeft = RightToLeft.Yes;
        Pojedinacni_RB.Size = new System.Drawing.Size(143, 19);
        Pojedinacni_RB.TabIndex = 4;
        Pojedinacni_RB.TabStop = true;
        Pojedinacni_RB.Text = "Pojedinacni projekat";
        Pojedinacni_RB.UseVisualStyleBackColor = true;
        // 
        // Grupni_RB
        // 
        Grupni_RB.AutoSize = true;
        Grupni_RB.Location = new System.Drawing.Point(93, 14);
        Grupni_RB.Name = "Grupni_RB";
        Grupni_RB.RightToLeft = RightToLeft.Yes;
        Grupni_RB.Size = new System.Drawing.Size(118, 19);
        Grupni_RB.TabIndex = 3;
        Grupni_RB.TabStop = true;
        Grupni_RB.Text = "Grupni projekat";
        Grupni_RB.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Georgia", 9F);
        label3.Location = new System.Drawing.Point(8, 318);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(81, 15);
        label3.TabIndex = 18;
        label3.Text = "Tip projekta:";
        // 
        // KratakOpis_TB
        // 
        KratakOpis_TB.Location = new System.Drawing.Point(169, 196);
        KratakOpis_TB.Multiline = true;
        KratakOpis_TB.Name = "KratakOpis_TB";
        KratakOpis_TB.Size = new System.Drawing.Size(217, 97);
        KratakOpis_TB.TabIndex = 4;
        // 
        // PreporuceniProgJezik_TB
        // 
        PreporuceniProgJezik_TB.Location = new System.Drawing.Point(169, 104);
        PreporuceniProgJezik_TB.Name = "PreporuceniProgJezik_TB";
        PreporuceniProgJezik_TB.Size = new System.Drawing.Size(217, 21);
        PreporuceniProgJezik_TB.TabIndex = 2;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Georgia", 9F);
        label5.Location = new System.Drawing.Point(8, 196);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(76, 15);
        label5.TabIndex = 22;
        label5.Text = "Kratak opis:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Georgia", 9F);
        label4.Location = new System.Drawing.Point(8, 107);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(143, 15);
        label4.TabIndex = 14;
        label4.Text = "Preporuceni prog. jezik:";
        // 
        // PrepWebStranice_TB
        // 
        PrepWebStranice_TB.Location = new System.Drawing.Point(169, 143);
        PrepWebStranice_TB.Multiline = true;
        PrepWebStranice_TB.Name = "PrepWebStranice_TB";
        PrepWebStranice_TB.Size = new System.Drawing.Size(217, 42);
        PrepWebStranice_TB.TabIndex = 3;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Georgia", 9F);
        label6.Location = new System.Drawing.Point(8, 146);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(159, 15);
        label6.TabIndex = 21;
        label6.Text = "Preporucene web stranice:";
        // 
        // IzmeniPrakticniProjekat
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = System.Drawing.Color.AntiqueWhite;
        ClientSize = new System.Drawing.Size(414, 442);
        Controls.Add(OsnovnipodaciopredmetuGB);
        Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(430, 481);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(430, 481);
        Name = "IzmeniPrakticniProjekat";
        Text = "Izmeni projekat";
        Load += IzmeniPrakticniProjekat_Load;
        OsnovnipodaciopredmetuGB.ResumeLayout(false);
        OsnovnipodaciopredmetuGB.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox Naziv_TB;
    private TextBox SkolskaGodIzdavanja_TB;
    private Button Izmeni_Btn;
    private GroupBox OsnovnipodaciopredmetuGB;
    private TextBox PreporuceniProgJezik_TB;
    private Label label4;
	private TextBox KratakOpis_TB;
	private Label label5;
	private TextBox PrepWebStranice_TB;
	private Label label6;
	private Label label3;
	private GroupBox groupBox1;
	private RadioButton Pojedinacni_RB;
	private RadioButton Grupni_RB;
}