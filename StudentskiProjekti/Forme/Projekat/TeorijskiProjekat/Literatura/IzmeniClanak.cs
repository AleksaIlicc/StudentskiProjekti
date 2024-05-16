namespace StudentskiProjekti.Forme;
public partial class IzmeniClanak : Form
{
    private DTOs.ClanakUCasopisuPregled clanak;

    public IzmeniClanak(DTOs.ClanakUCasopisuPregled clanak)
    {
        InitializeComponent();
        this.clanak = clanak;
        PopuniPodacima();
    }

    private void PopuniPodacima()
    {
        ISSN_TB.Text = clanak.ISSN;
        Naziv_TB.Text = clanak.Naziv;
        ImeCasopisa_TB.Text = clanak.ImeCasopisa;
        Broj_TB.Text = clanak.Broj.ToString();
        Godina_TB.Text = clanak.Godina.ToString();
    }

}

