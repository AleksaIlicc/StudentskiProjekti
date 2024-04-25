namespace StudentskiProjekti.Forme
{
	public partial class Predmeti : Form
	{
		public Predmeti()
		{
			InitializeComponent();
		}

		private void DodajPredmetBtn_Click(object sender, EventArgs e)
		{
			DodajPredmet DodajPred = new DodajPredmet
			{
				StartPosition = FormStartPosition.CenterParent,

			};
			DodajPred.ShowDialog();
		}
	}
}
