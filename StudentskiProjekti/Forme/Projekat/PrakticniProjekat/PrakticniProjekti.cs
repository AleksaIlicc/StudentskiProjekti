using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class PrakticniProjekti : Form
{
    DTOs.PredmetPregled izabraniPredmet;
    public PrakticniProjekti(DTOs.PredmetPregled predmet)
    {
        izabraniPredmet = predmet;
        InitializeComponent();
    }

    private void PrakticniProjekti_Load(object sender, EventArgs e)
    {
        PrakticniProjekti_ListV.Items.Clear();
        IList<PrakticniProjekatPregled> prakticniProjekat = DTOManager.VratiPrakticneProjekteZaPredmet(izabraniPredmet.Id);
        prakticniProjekat = prakticniProjekat.OrderBy(p => p.SkolskaGodinaZadavanja).ToList();

        foreach (PrakticniProjekatPregled p in prakticniProjekat)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id ,p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik });
            PrakticniProjekti_ListV.Items.Add(item);
        }

        PrakticniProjekti_ListV.Refresh();
    }

    private void DodajProjekatP_Btn_Click(object sender, EventArgs e)
    {
        DodajPrakticniProjekat dodajPproj = new DodajPrakticniProjekat()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajPproj.ShowDialog();
    }

    private void IzmeniProjekatP_Btn_Click(object sender, EventArgs e)
    {
       IzmeniPrakticniProjekat izmeniPproj = new IzmeniPrakticniProjekat()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniPproj.ShowDialog();
    }
}
