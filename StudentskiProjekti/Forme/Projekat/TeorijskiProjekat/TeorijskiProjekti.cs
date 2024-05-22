using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class TeorijskiProjekti : Form
{
    PredmetPregled izabraniPredmet;
    public TeorijskiProjekti(PredmetPregled predmet)
    {
        izabraniPredmet = predmet;
        InitializeComponent();
    }

    private void TeorijskiProjekti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        TeorijskiProjekti_ListV.Items.Clear();
        IList<TeorijskiProjekatPregled> teorijskiprojekti = DTOManager.VratiTeorijskeProjekteZaPredmet(izabraniPredmet.Id);

        foreach (TeorijskiProjekatPregled p in teorijskiprojekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana.ToString() });
            item.Tag = p.Id;
            TeorijskiProjekti_ListV.Items.Add(item);
        }

        TeorijskiProjekti_ListV.Refresh();
    }

    private void DodajProjekatT_Btn_Click(object sender, EventArgs e)
    {
        DodajTeorijskiProjekat dodajTproj = new DodajTeorijskiProjekat(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajTproj.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniProjekatT_Btn_Click(object sender, EventArgs e)
    {
        if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat koji zelite da izmenite!");
            return;
        }
        int idprojekta = (int)TeorijskiProjekti_ListV.SelectedItems[0].Tag;
        TeorijskiProjekatPregled ob = DTOManager.VratiTeorijskiProjekat(idprojekta);
        IzmeniTeorijskiProjekat izmeniTproj = new IzmeniTeorijskiProjekat(ob)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniTproj.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiProjekatT_Btn_Click(object sender, EventArgs e)
    {
        if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat koji zelite da obrisete!");
            return;
        }

        int idProjekta = (int)TeorijskiProjekti_ListV.SelectedItems[0].Tag;
        string poruka = "Da li zelite da obrisete izabrani projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiTeorijskiProjekat(idProjekta);
            MessageBox.Show("Brisanje projekta je uspesno obavljeno!");
            PopuniPodacima();
        }
    }

    private void Literatura_Btn_Click(object sender, EventArgs e)
    {

        if (TeorijskiProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat za koji zelite da vidite vise detalja!");
            return;
        }

        int idProjekta = int.TryParse(TeorijskiProjekti_ListV.SelectedItems[0].Tag.ToString(), out int result) ? result : -1;
        TeorijskiProjekatPregled izabraniProjekat = DTOManager.VratiTeorijskiProjekat(idProjekta);
        Literature literature = new Literature(izabraniProjekat)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        literature.ShowDialog();
    }

    private void Sortiraj_Btn_Click(object sender, EventArgs e)
    {
        if (!Grupni_RB.Checked && !Pojedinacni_RB.Checked && SkoslkaGodZad_TB.Text == "")
        {
            MessageBox.Show("Izaberite po čemu želite da sortirate.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string tipProjekta = Grupni_RB.Checked ? "grupni" : Pojedinacni_RB.Checked ? "pojedinacni" : "";
        string skolskaGodina = SkoslkaGodZad_TB.Text;

        List<TeorijskiProjekatPregled> projekti = DTOManager.VratiSortiraneTProjekteZaPredmet(izabraniPredmet.Id, tipProjekta, skolskaGodina);

        TeorijskiProjekti_ListV.Items.Clear();
        foreach (TeorijskiProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana.ToString() });
            item.Tag = p.Id;
            TeorijskiProjekti_ListV.Items.Add(item);
        }

        TeorijskiProjekti_ListV.Refresh();
    }
    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {
        Grupni_RB.Checked = false;
        Pojedinacni_RB.Checked = false;
        SkoslkaGodZad_TB.Text = "";
        PopuniPodacima();
    }

    private void PrikaziStudNaProj_Btn_Click(object sender, EventArgs e)
    {
        if(TeorijskiProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite neki od projekata!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        StudentiNaProjektu studNaProj = new StudentiNaProjektu(DTOManager.VratiTeorijskiProjekat((int)TeorijskiProjekti_ListV.SelectedItems[0].Tag))
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studNaProj.ShowDialog();
    }
}
