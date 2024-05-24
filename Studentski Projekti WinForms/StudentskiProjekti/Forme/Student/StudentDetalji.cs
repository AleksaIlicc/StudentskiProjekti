using System.Globalization;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class StudentDetalji : Form
{
    StudentPregled sp = new StudentPregled();
    ProjekatUcesceDetalji pd = new ProjekatUcesceDetalji();
    string format = "dd.MM.yyyy";

	public StudentDetalji(StudentPregled sp)
    {
        InitializeComponent();
        this.sp = sp;
    }

    private void StudentDetalji_Load(object sender, EventArgs e)
    {
        BrIndeksa_LB.Text = sp.BrIndeksa;
        Ime_LB.Text = sp.LIme;
        Prezime_LB.Text = sp.Prezime;
        Smer_LB.Text = sp.Smer;
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        StudentDetalji_ListV.Items.Clear();
        List<ProjekatUcesceDetalji> detalji = DTOManager.VratiProjekteZaStudenta(sp.BrIndeksa);

        foreach (ProjekatUcesceDetalji p in detalji)
        {
            string datumzavizrade = p.DatumZavrsetkaIzrade.HasValue ? p.DatumZavrsetkaIzrade.Value.ToString(format) : string.Empty;
            ListViewItem item = new ListViewItem(new string[] {p.NazivPredmeta, p.NazivProjekta, p.DatumPocetkaIzrade.ToString(format), datumzavizrade, p.RokZaZavrsetak.ToString(format), p.ProjekatZavrsen, p.VrstaProjekta });
            item.Tag = p.Id;

            StudentDetalji_ListV.Items.Add(item);
        }

        StudentDetalji_ListV.Refresh();
    }

    private void Ucesce_Btn_Click(object sender, EventArgs e)
    {
        if (StudentDetalji_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta za kog zelite da prikazete vise informacija o ucescu!");
            return;
        }
        pd.NazivProjekta = StudentDetalji_ListV.SelectedItems[0].SubItems[1].Text;
        pd.VrstaProjekta = StudentDetalji_ListV.SelectedItems[0].SubItems[6].Text;
        pd.ProjekatZavrsen = StudentDetalji_ListV.SelectedItems[0].SubItems[5].Text;
        pd.DatumPocetkaIzrade = DateTime.ParseExact(StudentDetalji_ListV.SelectedItems[0].SubItems[2].Text, format, CultureInfo.InvariantCulture);
		pd.DatumZavrsetkaIzrade = DateTime.TryParse(StudentDetalji_ListV.SelectedItems[0].SubItems[3].Text, out var datumZavrsetka) ? datumZavrsetka : null;
        pd.RokZaZavrsetak = DateTime.ParseExact(StudentDetalji_ListV.SelectedItems[0].SubItems[4].Text, format, CultureInfo.InvariantCulture);


		if (StudentDetalji_ListV.SelectedItems[0].SubItems[6].Text == "teorijski")
        {
            TeorijskiProjekatPregled tp = DTOManager.VratiTeorijskiProjekat((int)StudentDetalji_ListV.SelectedItems[0].Tag);
            TeorijskiUcesceDetalji teorijskiUcesceDetalji = new TeorijskiUcesceDetalji(sp, tp, pd)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            teorijskiUcesceDetalji.ShowDialog();
        }
        else if (StudentDetalji_ListV.SelectedItems[0].SubItems[6].Text == "prakticni")
        {

            PrakticniProjekatPregled pp = DTOManager.VratiPrakticniProjekat((int)StudentDetalji_ListV.SelectedItems[0].Tag);
            PrakticniUcesceDetalji prakticniUcesceDetalji = new PrakticniUcesceDetalji(sp, pp, pd)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            prakticniUcesceDetalji.ShowDialog();
        }
    }
}
