using StudentskiProjekti.Entiteti;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class IzmeniIzvestaj : Form
{

    PrakticniProjekatPregled pp = new PrakticniProjekatPregled();
    StudentPregled sp = new StudentPregled();
    IzvestajPregled ip = new IzvestajPregled();
    ProjekatUcesceDetalji pd = new ProjekatUcesceDetalji();
    public IzmeniIzvestaj(StudentPregled sp, PrakticniProjekatPregled pp, IzvestajPregled ip , ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.sp = sp;
        this.pp = pp;
        this.ip = ip;
        this.pd = pd;
    }

    private void IzmeniIzvestaj_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Opis_TB.Text = ip.Opis;
        DatumPredaje_DP.Value = (DateTime)ip.DatumPredaje;
    }
    private void Izmeni_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da izvrsite izmene na izvestaju?";
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
            if(DatumPredaje_DP.Value < pd.DatumPocetkaIzrade)
            {
                MessageBox.Show("Morate uneti validan datum predaje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ip.Opis = Opis_TB.Text;
            ip.DatumPredaje = DatumPredaje_DP.Value;

            DTOManager.AzurirajIzvestaj(ip);
            MessageBox.Show("Azuriranje predmeta je uspesno izvrseno!");
            this.Close();
        }
    }

}
