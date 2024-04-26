namespace StudentskiProjekti
{
    public partial class StudentskiProjekti : Form
    {
        public StudentskiProjekti()
        {
            InitializeComponent();
        }

        private void prodavnica_btn_clk(object sender, EventArgs e)
        {
            Predmeti predmeti = new Predmeti
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            predmeti.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession session = null;
            session = DataLayer.GetSession();
            session.Close();
        }
    }
}
