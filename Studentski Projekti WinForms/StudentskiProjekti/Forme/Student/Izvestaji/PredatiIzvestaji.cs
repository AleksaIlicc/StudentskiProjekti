using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class PredatiIzvestaji : Form
{
    StudentPregled sp;
    ProjekatUcesceDetalji pd;
    ProjekatPregled pp;

    public PredatiIzvestaji(StudentPregled sp, ProjekatPregled pp, ProjekatUcesceDetalji pd)
    {
        InitializeComponent();
        this.sp = sp;
        this.pp = pp;
        this.pd = pd;
    }

    private void PredatiIzvestaji_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
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

    private void PopuniPodacima()
    {
        Izvestaji_ListV.Items.Clear();
        List<IzvestajPregled> izvestaji = DTOManager.VratiIzvestajeZaStudenta(sp.BrIndeksa, pp.Id);

        foreach (IzvestajPregled i in izvestaji)
        { 
            string razlika = Math.Round((i.DatumPredaje - pd.DatumPocetkaIzrade).TotalDays).ToString() + " dana";

            ListViewItem item = new ListViewItem(new string[] { i.Opis, i.DatumPredaje.ToString("dd.MM.yyyy"), razlika });
            item.Tag = i.Id;
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
        OstaliIzvestaji ostali = new OstaliIzvestaji(pp.Id, sp.BrIndeksa)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        ostali.ShowDialog();
    }

    private void DodajIzvestaj_Btn_Click(object sender, EventArgs e)
    {
        DodajIzvestaj dodajIzvestaj = new DodajIzvestaj(sp.BrIndeksa, pp.Id, pd)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajIzvestaj.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniIzvestaj_Btn_Click(object sender, EventArgs e)
    {
        IzvestajPregled izvestaj = DTOManager.VratiIzvestaj((int)Izvestaji_ListV.SelectedItems[0].Tag);
        IzmeniIzvestaj izmeniIzvestaj = new IzmeniIzvestaj(izvestaj, pd)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniIzvestaj.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiIzvestaj_Btn_Click(object sender, EventArgs e)
    {
        if (Izvestaji_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite izvestaj koji zelite da obrisete!");
            return;
        }

        string poruka = "Da li zelite da obrisete izabrani izvestaj?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiIzvestaj((int)Izvestaji_ListV.SelectedItems[0].Tag);
            MessageBox.Show("Brisanje izvestaja je uspesno obavljeno!");
            PopuniPodacima();
        }
    }
}
