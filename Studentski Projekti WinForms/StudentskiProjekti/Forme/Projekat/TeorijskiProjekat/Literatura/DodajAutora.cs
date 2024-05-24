namespace StudentskiProjekti.Forme;
public partial class DodajAutora : Form
{
	int idLiterature;
	public DodajAutora(int idLiterature)
	{
		InitializeComponent();
		this.idLiterature = idLiterature;	
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novog autora?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if(result == DialogResult.OK)
		{
			DTOManager.DodajAutora(idLiterature, Naziv_TB.Text);
			MessageBox.Show("Uspesno ste dodali novog autora!");
			this.Close();
		}
	}
}
