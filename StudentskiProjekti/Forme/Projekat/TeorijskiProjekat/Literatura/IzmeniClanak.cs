using StudentskiProjekti.Entiteti;
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
		Broj_TB.Text = clanak.Broj.ToString();
		Godina_TB.Text = clanak.Godina.ToString();
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
			clanak.Naziv = Naziv_TB.Text.Trim();
			clanak.ImeCasopisa = ImeCasopisa_TB.Text.Trim();
			clanak.Broj = int.Parse(Broj_TB.Text.Trim());
			clanak.Godina = int.Parse(Godina_TB.Text.Trim());

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
}

