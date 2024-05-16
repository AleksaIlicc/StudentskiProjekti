namespace StudentskiProjekti.Forme;
public partial class IzmeniRad : Form
{
    private DTOs.RadPregled rad;

    public IzmeniRad(DTOs.RadPregled rad)
    {
        InitializeComponent();
        this.rad = rad;
        PopuniPodacima();
    }

    private void PopuniPodacima()
    {
        Naziv_TB.Text = rad.Naziv;
        URL_TB.Text = rad.Url;
        Format_TB.Text = rad.Format;
        KonfObjavljivanja_TB.Text = rad.KonferencijaObjavljivanja;
    }
}