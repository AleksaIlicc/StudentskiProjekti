using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class PrakticniUcesceDetalji : Form
{
    StudentPregled sp;
    ProjekatPregled p;
    ProjekatUcesceDetalji pd;

    public PrakticniUcesceDetalji(StudentPregled sp, ProjekatPregled p)
    {
        InitializeComponent();
        this.p = p;
        this.sp = sp;
        this.pd = DTOManager.VratiUcesceDetalji(sp.BrIndeksa, p.Id);
    }

    private void PrakticniUcesceDetalji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaLabele();
        if (p.TipProjekta == "grupni")
        {
            this.MaximumSize = new System.Drawing.Size(902, 520);
            this.MinimumSize = new System.Drawing.Size(902, 520);
            PrikaziStudenteNaIstom_Btn.Visible = false;
            PopuniPodacimaListView();
        }
        else if (p.TipProjekta == "pojedinacni")
        {
            this.MaximumSize = new System.Drawing.Size(583, 576);
            this.MinimumSize = new System.Drawing.Size(583, 576);
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
        OdabraniProgJezik_LB.Text = pd.OdabranProgramskiJezik ?? "";
        UrlDokumentacije_LB.Text = pd.UrlDokumentacijeProgJezika ?? "";
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

    private void PrikaziStudenteNaIstom_Btn_Click(object sender, EventArgs e)
    {
        OstaliStudentiNaProjektu studenti = new OstaliStudentiNaProjektu(sp.BrIndeksa, p.Id)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studenti.ShowDialog();
    }

    private void Izvestaji_Btn_Click(object sender, EventArgs e)
    {
        PredatiIzvestaji izvestaji = new PredatiIzvestaji(sp, p, pd)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izvestaji.ShowDialog();
    }
}
