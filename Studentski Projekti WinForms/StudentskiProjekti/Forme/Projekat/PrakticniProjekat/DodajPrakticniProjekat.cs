using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajPrakticniProjekat : Form
{
    PrakticniProjekatPregled projekat = new PrakticniProjekatPregled();
    public DodajPrakticniProjekat(PredmetPregled p)
    {
        InitializeComponent();
        projekat.PripadaPredmetu = p;
    }
    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi prakticni projekat?";
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
				MessageBox.Show("Morate odabrati da li je projekat pojedinačni ili grupni!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			projekat.Naziv = Naziv_TB.Text.Trim();
            projekat.SkolskaGodinaZadavanja = SkolskaGodIzdavanja_TB.Text.Trim();

            if (Pojedinacni_RB.Checked)
            {
                projekat.TipProjekta = "pojedinacni";
            }
            else if (Grupni_RB.Checked)
            {
                projekat.TipProjekta = "grupni";
            }

            projekat.PreporuceniProgramskiJezik = PreporuceniProgJezik_TB.Text.Trim();
            projekat.VrstaProjekta = "prakticni";
            projekat.KratakOpis = KratakOpis_TB.Text.Trim();

			List<PreporucenaWebStranicaPregled> stranice = new List<PreporucenaWebStranicaPregled>();

			string[] unosiStranica = PrepWebStranice_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosStranice in unosiStranica)
			{
				PreporucenaWebStranicaPregled novaStranica = new PreporucenaWebStranicaPregled(unosStranice.Trim());
				stranice.Add(novaStranica);
			}

			DTOManager.DodajPrakticniProjekat(projekat, stranice);
            MessageBox.Show("Uspesno ste dodali novi projekat!");
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
}
