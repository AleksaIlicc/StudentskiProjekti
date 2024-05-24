using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniClanak : Form
{
	private ClanakUCasopisuPregled clanak;
	private List<AutorPregled> autori;

	public IzmeniClanak(ClanakUCasopisuPregled clanak)
	{
		InitializeComponent();
		this.clanak = clanak;
		this.autori = DTOManager.VratiAutoreZaClanak(clanak.ISSN);
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		ISSN_TB.Text = clanak.ISSN;
		Naziv_TB.Text = clanak.Naziv;
		ImeCasopisa_TB.Text = clanak.ImeCasopisa;
		Broj_TB.Text = clanak.Broj.ToString() == "0" ? "" : clanak.Godina.ToString();
		Godina_TB.Text = clanak.Godina.ToString() == "0" ? "" : clanak.Godina.ToString();
		string autoriText = string.Join("\r\n", autori.Select(a => a.Autor));
		Autori_TB.Text = autoriText;
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da izvrsite izmene clanka?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
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

			clanak.Naziv = Naziv_TB.Text.Trim();
			clanak.ImeCasopisa = ImeCasopisa_TB.Text.Trim();
			if (int.TryParse(Broj_TB.Text, out int broj))
			{
				clanak.Broj = broj;
			}
			if (int.TryParse(Godina_TB.Text, out int godina))
			{
				if (godina < 1900 || godina > DateTime.Now.Year)
				{
					MessageBox.Show("Godina clanka mora biti broj izmedju 1900 i trenutne godine!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				clanak.Godina = godina;
			}

			List<AutorPregled> azuriraniAutori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				azuriraniAutori.Add(noviAutor);
			}
			DTOManager.AzurirajClanakSaAutorima(clanak, azuriraniAutori);
			MessageBox.Show("Azuriranje clanka u casopisu je uspesno izvrseno!");
			this.Close();
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

