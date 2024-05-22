using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajTeorijskiProjekat : Form
{
    TeorijskiProjekatPregled projekat = new TeorijskiProjekatPregled();
    public DodajTeorijskiProjekat(PredmetPregled predmet)
    {
        InitializeComponent();
        projekat.PripadaPredmetu = predmet;
    }
    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi teorijski projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(SkolskaGodIzdavanja_TB.Text))
			{
				MessageBox.Show("Morate uneti skolsku godinu zadavanja projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Pojedinacni_RB.Checked && !Grupni_RB.Checked)
			{
				MessageBox.Show("Morate odabrati da li je projekat pojedinačni ili grupni!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (int.TryParse(MaxBrStranica_TB.Text, out int maksBrojStrana))
			{
                if (maksBrojStrana <= 0) 
                { 
				    MessageBox.Show("Morate uneti ispravan broj za maksimalni broj strana (celobrojna vrednost veća od 0)!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				    return;
				}
			}

			projekat.Naziv = Naziv_TB.Text;
            projekat.SkolskaGodinaZadavanja = SkolskaGodIzdavanja_TB.Text;
            if (Pojedinacni_RB.Checked)
            {
                projekat.TipProjekta = "pojedinacni";
            }
            else if (Grupni_RB.Checked)
            {
                projekat.TipProjekta = "grupni";
            }
            projekat.MaksBrojStrana = maksBrojStrana;
            projekat.VrstaProjekta = "teorijski";

            DTOManager.DodajTeorijskiProjekat(projekat);
            MessageBox.Show("Uspesno ste dodali novi projekat!");

			string porukaLiteratura = "Da li želite da dodate postojeću literaturu za ovaj projekat?";
			string titleLiteratura = "Pitanje o literaturi";
			DialogResult resultLiteratura = MessageBox.Show(porukaLiteratura, titleLiteratura, MessageBoxButtons.YesNo);

			if (resultLiteratura == DialogResult.Yes)
			{
				DodajPostojecuLiteraturu dodajLiteraturuForm = new DodajPostojecuLiteraturu(projekat.Id)
                {
					StartPosition = FormStartPosition.CenterParent
				};
				dodajLiteraturuForm.ShowDialog();
			}

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

    private void MaxBrStranica_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}

