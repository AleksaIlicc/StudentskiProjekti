using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajPredmet : Form
{
	PredmetPregled predmet = new PredmetPregled();

	public DodajPredmet()
	{
		InitializeComponent();
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novi predmet?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(Sifra_TB.Text))
			{
				MessageBox.Show("Morate uneti šifru predmeta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv predmeta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int semestar;
			if (!int.TryParse(Semestar_TB.Text, out semestar) || semestar <= 0)
			{
				MessageBox.Show("Morate uneti ispravan broj za semestar (celobrojna vrednost veća od 0)!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.predmet.Id = Sifra_TB.Text;
			this.predmet.Naziv = Naziv_TB.Text;
			this.predmet.Semestar = int.TryParse(Semestar_TB.Text, out semestar) ? semestar : 0;
			this.predmet.Katedra = Katedra_TB.Text;

			DTOManager.DodajPredmet(this.predmet);
			MessageBox.Show("Uspesno ste dodali novi predmet!");
			this.Close();
		}
	}

	private void Semestar_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
		{
			e.Handled = true;
		}
	}
}
