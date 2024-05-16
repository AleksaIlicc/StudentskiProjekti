namespace StudentskiProjekti.Forme;
public partial class DodajClanak : Form
{
    DTOs.ClanakUCasopisuPregled clanak = new DTOs.ClanakUCasopisuPregled();
    public DodajClanak()
    {
        InitializeComponent();
    }

    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi clanak?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {

            this.clanak.Naziv = Naziv_TB.Text;
            this.clanak.ImeCasopisa = ImeCasopisa_TB.Text;
            this.clanak.ISSN = ISSN_TB.Text;
            this.clanak.Broj = int.Parse(Broj_TB.Text);
            this.clanak.Godina = int.Parse(Godina_TB.Text);


            DTOManager.DodajClanak(this.clanak);
            MessageBox.Show("Uspesno ste dodali novi clanak!");
            this.Close();
        }
    }

}
