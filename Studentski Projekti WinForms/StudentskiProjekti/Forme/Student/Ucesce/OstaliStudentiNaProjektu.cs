using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class OstaliStudentiNaProjektu : Form
{
    string brojIndeksa;
    int projekatId;

    public OstaliStudentiNaProjektu(string brojIndeksa, int projekatId)
    {
        InitializeComponent();
        this.brojIndeksa = brojIndeksa;
        this.projekatId = projekatId;
    }

    private void OstaliStudentiNaPProjektu_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListViewPrakticni();
    }

    private void PopuniPodacimaListViewPrakticni()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(projekatId);

        foreach (StudentPregled s in studenti)
        {
            if (s.BrIndeksa == brojIndeksa)
            {
                continue;
            }
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.Prezime });
            OstaliStudenti_ListV.Items.Add(item);
        }

        OstaliStudenti_ListV.Refresh();
    }
}
