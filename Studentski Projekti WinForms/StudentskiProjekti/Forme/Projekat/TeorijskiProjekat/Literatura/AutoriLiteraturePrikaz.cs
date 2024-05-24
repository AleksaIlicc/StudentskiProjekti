namespace StudentskiProjekti.Forme;
public partial class AutoriLiteraturePrikaz : Form
{
	private int litId;
	public AutoriLiteraturePrikaz(int litId)
	{
		InitializeComponent();
		this.litId = litId;
	}

	private void AutoriLiteraturePrikaz_Load(object sender, EventArgs e)
	{
		var sviAutori = DTOManager.VratiAutoreZaLiteraturu(litId);
		foreach(var autor in sviAutori)
		{
			ListViewItem item = new ListViewItem( new string[] { autor.Autor });
			Nazivi_ListV.Items.Add(item);
		}
	}
}
