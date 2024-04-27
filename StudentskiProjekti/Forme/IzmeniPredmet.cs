using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class IzmeniPredmet : Form
{
    public PredmetPregled predmet = new PredmetPregled();

    public IzmeniPredmet()
    {
        InitializeComponent();
    }

    public IzmeniPredmet(PredmetPregled p)
    {
        InitializeComponent();
        this.predmet = p;
    }

    private void IzmeniPredmet_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        this.Text = $"Azuriranje predmeta {predmet.Naziv}";
    }

    public void PopuniPodacima()
    {
        Sifra_TB.Text = this.predmet.Id;
        Naziv_TB.Text = this.predmet.Naziv;
        Katedra_TB.Text = this.predmet.Katedra;
        Semestar_TB.Text = this.predmet.Semestar.ToString();

    }
    private void Izmeni_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da izvrsite izmene predmeta?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);
        if (result == DialogResult.OK)
        {

            if (DTOManager.VratiPredmet(Sifra_TB.Text) == null || DTOManager.VratiPredmet(Sifra_TB.Text).Id == this.predmet.Id)
            {
                this.predmet.Id = Sifra_TB.Text;
                this.predmet.Naziv = Naziv_TB.Text;
                this.predmet.Katedra = Katedra_TB.Text;
                this.predmet.Semestar = int.TryParse(Semestar_TB.Text, out int semestar) ? semestar : 0;


                DTOManager.AzurirajPredmet(this.predmet);
                MessageBox.Show("Azuriranje predmeta je uspesno izvrseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Azuriranje predmeta nije uspesno, sifra predmeta vec postoji!");
            }
        }
        else
        {

        }
    }
}
