using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class TeorijskiProjekti : Form
{
    DTOs.PredmetPregled izabraniPredmet;
    public TeorijskiProjekti(DTOs.PredmetPregled predmet)
    {
        izabraniPredmet = predmet;
        InitializeComponent();
    }

    private void TeorijskiProjekti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {

        TeorijskiProjekti_ListV.Items.Clear();
        IList<TeorijskiProjekatPregled> teorijskiprojekti = DTOManager.VratiTeorijskeProjekteZaPredmet(izabraniPredmet.Id);
        teorijskiprojekti = teorijskiprojekti.OrderBy(p => p.SkolskaGodinaZadavanja).ToList();

        foreach (TeorijskiProjekatPregled p in teorijskiprojekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana.ToString() });
            item.Tag = p.Id;
            TeorijskiProjekti_ListV.Items.Add(item);
        }

        TeorijskiProjekti_ListV.Refresh();
    }

    private void DodajProjekatT_Btn_Click(object sender, EventArgs e)
    {
        DodajTeorijskiProjekat dodajTproj = new DodajTeorijskiProjekat()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajTproj.ShowDialog();
    }

    private void IzmeniProjekatT_Btn_Click(object sender, EventArgs e)
    {
        IzmeniTeorijskiProjekat izmeniTproj = new IzmeniTeorijskiProjekat()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniTproj.ShowDialog();
    }
}
