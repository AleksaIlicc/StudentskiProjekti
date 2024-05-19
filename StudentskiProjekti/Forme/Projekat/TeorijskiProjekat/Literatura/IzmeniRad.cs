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
		string autoriText = string.Join("\r\n", autori.Select(a => a.Autor));
		Autori_TB.Text = autoriText;
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
			MessageBox.Show("Azuriranje clanka u casopisu je uspesno izvrseno!");
			this.Close();
		}
	}
}