using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class Predmeti : Form
{
    public Predmeti()
    {
        InitializeComponent();
    }
    private void Predmeti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Predmeti_ListV.Items.Clear();
        List<PredmetPregled> predmeti = DTOManager.VratiSvePredmete();

        foreach (PredmetPregled p in predmeti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Semestar.ToString(), p.Katedra });
            Predmeti_ListV.Items.Add(item);
        }

        Predmeti_ListV.Refresh();
    }
    private void DodajPredmet_Btn_Click(object sender, EventArgs e)
    {
        DodajPredmet dodajPredmet = new DodajPredmet()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajPredmet.ShowDialog();
        PopuniPodacima();
    }
    private void IzmeniPredmet_Btn_Click(object sender, EventArgs e)
    {
        if (Predmeti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet koji zelite da izmenite!");
			return;
		}

        string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
        PredmetPregled ob = DTOManager.VratiPredmet(idPredmeta);

        IzmeniPredmet formaUpdate = new IzmeniPredmet(ob)
        {
            StartPosition = FormStartPosition.CenterParent
        };

        formaUpdate.ShowDialog();

        PopuniPodacima();
    }

    private void ObrisiPredmet_Btn_Click(object sender, EventArgs e)
    {
        if (Predmeti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet koji zelite da obrisete!");
            return;
        }

        string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da obrisete izabrani predmet?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiPredmet(idPredmeta);
            MessageBox.Show("Brisanje predmeta je uspesno obavljeno!");
            PopuniPodacima();
        }
    }

    private void Sortiraj_Btn_Click(object sender, EventArgs e)
    {
        string semestarFilter = Semestar_TB.Text;
        string katedraFilter = NazivKatedre_TB.Text;

        List<PredmetPregled> filtriraniPredmeti = DTOManager.VratiSortiranePredmete(semestarFilter, katedraFilter);

        Predmeti_ListV.Items.Clear();

        foreach (PredmetPregled p in filtriraniPredmeti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Semestar.ToString(), p.Katedra });
            Predmeti_ListV.Items.Add(item);
        }
    }

    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {
        Semestar_TB.Clear();
        NazivKatedre_TB.Clear();
        PopuniPodacima();
    }

    private void SemestarPrikaz_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void Prikazi_Btn_Click(object sender, EventArgs e)
    {
        if (Predmeti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet za koji zelite da vidite vise detalja!");
            return;
        }

        string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
        PredmetPregled izabraniPredmet = DTOManager.VratiPredmet(idPredmeta);

        Projekti projekti = new Projekti(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        projekti.ShowDialog();
    }
}

