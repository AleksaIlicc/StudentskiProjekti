using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class TeorijskiProjekti : Form
{
	PredmetPregled izabraniPredmet;
	public TeorijskiProjekti(PredmetPregled predmet)
	{
		izabraniPredmet = predmet;
		InitializeComponent();
	}

	private void TeorijskiProjekti_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
	}

	public void PopuniPodacima()
	{
		TeorijskiProjekti_ListV.Items.Clear();
		IList<TeorijskiProjekatPregled> teorijskiprojekti = DTOManager.VratiTeorijskeProjekteZaPredmet(izabraniPredmet.Id);

		foreach (TeorijskiProjekatPregled p in teorijskiprojekti)
		{
			ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana.ToString() == "0" ? null : p.MaksBrojStrana.ToString() });
			item.Tag = p.Id;
			TeorijskiProjekti_ListV.Items.Add(item);
		}

		TeorijskiProjekti_ListV.Refresh();
	}

	private void DodajProjekatT_Btn_Click(object sender, EventArgs e)
	{
		DodajTeorijskiProjekat dodajTproj = new DodajTeorijskiProjekat(izabraniPredmet)
		{
			StartPosition = FormStartPosition.CenterParent
		};
		dodajTproj.ShowDialog();
		PopuniPodacima();
	}

	private void IzmeniProjekatT_Btn_Click(object sender, EventArgs e)
	{
		if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite projekat koji zelite da izmenite!");
			return;
		}
		int idprojekta = (int)TeorijskiProjekti_ListV.SelectedItems[0].Tag;
		TeorijskiProjekatPregled ob = DTOManager.VratiTeorijskiProjekat(idprojekta);
		IzmeniTeorijskiProjekat izmeniTproj = new IzmeniTeorijskiProjekat(ob)
		{
			StartPosition = FormStartPosition.CenterParent
		};
		izmeniTproj.ShowDialog();
		PopuniPodacima();
	}

	private void ObrisiProjekatT_Btn_Click(object sender, EventArgs e)
	{
		if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite projekat koji zelite da obrisete!");
			return;
		}

		int idProjekta = (int)TeorijskiProjekti_ListV.SelectedItems[0].Tag;
		string poruka = "Da li zelite da obrisete izabrani projekat?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			DTOManager.ObrisiTeorijskiProjekat(idProjekta);
			MessageBox.Show("Brisanje projekta je uspesno obavljeno!");
			PopuniPodacima();
		}
	}

	private void Literatura_Btn_Click(object sender, EventArgs e)
	{

        if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat za koji zelite da vidite vise detalja!");
            return;
        }

        int idProjekta = int.TryParse(TeorijskiProjekti_ListV.SelectedItems[0].Tag.ToString(), out int result) ? result : 0;
        TeorijskiProjekatPregled izabraniProjekat = DTOManager.VratiTeorijskiProjekat(idProjekta);
        Literature literature = new Literature(izabraniProjekat)
		{
			StartPosition = FormStartPosition.CenterParent
		};
		literature.ShowDialog();
	}
}
