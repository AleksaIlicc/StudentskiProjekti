using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class Literature : Form
{
    TeorijskiProjekatPregled projekat;
    public Literature(TeorijskiProjekatPregled projekat)
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
        List<KnjigaPregled> knjige = DTOManager.VratiSveKnjigeZaTeorijskiProjekat(projekat.Id);

        foreach (KnjigaPregled k in knjige)
        {
            ListViewItem item = new ListViewItem(new string[] { k.ISBN, k.Naziv, k.Izdavac, k.GodinaIzdanja.ToString() });
            Knjige_ListV.Items.Add(item);
        }

        Knjige_ListV.Refresh();

        Radovi_ListV.Items.Clear();
        List<RadPregled> radovi = DTOManager.VratiSveRadoveZaTeorijskiProjekat(projekat.Id);

        foreach (RadPregled r in radovi)
        {
            ListViewItem item = new ListViewItem(new string[] {r.Naziv, r.Url, r.Format, r.KonferencijaObjavljivanja });
            item.Tag = r.Id;
            Radovi_ListV.Items.Add(item);
        }

        Radovi_ListV.Refresh();

        Clanci_ListV.Items.Clear();
        List<ClanakUCasopisuPregled> casopisi = DTOManager.VratiSveClankeZaTeorijskiProjekat(projekat.Id);

        foreach (ClanakUCasopisuPregled c in casopisi)
        {
            ListViewItem item = new ListViewItem(new string[] { c.ISSN, c.Naziv, c.ImeCasopisa, c.Broj.ToString(), c.Godina.ToString() });
            Clanci_ListV.Items.Add(item);
        }

        Clanci_ListV.Refresh();
    }

    private void DodajKnjigu_Btn_Click(object sender, EventArgs e)
    {
        DodajKnjigu dodajKnjigu = new DodajKnjigu(projekat.Id)
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
		KnjigaPregled knjiga = DTOManager.VratiKnjigu(Knjige_ListV.SelectedItems[0].SubItems[0].Text);
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
		string poruka = "Da li zelite da obrisete izabranu knjigu?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
			DTOManager.ObrisiKnjigu(Knjige_ListV.SelectedItems[0].SubItems[0].Text);
            MessageBox.Show("Brisanje knjige je uspesno obavljeno!");
            PopuniPodacima();
        }
    }

    private void DodajRad_Btn_Click(object sender, EventArgs e)
    {
        DodajRad dodajRad = new DodajRad(projekat.Id)
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
        RadPregled rad = DTOManager.VratiRad((int)Radovi_ListV.SelectedItems[0].Tag);
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
		string poruka = "Da li zelite da obrisete izabrani rad?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			DTOManager.ObrisiRad((int)Radovi_ListV.SelectedItems[0].Tag);
			MessageBox.Show("Brisanje rada je uspesno obavljeno!");
			PopuniPodacima();
		}
	}

    private void DodajClanak_Btn_Click(object sender, EventArgs e)
    {
        DodajClanak dodajClanak = new DodajClanak(this.projekat.Id)
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
        ClanakUCasopisuPregled clanak = DTOManager.VratiClanak(Clanci_ListV.SelectedItems[0].SubItems[0].Text);
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
		string poruka = "Da li zelite da obrisete izabrani clanak?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			DTOManager.ObrisiClanak(Knjige_ListV.SelectedItems[0].SubItems[0].Text);
			MessageBox.Show("Brisanje clanka je uspesno obavljeno!");
			PopuniPodacima();
		}
	}
}
