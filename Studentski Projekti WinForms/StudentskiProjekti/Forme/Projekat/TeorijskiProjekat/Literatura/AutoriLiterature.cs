using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class AutoriLiterature : Form
{
	int type;
	string id;
	public AutoriLiterature(string id, int type)
	{
		InitializeComponent();
		this.id = id;
		this.type = type;
	}

	private void AutoriLiterature_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		Nazivi_ListV.Items.Clear();
		List<AutorPregled> autori = [];
		if (type == 1)
		{ // knjiga
			autori = DTOManager.VratiAutoreZaKnjigu(id);
		}
		else if (type == 2)
		{ // rad
			autori = DTOManager.VratiAutoreZaRad(Int32.Parse(id));
		}
		else if (type == 3)
		{ // clanak
			autori = DTOManager.VratiAutoreZaClanak(id);
		}

		foreach (var a in autori)
		{
			ListViewItem item = new ListViewItem(new string[] { a.Autor });
			Nazivi_ListV.Items.Add(item);
		}
		Nazivi_ListV.Refresh();
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		int idLiterature = 0;
		if (type == 1)
		{ // knjiga
			idLiterature = DTOManager.VratiIdLiteratureKnjige(id);
		}
		else if (type == 2)
		{ // rad
			idLiterature = DTOManager.VratiIdLiteratureRada(Int32.Parse(id));
		}
		else if (type == 3)
		{ // clanak
			idLiterature = DTOManager.VratiIdLiteratureClanka(id);
		}
		DodajAutora dodajAutora = new DodajAutora(idLiterature)
		{
			StartPosition = FormStartPosition.CenterParent
		};
		dodajAutora.ShowDialog();
		PopuniPodacima();
	}

	private void Obrisi_Btn_Click(object sender, EventArgs e)
	{
		if (Nazivi_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite autora kojeg zelite da obrisete!");
			return;
		}

		string nazivAutora = Nazivi_ListV.SelectedItems[0].SubItems[0].Text;
		string poruka = "Da li zelite da obrisete odabranog autora?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			if (type == 1)
			{ // knjiga
				DTOManager.ObrisiAutoraKnjige(id, nazivAutora);
			}
			else if (type == 2)
			{ // rad
				DTOManager.ObrisiAutoraRada(Int32.Parse(id),nazivAutora);
			}
			else if (type == 3)
			{ // clanak
				DTOManager.ObrisiAutoraClanka(id, nazivAutora);
			}
			MessageBox.Show("Brisanje autora je uspesno obavljeno!");
			PopuniPodacima();
		}
	}
}
