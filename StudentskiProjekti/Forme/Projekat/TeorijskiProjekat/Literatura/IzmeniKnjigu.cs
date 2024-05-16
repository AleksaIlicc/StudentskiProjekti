namespace StudentskiProjekti.Forme;
public partial class IzmeniKnjigu : Form
{
    private DTOs.KnjigaPregled knjiga;

    public IzmeniKnjigu(DTOs.KnjigaPregled knjiga)
    {
        InitializeComponent();
        this.knjiga = knjiga;
        PopuniPodacima();
    }

    private void PopuniPodacima()
    {
        ISBN_TB.Text = knjiga.ISBN;
        Naziv_TB.Text = knjiga.Naziv;
        Izdavac_TB.Text = knjiga.Izdavac;
        GodinaIzdanja_TB.Text = knjiga.GodinaIzdanja.ToString();
    }
}
