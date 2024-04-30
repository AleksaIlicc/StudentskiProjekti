using StudentskiProjekti.Entiteti;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class Studenti : Form
{
	public Studenti()
	{
		InitializeComponent();
	}

	private void PopuniPodacima()
	{
		Studenti_ListV.Items.Clear();
		List<StudentPregled> studenti = DTOManager.VratiSveStudente();
		studenti = studenti.OrderBy(s => s.BrIndeksa).ToList();

		foreach (StudentPregled s in studenti)
		{
			ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer });
			Studenti_ListV.Items.Add(item);
		}

		Studenti_ListV.Refresh();
	}

	private void DodajStudenta_Btn_Click(object sender, EventArgs e)
	{
		DodajStudenta dodajPredmet = new DodajStudenta()
		{
			StartPosition = FormStartPosition.CenterParent
		};
		dodajPredmet.ShowDialog();
		PopuniPodacima();
	}

	private void Studenti_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
	}

	private void ObrisiStudenta_Btn_Click_1(object sender, EventArgs e)
	{
		if (Studenti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite studenta kojeg zelite da obrisete!");
			return;
		}

		string idStudenta = Studenti_ListV.SelectedItems[0].SubItems[0].Text;
		string poruka = "Da li zelite da obrisete izabranog studenta?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			DTOManager.ObrisiStudenta(idStudenta);
			MessageBox.Show("Brisanje studenta je uspesno obavljeno!");
			PopuniPodacima();
		}
	}

	private void IzmeniStudenta_Btn_Click(object sender, EventArgs e)
	{
		if (Studenti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite studenta kojeg zelite da izmenite!");
		}
		else
		{
			string brIndeksaStudenta = Studenti_ListV.SelectedItems[0].SubItems[0].Text;
			StudentPregled sp = DTOManager.VratiStudenta(brIndeksaStudenta);

			IzmeniStudenta formaUpdate = new IzmeniStudenta(sp)
			{
				StartPosition = FormStartPosition.CenterParent
			};

			formaUpdate.ShowDialog();

			PopuniPodacima();
		}
	}
}
