using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajClanak : Form
{
	ClanakUCasopisuPregled clanak = new ClanakUCasopisuPregled();
	int projekatId;
	public DodajClanak(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novi clanak?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(ISSN_TB.Text))
			{
				MessageBox.Show("Morate uneti ISSN clanka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv clanka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(ImeCasopisa_TB.Text))
			{
				MessageBox.Show("Morate uneti ime casopisa clanka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clanak.Naziv = Naziv_TB.Text;
			clanak.ImeCasopisa = ImeCasopisa_TB.Text;
			clanak.ISSN = ISSN_TB.Text;
			if (int.TryParse(Broj_TB.Text, out int broj))
			{
				clanak.Broj = broj;
			}
			if (int.TryParse(Godina_TB.Text, out int godina))
			{
				if (godina < 1900 || godina > DateTime.Now.Year)
				{
					MessageBox.Show($"Godina clanka mora biti broj izmedju 1900 i {DateTime.Now.Year} godine!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				clanak.Godina = godina;
			}

			List<AutorPregled> autori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				autori.Add(noviAutor);
			}

			DTOManager.DodajClanak(projekatId, clanak, autori);
			MessageBox.Show("Uspesno ste dodali novi clanak!");
			this.Close();
		}
	}

	private void ISSN_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Broj_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Godina_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Autori_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Enter && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}
}
