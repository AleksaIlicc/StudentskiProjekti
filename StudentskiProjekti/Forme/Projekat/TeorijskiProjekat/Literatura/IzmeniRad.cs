using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniRad : Form
{
	private RadPregled rad;

	public IzmeniRad(RadPregled rad)
	{
		InitializeComponent();
		this.rad = rad;
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		Naziv_TB.Text = rad.Naziv;
		URL_TB.Text = rad.Url;
		KonfObjavljivanja_TB.Text = rad.KonferencijaObjavljivanja;
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

	}
}