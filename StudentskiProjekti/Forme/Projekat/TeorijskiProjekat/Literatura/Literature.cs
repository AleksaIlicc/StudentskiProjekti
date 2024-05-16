namespace StudentskiProjekti.Forme;
public partial class Literature : Form
{
    DTOs.TeorijskiProjekatPregled projekat;
    public Literature(DTOs.TeorijskiProjekatPregled projekat)
    {
        InitializeComponent();
        this.projekat = projekat;
    }

    private void Literature_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Knjige_ListV.Items.Clear();
        List<DTOs.KnjigaPregled> knjige = DTOManager.VratiSveKnjigeZaTeorijskiProjekat(projekat.Id);

        foreach (DTOs.KnjigaPregled k in knjige)
        {
            ListViewItem item = new ListViewItem(new string[] { k.ISBN, k.Naziv, k.Izdavac, k.GodinaIzdanja.ToString() });
            item.Tag = k.ISBN;
            Knjige_ListV.Items.Add(item);
        }

        Knjige_ListV.Refresh();

        Radovi_ListV.Items.Clear();
        List<DTOs.RadPregled> radovi = DTOManager.VratiSveRadoveZaTeorijskiProjekat(projekat.Id);

        foreach (DTOs.RadPregled r in radovi)
        {
            ListViewItem item = new ListViewItem(new string[] {r.Naziv, r.Url, r.Format, r.KonferencijaObjavljivanja });
            item.Tag = r.id;
            Radovi_ListV.Items.Add(item);
        }

        Radovi_ListV.Refresh();

        Clanci_ListV.Items.Clear();
        List<DTOs.ClanakUCasopisuPregled> casopisi = DTOManager.VratiSveCasopiseZaTeorijskiProjekat(projekat.Id);

        foreach (DTOs.ClanakUCasopisuPregled c in casopisi)
        {
            ListViewItem item = new ListViewItem(new string[] { c.ISSN, c.Naziv, c.ImeCasopisa, c.Broj.ToString(), c.Godina.ToString() });
            item.Tag = c.ISSN;
            Clanci_ListV.Items.Add(item);
        }

        Clanci_ListV.Refresh();
    }

    private void DodajKnjigu_Btn_Click(object sender, EventArgs e)
    {
        DodajKnjigu dodajKnjigu = new DodajKnjigu()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajKnjigu.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniKnjigu_Btn_Click(object sender, EventArgs e)
    {
        if (Knjige_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite knjigu koju zelite da izmenite!");
            return;
        }
        DTOs.KnjigaPregled knjiga = DTOManager.VratiKnjiguPoISBN(Knjige_ListV.SelectedItems[0].Tag.ToString());
        IzmeniKnjigu izmeniKnjigu = new IzmeniKnjigu(knjiga)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniKnjigu.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiKnjigu_Btn_Click(object sender, EventArgs e)
    {
        if (Knjige_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite knjigu koju zelite da obrisete!");
            return;
        }
    }

    private void DodajRad_Btn_Click(object sender, EventArgs e)
    {
        DodajRad dodajRad = new DodajRad()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajRad.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniRad_Btn_Click(object sender, EventArgs e)
    {

        if (Radovi_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite rad koji zelite da izmenite!");
            return;
        }
        DTOs.RadPregled rad = DTOManager.VratiRadPoID((int)(Radovi_ListV.SelectedItems[0].Tag));
        IzmeniRad izmeniRad = new IzmeniRad(rad)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniRad.ShowDialog();
        PopuniPodacima();
    }
    private void ObrisiRad_Btn_Click(object sender, EventArgs e)
    {
        if (Radovi_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite rad koji zelite da obrisete!");
            return;
        }
    }

    private void DodajClanak_Btn_Click(object sender, EventArgs e)
    {
        DodajClanak dodajClanak = new DodajClanak()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajClanak.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniClanak_Btn_Click(object sender, EventArgs e)
    {
        if (Clanci_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite clanak koji zelite da izmenite!");
            return;
        }
        DTOs.ClanakUCasopisuPregled clanak = DTOManager.VratiClanakPoISSN(Clanci_ListV.SelectedItems[0].Tag.ToString());
        IzmeniClanak izmeniClanak = new IzmeniClanak(clanak)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniClanak.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiClanak_Btn_Click(object sender, EventArgs e)
    {
        if (Clanci_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite clanak koji zelite da obrisete!");
            return;
        }
    }
}
