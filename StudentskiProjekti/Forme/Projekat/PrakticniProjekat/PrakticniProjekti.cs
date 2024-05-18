using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class PrakticniProjekti : Form
{
    PredmetPregled izabraniPredmet;
    public PrakticniProjekti(PredmetPregled predmet)
    {
        izabraniPredmet = predmet;
        InitializeComponent();
    }

    private void PrakticniProjekti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    private void PopuniPodacima()
    {
        PrakticniProjekti_ListV.Items.Clear();
        IList<PrakticniProjekatPregled> prakticniProjekat = DTOManager.VratiPrakticneProjekteZaPredmet(izabraniPredmet.Id);

        foreach (PrakticniProjekatPregled p in prakticniProjekat)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik });
            item.Tag = p.Id;
            PrakticniProjekti_ListV.Items.Add(item);
        }

        PrakticniProjekti_ListV.Refresh();
    }

    private void DodajProjekatP_Btn_Click(object sender, EventArgs e)
    {
        DodajPrakticniProjekat dodajPproj = new DodajPrakticniProjekat(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajPproj.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniProjekatP_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat koji zelite da izmenite!");
            return;
        }
        int idprojekta = (int)PrakticniProjekti_ListV.SelectedItems[0].Tag;
        PrakticniProjekatPregled ob = DTOManager.VratiPrakticniProjekat(idprojekta);
        IzmeniPrakticniProjekat izmeniPproj = new IzmeniPrakticniProjekat(ob)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniPproj.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiProjekatP_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat koji zelite da obrisete!");
            return;
        }

        int idProjekta = (int)PrakticniProjekti_ListV.SelectedItems[0].Tag;
        string poruka = "Da li zelite da obrisete izabrani projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiPrakticniProjekat(idProjekta);
            MessageBox.Show("Brisanje projekta je uspesno obavljeno!");
            PopuniPodacima();
        }
    }
    private void KratakOpis_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet za koji zelite da prikazete opis!");
            return;
        }
        int idProjekta = (int)PrakticniProjekti_ListV.SelectedItems[0].Tag;
        string opisProjekta = DTOManager.VratiOpisPrakticnogProjekta(idProjekta);
        MessageBox.Show(opisProjekta, "Kratak opis projekta");
    }

    private void PreporuceneWebStrane_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet za koji zelite da prikazete web stranice!");
        }
        else
        {
            int.TryParse(PrakticniProjekti_ListV.SelectedItems[0].Tag.ToString(), out int idProjekta);
            PreporuceneWebStranice izmeniPproj = new PreporuceneWebStranice(idProjekta)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            izmeniPproj.ShowDialog();
        }
    }
}
