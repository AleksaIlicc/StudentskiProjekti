using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajPostojecuLiteraturu : Form
{
	int projekatId;
	public DodajPostojecuLiteraturu(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}


	private void DodajPostojecuLiteraturu_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
	}

	public void PopuniPodacima()
	{
		Literature_ListV.Items.Clear();
		List<LiteraturaPregled> literature = DTOManager.VratiSveLiterature();

		foreach (LiteraturaPregled l in literature)
		{
			ListViewItem item = new ListViewItem(new string[] { l.Naziv });
			item.Tag = l.Id;
			Literature_ListV.Items.Add(item);
		}

		Literature_ListV.Refresh();
	}

	private void PrikaziAutore_Btn_Click(object sender, EventArgs e)
	{
		int litSelCnt = Literature_ListV.SelectedItems.Count;
		if (litSelCnt == 0)
		{
			MessageBox.Show("Izaberite literaturu za koji zelite da prikazete autore!");
			return;
		}
		if (litSelCnt > 1)
		{
			MessageBox.Show("Izaberite samo jednu literaturu za koji zelite da prikazete autore!");
			return;
		}
		AutoriLiteraturePrikaz autoriLiterature = new AutoriLiteraturePrikaz((int)Literature_ListV.SelectedItems[0].Tag)
		{
			StartPosition = FormStartPosition.CenterParent
		};
		autoriLiterature.ShowDialog();
	}

	private void ObrisiSvaPojavljivanja_Btn_Click(object sender, EventArgs e)
	{
		int litSelCnt = Literature_ListV.SelectedItems.Count;
		if (litSelCnt == 0)
		{
			MessageBox.Show("Izaberite literaturu za koju želite da obrišete sva pojavljivanja!");
			return;
		}
		if (litSelCnt > 1)
		{
			MessageBox.Show("Izaberite samo jednu literaturu za koju želite da obrišete sva pojavljivanja!");
			return;
		}
		int idLiterature = (int)Literature_ListV.SelectedItems[0].Tag;
		string poruka = "Da li ste sigurni da želite da obrišete sva pojavljivanja ove literature?\n" +
						"Ova akcija će ukloniti literaturu iz svih postojećih projekata i ne može se poništiti.";
		string title = "Upozorenje o brisanju literature";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons, MessageBoxIcon.Warning);

		if (result == DialogResult.OK)
		{
			DTOManager.ObrisiLiteraturu(idLiterature);
			MessageBox.Show("Brisanje literature je uspešno obavljeno!");
			PopuniPodacima();
		}
	}

	private void DodajLiteratureZaProjekat_Btn_Click(object sender, EventArgs e)
	{
		int litSelCnt = Literature_ListV.SelectedItems.Count;
		if (litSelCnt == 0)
		{
			MessageBox.Show("Izaberite literaturu/e koju želite da dodate za projekat!");
			return;
		}

		string poruka = "Da li želite da dodate izabranu literaturu na projekat?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			foreach (ListViewItem item in Literature_ListV.SelectedItems)
			{
				int idLiterature = (int)item.Tag;
				DTOManager.DodajLiteraturuZaProjekat(projekatId, idLiterature);
			}
			MessageBox.Show("Uspešno ste dodali literaturu/e za projekat!");
		}
	}

	private void Pretrazi_Btn_Click(object sender, EventArgs e)
	{
		Literature_ListV.Items.Clear();
		List<LiteraturaPregled> literature = DTOManager.VratiPretrazeneLiterature(Pretraga_TB.Text);

		foreach (LiteraturaPregled l in literature)
		{
			ListViewItem item = new ListViewItem(new string[] { l.Naziv });
			item.Tag = l.Id;
			Literature_ListV.Items.Add(item);
		}

		Literature_ListV.Refresh();
	}

	private void Ocisti_Btn_Click(object sender, EventArgs e)
	{
		Pretraga_TB.Text = "";
		PopuniPodacima();
	}
}
