using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajRad : Form
{
	RadPregled rad = new RadPregled();
	int projekatId;
	public DodajRad(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void DodajRad_Load(object sender, EventArgs e)
	{
		List<string> opcije = new List<string>
		{
			"pdf",
			"word",
			"post-script"
		};

		Format_CB.DataSource = opcije;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novi rad?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{

			rad.Naziv = Naziv_TB.Text;
			rad.Url = URL_TB.Text;
			rad.KonferencijaObjavljivanja = KonfObjavljivanja_TB.Text;
			rad.Format = (string)Format_CB.SelectedItem;

			List<AutorPregled> autori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				autori.Add(noviAutor);
			}

			DTOManager.DodajRad(projekatId, rad, autori);
			MessageBox.Show("Uspesno ste dodali novi clanak!");
			this.Close();
		}
	}
}
