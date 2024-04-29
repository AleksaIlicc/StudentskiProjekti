using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class Studenti : Form
{
	public Studenti()
	{
		InitializeComponent();
	}

	private void PopuniPodacima() { }

	private void DodajStudenta_Btn_Click(object sender, EventArgs e)
	{
		DodajStudenta dodajPredmet = new DodajStudenta()
		{
			StartPosition = FormStartPosition.CenterParent
		};
		dodajPredmet.ShowDialog();
		this.PopuniPodacima();
	}

	private void IzmeniPredmet_Btn_Click(object sender, EventArgs e)
	{
		/*if (Predmeti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite predmet koji zelite da izmenite!");
		}*/
		/*else
		{
			string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
			PredmetPregled ob = DTOManager.VratiPredmet(idPredmeta);
*/
		IzmeniStudenta formaUpdate = new IzmeniStudenta()
		{
			StartPosition = FormStartPosition.CenterParent
		};

		formaUpdate.ShowDialog();

		this.PopuniPodacima();
/*		}*/
	}
}
