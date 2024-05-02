using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class PreporuceneWebStranice : Form
{
	private int projekatId;
	public PreporuceneWebStranice(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void PreporuceneWebStranice_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
	}

	private void PopuniPodacima()
	{
		Nazivi_ListV.Items.Clear();
		IList<PreporucenaWebStranicaPregled> preporuceneStranice = DTOManager.VratiPreporuceneWebStranicePProjekta(projekatId);

		foreach (var s in preporuceneStranice)
		{
			ListViewItem item = new ListViewItem(new string[] { s.Naziv });
			Nazivi_ListV.Items.Add(item);
		}

		Nazivi_ListV.Refresh();
	}
}
