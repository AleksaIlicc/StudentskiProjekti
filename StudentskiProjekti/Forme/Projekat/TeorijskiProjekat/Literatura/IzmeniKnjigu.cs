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
		GodinaIzdanja_TB.Text = knjiga.GodinaIzdanja.ToString();
		string autoriText = string.Join("\r\n", autori.Select(a => a.Autor));
		Autori_TB.Text = autoriText;
	}

	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da izvrsite izmene knjige?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
			knjiga.Izdavac = Izdavac_TB.Text.Trim();
			knjiga.Naziv = Naziv_TB.Text.Trim();
			knjiga.GodinaIzdanja = int.Parse(GodinaIzdanja_TB.Text);

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
}
