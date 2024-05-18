using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajPrakticniProjekat : Form
{
    PrakticniProjekatPregled projekat = new PrakticniProjekatPregled();
    public DodajPrakticniProjekat(PredmetPregled p)
    {
        InitializeComponent();
        projekat.PripadaPredmetu = p;
    }
    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi prakticni projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            this.projekat.Naziv = Naziv_TB.Text;
            this.projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            if (Pojedinacni_RB.Checked)
            {
                this.projekat.TipProjekta = "pojedinacni";
            }
            else if (Grupni_RB.Checked)
            {
                this.projekat.TipProjekta = "grupni";
            }
            this.projekat.PreporuceniProgramskiJezik = PreporuceniProgJezik_TB.Text;
            this.projekat.VrstaProjekta = "prakticni";

            DTOManager.DodajPrakticniProjekat(projekat);
            MessageBox.Show("Uspesno ste dodali novi projekat!");
            this.Close();
        }
    }

    private void SkoslaGodIzdavanja_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
        {
            e.Handled = true;
        }
    }
}
