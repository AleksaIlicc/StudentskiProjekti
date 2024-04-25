namespace StudentskiProjekti.Forme
{
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }

        private void DodajPredmet_Btn_Click(object sender, EventArgs e)
        {
            DodajPredmet dodajPredmet = new DodajPredmet()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            dodajPredmet.ShowDialog();
        }
        private void IzmeniPredmetBtn_Click(object sender, EventArgs e)
        {
            IzmeniPredmet izmeniPredmet = new IzmeniPredmet()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            izmeniPredmet.ShowDialog();
        }

        private void ObrisiPredmetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete predmet?",
                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else
            {

            }
        }
    }
}
