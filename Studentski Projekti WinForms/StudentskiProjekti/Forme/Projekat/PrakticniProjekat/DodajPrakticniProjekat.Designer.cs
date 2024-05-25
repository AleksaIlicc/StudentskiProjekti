using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentskiProjekti.Forme;

partial class DodajPrakticniProjekat
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
		label1 = new Label();
		label2 = new Label();
		Naziv_TB = new TextBox();
		SkolskaGodIzdavanja_TB = new TextBox();
		Dodaj_Btn = new Button();
		OsnovnipodaciopredmetuGB = new GroupBox();
		KratakOpis_TB = new TextBox();
		label5 = new Label();
		label3 = new Label();
		PrepWebStranice_TB = new TextBox();
		label6 = new Label();
		PreporuceniProgJezik_TB = new TextBox();
		label4 = new Label();
		groupBox2 = new GroupBox();
		Pojedinacni_RB = new RadioButton();
		Grupni_RB = new RadioButton();
		OsnovnipodaciopredmetuGB.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Georgia", 9F);
		label1.Location = new System.Drawing.Point(8, 42);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(45, 15);
		label1.TabIndex = 0;
		label1.Text = "Naziv:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Georgia", 9F);
		label2.Location = new System.Drawing.Point(8, 74);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(144, 15);
		label2.TabIndex = 1;
		label2.Text = "Skolska god. zadavanja:";
		// 
		// Naziv_TB
		// 
		Naziv_TB.Location = new System.Drawing.Point(175, 36);
		Naziv_TB.Name = "Naziv_TB";
		Naziv_TB.Size = new System.Drawing.Size(215, 21);
		Naziv_TB.TabIndex = 0;
		// 
		// SkoslaGodIzdavanja_TB
		// 
		SkolskaGodIzdavanja_TB.Location = new System.Drawing.Point(175, 71);
		SkolskaGodIzdavanja_TB.Name = "SkoslaGodIzdavanja_TB";
		SkolskaGodIzdavanja_TB.Size = new System.Drawing.Size(215, 21);
		SkolskaGodIzdavanja_TB.TabIndex = 1;
		SkolskaGodIzdavanja_TB.KeyPress += SkolskaGodIzdavanja_TB_KeyPress;
		// 
		// Dodaj_Btn
		// 
		Dodaj_Btn.BackColor = System.Drawing.Color.AntiqueWhite;
		Dodaj_Btn.Location = new System.Drawing.Point(235, 383);
		Dodaj_Btn.Name = "Dodaj_Btn";
		Dodaj_Btn.Size = new System.Drawing.Size(157, 29);
		Dodaj_Btn.TabIndex = 6;
		Dodaj_Btn.Text = "Dodaj";
		Dodaj_Btn.UseVisualStyleBackColor = false;
		Dodaj_Btn.Click += Dodaj_Btn_Click;
		// 
		// OsnovnipodaciopredmetuGB
		// 
		OsnovnipodaciopredmetuGB.Controls.Add(KratakOpis_TB);
		OsnovnipodaciopredmetuGB.Controls.Add(label5);
		OsnovnipodaciopredmetuGB.Controls.Add(label3);
		OsnovnipodaciopredmetuGB.Controls.Add(PrepWebStranice_TB);
		OsnovnipodaciopredmetuGB.Controls.Add(label6);
		OsnovnipodaciopredmetuGB.Controls.Add(PreporuceniProgJezik_TB);
		OsnovnipodaciopredmetuGB.Controls.Add(label4);
		OsnovnipodaciopredmetuGB.Controls.Add(groupBox2);
		OsnovnipodaciopredmetuGB.Controls.Add(Dodaj_Btn);
		OsnovnipodaciopredmetuGB.Controls.Add(SkolskaGodIzdavanja_TB);
		OsnovnipodaciopredmetuGB.Controls.Add(Naziv_TB);
		OsnovnipodaciopredmetuGB.Controls.Add(label2);
		OsnovnipodaciopredmetuGB.Controls.Add(label1);
		OsnovnipodaciopredmetuGB.Font = new System.Drawing.Font("Georgia", 9F);
		OsnovnipodaciopredmetuGB.Location = new System.Drawing.Point(12, 12);
		OsnovnipodaciopredmetuGB.Name = "OsnovnipodaciopredmetuGB";
		OsnovnipodaciopredmetuGB.Size = new System.Drawing.Size(398, 418);
		OsnovnipodaciopredmetuGB.TabIndex = 0;
		OsnovnipodaciopredmetuGB.TabStop = false;
		OsnovnipodaciopredmetuGB.Text = "Osnovni podaci o projektu";
		// 
		// KratakOpis_TB
		// 
		KratakOpis_TB.Location = new System.Drawing.Point(175, 198);
		KratakOpis_TB.Multiline = true;
		KratakOpis_TB.Name = "KratakOpis_TB";
		KratakOpis_TB.Size = new System.Drawing.Size(215, 97);
		KratakOpis_TB.TabIndex = 4;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Georgia", 9F);
		label5.Location = new System.Drawing.Point(8, 204);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(76, 15);
		label5.TabIndex = 18;
		label5.Text = "Kratak opis:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Georgia", 9F);
		label3.Location = new System.Drawing.Point(8, 317);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(81, 15);
		label3.TabIndex = 17;
		label3.Text = "Tip projekta:";
		// 
		// PrepWebStranice_TB
		// 
		PrepWebStranice_TB.Location = new System.Drawing.Point(175, 140);
		PrepWebStranice_TB.Multiline = true;
		PrepWebStranice_TB.Name = "PrepWebStranice_TB";
		PrepWebStranice_TB.Size = new System.Drawing.Size(215, 42);
		PrepWebStranice_TB.TabIndex = 3;
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Georgia", 9F);
		label6.Location = new System.Drawing.Point(8, 143);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(159, 15);
		label6.TabIndex = 16;
		label6.Text = "Preporucene web stranice:";
		// 
		// PreporuceniProgJezik_TB
		// 
		PreporuceniProgJezik_TB.Location = new System.Drawing.Point(175, 106);
		PreporuceniProgJezik_TB.Name = "PreporuceniProgJezik_TB";
		PreporuceniProgJezik_TB.Size = new System.Drawing.Size(215, 21);
		PreporuceniProgJezik_TB.TabIndex = 2;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Georgia", 9F);
		label4.Location = new System.Drawing.Point(8, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(143, 15);
		label4.TabIndex = 14;
		label4.Text = "Preporuceni prog. jezik:";
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(Pojedinacni_RB);
		groupBox2.Controls.Add(Grupni_RB);
		groupBox2.Location = new System.Drawing.Point(175, 301);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(217, 66);
		groupBox2.TabIndex = 5;
		groupBox2.TabStop = false;
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
		// DodajPrakticniProjekat
		// 
		AutoScaleMode = AutoScaleMode.None;
		BackColor = System.Drawing.Color.AntiqueWhite;
		ClientSize = new System.Drawing.Size(416, 442);
		Controls.Add(OsnovnipodaciopredmetuGB);
		Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		MaximizeBox = false;
		MaximumSize = new System.Drawing.Size(432, 481);
		MinimizeBox = false;
		MinimumSize = new System.Drawing.Size(432, 481);
		Name = "DodajPrakticniProjekat";
		Text = "Dodaj projekat";
		OsnovnipodaciopredmetuGB.ResumeLayout(false);
		OsnovnipodaciopredmetuGB.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private Label label1;
    private Label label2;
    private TextBox Naziv_TB;
    private TextBox SkolskaGodIzdavanja_TB;
    private Button Dodaj_Btn;
    private GroupBox OsnovnipodaciopredmetuGB;
    private GroupBox groupBox2;
    private RadioButton Pojedinacni_RB;
    private RadioButton Grupni_RB;
    private TextBox PreporuceniProgJezik_TB;
    private Label label4;
	private Label label3;
	private TextBox PrepWebStranice_TB;
	private Label label6;
	private TextBox KratakOpis_TB;
	private Label label5;
}