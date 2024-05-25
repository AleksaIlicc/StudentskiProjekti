using System.Globalization;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class StudentDetalji : Form
{
    ProjekatUcesceDetalji pd = new ProjekatUcesceDetalji();
    StudentPregled sp;
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
            ListViewItem item = new ListViewItem(new string[] {p.NazivPredmeta, p.NazivProjekta, p.DatumPocetkaIzrade.ToString(format), p.DatumZavrsetkaIzrade?.ToString(format), p.RokZaZavrsetak.ToString(format), p.ProjekatZavrsen, p.VrstaProjekta });
            item.Tag = p.IdProjekta;

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

		ProjekatPregled p = DTOManager.VratiProjekat((int)StudentDetalji_ListV.SelectedItems[0].Tag);
		if (StudentDetalji_ListV.SelectedItems[0].SubItems[6].Text == "teorijski")
        {
            TeorijskiUcesceDetalji teorijskiUcesceDetalji = new TeorijskiUcesceDetalji(sp, p)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            teorijskiUcesceDetalji.ShowDialog();
        }
        else if (StudentDetalji_ListV.SelectedItems[0].SubItems[6].Text == "prakticni")
        {
            PrakticniUcesceDetalji prakticniUcesceDetalji = new PrakticniUcesceDetalji(sp, p)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            prakticniUcesceDetalji.ShowDialog();
        }
    }

    private void DodajUcesce_Btn_Click(object sender, EventArgs e)
    {
        OdabirPredmetaUcesce odabirPredmetaUcesce = new OdabirPredmetaUcesce(sp)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        odabirPredmetaUcesce.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniUcesce_Btn_Click(object sender, EventArgs e)
    {
        IzmeniUcesce izmeniUcesce = new IzmeniUcesce((int)StudentDetalji_ListV.SelectedItems[0].Tag, sp)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniUcesce.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiUcesce_Btn_Click(object sender, EventArgs e)
    {
        if (StudentDetalji_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet koji zelite da obrisete!");
            return;
        }

        int idUcesca = DTOManager.VratiUcesce((int)StudentDetalji_ListV.SelectedItems[0].Tag , sp.BrIndeksa).Id;
        string poruka = "Da li zelite da obrisete izabrano ucesce?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiUcesce(idUcesca);
            MessageBox.Show("Brisanje ucesca je uspesno obavljeno!");
            PopuniPodacima();
        }
    }
}
