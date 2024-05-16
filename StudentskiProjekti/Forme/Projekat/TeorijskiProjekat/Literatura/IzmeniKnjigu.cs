using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class IzmeniKnjigu : Form
{
	private KnjigaPregled knjiga;

	public IzmeniKnjigu(KnjigaPregled knjiga)
	{
		InitializeComponent();
		this.knjiga = knjiga;
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		ISBN_TB.Text = knjiga.ISBN;
		Naziv_TB.Text = knjiga.Naziv;
		Izdavac_TB.Text = knjiga.Izdavac;
		GodinaIzdanja_TB.Text = knjiga.GodinaIzdanja.ToString();
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{

	}
}
