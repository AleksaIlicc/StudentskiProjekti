namespace StudentskiProjekti.Forme;

public partial class OstaliStudentiNaProjektu : Form
{
    DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
    DTOs.TeorijskiProjekatPregled te = new DTOs.TeorijskiProjekatPregled();
    DTOs.StudentPregled sp = new DTOs.StudentPregled();
    string tip = null;
    public OstaliStudentiNaProjektu(DTOs.StudentPregled sp, DTOs.PrakticniProjekatPregled pp)
    {
        InitializeComponent();
        this.sp = sp;
        this.pp = pp;
        tip = "prakticni";
    }
    public OstaliStudentiNaProjektu(DTOs.StudentPregled sp,DTOs.TeorijskiProjekatPregled te)
    {
        InitializeComponent();
        this.sp = sp;
        this.te = te;
        tip = "teorijski";
    }

    private void OstaliStudentiNaPProjektu_Load(object sender, EventArgs e)
    {
        if (tip == "prakticni")
        {
            PopuniPodacimaListViewPrakticni();
        }
        else if(tip == "teorijski")
        {
            PopuniPodacimaListViewTeorijski();
        }
    }
    private void PopuniPodacimaListViewPrakticni()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<DTOs.StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(pp.Id);

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

    private void PopuniPodacimaListViewTeorijski()
    {
        OstaliStudenti_ListV.Items.Clear();
        List<DTOs.StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(te.Id);

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
