namespace StudentskiProjekti.Forme;

public partial class TeorijskiUcesceDetalji : Form  
{
    DTOs.StudentPregled sp = new DTOs.StudentPregled();
    DTOs.TeorijskiProjekatPregled te = new DTOs.TeorijskiProjekatPregled();
    DTOs.ProjekatUcesceDetalji pd = new DTOs.ProjekatUcesceDetalji();
    public TeorijskiUcesceDetalji(DTOs.StudentPregled sp, DTOs.TeorijskiProjekatPregled te, DTOs.ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.te = te;
        this.sp = sp;
        this.pd = pd;
    }

    private void TeorijskiUcesceDetalji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaLabele();
        if (te.TipProjekta == "grupni")
        {
            PrikaziStudenteNaIstom_Btn.Visible = false;
            PopuniPodacimaListView();
        }
        else if (te.TipProjekta == "pojedinacni")
        {
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
        List<DTOs.StudentPregled> studenti = DTOManager.VratiStudNaGrupnomProj(te.Id);

        foreach (DTOs.StudentPregled s in studenti)
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
        OstaliStudentiNaTProjektu studenti = new OstaliStudentiNaTProjektu(sp , te)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studenti.ShowDialog();
    }
}
