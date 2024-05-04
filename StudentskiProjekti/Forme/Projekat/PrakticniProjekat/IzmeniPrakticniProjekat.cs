using StudentskiProjekti.Entiteti;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class IzmeniPrakticniProjekat : Form
{

    PrakticniProjekatPregled projekat;
    public IzmeniPrakticniProjekat(PrakticniProjekatPregled p)
    {
        InitializeComponent();
        projekat = p;
    }

    private void IzmeniPrakticniProjekat_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }
    public void PopuniPodacima()
    {
        Naziv_TB.Text = projekat.Naziv;
        SkoslaGodIzdavanja_TB.Text = projekat.SkolskaGodinaZadavanja;
        PreporuceniProgJezik_TB.Text = projekat.PreporuceniProgramskiJezik;

        if (projekat.TipProjekta == "grupni")
        {
            Grupni_RB.Checked = true;
        }
        else if (projekat.TipProjekta == "pojedinacni")
        {
            Pojedinacni_RB.Checked = true;
        }
    }
    private void Izmeni_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da izvrsite izmene projekta?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);
        if (result == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(Naziv_TB.Text))
            {
                MessageBox.Show("Morate uneti naziv prakticnog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(SkoslaGodIzdavanja_TB.Text))
            {
                MessageBox.Show("Morate uneti skolsku godinu zadavanja prakticnog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(PreporuceniProgJezik_TB.Text))
            {
                MessageBox.Show("Morate uneti preporuceni programski jezik pre zadavanja prakticnog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Grupni_RB.Checked == false && Pojedinacni_RB.Checked == false)
            {
                MessageBox.Show("Morate izabrati tip projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            projekat.Naziv = Naziv_TB.Text;
            projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            projekat.PreporuceniProgramskiJezik = PreporuceniProgJezik_TB.Text;

            if (Grupni_RB.Checked)
            {
                projekat.TipProjekta = "grupni";
            }
            else if (Pojedinacni_RB.Checked)
            {
                projekat.TipProjekta = "pojedinacni";
            }

            DTOManager.AzurirajPrakticniProjekat(projekat);
            MessageBox.Show("Azuriranje prakticnog projekta je uspesno izvrseno!");
            this.Close();
        }
    }

    private void SkoslaGodIzdavanja_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
        {
            e.Handled = true;
        }
    }
}
