using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class IzmeniTeorijskiProjekat : Form
{
    TeorijskiProjekatPregled projekat = new TeorijskiProjekatPregled();
    public IzmeniTeorijskiProjekat(DTOs.TeorijskiProjekatPregled p)
    {
        projekat = p;
        InitializeComponent();
        PopuniPodacima();
    }


    public void PopuniPodacima()
    {
        Naziv_TB.Text = projekat.Naziv;
        SkoslaGodIzdavanja_TB.Text = projekat.SkolskaGodinaZadavanja;
        MaxBrStrana_TB.Text = projekat.MaksBrojStrana.ToString();

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
        string poruka = "Da li zelite da izvrsite izmene predmeta?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);
        if (result == DialogResult.OK)
        {

            if (string.IsNullOrEmpty(Naziv_TB.Text))
            {
                MessageBox.Show("Morate uneti naziv teorijskog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(SkoslaGodIzdavanja_TB.Text))
            {
                MessageBox.Show("Morate uneti skolsku godinu zadavanja teorijskog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maksBrojStrana;
            if (!int.TryParse(MaxBrStrana_TB.Text, out maksBrojStrana) || maksBrojStrana <= 0)
            {
                MessageBox.Show("Morate uneti ispravan broj za maksimalni broj strana (celobrojna vrednost veća od 0)!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Grupni_RB.Checked == false && Pojedinacni_RB.Checked == false)
            {
                MessageBox.Show("Morate izabrati tip projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            projekat.Naziv = Naziv_TB.Text;
            projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            projekat.MaksBrojStrana = int.TryParse(MaxBrStrana_TB.Text, out int parsedValue) ? parsedValue : 0;
            if (Grupni_RB.Checked)
            {
                projekat.TipProjekta = "grupni";
            }
            else if (Pojedinacni_RB.Checked)
            {
                projekat.TipProjekta = "pojedinacni";
            }

            DTOManager.AzurirajTeorijskiProjekat(projekat);
            MessageBox.Show("Azuriranje teorijskog projekta je uspesno izvrseno!");
            this.Close();
        }
    }
}
