namespace StudentskiProjekti.Forme;

public partial class OstaliStudentiNaPProjektu : Form
{
    DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
    DTOs.StudentPregled sp = new DTOs.StudentPregled();
    public OstaliStudentiNaPProjektu(DTOs.StudentPregled sp, DTOs.PrakticniProjekatPregled pp)
    {
        InitializeComponent();
        this.sp = sp;
        this.pp = pp;
    }

    private void OstaliStudentiNaPProjektu_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListViewPrakticni();
    }
    private void PopuniPodacimaListViewPrakticni()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<DTOs.StudentPregled> studenti = DTOManager.VratiStudNaGrupnomProj(pp.Id);

        foreach (DTOs.StudentPregled s in studenti)
        {
            if (s.BrIndeksa == sp.BrIndeksa)
            {
                continue;
            }
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.Prezime });
            OstaliStudenti_ListV.Items.Add(item);
        }

        OstaliStudenti_ListV.Refresh();
    }
}
