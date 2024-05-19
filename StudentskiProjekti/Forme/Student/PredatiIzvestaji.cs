namespace StudentskiProjekti.Forme;

public partial class PredatiIzvestaji : Form
{

    DTOs.StudentPregled sp = new DTOs.StudentPregled();
    DTOs.ProjekatUcesceDetalji pd = new DTOs.ProjekatUcesceDetalji();
    DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
    public PredatiIzvestaji(DTOs.StudentPregled sp, DTOs.PrakticniProjekatPregled pp, DTOs.ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.sp = sp;
        this.pd = pd;
        this.pp = pp;
    }

    private void PredatiIzvestaji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListView();
        NazivProj_LB.Text = pp.Naziv;
        DatumZavrIzrade_LB.Text = pd.DatumZavrsetkaIzrade?.ToString("dd.MM.yyyy");
        DatumPocIzrade_LB.Text = pd.DatumPocetkaIzrade.ToString("dd.MM.yyyy");
        if (pp.TipProjekta == "grupni")
        {
            UkupanBrIzvest_LB.Text = DTOManager.VratiBrPredIzvestajaNaGrupi(pp.Id).ToString();
            UkupanBrIzPrikaz_LB.Visible = true;
            UkupanBrIzvest_LB.Visible = true;
        }

        BrIndeksa_LB.Text = sp.BrIndeksa;
        Ime_LB.Text = sp.LIme;
        Prezime_LB.Text = sp.Prezime;
        Smer_LB.Text = sp.Smer;
        if (pp.TipProjekta == "pojedinacni")
        {
            OstaliClanovi_Btn.Visible = false;
        }
    }

    private void PopuniPodacimaListView()
    {
        Izvestaji_ListV.Items.Clear();
        List<DTOs.IzvestajPregled> izvestaji = DTOManager.VratiIzvestajeZaStudenta(sp.BrIndeksa, pp.Id);

        foreach (DTOs.IzvestajPregled i in izvestaji)
        {
            string opisIzvest = i.OpisIzvest;
            string datumPred = i.DatumPred?.ToString("dd.MM.yyyy") ?? "N/A";
            string razlika = "N/A";

            if (i.DatumPred.HasValue)
            {
                TimeSpan? daysDiff = i.DatumPred.Value - pd.DatumPocetkaIzrade;
                razlika = daysDiff.HasValue ? daysDiff.Value.TotalDays.ToString() : "N/A";
            }
            razlika += " dana";

            ListViewItem item = new ListViewItem(new string[] { opisIzvest, datumPred, razlika });
            Izvestaji_ListV.Items.Add(item);
        }

        Izvestaji_ListV.Refresh();
    }

    private void Izvestaji_ListV_DoubleClick(object sender, EventArgs e)
    {
        if (Izvestaji_ListV.SelectedItems.Count > 0)
        {
            string opisIzvestaja = Izvestaji_ListV.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(opisIzvestaja, "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void OstaliClanovi_Btn_Click(object sender, EventArgs e)
    {
        OstaliIzvestaji ostali = new OstaliIzvestaji(pp, sp ,pd)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        ostali.ShowDialog();
    }
}
