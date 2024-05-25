using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniPrakticniProjekat : Form
{
    PrakticniProjekatPregled projekat;
    List<PreporucenaWebStranicaPregled> webStranice;
    string tipProjekta;
    public IzmeniPrakticniProjekat(PrakticniProjekatPregled p)
    {
        InitializeComponent();
        projekat = p;
        webStranice = DTOManager.VratiPreporuceneWebStranicePProjekta(projekat.Id);
        tipProjekta = p.TipProjekta;
    }

    private void IzmeniPrakticniProjekat_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Naziv_TB.Text = projekat.Naziv;
        SkolskaGodIzdavanja_TB.Text = projekat.SkolskaGodinaZadavanja;
        PreporuceniProgJezik_TB.Text = projekat.PreporuceniProgramskiJezik;
        KratakOpis_TB.Text = projekat.KratakOpis;
		PrepWebStranice_TB.Text = string.Join("\r\n", webStranice.Select(a => a.Naziv));
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
                MessageBox.Show("Morate uneti naziv projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(SkolskaGodIzdavanja_TB.Text))
            {
                MessageBox.Show("Morate uneti skolsku godinu zadavanja projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Grupni_RB.Checked && !Pojedinacni_RB.Checked)
            {
                MessageBox.Show("Morate izabrati tip projekta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            projekat.Naziv = Naziv_TB.Text;
            projekat.SkolskaGodinaZadavanja = SkolskaGodIzdavanja_TB.Text;
            projekat.PreporuceniProgramskiJezik = PreporuceniProgJezik_TB.Text;

            if (Grupni_RB.Checked)
            {
                projekat.TipProjekta = "grupni";
            }
            else if (Pojedinacni_RB.Checked)
            {
                projekat.TipProjekta = "pojedinacni";
            }
			projekat.KratakOpis = KratakOpis_TB.Text.Trim();

			List<PreporucenaWebStranicaPregled> stranice = new List<PreporucenaWebStranicaPregled>();

			string[] unosiStranica = PrepWebStranice_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosStranice in unosiStranica)
			{
				PreporucenaWebStranicaPregled novaStranica = new PreporucenaWebStranicaPregled(unosStranice.Trim());
				stranice.Add(novaStranica);
			}

			if (projekat.TipProjekta != tipProjekta)
			{
				string upozorenje = "Promenom tipa projekta obrisaće se svi učesnici na ovom projektu, kao i njihovi izvestaji, ukoliko postoje učešća na projektu. Da li želite da nastavite?";
				DialogResult potvrda = MessageBox.Show(upozorenje, "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (potvrda == DialogResult.Yes)
				{
					DTOManager.ObrisiUcesnikePrakticnogProjekta(projekat.Id);
				}
				else
				{
					return;
				}
			}

			DTOManager.AzurirajPrakticniProjekatSaStranicama(projekat, stranice);
            MessageBox.Show("Azuriranje prakticnog projekta je uspesno izvrseno!");
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
