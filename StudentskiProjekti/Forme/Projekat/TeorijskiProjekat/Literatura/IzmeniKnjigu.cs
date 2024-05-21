using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniKnjigu : Form
{
	private KnjigaPregled knjiga;
	private List<AutorPregled> autori;
	public IzmeniKnjigu(KnjigaPregled knjiga)
	{
		InitializeComponent();
		this.knjiga = knjiga;
		this.autori = DTOManager.VratiAutoreZaKnjigu(knjiga.ISBN);
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		ISBN_TB.Text = knjiga.ISBN;
		Naziv_TB.Text = knjiga.Naziv;
		Izdavac_TB.Text = knjiga.Izdavac;
		GodinaIzdanja_TB.Text = knjiga.GodinaIzdanja.ToString() == "0" ? "" : knjiga.GodinaIzdanja.ToString();
		Autori_TB.Text = string.Join("\r\n", autori.Select(a => a.Autor)); 
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da izvrsite izmene knjige?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv knjige!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (int.TryParse(GodinaIzdanja_TB.Text, out int godinaIzdanja))
			{
				if (godinaIzdanja < 1900 || godinaIzdanja > DateTime.Now.Year)
				{
					MessageBox.Show($"Godina izdanja knjige mora biti broj izmedju 1900 i {DateTime.Now.Year} godine!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				knjiga.GodinaIzdanja = godinaIzdanja;
			}

			knjiga.Izdavac = Izdavac_TB.Text.Trim();
			knjiga.Naziv = Naziv_TB.Text.Trim();

			List<AutorPregled> azuriraniAutori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				azuriraniAutori.Add(noviAutor);
			}
			DTOManager.AzurirajKnjiguSaAutorima(knjiga, azuriraniAutori);
			MessageBox.Show("Azuriranje knjige je uspesno izvrseno!");
			this.Close();
		}
	}

	private void Autori_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Enter && !char.IsControl(e.KeyChar))
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
}
