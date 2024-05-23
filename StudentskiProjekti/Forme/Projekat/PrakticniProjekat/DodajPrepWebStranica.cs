namespace StudentskiProjekti.Forme;
public partial class DodajPrepWebStranica : Form
{
    int projekat_id;
    public DodajPrepWebStranica(int p)
    {
        InitializeComponent();
        projekat_id = p;
    }

    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novu web stranicu?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);
        if(result == DialogResult.OK)
        {
            DTOManager.DodajPreporucenuWebStranicuZaProjekat(projekat_id, Naziv_TB.Text);
            MessageBox.Show("Uspesno ste dodali novu web stranicu!");
            this.Close();
        }
    }
}
