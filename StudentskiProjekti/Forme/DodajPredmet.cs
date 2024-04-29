using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;

public partial class DodajPredmet : Form
{
    PredmetPregled predmet = new PredmetPregled();

    public DodajPredmet()
    {
        InitializeComponent();
    }

    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi predmet?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            this.predmet.Id = Sifra_TB.Text;
            this.predmet.Naziv = Naziv_TB.Text;
            this.predmet.Semestar = int.TryParse(Semestar_TB.Text, out int semestar) ? semestar : 0;
            this.predmet.Katedra = Katedra_TB.Text;


            DTOManager.DodajPredmet(this.predmet);
            MessageBox.Show("Uspesno ste dodali novi predmet!");
            this.Close();
        }
        else
        {

        }
    }
}
