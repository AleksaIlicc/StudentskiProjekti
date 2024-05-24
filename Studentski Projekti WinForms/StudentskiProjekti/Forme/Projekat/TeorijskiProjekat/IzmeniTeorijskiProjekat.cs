using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class IzmeniTeorijskiProjekat : Form
{
    TeorijskiProjekatPregled projekat;
    public IzmeniTeorijskiProjekat(TeorijskiProjekatPregled p)
    {
        projekat = p;
        InitializeComponent();
    }

    private void IzmeniTeorijskiProjekat_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Naziv_TB.Text = projekat.Naziv;
        SkoslaGodIzdavanja_TB.Text = projekat.SkolskaGodinaZadavanja;
        MaxBrStrana_TB.Text = projekat.MaksBrojStrana.ToString() == "0" ? null : projekat.MaksBrojStrana.ToString();

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
                MessageBox.Show("Morate uneti naziv teorijskog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(SkoslaGodIzdavanja_TB.Text))
            {
                MessageBox.Show("Morate uneti skolsku godinu zadavanja teorijskog projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (Grupni_RB.Checked == false && Pojedinacni_RB.Checked == false)
            {
                MessageBox.Show("Morate izabrati tip projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (int.TryParse(MaxBrStrana_TB.Text, out int maksBrojStrana))
			{
				if (maksBrojStrana <= 0)
				{
					MessageBox.Show("Morate uneti ispravan broj za maksimalni broj strana (celobrojna vrednost veća od 0)!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			projekat.Naziv = Naziv_TB.Text;
            projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            projekat.MaksBrojStrana = maksBrojStrana;

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

    private void SkolskaGodIzdavanja_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
        {
            e.Handled = true;
        }
    }

    private void MaxBrStrana_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}
