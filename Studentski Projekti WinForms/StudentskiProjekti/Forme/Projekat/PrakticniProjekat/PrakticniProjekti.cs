﻿using static StudentskiProjekti.DTOs;
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

		if (string.IsNullOrWhiteSpace(opisProjekta))
		{
			MessageBox.Show("Ne postoji opis za ovaj projekat.", "Kratak opis projekta");
		}
		else
		{
			MessageBox.Show(opisProjekta, "Kratak opis projekta");
		}
	}

    private void PreporuceneWebStrane_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet za koji zelite da prikazete web stranice!");
            return;
        }

        int.TryParse(PrakticniProjekti_ListV.SelectedItems[0].Tag.ToString(), out int idProjekta);
        PreporuceneWebStranice izmeniPproj = new PreporuceneWebStranice(idProjekta)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniPproj.ShowDialog();

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

        List<PrakticniProjekatPregled> projekti = DTOManager.VratiSortiranePProjekteZaPredmet(izabraniPredmet.Id, tipProjekta, skolskaGodina);

        PrakticniProjekti_ListV.Items.Clear();
        foreach (PrakticniProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik });
            item.Tag = p.Id;
            PrakticniProjekti_ListV.Items.Add(item);
        }

        PrakticniProjekti_ListV.Refresh();
    }

    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {
        Grupni_RB.Checked = false;
        Pojedinacni_RB.Checked = false;
        SkoslkaGodZad_TB.Clear();
        PopuniPodacima();
    }

    private void PrikaziStudNaProj_Btn_Click(object sender, EventArgs e)
    {
        if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite neki od projekata!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        StudentiNaProjektu studNaProj = new StudentiNaProjektu((int)PrakticniProjekti_ListV.SelectedItems[0].Tag)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        studNaProj.ShowDialog();
    }
}
