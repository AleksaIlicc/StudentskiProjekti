namespace StudentskiProjekti;

public partial class StudentskiProjekti : Form
{
	public StudentskiProjekti()
	{
		InitializeComponent();
	}

	private void Predmeti_Btn_Click(object sender, EventArgs e)
	{
		Predmeti predmeti = new Predmeti
		{
			StartPosition = FormStartPosition.CenterParent,
		};
		predmeti.ShowDialog(this);
	}
}
