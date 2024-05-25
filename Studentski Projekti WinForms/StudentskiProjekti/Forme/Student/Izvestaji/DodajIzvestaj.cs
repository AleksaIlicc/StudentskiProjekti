using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajIzvestaj : Form
{
    IzvestajPregled ip = new IzvestajPregled();
    ProjekatUcesceDetalji pd;
    int projekatId;
    string brIndeksa;

    public DodajIzvestaj(string brIndeksa, int projekatId, ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.brIndeksa = brIndeksa;
        this.projekatId = projekatId;
        this.pd = pd;
    }

    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi izvestaj?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(Opis_TB.Text))
            {
                MessageBox.Show("Morate uneti opis izvestaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(DatumPredaje_DP.Text))
            {
                MessageBox.Show("Morate uneti datum predaje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (DatumPredaje_DP.Value < pd.DatumPocetkaIzrade || DatumPredaje_DP.Value > DateTime.Now)
			{
				MessageBox.Show("Morate uneti validan datum predaje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ip.Opis = Opis_TB.Text;
            ip.DatumPredaje = DatumPredaje_DP.Value;

            DTOManager.DodajIzvestaj(projekatId, brIndeksa, ip);
            MessageBox.Show("Uspesno ste dodali novi izvestaj!");
            Close();
        }
    }
}
