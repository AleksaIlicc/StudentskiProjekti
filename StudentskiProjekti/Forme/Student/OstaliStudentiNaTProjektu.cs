namespace StudentskiProjekti.Forme;

public partial class OstaliStudentiNaTProjektu : Form
{
    DTOs.TeorijskiProjekatPregled te = new DTOs.TeorijskiProjekatPregled();
    DTOs.StudentPregled sp = new DTOs.StudentPregled();

    public OstaliStudentiNaTProjektu(DTOs.StudentPregled sp,DTOs.TeorijskiProjekatPregled te)
    {
        InitializeComponent();
        this.te = te;
        this.sp = sp;
    }
    private void OstaliStudentiNaProjektu_Load(object sender, EventArgs e)
    {

            PopuniPodacimaListViewTeorijski();
       
    }
    private void PopuniPodacimaListViewTeorijski()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<DTOs.StudentPregled> studenti = DTOManager.VratiStudNaGrupnomProj(te.Id);

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
