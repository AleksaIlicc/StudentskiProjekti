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
            ListViewItem item = new ListViewItem(new string[] { i.Naziv, i.DatumPocIzrade.ToString("dd.MM.yyyy"), i.DatumZavrIzrade?.ToString("dd.MM.yyyy"), i.RokZaZavr.ToString("dd.MM.yyyy"), i.RokZaZavr.ToString("dd.MM.yyyy") , i.DatumZavrIzrade?.ToString("dd.MM.yyyy") });
            item.Tag = i.OpisIzvest;
            Izvestaji_ListV.Items.Add(item);
        }

        Izvestaji_ListV.Refresh();
    }

    private void Izvestaji_ListV_DoubleClick(object sender, EventArgs e)
    {
        if (Izvestaji_ListV.SelectedItems.Count > 0)
        {
            string opisIzvestaja = Izvestaji_ListV.SelectedItems[0].Tag as string;
            MessageBox.Show(opisIzvestaja, "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void OstaliClanovi_Btn_Click(object sender, EventArgs e)
    {
        OstaliIzvestaji ostali = new OstaliIzvestaji( pp, sp)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        ostali.ShowDialog();
    }
}
