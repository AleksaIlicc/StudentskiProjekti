using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniClanak : Form
{
	private ClanakUCasopisuPregled clanak;

	public IzmeniClanak(ClanakUCasopisuPregled clanak)
	{
		InitializeComponent();
		this.clanak = clanak;
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		ISSN_TB.Text = clanak.ISSN;
		Naziv_TB.Text = clanak.Naziv;
		ImeCasopisa_TB.Text = clanak.ImeCasopisa;
		Broj_TB.Text = clanak.Broj.ToString();
		Godina_TB.Text = clanak.Godina.ToString();
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{

	}
}

