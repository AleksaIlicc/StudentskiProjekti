using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class Projekti : Form
{

    private PredmetPregled izabraniPredmet;
    public Projekti(PredmetPregled izabraniPredmet)
    {
        InitializeComponent();
        this.izabraniPredmet = izabraniPredmet;
    }

    private void Projekti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        Naziv_Lbl.Text = izabraniPredmet.Naziv;
        Sifra_Lbl.Text = izabraniPredmet.Id;
        Katedra_Lbl.Text = izabraniPredmet.Katedra;
        Semestar_Lbl.Text = izabraniPredmet.Semestar.ToString() + ".";
    }

    public void PopuniPodacima()
    {

        Projekti_ListV.Items.Clear();
        List<ProjekatPregled> projekti = DTOManager.VratiProjekteZaPredmet(izabraniPredmet.Id);
        projekti = projekti.OrderBy(p => p.Naziv).ToList();

        foreach (ProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta });
            Projekti_ListV.Items.Add(item);
        }

        Projekti_ListV.Refresh();
    }
}
