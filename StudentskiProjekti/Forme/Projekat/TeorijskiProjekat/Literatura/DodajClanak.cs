using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajClanak : Form
{
	ClanakUCasopisuPregled clanak = new ClanakUCasopisuPregled();
	int projekatId;
	public DodajClanak(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novi clanak?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{

			clanak.Naziv = Naziv_TB.Text;
			clanak.ImeCasopisa = ImeCasopisa_TB.Text;
			clanak.ISSN = ISSN_TB.Text;
			clanak.Broj = int.Parse(Broj_TB.Text);
			clanak.Godina = int.Parse(Godina_TB.Text);

			List<AutorPregled> autori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled()
				{
					Autor = detaljiAutora
				};
				autori.Add(noviAutor);
			}

			DTOManager.DodajClanak(projekatId, clanak, autori);
			MessageBox.Show("Uspesno ste dodali novi clanak!");
			this.Close();
		}
	}

}
