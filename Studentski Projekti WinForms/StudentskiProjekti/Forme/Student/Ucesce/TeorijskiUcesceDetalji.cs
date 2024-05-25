using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class TeorijskiUcesceDetalji : Form  
{
    StudentPregled sp;
    ProjekatPregled p;
    ProjekatUcesceDetalji pd;

    public TeorijskiUcesceDetalji(StudentPregled sp, ProjekatPregled p)
    {
        InitializeComponent();
        this.p = p;
        this.sp = sp;
        this.pd = DTOManager.VratiUcesceDetalji(sp.BrIndeksa, p.Id);
    }

    private void TeorijskiUcesceDetalji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaLabele();
        if (p.TipProjekta == "grupni")
        {
            this.MaximumSize = new System.Drawing.Size(919, 451);
            this.MinimumSize = new System.Drawing.Size(919, 451);
            PrikaziStudenteNaIstom_Btn.Visible = false;
            PopuniPodacimaListView();
        }
        else if (p.TipProjekta == "pojedinacni")
        {
            this.MaximumSize = new System.Drawing.Size(585, 500);
            this.MinimumSize = new System.Drawing.Size(585, 500);
            OstaliClanovi_GB.Visible = false;
            OstaliClanovi_ListV.Visible = false;
        }
    }

    private void PopuniPodacimaLabele()
    {
        Naziv_LB.Text = p.Naziv;
        DatumPocetka_LB.Text = pd.DatumPocetkaIzrade.ToString("dd.MM.yyyy");
        DatumZavrsetka_LB.Text = pd.DatumZavrsetkaIzrade?.ToString("dd.MM.yyyy") ?? "";
        RokZaZavrsetak_LB.Text = pd.RokZaZavrsetak.ToString("dd.MM.yyyy");
        ProjekatZavrsen_LB.Text = pd.ProjekatZavrsen;
        SkolskaGodinaZad_LB.Text = p.SkolskaGodinaZadavanja;
        DopunskaLit_LB.Text = pd.DopunskaLiteratura ?? "";
    }

    private void PopuniPodacimaListView()
    {
        OstaliClanovi_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(p.Id);

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
        OstaliStudentiNaProjektu studenti = new OstaliStudentiNaProjektu(sp.BrIndeksa, p.Id)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studenti.ShowDialog();
    }
}
