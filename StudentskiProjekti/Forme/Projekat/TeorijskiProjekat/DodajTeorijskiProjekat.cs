using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajTeorijskiProjekat : Form
{

    TeorijskiProjekatPregled projekat = new TeorijskiProjekatPregled();
    public DodajTeorijskiProjekat()
    {
        InitializeComponent();
    }
    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi teorijski projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            this.projekat.Naziv = SkoslaGodIzdavanja_TB.Text;
            this.projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            if (Pojedinacni_RB.Checked)
            {
                this.projekat.TipProjekta = "pojedinacni";
            }
            else if (Grupni_RB.Checked)
            {
                this.projekat.TipProjekta = "grupni";
            }

            MessageBox.Show("Uspesno ste dodali novi predmet!");
            this.Close();
        }
        else
        {

        }
    }
}

