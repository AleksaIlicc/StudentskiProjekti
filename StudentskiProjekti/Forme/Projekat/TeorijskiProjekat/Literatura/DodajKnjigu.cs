using StudentskiProjekti.Entiteti;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajKnjigu : Form
{
	KnjigaPregled knjiga = new KnjigaPregled();
	int projekatId;
	public DodajKnjigu(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novu knjigu?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{

			knjiga.ISBN = ISBN_TB.Text;
			knjiga.Naziv = Naziv_TB.Text;
			knjiga.Izdavac = Izdavac_TB.Text;
			knjiga.GodinaIzdanja = int.Parse(GodinaIzdanja_TB.Text);

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

			DTOManager.DodajKnjigu(projekatId, knjiga, autori);
			MessageBox.Show("Uspesno ste dodali novu knjigu!");
			this.Close();
		}
	}
}
