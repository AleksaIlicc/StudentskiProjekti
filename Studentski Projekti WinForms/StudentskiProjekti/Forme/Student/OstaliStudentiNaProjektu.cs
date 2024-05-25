using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class OstaliStudentiNaProjektu : Form
{
    ProjekatPregled p = new ProjekatPregled();
    StudentPregled sp = new StudentPregled();

    public OstaliStudentiNaProjektu(StudentPregled sp, ProjekatPregled p)
    {
        InitializeComponent();
        this.sp = sp;
        this.p = p;
    }

    private void OstaliStudentiNaPProjektu_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListViewPrakticni();
    }

    private void PopuniPodacimaListViewPrakticni()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(p.Id);

        foreach (StudentPregled s in studenti)
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
