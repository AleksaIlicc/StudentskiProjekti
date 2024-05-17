using StudentskiProjekti.Entiteti;
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
		string poruka = "Da li zelite da izvrsite izmene clanka?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
			clanak.Naziv = Naziv_TB.Text.Trim();
			clanak.ImeCasopisa = ImeCasopisa_TB.Text.Trim();
			clanak.Broj = int.Parse(Broj_TB.Text.Trim());
			clanak.Godina = int.Parse(Godina_TB.Text.Trim());

			DTOManager.AzurirajClanak(clanak);
			MessageBox.Show("Azuriranje clanka u casopisu je uspesno izvrseno!");
			this.Close();
		}
	}
}

