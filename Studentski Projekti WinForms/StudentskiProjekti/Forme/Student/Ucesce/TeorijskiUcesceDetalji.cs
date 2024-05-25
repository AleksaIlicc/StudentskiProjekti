using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class TeorijskiUcesceDetalji : Form  
{
    StudentPregled sp = new StudentPregled();
    ProjekatPregled te = new TeorijskiProjekatPregled();
    ProjekatUcesceDetalji pd = new ProjekatUcesceDetalji();

    public TeorijskiUcesceDetalji(StudentPregled sp, TeorijskiProjekatPregled te, ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.te = te;
        this.sp = sp;
        this.pd = pd;
    }

    public TeorijskiUcesceDetalji(StudentPregled sp, ProjekatPregled p)
    {
        InitializeComponent();
        this.te = p;
        this.sp = sp;
        this.pd = DTOManager.VratiUcesceNaProj(sp.BrIndeksa, te.Id);
    }

    private void TeorijskiUcesceDetalji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaLabele();
        if (te.TipProjekta == "grupni")
        {
            this.MaximumSize = new System.Drawing.Size(919, 451);
            this.MinimumSize = new System.Drawing.Size(919, 451);
            PrikaziStudenteNaIstom_Btn.Visible = false;
            PopuniPodacimaListView();
        }
        else if (te.TipProjekta == "pojedinacni")
        {
            this.MaximumSize = new System.Drawing.Size(585, 500);
            this.MinimumSize = new System.Drawing.Size(585, 500);
            OstaliClanovi_GB.Visible = false;
            OstaliClanovi_ListV.Visible = false;
        }
    }

    private void PopuniPodacimaLabele()
    {
        Naziv_LB.Text = te.Naziv;
        DatumPocetka_LB.Text = pd.DatumPocetkaIzrade.ToString("dd.MM.yyyy");
        DatumZavrsetka_LB.Text = pd.DatumZavrsetkaIzrade?.ToString("dd.MM.yyyy") ?? "";
        RokZaZavrsetak_LB.Text = pd.RokZaZavrsetak.ToString("dd.MM.yyyy");
        ProjekatZavrsen_LB.Text = pd.ProjekatZavrsen;
        SkolskaGodinaZad_LB.Text = te.SkolskaGodinaZadavanja.ToString();
        DopunskaLit_LB.Text = DTOManager.VratiDopunskuLiteraturu(te.Id, sp.BrIndeksa);
    }

    private void PopuniPodacimaListView()
    {
        OstaliClanovi_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(te.Id);

        foreach (StudentPregled s in studenti)
        {
            if (s.BrIndeksa == sp.BrIndeksa)
            {
                continue;
            }
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.Prezime });
            OstaliClanovi_ListV.Items.Add(item);
        }

        OstaliClanovi_ListV.Refresh();
    }

    private void PrikaziStudente_Btn_Click(object sender, EventArgs e)
    {
        OstaliStudentiNaProjektu studenti = new OstaliStudentiNaProjektu(sp , te)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studenti.ShowDialog();
    }
}
