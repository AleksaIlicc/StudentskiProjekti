using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajIzvestaj : Form
{

    PrakticniProjekatPregled pp = new PrakticniProjekatPregled();
    StudentPregled sp = new StudentPregled();
    IzvestajPregled ip = new IzvestajPregled();
    ProjekatUcesceDetalji pd = new ProjekatUcesceDetalji();
    public DodajIzvestaj(StudentPregled sp, PrakticniProjekatPregled pp, ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.sp = sp;
        this.pp = pp;
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
            if (DatumPredaje_DP.Value < pd.DatumPocetkaIzrade)
            {
                MessageBox.Show("Morate uneti validan datum predaje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ip.Opis = Opis_TB.Text;
            ip.DatumPredaje = DatumPredaje_DP.Value;

            DTOManager.DodajIzvestaj(pp.Id , sp.BrIndeksa , ip);
            MessageBox.Show("Uspesno ste dodali novi izvestaj!");
            Close();
        }
    }
}
