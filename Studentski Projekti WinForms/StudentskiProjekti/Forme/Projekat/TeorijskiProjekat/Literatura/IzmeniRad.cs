using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniRad : Form
{
	private RadPregled rad;
	private List<AutorPregled> autori;
	public IzmeniRad(RadPregled rad)
	{
		InitializeComponent();
		this.rad = rad;
		this.autori = DTOManager.VratiAutoreZaRad(rad.Id);
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		Naziv_TB.Text = rad.Naziv;
		URL_TB.Text = rad.Url;
		KonfObjavljivanja_TB.Text = rad.KonferencijaObjavljivanja;
		Autori_TB.Text = string.Join("\r\n", autori.Select(a => a.Autor));
	}

	private void IzmeniRad_Load(object sender, EventArgs e)
	{
		List<string> opcije = new List<string>
		{
			"pdf",
			"word",
			"post-script"
		};

		Format_CB.DataSource = opcije;
		Format_CB.SelectedItem = rad.Format;
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da izvrsite izmene rada?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv rada!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!string.IsNullOrEmpty(URL_TB.Text) && !IsValidUrl(URL_TB.Text))
			{
				MessageBox.Show("Uneti URL nije validan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			rad.Naziv = Naziv_TB.Text.Trim();
			rad.Url = URL_TB.Text.Trim();
			rad.KonferencijaObjavljivanja = KonfObjavljivanja_TB.Text.Trim();
			rad.Format = (string)Format_CB.SelectedItem;

			List<AutorPregled> azuriraniAutori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				azuriraniAutori.Add(noviAutor);
			}
			DTOManager.AzurirajRadSaAutorima(rad, azuriraniAutori);
			MessageBox.Show("Azuriranje rada je uspesno izvrseno!");
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

	private bool IsValidUrl(string url)
	{
		return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
			   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
	}
}